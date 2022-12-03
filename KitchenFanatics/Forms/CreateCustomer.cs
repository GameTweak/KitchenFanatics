using KitchenFanatics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenFanatics.Forms
{
    public partial class CreateCustomer : Form
    {
        //Written by Thomas
        //A connection to the logService
        LogService logService = new LogService();
        public CreateCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the site when cancel is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Goes to ValidCustomer when save is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveCustomer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ValidCustomer();
            }
            catch (Exception ex)
            {
                logService.LogError(ex);
            }
        }

        /// <summary>
        /// The function that checks if the Customer data is valid
        /// </summary>
        private void ValidCustomer()
        {
            bool ValidPhoneNumber = false;
            bool ValidEmail = false;
            string MissingData = "";

            //verifies the phonenumber
            if (createCustomerPhoneNumber_tb.Text != "")
            {
                ValidPhoneNumber = true;
            }

            //verifies the email
            if (createCustomerMail_tb.Text.Contains("@") == true && createCustomerMail_tb.Text.Contains(".") == true)
            {
                ValidEmail = true;
            }

            //Tells the user that they are missing contact info
            if (ValidPhoneNumber != true && ValidEmail != true)
            {
                //Adds Contact info to the list of data missing
                MissingData += "Contact info";
            }

            //verifies firstname
            if (createCustomerFirstName_tb.Text == "" && MissingData != "")
            {
                //Adds First name to the list of data missing
                MissingData += ", First name";
            }
            else if (createCustomerFirstName_tb.Text == "")
            {
                //Adds First name to the list of data missing
                MissingData += "First name";
            }

            //verifies lastname
            if (createCustomerLastName_tb.Text == "" && MissingData != "")
            {
                //Adds Last name to the list of data missing
                MissingData += ", Last name";
            }
            else if (createCustomerLastName_tb.Text == "")
            {
                //Adds Last name to the list of data missing
                MissingData += "Last name";
            }

            //verifies adress
            if (createCustomerAddress_tb.Text == "" && MissingData != "")
            {
                //Adds Adress to the list of data missing
                MissingData += ", Adress";
            }
            else if (createCustomerAddress_tb.Text == "")
            {
                //Adds Adress to the list of data missing
                MissingData += "Adress";
            }

            //Tells the user what info is missing, if nothing is missing, save customer
            if (MissingData != "")
            {
                MissingData_lb.Text = MissingData;
                Missing_lb.Visible = true;
                MissingData_lb.Visible = true;
            }
            else
            {
                SaveCustomer();
                this.Close();
            }
        }

        /// <summary>
        /// Saves the customer
        /// </summary>
        private void SaveCustomer()
        {
            // makes a new connection to the CustomerService
            var customerService = new CustomerService();

            // makes a Models.Customer named NewCustomer, with all the data inserted into the form
            Models.Customer NewCustomer = new Models.Customer(createCustomerFirstName_tb.Text, createCustomerLastName_tb.Text, createCustomerMail_tb.Text, createCustomerAddress_tb.Text, createCustomerPhoneNumber_tb.Text, null);
            // saves the customer
            customerService.createCustomer(NewCustomer);
        }

        /// <summary>
        /// makes it so the phonenumber only accepts numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createCustomerPhoneNumber_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
