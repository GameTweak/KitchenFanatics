using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Repositories
{
    //Written by Johanne 
    public class ItemRepository
    {
        //a variable is instantiated, representing a connection to the KitchenFanatic Database
        Database.KitchenFanaticDBDataContext dbContext = new Database.KitchenFanaticDBDataContext();

        /// <summary>
        /// Returns a list containing all of the Items from the Database
        /// </summary>
        /// <returns></returns>
        public List<Models.Item> GetAllItems()
        {
            try
            {
                //a new list containing obejcts of the Item class is instantiated
                var result = new List<Models.Item>();
                //this variable represents the Product table from the database, which cointains the Items
                var allDatabaseItems = dbContext.Products;

                //the loop runs through all of the Items in the database
                foreach (var dbitem in allDatabaseItems)
                {
                    //a new object of the Item class is instantiated and assigned the values of the Item from the database
                    //the item is then added to the result list, which was instantiated outside of the loop
                    var item = new Models.Item(dbitem.ItemNR, dbitem.ItemName, dbitem.ItemPrice, dbitem.ItemStock, dbitem.ItemCategory, dbitem.ItemWidth, dbitem.ItemHeight, dbitem.ItemDepth, dbitem.ItemWeight, dbitem.ItemTags);
                    result.Add(item);
                }
                //the method returns result, which cointains all the Items from the Database
                return result;
            }
            //if an exception is catched, an error messaged is logged and the method will return null
            catch (Exception ex)
            {
                Console.WriteLine("Fejl: Der opstod følgende fejl: " + ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Creates a new item row in the Product table of the database
        /// </summary>
        /// <param name="item"></param>
        public void CreateItem(Models.Item item)
        {
            //a new object of the database Product type is instansiated
            Database.Product newItem = new Database.Product();

            //newItem is assigned the values of the item, which is the parameter for the method
            newItem.ItemName = item.Title;
            newItem.ItemPrice = item.Price;
            newItem.ItemStock = item.InStock;
            newItem.ItemCategory = item.ItemCategory;
            newItem.ItemWidth = item.Width;
            newItem.ItemHeight = item.Height;
            newItem.ItemDepth = item.Depth;
            newItem.ItemWeight = item.Weight;
            newItem.ItemTags = item.Tags;

            //the new row will be inserted in the table when submitted
            dbContext.Products.InsertOnSubmit(newItem);
            //the changes are submitted 
            dbContext.SubmitChanges();

        }

        /// <summary>
        /// Updates a chosen row in the Product table in the database 
        /// </summary>
        /// <param name="item"></param>
        public void UpdateItem(Models.Item item)
        {
            //linq is used to find the product row whose id matches the id of the item used in the method's parameter
            var dbItem = dbContext.Products.Where(dbi => dbi.ItemNR == item.Id).FirstOrDefault();

            //the database item is assigned the values of the item 
            dbItem.ItemName = item.Title;
            dbItem.ItemPrice = item.Price;
            dbItem.ItemStock = item.InStock;
            dbItem.ItemCategory = item.ItemCategory;
            dbItem.ItemWidth = item.Width;
            dbItem.ItemHeight = item.Height;
            dbItem.ItemDepth = item.Depth;
            dbItem.ItemWeight = item.Weight;
            dbItem.ItemTags = item.Tags;

            //the update is submitted to the database
            dbContext.SubmitChanges();
        }

        /// <summary>
        /// Deletes a chosen row from the Product table in the database
        /// </summary>
        /// <param name="item"></param>
        public void DeleteItem(Models.Item item)
        {
            //linq is used to find the product row whose id matches the id of the item used in the method's parameter
            var dbItem = dbContext.Products.Where(dbi => dbi.ItemNR == item.Id).First();

            //on submit the matching database item will be deleted
            dbContext.Products.DeleteOnSubmit(dbItem);
            //the changes are submitted
            dbContext.SubmitChanges();
        }
    }
}
