using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitchenFanatics.Forms;
using KitchenFanatics.Models;

namespace KitchenFanatics.Forms
{
    public partial class CustomerOverview : Form
    {
        public CustomerOverview()
        {
            InitializeComponent();
        }

        private void UpdateInformation(Customer customer)
        {
            customerFullName_tb.Text = customer.FirstName + " " + customer.LastName;
            customerAddress_tb.Text = customer.Customeraddress;
            customerMail_tb.Text = customer.Email;
            customerPhoneNumber_tb.Text = customer.phonenumber;
        }
        private void createCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer customer = new CreateCustomer();
        }

        private void RowClick_customer(object sender, DataGridViewCellMouseEventArgs e)
        {
            CreateCustomer form = new CreateCustomer();
            form.ShowDialog();
        }
    }
}
