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

        /// <summary>
        /// Sorts all items by price (lowest to highest) and puts them into a list
        /// </summary>
        /// <returns></returns>
        public List<Models.Item> SortByPriceLow()
        {
            //call to a method, which retrieves all of the items from the database thorugh the repository
            var allItems = GetAllItems();
            //sorts the items in order of price (ascending)
            var sortedItems = allItems.OrderBy(i => i.Price);
            //puts the sorted items into a list
            var result = sortedItems.ToList();

            return result;

        }

        /// <summary>
        /// Sorts all items by price (highest to lowest) and puts them into a list
        /// </summary>
        /// <returns></returns>
        public List<Models.Item> SortByPriceHigh()
        {
            //call to a method, which retrieves all of the items from the database through the repository
            var allItems = GetAllItems();
            //sorts the items in order of price (descending)
            var sortedItems = allItems.OrderByDescending(i => i.Price);
            //puts the sorted items into a list
            var result = sortedItems.ToList();

            return result;
        }

        /// <summary>
        /// Sorts all items by item name (from a - å)
        /// </summary>
        /// <returns></returns>
        public List<Models.Item> SortByItemNameAsc()
        {
            //call to a method which retrieves all of the items from the database through the repository
            var allItems = GetAllItems();
            //sorts the items in order of their title (ascending)
            var sortedItems = allItems.OrderBy(i => i.Title);
            //puts the sorted items into a list
            var result = sortedItems.ToList();

            return result;
        }

        /// <summary>
        /// Sorts all items by item name (from å - a)
        /// </summary>
        /// <returns></returns>
        public List<Models.Item> SortByNameDesc()
        {
            //call to a method which retireves all of the items from the database thorugh the repository
            var allItems = GetAllItems();
            //sorts the items in order of their title (descending)
            var sortedItems = allItems.OrderByDescending(i => i.Title);
            //puts the sorted items into a list
            var result = sortedItems.ToList();

            return result;
        }
    }
}
