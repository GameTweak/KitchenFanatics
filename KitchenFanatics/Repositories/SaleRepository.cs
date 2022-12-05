using KitchenFanatics.Database;
using KitchenFanatics.Models;
using KitchenFanatics.Services;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenFanatics.Repositories
{
    /// <summary>
    /// The repository used to fetch the data from the Sales table
    /// 
    /// Written by Esben
    /// </summary>
    public class SaleRepository : KitchenFanaticDBDataContext
    {

        /// <summary>
        /// Establishes an connection to the database and retrieves all the Sales stored on it
        /// </summary>
        /// <returns>All sales</returns>
        public List<SaleHistory> GetAllSales()
        {
            // Creates an collection that will contain all the sales from the Database
            List<SaleHistory> saleHistories = new List<SaleHistory>();

            // A foreach loop, looping through all the Sales in the Sales table
            foreach (var saleHistory in Sales)
            {
                // The list that'll be containing all the Items associated with the Sale
                //List<Item> items = new List<Item>();

                //List<Models.SaleLine> line = new List<Models.SaleLine>();

                // Defines the customer assosiated with the sale
                Models.Customer customer = new Models.Customer(
                    saleHistory.Customer.FirstName,
                    saleHistory.Customer.LastName,
                    saleHistory.Customer.Email,
                    saleHistory.Customer.CustomerAddress,
                    saleHistory.Customer.PhoneNumber,
                    saleHistory.Customer.CustomerID
                    );

                // Foreach loop that connects the SaleLine with the SaleHistory
                //foreach (var newline in SaleLines.Where(sl => sl.SaleID == saleHistory.SaleID))
                //{
                //    Models.SaleLine newSaleLine = new Models.SaleLine(newline);

                //    line.Add(newSaleLine);
                //}

                // Defines the Sale object
                SaleHistory newSale = new SaleHistory(
                    saleHistory.SaleID,
                    saleHistory.SaleDate,
                    saleHistory.SaleTotal,
                    saleHistory.DeliveryAddress,
                    saleHistory.SaleStatus,
                    null,
                    customer
                    );

                // Adds the sale to the list
                saleHistories.Add(newSale);
            }

            return saleHistories;
        }

        /// <summary>
        /// Method used to create a new sale and store it on the Database
        /// </summary>
        /// <param name="historyToSave">The history being saved</param>
        /// <exception cref="NullReferenceException"></exception>
        public void CreateNewSale(SaleHistory historyToSave)
        {
            // Check if Customeer or SaleLine is null
            if (historyToSave.Customer == null) throw new NullReferenceException("Customer cannot be null!");
            if (historyToSave.SaleLine == null) throw new NullReferenceException("The items list must not be Empty!");

            List<Database.SaleLine> lineToSave = new List<Database.SaleLine>();

            // Defines a new Sale instance from the SaleHistory
            Sale newSale = new Sale
            {
                // Get current time
                SaleDate = historyToSave.SaleDate,
                // Gets total
                SaleTotal = (decimal)historyToSave.SaleLine.Select(l => l.Price).Sum(),
                // Sets delivery address
                DeliveryAddress = historyToSave.DeliveryAddress,
                // Sets sale status
                SaleStatus = historyToSave.SaleStatus,
                // Sets customer id
                CustomerID = historyToSave.Customer.CustomerID
            };

            // Inserts the Sale on the database table
            Sales.InsertOnSubmit(newSale);

            // Submits changes
            SubmitChanges();

            historyToSave.Id = newSale.SaleID;

            // Loops through all salelines
            foreach (var line in historyToSave.SaleLine)
            {
                // Defines a new SaleLine instance
                Database.SaleLine newline = new Database.SaleLine();

                // Sets the saleline variables
                newline.ItemNR = line.ItemNR;
                newline.Amount = (int)line.Amount;
                newline.Price = (decimal)line.Price;
                newline.SaleID = newSale.SaleID;

                // Adds to the lineToSale collection
                lineToSave.Add(newline);
            }

            // Inserts all changes to the SaleLines table
            SaleLines.InsertAllOnSubmit(lineToSave);

            // Submits changes
            SubmitChanges();
        }

        /// <summary>
        /// Method used to edit an already existing sale
        /// </summary>
        /// <param name="saleToEdit">The salehistory wanted to be updated</param>
        public void EditSale(SaleHistory editSale)
        {
            // Creates two list containing what should be kept and what to remove
            List<Database.SaleLine> salesToDelete = new List<Database.SaleLine>();

            //
            List<Database.SaleLine> salesToAdd = new List<Database.SaleLine>();

            // Loops through all entries in editSale's saleLines
            foreach (var saleLine in editSale.SaleLine)
            {
                // Defines a new SaleLine object that contain data if it exist in DB
                Database.SaleLine resultSale = SaleLines.Where(sl => sl.SaleLineID == saleLine.SaleLineID).FirstOrDefault();

                // Checks if it exist in DB
                if (resultSale == null)
                {
                    // Creates new entry if it doesn't exist
                    salesToAdd.Add(CreateNewSaleLine(saleLine, editSale.Id));
                }
            }

            SaleLines.InsertAllOnSubmit(salesToAdd);
            
            SubmitChanges();

            foreach (var saleLine in SaleLines.Where(sl => sl.SaleID == editSale.Id))
            {
                string output = $"{saleLine.ItemNR} was added to ";
                
                // Check if the saleline is present in editSale's SaleLine collection
                if (!editSale.SaleLine.Any(sl => sl.SaleLineID == saleLine.SaleLineID) && !salesToAdd.Contains(saleLine))
                {
                    // Adds it to removal collection
                    salesToDelete.Add(saleLine);
                }
            }

            // Removes them on submit
            SaleLines.DeleteAllOnSubmit(salesToDelete);

            // Submits changes
            SubmitChanges();

            // Fetches the Sale History
            var dbSale = Sales.Where(s => s.SaleID == editSale.Id).FirstOrDefault();

            // Upates Status
            dbSale.SaleStatus = editSale.SaleStatus;

            // Updates total
            dbSale.SaleTotal = SaleLines.Where(sl => sl.SaleID == editSale.Id).Select(sl => sl.Price).Sum();

            // Updates SaleDate
            dbSale.SaleDate = DateTime.Now;

            // Submits changes
            SubmitChanges();
        }

        /// <summary>
        /// Deletes the selected entry from the database
        /// </summary>
        /// <param name="historyToSave">Entry to delete</param>
        public void DeleteSelectedSale(SaleHistory historyToSave)
        {
            // Selects the entry that's going to be deleted
            var saleToDelete = Sales.Where(sd => sd.SaleID == historyToSave.Id).FirstOrDefault();

            // Gets the list of items connected to the sales that are going to be deleted
            var saleLineToDelete = SaleLines.Where(sld => sld.SaleID == historyToSave.Id);

            // Removes entries on submit
            SaleLines.DeleteAllOnSubmit(saleLineToDelete);

            // Removes sale on submit
            Sales.DeleteOnSubmit(saleToDelete);

            // Submits the changes to the database
            SubmitChanges();
        }

        /// <summary>
        /// CreateNewSaleLine is a private method that is used to create a new SaleLine and place it into the DB
        /// </summary>
        /// <param name="sale">Associated SaleHistory</param>
        /// <param name="id">What sale id to match it with</param>
        /// <returns></returns>
        private Database.SaleLine CreateNewSaleLine(Models.SaleLine sale, int id)
        {
            // Defines new sale
            Database.SaleLine newSale = new Database.SaleLine();

            // Sets the variables for the object
            newSale.SaleID = id;
            newSale.Price = (decimal)sale.Price;
            newSale.ItemNR = sale.ItemNR;
            newSale.Amount = (int)sale.Amount;

            // Returns newly made entry
            return newSale;
        }

        /// <summary>
        /// Fetches all SaleLines associated with the given SaleHistory
        /// </summary>
        /// <param name="sale">SaleHistory to retrieve item from</param>
        /// <returns>Returns all salelines from the SaleHistory</returns>
        public List<Models.SaleLine> FetchItemsFromSale(SaleHistory sale)
        {
            // Defines a collection that will be containing all the Items
            List<Models.SaleLine> saleLines = new List<Models.SaleLine>();

            // Loops through each instance with the SaleID that matches the SaleHistory's ID
            foreach (var newline in SaleLines.Where(sl => sl.SaleID == sale.Id))
            {
                // Defines a new SaleLine
                Models.SaleLine newSaleLine = new Models.SaleLine(newline);

                // Adds it to the Collection
                saleLines.Add(newSaleLine);
            }

            // Returns the collection
            return saleLines;
        }
    }
}
