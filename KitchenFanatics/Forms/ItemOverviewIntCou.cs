﻿using System;
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
    //Written by Thomas
    public partial class ItemOverviewIntCou : Form
    {
        //a list and a Models.Filter are initiated
        public List<Models.Item> AllItems { get; set; }
        public Models.Filter CurrentFilter { get; set; }

        public ItemOverviewIntCou()
        {
            InitializeComponent(); 
        }

        private void ItemOverview_Load(object sender, EventArgs e)
        {
            //a method is called, which loads the item data
            LoadItemData();
        }

        /// <summary>
        /// Gets all of data about the items from the database and displays them in a DataGridView
        /// </summary>
        public void LoadItemData()
        {
            //creates a new variable which is an instance of the ItemService
            var itemsService = new Services.ItemService();
            //the AllItems variable gets the value of a call to a method from the itemservice which gets all items from the database 
            AllItems = itemsService.GetAllItems();
            //the itemoverview datagridview is set to display all of the items from the database
            dgw_itemoverview.DataSource = AllItems; 
        }

        /// <summary>
        /// Opens the intellectual counceling form when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IntCouFormOpen_Click(object sender, EventArgs e)
        {
            OpenIntellectualCounceling();
        }

        /// <summary>
        /// Opens the form Intellectual_Counceling
        /// </summary>
        private void OpenIntellectualCounceling()
        {
            using (var form = new Intellectual_Counceling())
            {
                var result = form.ShowDialog();

                //checks whether or not DialogResult is OK, it will be OK as long as cancel in Intellectual counceling has not been clicked
                if (result == DialogResult.OK)
                {
                    // gets the filter from the form, and sends the filter to FilterData
                    CurrentFilter = form.CurrentFilter;
                    FilterData(CurrentFilter);
                }
            }
        }

        /// <summary>
        /// Filters data using Filterservice
        /// </summary>
        /// <param name="filter"></param>
        private void FilterData(Models.Filter filter)
        {
            var filterService = new Services.FilterService();
            var result = filterService.CompleteFilter(filter);
            UpdateData(result);
        }

        /// <summary>
        /// Updates the DataGridView with new data
        /// </summary>
        /// <param name="items"></param>
        private void UpdateData(List<Models.Item> items)
        {
            dgw_itemoverview.DataSource = items;
            dgw_itemoverview.Update();
        }
    }
}
