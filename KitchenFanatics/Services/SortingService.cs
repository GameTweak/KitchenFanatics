using KitchenFanatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    public class SortingService
    {

        public List<SaleHistory> FilterSale(List<SaleHistory> saleHistories, string name, string email, string phone, DateTime start, DateTime end)
        {

            List<SaleHistory> sortedList = saleHistories.Where(s => s.CustomerName.StartsWith(name) || s.Customer.Email.StartsWith(email) || s.Customer.phonenumber.StartsWith(phone) || (s.SaleDate > start && s.SaleDate < end)).ToList();

            //List<SaleHistory> sortedList = saleHistories.Where(s => s.CustomerName == name || s.Customer.Email == email || s.Customer.phonenumber == phone || (s.SaleDate > start && s.SaleDate < end)).ToList();

            return sortedList.OrderBy(p => p.SaleDate).ToList();
        }

    }
}
