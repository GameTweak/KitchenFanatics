using KitchenFanatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    internal class CustomerSorting
    {
        private List<Customer> History { get; set; }

        public bool ColumnHeadClicked { get; set; }

        public CustomerSorting(List<Customer> CustomerHistory)
        {
            this.History = CustomerHistory;
        }

        public List<Customer> ReturnNewest()
        {
            return History.OrderByDescending(ch => ch.CustomerID).ToList();
        }

        public List<Customer> ReturnOldest()
        {
            return History.OrderBy(ch => ch.CustomerID).ToList();
        }

        
    }
}
