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
            ItemService itemService = new ItemService();
            CustomerService customerService = new CustomerService();

            cb_Customers.DataSource = customerService.GetCustomers();
            cb_Customers.DisplayMember = "FullName";

            Cart.DataSource = saleLine;

            dgv_Products.DataSource = itemService.GetAllItems();
            dgv_Selected.DataSource = Cart;
        }

        private void AddItemToChosen(object sender, MouseEventArgs e)
        {
            currentSelected = (Item)dgv_Products.CurrentRow.DataBoundItem;


            tb_Name.Text = currentSelected.Title;
            tb_Stock.Text = currentSelected.InStock.ToString();
            tb_Category.Text = currentSelected.ItemCategory.ToString();
            tb_Height.Text = currentSelected.Height.ToString();
            tb_Width.Text = currentSelected.Width.ToString();
            tb_Depth.Text = currentSelected.Depth.ToString();
            tb_Weight.Text = currentSelected.Weight.ToString();
            tb_Tags.Text = currentSelected.Tags;

            ItemSelected = true;
        }

        private void AddToCart(object sender, EventArgs e)
        {
            try
            {
                if (ItemSelected && !string.IsNullOrEmpty(tb_Amount.Text))
                {
                    SaleLine newSale = new SaleLine(
                                    currentSelected.Id, int.Parse(tb_Amount.Text), currentSelected.Price * decimal.Parse(tb_Amount.Text)
                                    );

                    saleLine.Add(newSale);

                    Cart.ResetBindings(false);
                } else
                {
                    throw new NullReferenceException("No item is selected or amount given!");
                }
            } catch (NullReferenceException ex)
            {
                logger.LogError(ex);
            } catch (FormatException ex)
            {
                logger.LogError(ex, "Invalid input typed");
            } catch (Exception ex)
            {
                logger.LogError(ex);
            }
        }

        private void CreateNewSale(object sender, EventArgs e)
        {
            SaleService saleService = new SaleService();

            Customer customer = (Customer) cb_Customers.SelectedValue;

            decimal Price = (decimal) saleLine.Select(sl => sl.Price).Sum();

            SaleHistory saleHistory = new SaleHistory(DateTime.Now, Price, customer.Customeraddress, 1, saleLine, customer);

            saleService.CreateEntry(saleHistory);
        }
    }
}
