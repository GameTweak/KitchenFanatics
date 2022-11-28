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
    public partial class ItemOverview : Form

        //Written by Johanne
    {
        //a list containing items from the item class is instantiated
        public List<Models.Item> AllItems { get; set; }

        public ItemOverview()
        {
            InitializeComponent(); 
        }

        private void ItemOverview_Load(object sender, EventArgs e)
        {
            //a method is called, which loads the item data
            LoadItemData();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            //a method is called, which opens the ItemUpdate form
            OpenUpdateItem();
        }

        private void btn_createnewitem_Click(object sender, EventArgs e)
        {
            //a method is called which opens the CreateItem form 
            OpenCreateItem(); 
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
        /// Opens the ItemUpdate form
        /// </summary>
        public void OpenUpdateItem()
        {
            //the variable selectedItem is created with the value of the currently pressed row
            Models.Item selectedItem = (Models.Item)dgw_itemoverview.SelectedRows[0].DataBoundItem;
            //checks if an item is selected and throws an exception if nothing was selected
            if (selectedItem == null)
            {
                throw new NullReferenceException("Vælg venligst en vare");
            }

            //a new instance of the ItemUpdate form is created, taking the selectedItem as a parameter 
            ItemUpdate ItemUpdateForm = new ItemUpdate(selectedItem);
            //call to a method which will open the form
            ItemUpdateForm.ShowDialog();
            //call to a method which loads the item data to the datagridview, to show possible changes 
            LoadItemData(); 
        }

        /// <summary>
        /// Opens the CreateItem form
        /// </summary>
        public void OpenCreateItem()
        {
            //a new instance of the ItemCreate form is created
            ItemCreate ItemCreateForm = new ItemCreate();
            //call to a method which will open the form
            ItemCreateForm.ShowDialog();
            //call to a method which loads the item data to the datagridview, to show possible changes
            LoadItemData(); 
        }
    }
}
