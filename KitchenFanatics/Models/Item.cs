using KitchenFanatics.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Models
{
    //Written by Johanne
    public class Item
    {
        //a constructor is created for the Item class, ? is used to allow nulls
        public Item(int id, string title, decimal price, int stock, int? category, decimal? width, decimal? height, decimal? depth, decimal? weight, string tags)
        {
            //the fields of the class are assigned the value of the parameters in the constructor
            this.Id = id;
            this.Title = title;
            this.Price = price;
            this.InStock = stock;
            this.ItemCategory = category;
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
            this.Weight = weight;
            this.Tags = tags; 
        }

        //the class is assigned fields, which are all made public 
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int? ItemCategory { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Weight { get; set; }
        public string Tags { get; set; }
    }
}
