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
        /// <summary>
        /// Filters the given list
        /// </summary>
        /// <param name="saleHistories">The </param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<SaleHistory> FilterSale(List<SaleHistory> saleHistories, string fname, string email, string phone, DateTime start, DateTime end)
        {
            // Defines the collection that will be storing the sorted list
            List<SaleHistory> sortedList = saleHistories;
            
            // Defines a string array that'll be containing the information typed into the name box and split between first and last name
            string[] name = fname.Split(' ');


            // Checks if empty
            if (name.Length == 0 && !string.IsNullOrEmpty(name[0]))
            {
                // Sorts the list by where the FirstName matches the input from the name box
                sortedList = sortedList.Where(s => s.Customer.FirstName.StartsWith(name[0], StringComparison.InvariantCultureIgnoreCase) || s.Customer.LastName.StartsWith(name[0], StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Checks if empty and if array is longer than 1
            if (name.Length > 1 && !string.IsNullOrEmpty(name[1]))
            {
                sortedList = sortedList.Where(s => s.Customer.LastName.StartsWith(name[1], StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Checks if empty
            if (!string.IsNullOrEmpty(email))
            {
                sortedList = sortedList.Where(s => s.Customer.Email.StartsWith(email, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Checks if empty
            if (!string.IsNullOrEmpty(phone))
            {
                sortedList = sortedList.Where(s => s.Customer.phonenumber.StartsWith(phone, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Sorts by date
            sortedList = sortedList.Where(s => (s.SaleDate > start && s.SaleDate < end)).ToList();

            // Returns the list order by date
            return sortedList.OrderBy(p => p.SaleDate).ToList();
        }

    }
}
