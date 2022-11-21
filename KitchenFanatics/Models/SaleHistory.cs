using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenFanatics.Models;

namespace KitchenFanatics.Models
{
    public class SaleHistory
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public int SaleStatus { get; set; }
    }
}
