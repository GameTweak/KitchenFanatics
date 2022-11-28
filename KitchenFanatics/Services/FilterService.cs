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
        private List<Item> result { get; set; }

        public FilterService()
        {

        }
        /// <summary>
        /// Filters the items by type
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public List<Item> FilterByType(List<Item> ListToSort, List<int> TypeID)
        {
            //Sets result to ListToSort
            result.Clear();

            //Repeats for each type searched for
            foreach (var type in TypeID)
            {
                //Adds the items matching the type to result
                var temp = ListToSort.Where(itm => itm.ItemCategory == type).ToList();
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
        public List<Item> FilterBySize(List<Item> ListToSort, decimal MaxWidth, decimal MaxHeight, decimal MaxDepth, decimal MinWidth, decimal MinHeight, decimal MinDepth)
        {
            //Sets result to ListToSort
            result = ListToSort;

            //If the items max width is not zero, then it filters by max width
            if (MaxWidth != 0)
            {
                result = result.Where(itm => itm.Weight < MaxWidth).ToList();
            }

            //If the items max height is not zero, then it filters by max height
            if (MaxHeight != 0)
            {
                result = result.Where(itm => itm.Weight < MaxHeight).ToList();
            }

            //If the items max depth is not zero, then it filters by max depth
            if (MaxDepth != 0)
            {
                result = result.Where(itm => itm.Weight < MaxDepth).ToList();
            }

            //If the items min width is not zero, then it filters by min width
            if (MinWidth != 0)
            {
                result = result.Where(itm => itm.Weight < MinWidth).ToList();
            }

            //If the items min height is not zero, then it filters by min height
            if (MinHeight != 0)
            {
                result = result.Where(itm => itm.Weight < MinHeight).ToList();
            }

            //If the items min depth is not zero, then it filters by min depth
            if (MinDepth != 0)
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
        public List<Item> FilterByWeight(List<Item> ListToSort, decimal MaxWeight)
        {
            //Sets result to ListToSort
            result = ListToSort;

            //If the items max weight is not zero, then it filters by max weight
            if (MaxWeight != 0)
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
        public List<Item> FilterByPrice(List<Item> ListToSort, decimal MaxPrice, decimal MinPrice)
        {
            //Sets result to ListToSort
            result = ListToSort;

            //If the items max price is not zero, then it filters by max price
            if (MaxPrice != 0)
            {
                result = result.Where(Itm => Itm.Price < MaxPrice).ToList();
            }

            //If the items min price is not zero, then it filters by min price
            if(MinPrice != 0)
            {
                result = result.Where(Itm => Itm.Price > MinPrice).ToList();
            }

            //Returns result
            return result;
        }
    }
}
