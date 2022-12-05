using KitchenFanatics.Models;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    internal class CustomerFilterService
    {
        public List<Customer> FilterCustomer(List<Customer> filtCus, string firstName, string eMail, string phoneNumber, string address)
        {
            List<Customer> FilteredList = filtCus;

            string[] name = firstName.Split(' ');

            // Checks if string is empty the first index is empty or null and filters from it
            if (!string.IsNullOrEmpty(name[0]))
            {
                // Sorts the list by where the FirstName matches the input from the name box
                FilteredList = FilteredList.Where(c =>
                    c.FirstName.StartsWith(name[0], StringComparison.InvariantCultureIgnoreCase) ||
                    c.LastName.StartsWith(name[0], StringComparison.InvariantCultureIgnoreCase)
                    ).ToList();
            }
            // Checks if Name is empty and if array is longer than 1
            if (name.Length > 1 && !string.IsNullOrEmpty(name[0]) && !string.IsNullOrEmpty(name[1]))
            {
                FilteredList = FilteredList.Where(c => c.LastName.StartsWith(name[1], StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Checks if the email box is empty
            if (!string.IsNullOrEmpty(eMail))
            {
                FilteredList = FilteredList.Where(c => c.Email.StartsWith(eMail, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            // Checks if the phoneNumber box is empty
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                FilteredList = FilteredList.Where(c => c.phonenumber.StartsWith(phoneNumber, StringComparison.InvariantCultureIgnoreCase)).ToList();
            };
            //Returns the list orderedby CustomerID
            return FilteredList;
        }
    }
}
