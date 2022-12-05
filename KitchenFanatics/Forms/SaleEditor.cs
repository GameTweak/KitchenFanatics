using KitchenFanatics.Services;
using KitchenFanatics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using Microsoft.Office.Core;

namespace KitchenFanatics.Forms
{
    /// <summary>
    /// SaleEditor for creating and editing sales
    /// 
    /// Written by Esben
    /// </summary>
    public partial class SaleEditor : Form
    {
        // Objects used
        private List<SaleLine> saleLine = new List<SaleLine>();
        private Item currentSelected { get; set; }
        public SaleHistory History { get; set; }
        private BindingSource Cart = new BindingSource();


        // Variables
        private bool ItemSelected = false;
        private bool IsNew { get; set; }

        // Services
        LogService logger = new LogService();

        public SaleEditor(bool isNew)
        {

            InitializeComponent();
            IsNew = isNew;
        }

        public SaleEditor(bool isNew, SaleHistory history)
        {
            InitializeComponent();
            IsNew = isNew;
            this.History = history;
        }

        /// <summary>
        /// The method that's executed once the page loads
        /// </summary>
        private void CreateSale_Load(object sender, EventArgs e)
        {
            // Defines itemService and CustomerSerivce
            ItemService itemService = new ItemService();
            CustomerService customerService = new CustomerService();

            // Binds the ComboBox to contain all Customers
            cb_Customers.DataSource = customerService.GetCustomers();

            // Makes it so the ComboBox displays their full name
            cb_Customers.DisplayMember = "FullName";

            if (IsNew)
            {
                // Changes btn text to Create
                btn_CreateEdit.Text = "Opret";

                //
                cb_Status.SelectedIndex = cb_Status.FindStringExact("Pending");
            }
            else
            {
                // Changes btn text to "Edit"
                btn_CreateEdit.Text = "Gem";

                // Sets the combobox to have the customer Name
                cb_Customers.SelectedIndex = cb_Customers.FindStringExact(History.Customer.FullName);

                // Disable the user from changing associated customer
                cb_Customers.Enabled = false;

                // Sets saleline to be the same as history saleline
                saleLine = History.SaleLine;

                // Sets the Total
                tb_Total.Text = History.SaleLine.Select(sl => sl.Price).Sum().ToString();

                // Fetches status
                cb_Status.SelectedIndex = cb_Status.FindStringExact(GetStatusString(History.SaleStatus));
            }

            // Binds the datasoruce of the cart to the saleLine collection
            Cart.DataSource = saleLine;

            // Retrives all items from the store and binds it to the DataGridView "Products"
            dgv_Products.DataSource = itemService.GetAllItems();

            // Binds the cart source to the DataGridView "Selected"
            dgv_Selected.DataSource = Cart;
        }

        /// <summary>
        /// AddItemToChosen is an eventhandler that is triggered when the user selects an item from the DataGridView. 
        /// Once a click occur the textboxes are updated to fit the data associated with the selected item
        /// </summary>
        private void AddItemToChosen(object sender, MouseEventArgs e)
        {
            // Fetches the currently selected item
            currentSelected = (Item)dgv_Products.CurrentRow.DataBoundItem;

            // Changes the textboxes to display the data of the Item
            tb_Name.Text = currentSelected.Title;
            tb_Stock.Text = currentSelected.InStock.ToString();
            tb_Category.Text = currentSelected.ItemCategory.ToString();
            tb_Height.Text = currentSelected.Height.ToString();
            tb_Width.Text = currentSelected.Width.ToString();
            tb_Depth.Text = currentSelected.Depth.ToString();
            tb_Weight.Text = currentSelected.Weight.ToString();
            tb_Tags.Text = currentSelected.Tags;

            // Changes the bool of ItemSelected to true, since we've selected an item
            ItemSelected = true;
        }

        /// <summary>
        /// AddToCart is an eventhandler that is trigger when the user clicks the "Add" button.
        /// Once clicked the DataGridView on the opposite side updates and adds the newly selected item
        /// </summary>
        private void AddToCart(object sender, EventArgs e)
        {
            try
            {
                int amount;

                if(!int.TryParse(tb_Amount.Text, out amount) || string.IsNullOrEmpty(tb_Amount.Text) || amount < 0)
                {
                    MessageBox.Show("Der er blevet tastet en invalid input i mængde", "An error occured!");
                    return;
                }
                // Checks if there is an item selected and if the amount field is empty as well as if the given amount is 0 or less
                if (ItemSelected && !string.IsNullOrEmpty(tb_Amount.Text) && int.Parse(tb_Amount.Text) > 0 && amount <= currentSelected.InStock)
                {
                    // Creates a new SaleLine object containing the data given
                    SaleLine newSale = new SaleLine(
                                    currentSelected, int.Parse(tb_Amount.Text), currentSelected.Price * decimal.Parse(tb_Amount.Text)
                                    );

                    // Adds the SaleLine to the collection
                    saleLine.Add(newSale);

                    // Updates the DataGridView accordingly
                    Cart.ResetBindings(false);

                    // Updates total box
                    tb_Total.Text = (decimal.Parse(tb_Total.Text) + newSale.Price).ToString();
                }
            }
            catch (NullReferenceException ex) { logger.LogError(ex); }
            catch (FormatException ex) { logger.LogError(ex, "Invalid input typed"); }
            catch (Exception ex) { logger.LogError(ex); }
        }

