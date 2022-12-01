using KitchenFanatics.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Models
{
    /// <summary>
    /// SaleLine model used to set and retrieve data.
    /// 
    /// Written by Esben
    /// </summary>
    public class SaleLine
    {
        // Constructor for when we're defining an exsisting SaleLine
        public SaleLine(int? saleLineID, Item item, int? amount, decimal? price, int? saleID)
        {
            SaleLineID = saleLineID;
            ItemInLine = item;
            Amount = amount;
            Price = price;
            SaleID = saleID;
        }

        // Constructor for when the program needs to define a new SaleLine.
        public SaleLine(Item item, int? amount, decimal? price)
        {
            ItemInLine = item;
            Amount = amount;
            Price = price;
        }

        public SaleLine(Database.SaleLine saleLine)
        {
            this.SaleLineID = saleLine.SaleLineID;
            this.ItemInLine = new Item(saleLine.Product);
            this.Price = saleLine.Price;
            this.Amount = saleLine.Amount;
            this.SaleID = saleLine.SaleID;
        }

        // The ID of the SaleLine
        public int? SaleLineID { get; set; }

        // The Item associated with the SaleLine
        public Item ItemInLine { get; set; }

        // The Item Number/Identification
        public int? ItemNR { get { return ItemInLine.Id; } }

        // Get ItemName
        public String ItemName { get { return ItemInLine.Title; } }

        // Amount of Item
        public int? Amount { get; set; }

        // The Price of the item
        public decimal? Price { get; set; }

        // The ID of the sale it is associatied with
        public int? SaleID { get; set; }

    }
}
