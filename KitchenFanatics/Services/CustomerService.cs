using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenFanatics.Services;

namespace KitchenFanatics.Services
{
    internal class CustomerService
    {
        private CustomerSorting CustomerSortingTool { get; set; }
        public bool ColumnHeadClicked { get; set; }
        public void createCustomer(Models.Customer currentCustomer)
        {
            var CustomerRepository = new Repositories.CustomerRepository();
            CustomerRepository.createCustomer(currentCustomer);
        }

        public void updateCustomer(Models.Customer currentCustomer)
        {
            var customerRepository = new Repositories.CustomerRepository();
            customerRepository.updateCustomer(currentCustomer);
        }

        public void deleteCustomer(Models.Customer currentCustomer)
        {
            var customerRepository = new Repositories.CustomerRepository();
            customerRepository.deleteCustomer(currentCustomer);
        }

        public List<Models.Customer> GetCustomers()
        {
            var customerRepository = new Repositories.CustomerRepository();
            return customerRepository.GetAllCustomers();
        }

        public void datagridSort()
        {
            if (ColumnHeadClicked == true)
            {
               CustomerSortingTool.ReturnNewest();
            } else
            {
               CustomerSortingTool.ReturnOldest();
            }
        }
    }
}
