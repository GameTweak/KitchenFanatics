using KitchenFanatics.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Models
{
    public class SaleLine
    {
        public SaleLine(int? saleLineID, int? itemNR, int? amount, decimal? price, int? saleID)
        {
            SaleLineID = saleLineID;
            ItemNR = itemNR;
            Amount = amount;
            Price = price;
            SaleID = saleID;
        }

        public int? SaleLineID { get; set; }

        public int? ItemNR { get; set; }

        public int? Amount { get; set; }

        public decimal? Price { get; set; }

        public int? SaleID { get; set; }

    }
}
