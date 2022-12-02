using KitchenFanatics.Models;
using KitchenFanatics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenFanatics.Forms
{
    /// <summary>
    /// SalesModule is an overview of all sales
    /// 
    /// Written by Esben
    /// </summary>
    public partial class SalesModule : Form
    {
        // Defines the services used in the from
        private SaleService saleService = new SaleService();
        private SortingService sorting = new SortingService();
        private LogService logger = new LogService();
        private FileService file = new FileService();

        // Defines the SaleHistory collection that will be storing the sales
        private List<SaleHistory> history { get; set; }

        // Defines the binding source that will be holding the collection
        private BindingSource source = new BindingSource();

        // A stopwatch for benchmarks
        private Stopwatch watch = new Stopwatch();

        public SalesModule()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SaleModule_Load is an eventhandler that is triggered when the form is being loaded
        /// </summary>
        private void SalesModul_Load(object sender, EventArgs e)
        {
            try
            {
                // Starts Watch
                watch.Start();

                // Sets the history to contain all the SaleHistories on the Database
                history = saleService.GetSaleHistories();

                // Binds the source to the history collection
                source.DataSource = history;

                // Binds the DGV to display the collection
                DGV_SaleHistories.DataSource = source;

                // Ends watch
                watch.Stop();

                this.Text = $"Salgsoversigt [{watch.ElapsedMilliseconds}ms]";
            }
            catch (Exception ex)
            {
                // Logs the error
                logger.LogError(ex);
            }
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

                    // Refreshes the source
                    source.ResetBindings(false);

                    // Displays to the user that the entry was deleted
                    MessageBox.Show($"Sale entry {sale.Id} was removed from the Database", "Entry Deleted");
                }
                else { throw new NullReferenceException("No sale selected!"); }
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
            DGV_SaleHistories.DataSource = sorting.FilterSale(history, tb_FirstName.Text, tb_LastName.Text, tb_Email.Text, tb_Phone.Text, dtp_Start.Value, dtp_End.Value);
        }

        /// <summary>
        /// CreateSale is an eventhandler that is executed when the "Create Sale" button is clicked
        /// </summary>
        private void CreateSale(object sender, EventArgs e)
        {
            try
            {

                // Defines the CreateSale form
                SaleEditor sale = new SaleEditor(true);

                // Opens the form for the user
                sale.ShowDialog();

                // Adds new entry to DGV
                source.Add(sale.History);

                // Updates the list
                source.ResetBindings(false);
            }
            catch (NullReferenceException ex) { logger.LogError(ex); }
            catch (Exception ex) { logger.LogError(ex); }

        }

        private void EditSale(object sender, EventArgs e)
        {
            try
            {
                // Defines the CreateSale form
                SaleEditor sale = new SaleEditor(false, (SaleHistory)DGV_SaleHistories.CurrentRow.DataBoundItem);

                // Opens the form for the user
                sale.ShowDialog();

                // Updates the list
                source.ResetBindings(false);
            }
            catch (NullReferenceException ex) { logger.LogError(ex); }
            catch (Exception ex) { logger.LogError(ex); }

        }

        /// <summary>
        /// Prints the filtered sale to a pdf file
        /// </summary>
        private void PrintData(object sender, EventArgs e)
        {
            try
            {
                // Defines a new collection that will be storing all filtered data
                List<SaleHistory> saleHistories = new List<SaleHistory>();

                // Loops through the DGV
                foreach (DataGridViewRow sh in DGV_SaleHistories.Rows)
                {
                    // Adds the filtered data to the collection
                    saleHistories.Add((SaleHistory)sh.DataBoundItem);
                }

                // Creates a new file
                file.CreateFile(saleHistories, dtp_Start.Value, dtp_End.Value);
            }
            catch (IOException ex)
            {
                // Throws an exception if the file is already open
                logger.LogError(ex, "The file is already open!");
            }
            catch (Exception ex)
            {
                // Throws an exception if an error occurs
                logger.LogError(ex);
            }
        }
    }
}
