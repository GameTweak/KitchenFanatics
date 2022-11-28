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
using KitchenFanatics.Services;

namespace KitchenFanatics.Forms
{
    public partial class CustomerOverview : Form
    {
        private CustomerService CustomerService { get; set; }
        private List<Customer> CustomerList { get; set; }
        public CustomerOverview()
        {
            InitializeComponent();
            CustomerService= new CustomerService();
            CustomerList= new List<Customer>();
            CustomerList = CustomerService.GetCustomers();
            UpdateUI();
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

        private void HeaderClick_CustomerID()
        {

        }

        private void UpdateUI()
        {
            customerOverview_dgv.DataSource = CustomerList;
        }
    }
}
