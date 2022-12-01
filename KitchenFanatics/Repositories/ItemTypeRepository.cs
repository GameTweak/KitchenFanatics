using KitchenFanatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Repositories
{
    // Written by Thomas
    public class ItemTypeRepository
    {
        //a variable is initialized, representing a connection to the KitchenFanatic Database
        Database.KitchenFanaticDBDataContext dbContext = new Database.KitchenFanaticDBDataContext();

        /// <summary>
        /// Returns a list containing all of the ItemTypes from the Database
        /// </summary>
        /// <returns></returns>
        public List<ItemType> GetAllItemTypes()
        {
            //a new list containing obejcts of the ItemType class is initialized
            var result = new List<ItemType>();

            //this variable represents the ProductCategories table from the database, which cointains the ItemTypes
            var AllTypes = dbContext.ProductCategories;

            //the foreach loop runs through all of the ItemTypes in the database
            foreach (var type in AllTypes)
            {
                //a new object of the ItemType class is initialized and assigned the values of the ItemType from the database
                //the itemType is then added to the result list, which was initialized outside of the loop
                //this is done for all ItemTypess in the database 
                var itemType = new ItemType(type.CategoryName, type.UniqueAmount, type.CategoryID);
                result.Add(itemType);
            }

            //the method returns result, which cointains all the Items from the Database
            return result;
        }
    }
}
