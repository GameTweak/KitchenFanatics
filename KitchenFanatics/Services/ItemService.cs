using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    //Written by Johanne
    public class ItemService
    {
        Repositories.ItemRepository ItemsRepository = new Repositories.ItemRepository(); 

        /// <summary>
        /// Retrives a method from the ItemRepository, which puts all Items from the database into a list
        /// </summary>
        /// <returns></returns>
        public List<Models.Item> GetAllItems()
        {
            return ItemsRepository.GetAllItems(); 
        }

        /// <summary>
        /// Retrieves a method from the ItemRepository, which creates a new item in the database
        /// </summary>
        /// <param name="item"></param>
        public void CreateItem(Models.Item item)
        {
            ItemsRepository.CreateItem(item); 
        }

        /// <summary>
        /// Retrieves a method from the ItemRepository, which updates a chosen row in the product table in the database
        /// </summary>
        /// <param name="item"></param>
        public void UpdateItem(Models.Item item)
        {
            ItemsRepository.UpdateItem(item); 
        }

        /// <summary>
        /// Retrieves a method from the ItemRepository, which deletes a chosen row from the Products table in the database
        /// </summary>
        /// <param name="item"></param>
        public void DeleteItem(Models.Item item)
        {
            ItemsRepository.DeleteItem(item); 
        }
    }
}
