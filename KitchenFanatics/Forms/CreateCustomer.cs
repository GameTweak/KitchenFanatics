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
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveCustomer_btn_Click(object sender, EventArgs e)
        {
            ValidCustomer();
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
                MissingData += "Contact info";
            }

            //verifies firstname
            if (createCustomerFirstName_tb.Text != "")
            {

            }
            else if (MissingData != "")
            {
                MissingData += ", First name";
            }
            else
            {
                MissingData += "First name";
            }

            //verifies lastname
            if (createCustomerLastName_tb.Text != "")
            {

            }
            else if (MissingData != "")
            {
                MissingData += ", Last name";
            }
            else
            {
                MissingData += "Last name";
            }

            //verifies adress
            if (createCustomerAddress_tb.Text != "")
            {

            }
            else if (MissingData != "")
            {
                MissingData += ", Adress";
            }
            else
            {
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
