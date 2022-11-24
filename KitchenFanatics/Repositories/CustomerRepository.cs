using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenFanatics.Models;
using KitchenFanatics.Forms;
using KitchenFanatics.Properties;
using KitchenFanatics.Services;
using KitchenFanatics.Database;
using System.Data.Linq;

namespace KitchenFanatics.Repositories
{
    internal class CustomerRepository : KitchenFanaticDBDataContext
    {
        /// <summary>
        /// Here we make a List of customers and call it GetAllCustomers
        /// 
        /// Written by Mikkel
        /// </summary>
        /// <returns></returns>
        public List<Models.Customer> GetAllCustomers()
        {
            ///Creates a variable called result which makes a new instance of the Models.Customer list
            var result = new List<Models.Customer>();

            ///Creates a variable called AllCustomers that will include all the database Customers
            var AllCustomers = Customers;

            ///Creates a foreach loop that goes through each customer in the variable AllCustomers
            foreach (var customer in AllCustomers)
            {
                ///Creates a variable called Customers in the loop which will make sure that all the variables from the models.customer are fullfilled
                var customers = new Models.Customer(customer.FirstName, customer.LastName, customer.Email, customer.PhoneNumber, customer.CustomerAddress, customer.CustomerID);

                ///Adds the customer that was part of the customers variable to the result
                result.Add(customers);
            }
            ///Returns the result to the list
            return result;
        }
        
        /// <summary>
        /// A method for creating customers
        /// </summary>
        /// <param name="currentCustomer"></param>
        public void createCustomer(Models.Customer currentCustomer)
        {
           ///Says NewCustomer = the database version of Customer
           Database.Customer NewCustomer = new Database.Customer();
            
            ///Sets the variables for NewCustomer equal to the Customer currently selected
            NewCustomer.FirstName = currentCustomer.FirstName;
            NewCustomer.LastName = currentCustomer.LastName;
            NewCustomer.Email = currentCustomer.Email;
            NewCustomer.PhoneNumber = currentCustomer.phonenumber;
            NewCustomer.CustomerAddress = currentCustomer.Customeraddress;
            
            ///When you submit you insert the NewCustomer into the Customers
            Customers.InsertOnSubmit(NewCustomer);
            SubmitChanges();
        }

        /// <summary>
        /// A method for updating the Customer 
        /// </summary>
        /// <param name="currentCustomer"></param>
        public void updateCustomer(Models.Customer currentCustomer)
        {
            ///Says a variable called UpdatedCustomer is equal to a new Database customer
            Database.Customer updatedCustomer = new Database.Customer();

            ///creates a variable called selectedCustomer which finds a single entity in the Customers database
            ///where the currentCustomers id equals the customerID in the dtabase 
            var selectedCustomer = Customers.Single(Customer => Customer.CustomerID == currentCustomer.id);
            
            ///Sets the information that has currently been input in the form to be equal to the updateCustomer data
            updatedCustomer.FirstName = selectedCustomer.FirstName;
            updatedCustomer.LastName = selectedCustomer.LastName;
            updatedCustomer.Email = selectedCustomer.Email;
            updatedCustomer.PhoneNumber = selectedCustomer.PhoneNumber;
            updatedCustomer.CustomerAddress = selectedCustomer.CustomerAddress;

            ///Just Updates the information
            SubmitChanges();
        }

        /// <summary>
        /// A method for deletingCustomers
        /// </summary>
        /// <param name="currentCustomer"></param>
        public void deleteCustomer(Models.Customer currentCustomer)
        {
           ///Creates a variable called selectedCustomer which finds the single entity selected
           ///It checks if the customer you are currently on has the same id as the one in the database
           var selectedCustomer = Customers.Single(Customer => Customer.CustomerID == currentCustomer.id);
            ///Tells it to delete when it gets submitted
            Customers.DeleteOnSubmit(selectedCustomer);
            SubmitChanges();
        }
    }
}
