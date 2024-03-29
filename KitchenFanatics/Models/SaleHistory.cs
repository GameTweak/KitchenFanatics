﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using KitchenFanatics.Database;
using KitchenFanatics.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KitchenFanatics.Models
{
    /// <summary>
    /// A SaleHistory class, which will contain the information used
    /// in the sale part of the Application
    /// 
    /// Written by Esben
    /// </summary>
    public class SaleHistory
    {
        // Constructor for defining af instance in the Sale History
        public SaleHistory(int id, DateTime date, decimal? price, string address, int status, List<SaleLine> saleLine, Customer customer)
        {
            this.Id = id;
            this.SaleDate = date;
            this.TotalPrice = price;
            this.DeliveryAddress = address;
            this.SaleStatus = status;
            this.SaleLine = saleLine;
            this.Customer = customer;
        }

        // Constructor for when defining a new instance in Sale History
        public SaleHistory(DateTime date, decimal? price, string address, int status, List<SaleLine> saleLine, Customer customer)
        {
            this.SaleDate = date;
            this.TotalPrice = price;
            this.DeliveryAddress = address;
            this.SaleStatus = status;
            this.SaleLine = saleLine;
            this.Customer = customer;
        }

        // Used to set and get the ID
        public int Id { get; set; }

        // Places a creation date of the Sale
        public DateTime SaleDate { get; set; }

        // Sets the total price of the sale
        public decimal? TotalPrice { get; set; }

        // Connects the Delivery Address to the Sale
        public String DeliveryAddress { get; set; }

        // Used to control the status of the Sale
        public int SaleStatus { get; set; }

        // A list containing all the items of the Sale
        public List<SaleLine> SaleLine { get; set; }

        // The customer connected to the Sale
        public Customer Customer { get; set; }

        // Returns the customers full name
        public String CustomerName { get { return Customer.FirstName + " " + Customer.LastName; } }

        // Get the sale status as a string
        public String GetStatusType
        {
            get
            {
                switch (SaleStatus)
                {
                    case 0:
                        return "Cancelled";
                    case 1:
                        return "Pending";
                    case 2:
                        return "Completed";
                    default:
                        return "Pending";
                }
            }
        }

        // Returns Customers email
        public String GetEmail { get { return Customer.Email; } }

        // Gets Customers phone number
        public String GetPhoneNumber { get { return Customer.phonenumber; } }
    }
}
