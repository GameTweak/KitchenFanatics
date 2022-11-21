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
        /// <summary>
        /// A SaleHistory class, which will contain the information used
        /// in the sale part of the Application
        /// 
        /// Written by Esben
        /// </summary>
        
        // Used to set and get the ID
        public int Id { get; set; }

        // Places a creation date of the Sale
        public DateTime SaleDate { get; set; }

        // Sets the total price of the sale
        public decimal TotalPrice { get; set; }

        // Connects the Delivery Address to the Sale
        public string DeliveryAddress { get; set; }

        // Used to control the status of the Sale
        public int SaleStatus { get; set; }

        // A list containing all the items of the Sale
        public List<Item> Items { get; set; }

        // The customer connected to the Sale
        public Customer Customer { get; set; }
    }
}
