using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Models
{
    internal class Customer
    {
        public Customer(string firstname, string lastname, string email, string customeraddress, int phonenumber) 
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Customeraddress = customeraddress;
            this.phonenumber = phonenumber;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Customeraddress { get; set; }
        public int phonenumber { get; set; }
    }
}
