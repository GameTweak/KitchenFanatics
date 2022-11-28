using KitchenFanatics.Models;
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
    public partial class SalesModule : Form
    {
        // Defines the services used in the from
        private SaleService saleService = new SaleService();
        private SortingService sorting = new SortingService();
        private LogService logger = new LogService();

        // Defines the SaleHistory collection that will be storing the sales
        private List<SaleHistory> history { get; set; }

        // Defines the binding source that will be holding the collection
        private BindingSource source = new BindingSource();

        public SalesModule()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SaleModule_Load is an eventhandler that is triggered when the form is being loaded
        /// </summary>
        private void SalesModul_Load(object sender, EventArgs e)
        {
            // Sets the history to contain all the SaleHistories on the Database
            history = saleService.GetSaleHistories();

            // Binds the source to the history collection
            source.DataSource = history;

            // Binds the DGV to display the collection
            DGV_SaleHistories.DataSource = source;
        }

        /// <summary>
        /// DeleteEntry is an eventhandler that is executed when the user presses the "Delete" button on the page
        /// Once clicked the selected entry is removed from the Database
        /// </summary>
        private void DeleteEntry(object sender, EventArgs e)
        {
            try
            {
                // Checks if a row is selected
                if (DGV_SaleHistories.CurrentRow != null)
                {
                    SaleHistory sale = (SaleHistory)DGV_SaleHistories.CurrentRow.DataBoundItem;

                    // Gets the object of the seleted item
                    saleService.DeleteEntry(sale);

                    // Removes the item from the DataGridView
                    history.Remove(sale);

                    source.ResetBindings(false);

                    // Displays to the user that the entry was deleted
                    MessageBox.Show($"Sale entry {sale.Id} was removed from the Database", "Entry Deleted");
                } else { throw new NullReferenceException("No sale selected!"); }
            }
            catch (NullReferenceException ex) { logger.LogError(ex); }
            catch (Exception ex) { logger.LogError(ex); }
        }

        /// <summary>
        /// ClickToFilter is an eventhandler that is executed when the user presses the "Filter" button on the page
        /// Once clicked the DataGridView (DGV) is updated to fit the criteria in the textbox controls
        /// </summary>
        private void ClickToFilter(object sender, EventArgs e)
        {
            // Sorts the DGV by using a method from the SortingService
            DGV_SaleHistories.DataSource = sorting.FilterSale(history, tb_Name.Text, tb_Email.Text, tb_Phone.Text, dtp_Start.Value, dtp_End.Value);
        }

        /// <summary>
        /// CreateSale is an eventhandler that is executed when the "Create Sale" button is clicked
        /// </summary>
        private void CreateSale(object sender, EventArgs e)
        {
            // Defines the CreateSale form
            CreateSale sale = new CreateSale();

            // Opens the form for the user
            sale.ShowDialog();
        }
    }
}
