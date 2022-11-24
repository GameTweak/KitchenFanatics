using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenFanatics.Database;
using KitchenFanatics.Repositories;

namespace KitchenFanatics.Services
{
    internal class CustomerService
    {
        /// <summary>
        /// A service method for creating a customer
        /// 
        /// Written by Mikkel
        /// </summary>
        /// <param name="currentCustomer"></param>
        public void createCustomer(Models.Customer currentCustomer)
        {
            ///Creates a variable named CustomerRepository that creates a new instance of the CustomerRepository
            var CustomerRepository = new Repositories.CustomerRepository();
            ///Calls the createCustomer method in the CustomerRepository
            CustomerRepository.createCustomer(currentCustomer);
        }

        /// <summary>
        /// A service method for Updating the customer
        /// </summary>
        /// <param name="currentCustomer"></param>
        public void updateCustomer(Models.Customer currentCustomer)
        {
            ///Creates a variable named CustomerRepository that creates a new instance of the CustomerRepository
            var customerRepository = new Repositories.CustomerRepository();
            ///Calls the updateCustomer method in the CustomerRepository
            customerRepository.updateCustomer(currentCustomer);
        }

        private void deleteCustomer(Models.Customer currentCustomer)
        {
            ///Creates a variable named CustomerRepository that creates a new instance of the CustomerRepository
            var customerRepository = new Repositories.CustomerRepository();
            ///Calls the deleteCustomer method in the CustomerRepository
            customerRepository.deleteCustomer(currentCustomer);
        }

        private List<Models.Customer> GetCustomers()
        {
            ///Creates a variable named CustomerRepository that creates a new instance of the CustomerRepository
            var customerRepository = new Repositories.CustomerRepository();
            ///Calls the GetAllCustomers method in the CustomerRepository
            return customerRepository.GetAllCustomers();
        }
    }
}
