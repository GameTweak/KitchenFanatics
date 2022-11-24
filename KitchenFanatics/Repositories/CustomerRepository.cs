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
        public List<Models.Customer> GetAllCustomers()
        {
            var result = new List<Models.Customer>();

            var AllCustomers = Customers;

            foreach (var customer in AllCustomers)
            {
                var customers = new Models.Customer(customer.FirstName, customer.LastName, customer.Email, customer.PhoneNumber, customer.CustomerAddress, customer.CustomerID);

                result.Add(customers);
            }
            return result;
        }
    
        public void createCustomer(Models.Customer currentCustomer)
        {
           Database.Customer NewCustomer = new Database.Customer();

            NewCustomer.FirstName = currentCustomer.FirstName;
            NewCustomer.LastName = currentCustomer.LastName;
            NewCustomer.Email = currentCustomer.Email;
            NewCustomer.PhoneNumber = currentCustomer.phonenumber;
            NewCustomer.CustomerAddress = currentCustomer.Customeraddress;
            
            Customers.InsertOnSubmit(NewCustomer);
            SubmitChanges();
        }

        public void updateCustomer(Models.Customer currentCustomer)
        {
            Database.Customer updatedCustomer = new Database.Customer();
            var selectedCustomer = Customers.Single(Customer => Customer.CustomerID == currentCustomer.id);
            
            updatedCustomer.FirstName = selectedCustomer.FirstName;
            updatedCustomer.LastName = selectedCustomer.LastName;
            updatedCustomer.Email = selectedCustomer.Email;
            updatedCustomer.PhoneNumber = selectedCustomer.PhoneNumber;
            updatedCustomer.CustomerAddress = selectedCustomer.CustomerAddress;

            SubmitChanges();
        }

        public void deleteCustomer(Models.Customer currentCustomer)
        {
           var selectedCustomer = Customers.Single(Customer => Customer.CustomerID == currentCustomer.id);
            Customers.DeleteOnSubmit(selectedCustomer);
            SubmitChanges();
        }
    }
}
