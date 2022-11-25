using KitchenFanatics.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KitchenFanatics.Models
{
    public class Customer
    {
        public Customer(string firstname, string lastname, string email, string customeraddress, string phonenumber, int id) 
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Customeraddress = customeraddress;
            this.phonenumber = phonenumber;
            this.id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Customeraddress { get; set; }
        public string phonenumber { get; set; }
        public int id { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
