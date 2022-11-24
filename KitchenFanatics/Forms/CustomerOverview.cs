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
        /// <summary>
        /// A method where you initialize the components on the form
        /// 
        /// Written by Mikkel
        /// </summary>
        public CustomerOverview()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A method for updatingInformation
        /// It sets the textboxes texts to be equal to some information from the customer class
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateInformation(Customer customer)
        {
            customerFullName_tb.Text = customer.FirstName + " " + customer.LastName;
            customerAddress_tb.Text = customer.Customeraddress;
            customerMail_tb.Text = customer.Email;
            customerPhoneNumber_tb.Text = customer.phonenumber;
        }

        /// <summary>
        /// A method for when you click the createCustomer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer customer = new CreateCustomer();
        }

        /// <summary>
        /// A method for when you doubbleclick on a row in the datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RowClick_customer(object sender, DataGridViewCellMouseEventArgs e)
        {
            ///makes a createCustomer called form which is a new instance of the form and after that makes the form show up
            CreateCustomer form = new CreateCustomer();
            form.ShowDialog();
        }
    }
}
