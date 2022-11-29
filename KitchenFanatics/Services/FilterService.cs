using KitchenFanatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    public class FilterService
    {
        private Filter filter { get; set; }

        public FilterService()
        {

        }
        /// <summary>
        /// Filters the items by type
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public List<Item> FilterByType(List<Item> ListToFilter, List<int> TypeID)
        {
            List<Item> result = new List<Item>(); 

            //Repeats for each type searched for
            foreach (var type in TypeID)
            {
                //Adds the items matching the type to result
                var temp = ListToFilter.Where(itm => itm.ItemCategory == type).ToList();
                result.AddRange(temp);
            }

            //returns result
            return result;
        }

        /// <summary>
        /// Filters the items by size
        /// </summary>
        /// <param name="MaxWidth"></param>
        /// <param name="MaxHeight"></param>
        /// <param name="MaxDepth"></param>
        /// <param name="MinWidth"></param>
        /// <param name="MinHeight"></param>
        /// <param name="MinDepth"></param>
        /// <returns></returns>
        public List<Item> FilterBySize(List<Item> ListToFilter, decimal? MaxWidth, decimal? MaxHeight, decimal? MaxDepth, decimal? MinWidth, decimal? MinHeight, decimal? MinDepth)
        {
            List<Item> result = new List<Item>();

            //Sets result to ListToFilter
            result = ListToFilter;

            //If the items max width is not null, then it filters by max width
            if (MaxWidth != null)
            {
                result = result.Where(itm => itm.Weight < MaxWidth).ToList();
            }

            //If the items max height is not null, then it filters by max height
            if (MaxHeight != null)
            {
                result = result.Where(itm => itm.Weight < MaxHeight).ToList();
            }

            //If the items max depth is not null, then it filters by max depth
            if (MaxDepth != null)
            {
                result = result.Where(itm => itm.Weight < MaxDepth).ToList();
            }

            //If the items min width is not null, then it filters by min width
            if (MinWidth != null)
            {
                result = result.Where(itm => itm.Weight < MinWidth).ToList();
            }

            //If the items min height is not null, then it filters by min height
            if (MinHeight != null)
            {
                result = result.Where(itm => itm.Weight < MinHeight).ToList();
            }

            //If the items min depth is not null, then it filters by min depth
            if (MinDepth != null)
            {
                result = result.Where(itm => itm.Weight < MinDepth).ToList();
            }

            //Returns result
            return result;
        }

        /// <summary>
        /// Filters by the items weight
        /// </summary>
        /// <param name="Weight"></param>
        /// <returns></returns>
        public List<Item> FilterByWeight(List<Item> ListToFilter, decimal? MaxWeight)
        {
            List<Item> result = new List<Item>();
            //Sets result to ListToFilter
            result = ListToFilter;

            //If the items max weight is not null, then it filters by max weight
            if (MaxWeight != null)
            {
                result = result.Where(itm => itm.Weight < MaxWeight).ToList();
            }

            //Returns result
            return result;
        }

        /// <summary>
        /// Filters by the items price
        /// </summary>
        /// <param name="MaxPrice"></param>
        /// <param name="MinPrice"></param>
        /// <returns></returns>
        public List<Item> FilterByPrice(List<Item> ListToFilter, decimal? MaxPrice, decimal? MinPrice)
        {
            List<Item> result = new List<Item>();
            //Sets result to ListToFilter
            result = ListToFilter;

            //If the items max price is not null, then it filters by max price
            if (MaxPrice != null)
            {
                result = result.Where(Itm => Itm.Price < MaxPrice).ToList();
            }

            //If the items min price is not null, then it filters by min price
            if(MinPrice != null)
            {
                result = result.Where(Itm => Itm.Price > MinPrice).ToList();
            }

            //Returns result
            return result;
        }

        /// <summary>
        /// Uses the other methods to filter all data in the database with all data from the Intellectual counceling form
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Item> CompleteFilter(Filter filter)
        {
            // Makes a new list of items called result
            List<Item> result = new List<Item>();

            // Gets all items from the database
            var itemsService = new ItemService();
            result = itemsService.GetAllItems();

            // Makes a connection to the LineReadService
            var lineReadService = new LineReadService();

            // Filters the items by each filter type, uses the filter from the Intellectual counceling form, and the lineReadService to read type
            result = FilterByType(result, lineReadService.ReadForType(filter.Type));
            result = FilterBySize(result, filter.MaxWidth, filter.MaxHeight, filter.MaxDepth, filter.MinWidth, filter.MinHeight, filter.MinDepth);
            result = FilterByWeight(result, filter.MaxWeight);
            result = FilterByPrice(result, filter.MaxPrice, filter.MinPrice);

            // Returns result
            return result;
        }
    }
}
