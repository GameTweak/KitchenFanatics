using KitchenFanatics.Database;
using KitchenFanatics.Models;
using KitchenFanatics.Services;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using System.Linq;
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
                List<Item> items = new List<Item>();

                List<Models.SaleLine> line = new List<Models.SaleLine>();

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
                foreach (var newline in SaleLines.Where(sl => sl.SaleID == saleHistory.SaleID))
                {
                    Models.SaleLine newSaleLine = new Models.SaleLine(
                        newline.SaleLineID,
                        newline.ItemNR,
                        newline.Amount,
                        newline.Price,
                        newline.SaleID
                        );

                    line.Add(newSaleLine);
                }

                // Defines the Sale object
                SaleHistory newSale = new SaleHistory(
                    saleHistory.SaleID,
                    saleHistory.SaleDate,
                    line.Select(l => l.Price).Sum(),
                    saleHistory.DeliveryAddress,
                    saleHistory.SaleStatus,
                    line,
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
                SaleDate = DateTime.Now,
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
            
            // Loops through all salelines
            foreach (var line in historyToSave.SaleLine)
            {
                // Defines a new SaleLine instance
                Database.SaleLine newline = new Database.SaleLine();

                // Sets the saleline variables
                newline.ItemNR = line.ItemNR;
                newline.Amount = (int) line.Amount;
                newline.Price = (decimal) line.Price;
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
        public void EditSale(SaleHistory saleToEdit) 
        {
            // Creates two list containing what should be kept and what to remove
            List<Database.SaleLine> salesToKeep = new List<Database.SaleLine>();
            List<Database.SaleLine> salesToDelete = new List<Database.SaleLine>();

            // Looping through all instances that match SaleID
            foreach (var lines in SaleLines.Where(sl => sl.SaleID == saleToEdit.Id))
            {
                // A bool that returns whether a entry exist or not
                bool saleLine = saleToEdit.SaleLine.Select(sl => sl.SaleLineID == lines.SaleLineID).FirstOrDefault();

                // If it exist in the collection and there is none of it on the database 
                if (saleLine && lines == null)
                {
                    // Adds new entry to the collection
                    salesToKeep.Add(lines);
                }
                // If it does not exist in the collection but does on the database
                else if (lines != null && saleLine)
                {
                    // Updates Amount
                    lines.Amount = (int) saleToEdit.SaleLine.Where(sl => sl.SaleID == lines.SaleID).Select(sl => sl.Amount).FirstOrDefault();
                }
                // If it does not exist in the collection and should be deleted
                else
                {
                    // Deleted from SaleLine
                    salesToDelete.Add(lines);
                }
            }

            // Inserts new entries
            SaleLines.InsertAllOnSubmit(salesToKeep);

            // Removes deleted entries
            SaleLines.DeleteAllOnSubmit(salesToDelete);

            // Fetches the Sale History
            var dbSale = Sales.Where(s => s.SaleID == saleToEdit.Id).FirstOrDefault();

            // Upates Status
            dbSale.SaleStatus = saleToEdit.SaleStatus;

            // Updates total
            dbSale.SaleTotal = (decimal) salesToKeep.Select(stk => stk.Price).Sum();
            
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

            if (historyToSave == null) throw new NullReferenceException("Sale cannot be null!");

            // Selects the entry that's going to be deleted
            var saleToDelete = Sales.Where(sd => sd.SaleID == historyToSave.Id).FirstOrDefault();
            
            // Gets the list of items connected to the sales that are going to be deleted
            var saleLineToDelete = SaleLines.Where(sld => sld.SaleID == historyToSave.Id);

            foreach(var i in saleLineToDelete)
            {
                Console.WriteLine(i.SaleLineID);
            }

            // 
            SaleLines.DeleteAllOnSubmit(saleLineToDelete);

            // 
            Sales.DeleteOnSubmit(saleToDelete);

            // Submits the changes to the database
            SubmitChanges();
        }

        
    }
}
