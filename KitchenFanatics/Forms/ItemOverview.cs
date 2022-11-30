using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public Services.ItemService ItemsService { get; set; }

        public ItemOverview()
        {
            InitializeComponent();
            ItemsService = new Services.ItemService(); 
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

        private void cb_sortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sorts the items in the datagridview when an option is clicked in the combobox
            SortItemList();
        }

        private void btn_printitems_Click(object sender, EventArgs e)
        {
            //prints the content of the datagridview to a txt file
            WriteToTxtFile(); 
        }

        /// <summary>
        /// Gets all of data about the items from the database and displays them in a DataGridView
        /// </summary>
        public void LoadItemData()
        {
            //the AllItems variable gets the value of a call to a method from the itemservice which gets all items from the database 
            AllItems = ItemsService.GetAllItems();
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

        /// <summary>
        /// Sorts the list in the datagridview according to what is selected on cb_sortby
        /// </summary>
        public void SortItemList()
        {
            //chekcs which option is picked in the combobox, and changes the datagridview accordingly
            switch (cb_sortby.Text)
            {
                case "Standard":
                    dgw_itemoverview.DataSource = AllItems;
                    break;
                case "Pris - Lav til høj":
                    dgw_itemoverview.DataSource = ItemsService.SortByPriceLow();
                    break;
                case "Pris - Høj til lav":
                    dgw_itemoverview.DataSource = ItemsService.SortByPriceHigh();
                    break;
                case "Varenavn - a-å":
                    dgw_itemoverview.DataSource = ItemsService.SortByItemNameAsc();
                    break;
                case "Varenavn - å-a":
                    dgw_itemoverview.DataSource = ItemsService.SortByNameDesc();
                    break;
            }
        }

        /// <summary>
        /// Saves the content of the itemoverview datagridview to a txt file
        /// </summary>
        public void WriteToTxtFile()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Vareudskrift[{DateTime.Now.ToString("MM-dd-yy HH:mm")}].txt");
            Console.WriteLine(path);
            
            //initiates an empty string
            string textToPrint = "";
            
            //loops through all of the rows in the datagridview
            foreach (DataGridViewRow it in dgw_itemoverview.Rows)
            {
                //gets the data from the row and saves it in "item"
                Models.Item item = (Models.Item)it.DataBoundItem;
                //the row is saved as a string in the previously initiated string 
                textToPrint += $"Varenummer: {item.Id}, Varenavn: {item.Title}, Pris: {item.Price}, Varekategori: {item.ItemCategory}, På lager: {item.InStock}, " +
                    $"{Environment.NewLine} Bredde: {item.Width}, Højde: {item.Height}, Dybde: {item.Depth}, Vægt: {item.Weight}, Tags: {item.Tags} " +
                    $"{Environment.NewLine} {Environment.NewLine}";
            }
            
            //the string is saved in the Vareudskrift txt file which will be created
            //if the file already exists it will be overwritten
            File.WriteAllText(path, textToPrint);
            //a messagebox pops up to inform the user of the action
            MessageBox.Show("Varene på listen er blevet udskrevet");
        }
    }
}
