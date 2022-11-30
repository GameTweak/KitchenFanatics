using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenFanatics.Forms;
using KitchenFanatics.Models;

namespace KitchenFanatics.Services
{
    /// <summary>
    /// This Code and these comments have been written by Mikkel
    /// </summary>
    internal class CustomerSortingService
    {
        private List<Customer> History { get; set; }
       //public object HeaderClick_CustomerID { get; private set; }

        private bool CustomerID { get; set; }

        private bool CustomerFirstName { get; set; }

        private bool CustomerLastName { get; set; }
        private bool CustomerAddress { get; set; }
        private bool CustomerPhoneNumber { get; set; }
        private bool CustomerEmail { get; set; }

        /// <summary>
        /// A constructor for the CustomerSortingService
        /// </summary>
        /// <param name="CustomerHistory"></param>
        public CustomerSortingService(List<Customer> CustomerHistory)
        {
            this.History = CustomerHistory;
        }

        /// <summary>
        /// a method to Return the Newest or Oldest Customer in a list
        /// By Newest we mean the one with the highest CustomerID
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReturnNewest()
        {
            ///Remnant of when I used two separet methods for sorting based on CustomerID
            //var result = ReturnOldest();
            ///Checks if the CustomerID bool equals false
            if (CustomerID == false)
            {
                ///Sets the CustomerID bool to true
                CustomerID = true;
                ///Tells it to return the History in descendingOrder based on CustomerID
                return History.OrderByDescending(ch => ch.CustomerID).ToList();
            }
            else
            {
                ///Sets the CustomerID bool to be false
                CustomerID = false;
                ///Tells it to return the history in ascendingorder based on CustomerID
                return History.OrderBy(ch => ch.CustomerID).ToList();
                ///Remnant of when I used two separet methods for sorting based on CustomerID
                // return result;
            }

        }

       /* public List<Customer> ReturnOldest()
        {
            return History.OrderBy(ch => ch.CustomerID).ToList();
        }*/

        /// <summary>
        /// A method for Sorting based on the FirstName and doing it in Alphabetical order
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReturnFirstNameAlphabetical()
        {
            ///Checks if the CustomerFirstName bool is equal to false
            if (CustomerFirstName == false)
            {
                ///Sets the CustomerFirstName bool to be true
                CustomerFirstName = true;
                ///Tells it to return the history in ascendingorder based on CustomerFirstName
                return History.OrderBy(ch => ch.FirstName).ToList();
            }
            else
            {
                ///Sets the CustoemrFirstName bool to be false
                CustomerFirstName = false;
                ///Tells it to return the history in descendingorder based on CustomerFirstName
                return History.OrderByDescending(ch => ch.FirstName).ToList();
            }
        }

        /// <summary>
        /// A method for Sorting based on the LastName and doing it in Alphabetical order
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReturnLastNameAlphabetical()
        {
            ///Checks if the CustomerLastName bool is equal to false
            if (CustomerLastName == false)
            {
                ///Sets the CustomerLastName bool to true
                CustomerLastName = true;
                ///Tells it to return the history in ascendingorder based on CustomerLastName
                return History.OrderBy(ch => ch.LastName).ToList();
            }
            else
            {
                ///Sets the CustomerLastName bool to false
                CustomerLastName = false;
                ///Tells it to return the history in descendingorder based on CustomerLastName
                return History.OrderByDescending(ch => ch.LastName).ToList();
            }
        }

        /// <summary>
        /// A method for Sorting based on the CustomerAddress and doing it in Alphabetical order
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReturnCustomerAdressAlphabetical()
        {
            ///Checks if the CustomerAddress bool is equal to false
            if (CustomerAddress == false)
            {
                ///Sets the CustomerAddress bool to true
                CustomerAddress = true;
                ///Tells it to return the history in ascendingorder based on CustomerAddress
                return History.OrderBy(ch => ch.Customeraddress).ToList();
            }
            else
            {
                ///Sets the CustomerAddress bool to false
                CustomerAddress = false;
                ///Tells it to return the history in descendingorder based on CustomerAddress
                return History.OrderByDescending(ch => ch.Customeraddress).ToList();
            }

        }

        /// <summary>
        /// A method for Sorting based on the Email and doing it in Alphabetical order
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReturnCustomerEmailAlphabetical()
        {
            ///Checks if the CustomerEmail bool is equal to false
            if (CustomerEmail == false)
            {
                ///Sets the CustomerEmail bool to true
                CustomerEmail = true;
                ///Tells it to return the history in ascendingorder based on CustomerEmail
                return History.OrderBy(ch => ch.Email).ToList();
            }
            else
            {
                ///Sets the CustomerEmail bool to false
                CustomerEmail = false;
                ///Tells it to return the history in descendingorder based on CustomerEmail
                return History.OrderByDescending(ch => ch.Email).ToList();
            }
        }

        /// <summary>
        /// A method for Sorting based on the PhoneNumber and doing it in Numerical order
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReturnCustomerPhoneNumberHighestToLowest()
        {
            ///Checks if the CustomerPhoneNumber is equal to false
            if (CustomerPhoneNumber == false)
            {
                ///Sets the CustomerPhoneNumber bool to true
                CustomerPhoneNumber = true;
                ///Tells it to return the history in ascendingorder based on CustomerPhoneNumber
                return History.OrderBy(ch => ch.phonenumber).ToList();
            }
            else
            {
                ///Sets the CustomerPhoneNumber bool to false
                CustomerPhoneNumber = false;
                ///Tells it to return the history in descendingorder based on CustomerPhoneNumber
                return History.OrderByDescending(ch => ch.phonenumber).ToList();
            }
        }
    }
}
