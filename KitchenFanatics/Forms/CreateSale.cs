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

namespace KitchenFanatics.Forms
{
    public partial class CreateSale : Form
    {
        // Objects used
        private List<SaleLine> saleLine = new List<SaleLine>();
        private Item currentSelected { get; set; }
        private BindingSource Cart = new BindingSource();


        // Variables
        public bool ItemSelected = false;

        // Services
        LogService logger = new LogService();

        public CreateSale()
        {
            InitializeComponent();
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
            currentSelected = (Item) dgv_Products.CurrentRow.DataBoundItem;

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
                // Checks if there is an item selected and if the amount field is empty as well as if the given amount is 0 or less
                if (ItemSelected && !string.IsNullOrEmpty(tb_Amount.Text) || int.Parse(tb_Amount.Text) <= 0)
                {
                    // Creates a new SaleLine object containing the data given
                    SaleLine newSale = new SaleLine(
                                    currentSelected.Id, int.Parse(tb_Amount.Text), currentSelected.Price * decimal.Parse(tb_Amount.Text)
                                    );

                    // Adds the SaleLine to the collection
                    saleLine.Add(newSale);

                    // Updates the DataGridView accordingly
                    Cart.ResetBindings(false);
                }
                else
                {
                    // Throws an exception if the conditions are not met
                    throw new NullReferenceException("No item is selected or amount given!");
                }
            }
            catch (NullReferenceException ex) { logger.LogError(ex); }
            catch (FormatException ex) { logger.LogError(ex, "Invalid input typed"); }
            catch (Exception ex) { logger.LogError(ex); }
        }

        /// <summary>
        /// CreateNewSale is an eventhandler that is triggered when the "Create Sale" button is clicked
        /// Once clicked the list stored in the DataGridView is saved and stored on the DataBase
        /// </summary>
        private void CreateNewSale(object sender, EventArgs e)
        {
            try
            {
                // Checks if the saleLine is empty
                if (saleLine.Any())
                {
                    // Defines the saleService
                    SaleService saleService = new SaleService();

                    // Gets the customer selected in the ComboBox
                    Customer customer = (Customer)cb_Customers.SelectedValue;

                    // Gets the total price of selected items
                    decimal Price = (decimal)saleLine.Select(sl => sl.Price).Sum();

                    // Creates a new saleHistory with the data on the page
                    SaleHistory saleHistory = new SaleHistory(DateTime.Now, Price, customer.Customeraddress, 1, saleLine, customer);

                    // Saves and stores the saleHistory on the database
                    saleService.CreateEntry(saleHistory);
                }
            } 
            catch (NullReferenceException ex) { logger.LogError(ex); }
            catch (Exception ex) { logger.LogError(ex); }
        }
    }
}
