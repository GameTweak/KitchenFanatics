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

            foreach (var dbcustomer in AllCustomers)
            {
                var customers = new Models.Customer(dbcustomer.FirstName, dbcustomer.LastName, dbcustomer.Email, dbcustomer.CustomerAddress, dbcustomer.PhoneNumber,  dbcustomer.CustomerID);

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
            var selectedCustomer = Customers.Single(Customer => Customer.CustomerID == currentCustomer.CustomerID);
            
            selectedCustomer.FirstName = currentCustomer.FirstName;
            selectedCustomer.LastName = currentCustomer.LastName;
            selectedCustomer.Email = currentCustomer.Email;
            selectedCustomer.PhoneNumber = currentCustomer.phonenumber;
            selectedCustomer.CustomerAddress = currentCustomer.Customeraddress;

            SubmitChanges();
        }

        public void deleteCustomer(Models.Customer currentCustomer)
        {
           var selectedCustomer = Customers.Single(Customer => Customer.CustomerID == currentCustomer.CustomerID);
            Customers.DeleteOnSubmit(selectedCustomer);
            SubmitChanges();
        }
    }
}
