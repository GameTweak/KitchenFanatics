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
        /// <param name="saleHistories">The sale that's going to be sorted</param>
        /// <param name="fname">The name to filter</param>
        /// <param name="email">The email to filter</param>
        /// <param name="phone">The phone number to filter</param>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        /// <returns></returns>
        public List<SaleHistory> FilterSale(List<SaleHistory> saleHistories, string fname, string lname, string email, string phone, DateTime start, DateTime end)
        {
            // Defines the collection that will be storing the sorted list
            List<SaleHistory> sortedList = saleHistories;
            
            // Defines a string array that'll be containing the information typed into the name box and split between first and last name


            // Checks if empty the first index is empty or null and filters from it
            if (!string.IsNullOrEmpty(fname))
            {
                // Sorts the list by where the FirstName matches the input from the name box
                sortedList = sortedList.Where(s => 
                    s.Customer.FirstName.StartsWith(fname, StringComparison.InvariantCultureIgnoreCase)
                    ).ToList();
            }

            // Checks if empty and if array is longer than 1
            if (!string.IsNullOrEmpty(lname))
            {
                sortedList = sortedList.Where(s => s.Customer.LastName.StartsWith(lname, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Checks if the email box is empty
            if (!string.IsNullOrEmpty(email))
            {
                sortedList = sortedList.Where(s => s.Customer.Email.StartsWith(email, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Checks if the phone box is empty
            if (!string.IsNullOrEmpty(phone))
            {
                sortedList = sortedList.Where(s => s.Customer.phonenumber.StartsWith(phone, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Sorts by the given date
            sortedList = sortedList.Where(s => (s.SaleDate > start && s.SaleDate < end)).ToList();

            // Returns the list order by date
            return sortedList.OrderBy(p => p.SaleDate).ToList();
        }

    }
}
