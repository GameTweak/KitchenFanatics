﻿using System;
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
    /// <summary>
    /// This code and these comments have been written by Mikkel
    /// </summary>
    public partial class CustomerOverview : Form
    {
        private CustomerFilterService CustomerFilter = new CustomerFilterService();
        private CustomerSortingService customerSortings { get; set;}
        ///Makes a new instance of the CustomerService
        private CustomerService CustomerService = new CustomerService();
        ///Makes a new instance of the Model made into a List
        private List<Customer> CustomerList = new List<Customer>();

       // private BindingSource source = new BindingSource();
        private LogService logger = new LogService();
        public bool CustomerID { get; set; }
        public bool CustomerFirstName { get; set; }

        public bool CustomerLastName { get; set; }
        public bool CustomerAddress { get; set; }
        public bool CustomerPhoneNumber { get; set; }
        public bool CustomerEmail { get; set; }

        /// <summary>
        /// Customer Constructor
        /// </summary>
        public CustomerOverview()
        {
            ///Initializes each individual component on the form
            InitializeComponent();
            ///Calls the UpdateUI method
            UpdateUI();
        }

        public void CustomerOverview_Load(object sender, EventArgs e)
        {
            try
            {
                ///Sets the CustomerList to be equal to the GetCustomers method from CustomerService
                CustomerList = CustomerService.GetCustomers();
                ///Makes a new instance of the CustomerSortingService
                customerSortings = new CustomerSortingService(CustomerList);

               // source.DataSource = CustomerList;

                customerOverview_dgv.DataSource = CustomerList;
            } catch (Exception ex)
            {
                logger.LogError(ex);
            }
        }

        /// <summary>
        /// A method for when you click on the createCustomer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createCustomer_Click(object sender, EventArgs e)
        {
            ///Create a new instance of the CreateCustomer Form
            CreateCustomer customer = new CreateCustomer();
            ///Shows the CreateCustomer form as a dialog box
            customer.ShowDialog();
        }

        /// <summary>
        /// A method for when you click the on a the rowheader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RowClick_customer(object sender, DataGridViewCellMouseEventArgs e)
        {
            ///Create a new instance of the CreateCustomer Form
            CreateCustomer customer = new CreateCustomer();
            ///Shows the CreateCustomer form as a dialog box
            customer.ShowDialog();
        }
        // <summary>
        // This was my first attempt on sorting by clicking on the header of the DataGridView
        // We managed to get it to read the name of the header of the cell that was last clicked
        // </summary>
        /* private void HeaderClick_CustomerID(object sender, DataGridViewCellMouseEventArgs e)
       {
           var temp = customerOverview_dgv.SelectedCells[0].OwningColumn.HeaderText;
           var result = temp.ToString();
       }*/

        /// <summary>
        /// A method for updating the UI
        /// </summary>
        private void UpdateUI()
        {
            ///Sets the DataSource of the DataGridView to be equal to the CustomerList
            customerOverview_dgv.DataSource = CustomerList;
            ///Calls the update method for the DataGridView
            customerOverview_dgv.Update();
        }

        /// <summary>
        /// An overly complicated method for calling the correct sorting method for customers
        /// 
        /// My original idea was for it to take the variable from here and use it in the CustomerSortingService
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortCustomerId_BtnClick(object sender, EventArgs e)
        {
            ///Starts an if statement loop that checks if the bool CustomerID == true
            if (CustomerID == true)
            {
                ///Sets the CustomerList to be equal to the ReturnNewest method of the CustomerSortingService
                CustomerList = customerSortings.ReturnNewest();
                ///Calls the UpdateUI method
                UpdateUI();
                ///Sets the CustomerID bool to false
                CustomerID = false;
            }
            else
            {
                ///Sets the CustomerID bool to true
                CustomerID = true;
                ///Once again sets the CustomerList to RerturnNewest
                CustomerList = customerSortings.ReturnNewest();
                ///Calls the UpdateUI method
                UpdateUI();
            }
        }

        private void SortCustomerFirstName_btnClick(object sender, EventArgs e)
        {
            ///Starts an if statement loop that checks if the bool CustomerFirstName == true
            if (CustomerFirstName == true)
            {
                ///Sets the CustomerList to be equal to the ReturnFirstNameAlphabetical method of the CustomerSortingService
                CustomerList = customerSortings.ReturnFirstNameAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
                ///Sets the CustomerFirstName bool to be false
                CustomerFirstName = false;
            }
            else
            {
                ///Sets the CustomerFirstname bool to be true
                CustomerFirstName = true;
                ///Once again sets the CustomerList to ReturnFirstNameAlphabetical
                CustomerList = customerSortings.ReturnFirstNameAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
            }
        }

        private void SortCustomerLastName_btnClick(Object sender, EventArgs e)
        {
            ///Starts an if statement loop that checks if the bool CustomerLastName == true
            if (CustomerLastName == true)
            {
                ///Sets the CustomerList to be equal to the ReturnLastNameAlphabetical method of the CustomerSortingService
                CustomerList = customerSortings.ReturnLastNameAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
                ///Sets the CustomerLastName bool to false
                CustomerLastName = false;
            }
            else
            {
                ///Sets the CustomerLastName bool to true
                CustomerLastName = true;
                ///Once again sets the CustomerList to ReturnLastNameAlphabetical
                CustomerList = customerSortings.ReturnLastNameAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
            }
        }

        private void SortCustomerAddress_btnCLick(object sender, EventArgs e)
        {
            ///Starts an if statement loop that checks if the bool CustomerAddress == true
            if (CustomerAddress == true)
            {
                ///Sets the CustomerList to be equal to the ReturnCustomerAdressAlphabetical method of the CustomerSortingService
                CustomerList = customerSortings.ReturnCustomerAdressAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
                ///Sets the CustomerAddress bool to false
                CustomerAddress = false;
            }
            else
            {
                ///Sets the CustomerAddress bool to true
                CustomerAddress = true;
                ///Once again sets the CustomerList to ReturnCustomerAdressAlphabetical
                CustomerList = customerSortings.ReturnCustomerAdressAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
            }
        }

        private void SortCustomerEmail_btnCLick(object sender, EventArgs e)
        {
            ///Starts an if statement loop that checks if the bool CustomerEmail == true
            if (CustomerEmail == true)
            {
                ///Sets the CustomerList to be equal to the ReturnCustomerEmailAlphabetical method of the CustomerSortingService
                CustomerList = customerSortings.ReturnCustomerEmailAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
                ///Sets the CustomerEmail bool to false
                CustomerEmail = false;
            }
            else
            {
                ///Sets the CustomerEmail bool to true
                CustomerEmail = true;
                ///Once again sets the CustomerList to ReturnCustomerEmailAlphabetical 
                CustomerList = customerSortings.ReturnCustomerEmailAlphabetical();
                ///Calls the UpdateUI method
                UpdateUI();
            }
        }

        private void SortCustomerPhoneNumber_btnCLick(Object sender, EventArgs e)
        {
            ///Starts an if statement loop that checks if the bool CustomerPhoneNumber == true
            if (CustomerPhoneNumber == false)
            {
                ///Sets the CustomerList to be equal to the ReturnCustomerPhoneNumberHighestToLowest method of the CustomerSortingService
                CustomerList = customerSortings.ReturnCustomerPhoneNumberHighestToLowest();
                ///Calls the UpdateUI method
                UpdateUI();
                ///Sets the CustomerPhoneNumber bool to true
                CustomerPhoneNumber = true;
            }
            else
            {
                ///Sets the CustomerPhoneNumber bool to false
                CustomerPhoneNumber = false;
                ///Once again sets the CustomerList to the ReturnCustomerPhoneNumberHighestToLowest
                CustomerList = customerSortings.ReturnCustomerPhoneNumberHighestToLowest();
                ///Calls the UpdateUI method
                UpdateUI();
            }
        }

        private void ClickToFilter(object sender, EventArgs e)
        {
            customerOverview_dgv.DataSource = CustomerFilter.FilterCustomer(CustomerList, customerFullName_tb.Text, customerMail_tb.Text, customerPhoneNumber_tb.Text, customerAddress_tb.Text);
        }
        
        private void customerOverview_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer SelectedCustomer = (Customer)customerOverview_dgv.SelectedRows[0].DataBoundItem;
            ///Create a new instance of the CreateCustomer Form
            CreateCustomer customer = new CreateCustomer(SelectedCustomer);
            ///Shows the CreateCustomer form as a dialog box
            customer.ShowDialog();
        }
    }
}