        /// <summary>
        /// RemoveItem is a eventhandler that is trigger when the user double clicks an entry in the Cart DGV
        /// </summary>
        private void RemoveItem(object sender, EventArgs e)
        {
            // Gets SaleLine
            SaleLine sale = (SaleLine)dgv_Selected.CurrentRow.DataBoundItem;

            // Updates total box
            tb_Total.Text = (decimal.Parse(tb_Total.Text) - sale.Price).ToString();

            // Removes selected item
            saleLine.Remove(sale);

            // Updates the DataGridView
            Cart.ResetBindings(false);
        }

        /// <summary>
        /// CreateNewSale is an eventhandler that is triggered when the "Create Sale" button is clicked
        /// Once clicked the list stored in the DataGridView is saved and stored on the DataBase
        /// </summary>
        private void CreateEditSale(object sender, EventArgs e)
        {
            try
            {
                // Checks if the saleLine is empty
                if (saleLine.Any())
                {
                    if (IsNew)
                    {
                        // Defines the saleService
                        SaleService saleService = new SaleService();

                        // Gets the customer selected in the ComboBox
                        Customer customer = (Customer)cb_Customers.SelectedValue;

                        // Gets the total price of selected items
                        decimal Price = (decimal)saleLine.Select(sl => sl.Price).Sum();

                        // Creates a new saleHistory with the data on the page
                        History = new SaleHistory(RandomDateTime(), Price, customer.Customeraddress, 1, saleLine, customer);

                        // Saves and stores the saleHistory on the database
                        saleService.CreateEntry(History);

                        // Closes the window
                        Close();
                    } 
                    else
                    {
                        // Defines the saleService
                        SaleService saleService = new SaleService();

                        // Gets the customer selected in the ComboBox
                        Customer customer = History.Customer;

                        // Gets the total price of selected items
                        decimal Price = (decimal)saleLine.Select(sl => sl.Price).Sum();

                        History.SaleDate = DateTime.Now;
                        History.TotalPrice = Price;
                        History.SaleStatus = GetStatusInt(cb_Status.Text);
                        History.SaleLine = saleLine;


                        // Saves and stores the saleHistory on the database
                        saleService.EditSale(History);

                        // Closes the window
                        Close();
                    }

                }
            }
            catch (NullReferenceException ex) { logger.LogError(ex); }
            catch (Exception ex) { logger.LogError(ex); }
        }

        DateTime RandomDateTime()
        {
            Random random = new Random();
            DateTime start = new DateTime(2010, 1, 1);
            int range = (DateTime.Today - start).Days;

            int randomHour = random.Next(0, 24);
            int randomMinute = random.Next(0, 60);
            int randomSecond = random.Next(0, 60);

            var randomDate = start.AddDays(random.Next(range));

            return new DateTime(randomDate.Year, randomDate.Month, randomDate.Day, randomHour, randomMinute, randomSecond);
        }

        /// <summary>
        /// A simple switch method that returns what type of status it is as a string
        /// </summary>
        /// <param name="status">The int type of status</param>
        /// <returns></returns>
        public string GetStatusString(int status)
        {
            switch (status)
            {
                case 0:
                    return "Cancelled";
                case 1:
                    return "Pending";
                case 2:
                    return "Completed";
                default:
                    return "Pending";
            }
        }

        /// <summary>
        /// A simple switch method that returns what of status it is as an int
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public int GetStatusInt(string status)
        {
            switch (status)
            {
                case "Cancelled":
                    return 0;
                case "Pending":
                    return 1;
                case "Completed":
                    return 2;
                default:
                    return 1;
            }
        }

        /// <summary>
        /// CancelAction is an eventhandler that trigger when the user presses the Cancel Button
        /// </summary>
        private void CancelAction(object sender, EventArgs e)
        {
            // Closes window
            Close();
        }
    }
}
