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

        public string GetItemCategory
        {
            get
            {
                switch (ItemCategory)
                {
                    case 0:
                        return string.Empty;
                    case 1:
                        return "Hjørneskab";
                    case 2:
                        return "Overskab";
                    case 3:
                        return "Underskab";
                    case 4:
                        return "Låger";
                    case 5:
                        return "Bordplader";
                    case 6:
                        return "Belysning";
                    case 7:
                        return "Reoler";
                    case 8:
                        return "Køkkenvaske";
                    case 9:
                        return "Knopper og greb";
                    case 10:
                        return "Skuffer";
                    case 11:
                        return "Rulleborde";
                    case 12:
                        return "Hvidevare";
                    default: return string.Empty;
                }
            }
        }

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

        //a second constructor is addedl where the id is removed as a parameter 
        public Item(string title, decimal price, int stock, int? category, decimal? width, decimal? height, decimal? depth, decimal? weight, string tags)
        {
            //the fields of the class are assigned the value of the parameters in the contructor
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

        // Another constructor that uses the Product table as a paramenter / Written by Esben
        public Item(Product product)
        {
            this.Id = product.ItemNR;
            this.Title = product.ItemName;
            this.Price = product.ItemPrice;
            this.InStock = product.ItemStock;
            this.ItemCategory = product.ItemCategory;
            this.Width = product.ItemWidth;
            this.Height = product.ItemHeight;
            this.Depth = product.ItemDepth; ;
            this.Weight = product.ItemWeight;
            this.Tags = product.ItemTags;
        }
    }
}
