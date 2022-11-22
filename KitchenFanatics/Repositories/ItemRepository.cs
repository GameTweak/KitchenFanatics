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
        /// <summary>
        /// Returns a list containing all of the Items from the Database
        /// </summary>
        /// <returns></returns>
        public List<Models.Item> GetAllItems()
        {
            //a variable is initialized, representing a connection to the KitchenFanatic Database 
            Database.KitchenFanaticDBDataContext dbContext = new Database.KitchenFanaticDBDataContext();

            //a new list containing obejcts of the Item class is initialized
            var result = new List<Models.Item>();
            //this variable represents the Product table from the databse, which cointains the Items
            var allDatabaseItems = dbContext.Products;

            //the foreach loop runs through all of the Items in the database
            foreach (var dbitem in allDatabaseItems)
            {
                //a new object of the Item class is initialized and assigned the values of the Item from the database
                //the item is then added to the result list, which was initialized outside of the loop
                //this is done for all Items in the database 
                var item = new Models.Item(dbitem.ItemNR, dbitem.ItemName, dbitem.ItemPrice, dbitem.ItemStock, dbitem.ItemCategory, dbitem.ItemWidth, dbitem.ItemHeight, dbitem.ItemDepth, dbitem.ItemWeight, dbitem.ItemTags);
                result.Add(item); 
            }
            //the method returns result, which cointains all the Items from the Database
            return result; 
        }

        public void CreateItem()
        {
            //Do something
        }

        public void UpdateItem()
        {
            //Do something 
        }

        public void DeleteItem()
        {
            //Do something 
        }
    }
}
