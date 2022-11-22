using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenFanatics.Models;
using KitchenFanatics.Forms;
using KitchenFanatics.Properties;
using KitchenFanatics.Services;

namespace KitchenFanatics.Repositories
{
    internal class CustomerRepository
    {
        public List<Customer> GetAllCustomers()
        {
            Database.KitchenFanaticDBDataContext customerDataContext = new Database.KitchenFanaticDBDataContext();

            var result = new List<Customer>();

            var AllCustomers = customerDataContext.Customers;

            foreach (var customer in AllCustomers)
            {
                var customers = new Customer(customer.FirstName, customer.LastName, customer.Email, customer.PhoneNumber, customer.CustomerAddress, customer.CustomerID);

                result.Add(customers);
            }
            return result;
        }
    }
}
