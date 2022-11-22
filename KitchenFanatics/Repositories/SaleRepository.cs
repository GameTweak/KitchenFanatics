using KitchenFanatics.Database;
using KitchenFanatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Repositories
{
    public class SaleRepository : KitchenFanaticDBDataContext
    {
        /// <summary>
        /// Establishes an connection to the database and retrieves all the Sales stored on it
        /// 
        /// Written by Esben
        /// </summary>
        /// <returns>All notes</returns>
        public List<SaleHistory> GetAllSales()
        {
            // Defines the connection to the Database
            using (KitchenFanaticDBDataContext dbContext = new KitchenFanaticDBDataContext())
            {
                // Creates an collection that will contain all the sales from the Database
                List<SaleHistory> saleHistories = new List<SaleHistory>();

                // A foreach loop, looping through all the Sales in the Sales table
                foreach (var saleHistory in dbContext.Sales)
                {
                    // The list that'll be containing all the Items associated with the Sale
                    List<Item> items = new List<Item>();

                    // Defines the customer assosiated with the sale
                    Models.Customer customer = new Models.Customer(
                        saleHistory.Customer.FirstName,
                        saleHistory.Customer.LastName,
                        saleHistory.Customer.Email,
                        saleHistory.Customer.CustomerAddress,
                        saleHistory.Customer.PhoneNumber,
                        saleHistory.Customer.CustomerID
                        );

                    // Foreach loop adding all the items to the List
                    foreach (var item in dbContext.SaleLines.Where(sl => saleHistory.SaleID == sl.SaleID))
                    {
                        var product = item.Product;

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

                        items.Add(lineItem);
                    }

                    // Defines the Sale object
                    SaleHistory sale = new SaleHistory(
                        saleHistory.SaleID,
                        saleHistory.SaleDate,
                        saleHistory.SaleTotal,
                        saleHistory.DeliveryAddress,
                        saleHistory.SaleStatus,
                        items,
                        customer
                        );

                    // Adds the sale to the list
                    saleHistories.Add(sale);
                }
                // Returns the sale
                return saleHistories;
            }
        }

        public List<SaleHistory> GetAllSalesV2()
        {
            // Creates an collection that will contain all the sales from the Database
            List<SaleHistory> saleHistories = new List<SaleHistory>();

            // A foreach loop, looping through all the Sales in the Sales table
            foreach (var saleHistory in Sales)
            {
                // The list that'll be containing all the Items associated with the Sale
                List<Item> items = new List<Item>();

                // 
                decimal TotalPrice = 0;

                // Defines the customer assosiated with the sale
                Models.Customer customer = new Models.Customer(
                    saleHistory.Customer.FirstName,
                    saleHistory.Customer.LastName,
                    saleHistory.Customer.Email,
                    saleHistory.Customer.CustomerAddress,
                    saleHistory.Customer.PhoneNumber,
                    saleHistory.Customer.CustomerID
                    );

                // Foreach loop adding all the items to the List
                foreach (var item in SaleLines.Where(sl => saleHistory.SaleID == sl.SaleID))
                {
                    var product = item.Product;

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

                    TotalPrice += lineItem.Price;

                    items.Add(lineItem);
                }

                // Defines the Sale object
                SaleHistory sale = new SaleHistory(
                    saleHistory.SaleID,
                    saleHistory.SaleDate,
                    TotalPrice,
                    saleHistory.DeliveryAddress,
                    saleHistory.SaleStatus,
                    items,
                    customer
                    );

                // Adds the sale to the list
                saleHistories.Add(sale);
            }
            return saleHistories;
        }
    }
}
