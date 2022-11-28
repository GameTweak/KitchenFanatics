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

namespace KitchenFanatics.Repositories
{
    /// <summary>
    /// The repository used to fetch the data from the Sales table
    /// 
    /// Written by Esben
    /// </summary>
    public class SaleRepository : KitchenFanaticDBDataContext
    {
        // Time debug objects
        Stopwatch sw = new Stopwatch();

        /// <summary>
        /// Establishes an connection to the database and retrieves all the Sales stored on it
        /// </summary>
        /// <returns>All sales</returns>
        public List<SaleHistory> GetAllSales()
        {
            // Creates an collection that will contain all the sales from the Database
            List<SaleHistory> saleHistories = new List<SaleHistory>();

            sw.Start();

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

                // Uses the FetchItems to add connect the SaleLine items to the SaleHistory
                //items = FetchItems(SaleLines.Where(sl => saleHistory.SaleID == sl.SaleID));


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

            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);

            return saleHistories;
        }

        public void CreateNewSale(SaleHistory historyToSave)
        {
            if (historyToSave.Customer == null) throw new NullReferenceException("Customer cannot be null!");
            if (historyToSave.SaleLine == null) throw new NullReferenceException("The items list must not be Empty!");

            List<Database.SaleLine> lineToSave = new List<Database.SaleLine>();

            Sale newSale = new Sale
            {
                SaleDate = DateTime.Now,
                SaleTotal = (decimal)historyToSave.SaleLine.Select(l => l.Price).Sum(),
                DeliveryAddress = historyToSave.DeliveryAddress,
                SaleStatus = historyToSave.SaleStatus,
                CustomerID = historyToSave.Customer.CustomerID
            };

            Sales.InsertOnSubmit(newSale);

            SubmitChanges();

            Console.WriteLine(newSale.SaleID + " was created");

            foreach (var line in historyToSave.SaleLine)
            {
                Database.SaleLine newline = new Database.SaleLine();

                newline.ItemNR = line.ItemNR;
                newline.Amount = (int) line.Amount;
                newline.Price = (decimal) line.Price;
                newline.SaleID = newSale.SaleID;
                lineToSave.Add(newline);
            }

            SaleLines.InsertAllOnSubmit(lineToSave);
            
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

        /// <summary>
        /// A method used retrieve SaleLine items assosiated with the SaleHistory
        /// </summary>
        /// <param name="line">Linq2Sql line that specifes what sale is connected</param>
        /// <returns>A List collection containing Items</returns>
        private List<Item> FetchItems(IQueryable<Database.SaleLine> line)
        {
            // Defines the List that'll be returned with all the Items
            List<Item> LineItems = new List<Item>();

            // Loops through 
            foreach (var item in line)
            {
                // Selects the Product from each line
                var product = item.Product;

                // Defines the object
                Item lineItem = new Item(
                    product.ItemNR,
                    product.ItemName,
                    product.ItemPrice,
                    product.ItemStock,
                    product.ItemCategory,
                    product.ItemWidth,
                    product.ItemHeight,
                    product.ItemDepth,
                    product.ItemWeight,
                    product.ItemTags);

                // Adds the object to the collection
                LineItems.Add(lineItem);
            }
            // Returns the list
            return LineItems;
        }
    }
}
