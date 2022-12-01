using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Models
{
    //Written by Thomas
    public class Filter
    {
        //a constructor is created for the Item class, ? is used to allow nulls
        public Filter(string type, decimal? maxWidth, decimal? maxHeight, decimal? maxDepth, decimal? minWidth, decimal? minHeight, decimal? minDepth, decimal? maxWeight, decimal? maxPrice, decimal? minPrice)
        {
            //the fields of the class are assigned the value of the parameters in the constructor
            this.Type = type;
            this.MaxWidth = maxWidth;
            this.MaxHeight = maxHeight;
            this.MaxDepth = maxDepth;
            this.MinWidth = minWidth;
            this.MinHeight = minHeight;
            this.MinDepth = minDepth;
            this.MaxWeight = maxWeight;
            this.MaxPrice = maxPrice;
            this.MinPrice = minPrice;
        }

        //the class is assigned fields, which are all made public 
        public string Type { get; set; }
        public decimal? MaxWidth { get; set; }
        public decimal? MaxHeight { get; set; }
        public decimal? MaxDepth { get; set; }
        public decimal? MinWidth { get; set; }
        public decimal? MinHeight { get; set; }
        public decimal? MinDepth { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MinPrice { get; set; }
    }
}
