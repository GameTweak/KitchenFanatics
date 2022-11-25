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
    //Written by Johanne
    public partial class ItemUpdate : Form
    {
        //an instance of the item class and the itemservice class are instantiated
        public Models.Item SelectedItem { get; set; }
        public Services.ItemService ItemsService { get; set; }

        public ItemUpdate(Models.Item item)
        {
            InitializeComponent();
            //the SelectedItem is set to the value of the item from the form's parameter
            SelectedItem = item;
            //the ItemService is an instance og the ItemService class 
            ItemsService = new Services.ItemService();
        }

        private void ItemUpdate_Load(object sender, EventArgs e)
        {
            //call to a method, which loads the data for the SelectedItem, when the form is loaded
            LoadItemData();
        }

        private void btn_saveitem_Click(object sender, EventArgs e)
        {
            //call to a method, which updates data of the SelectedItem when the save button is pressed 
            UpdateItemData();
        }

        private void btn_deleteitem_Click(object sender, EventArgs e)
        {
            //call to a method, which deletes the SelectedItem's row from the table in the database 
            DeleteFromDatabase();
        }

        /// <summary>
        /// Sets the text in the textboxes to the corresponding data from the SelectedItem 
        /// </summary>
        public void LoadItemData()
        {
            txt_itemname.Text = SelectedItem.Title;
            txt_itemtags.Text = SelectedItem.Tags;
            txt_itemprice.Text = SelectedItem.Price.ToString();
            txt_itemwidth.Text = SelectedItem.Width.ToString();
            txt_itemheight.Text = SelectedItem.Height.ToString();
            txt_itemdepth.Text = SelectedItem.Depth.ToString();
            txt_itemweight.Text = SelectedItem.Weight.ToString();
            txt_iteminstock.Text = SelectedItem.InStock.ToString();
            txt_itemcategory.Text = SelectedItem.ItemCategory.ToString();
        }

        /// <summary>
        /// Updates the data of the SelectedItem in the database to the inserted values
        /// </summary>
        public void UpdateItemData()
        {
            SelectedItem.Title = txt_itemname.Text;
            //checks if the title of the SelectedItem is null/empty, and in that case gives an error message
            if (String.IsNullOrEmpty(SelectedItem.Title))
            {
                MessageBox.Show("Varenavn skal udfyldes");
                return; 
            }

            //checks whether the decimals and integers can NOT be parsed, and saves them in a new variable 
            //also checks if the value of the new variable is NOT above or equal to 0
            if (!((decimal.TryParse(txt_itemprice.Text, out decimal upPrice) && upPrice >= 0) &&
                (decimal.TryParse(txt_itemwidth.Text, out decimal upWidth) && upWidth >= 0) &&
                (decimal.TryParse(txt_itemheight.Text, out decimal upHeight) && upHeight >= 0) &&
                (decimal.TryParse(txt_itemdepth.Text, out decimal upDepth) && upDepth >= 0) &&
                (decimal.TryParse(txt_itemweight.Text, out decimal upWeight) && upWeight >= 0) &&
                (int.TryParse(txt_iteminstock.Text, out int upInStock) && upInStock >= 0) &&
                (int.TryParse(txt_itemcategory.Text, out int upCategory) && upCategory > 0)))
            {
                //if the if statement is true an error message is displayed 
                MessageBox.Show("Felterne skal indeholde tal");
                return;
            }
            //if the if statement is false, the new variables are set as values of the SelectedItem
            else
            {
                SelectedItem.Price = upPrice;
                SelectedItem.Width = upWidth;
                SelectedItem.Height = upHeight;
                SelectedItem.Depth = upDepth;
                SelectedItem.Weight = upWeight;
                SelectedItem.InStock = upInStock;
                SelectedItem.ItemCategory = upCategory;
            }

            //the content of the tags textbox is saved as a value to the SelectedItem
            SelectedItem.Tags = txt_itemtags.Text;

            //call to a Service method which saves the updates of the SelectedItem to the database
            ItemsService.UpdateItem(SelectedItem);
            //lastly the form is closed
            this.Close(); 
        }

        /// <summary>
        /// Deletes the SelectedItem from the database
        /// </summary>
        public void DeleteFromDatabase()
        {
            //when the delete button is pressed, a messagebox will pop up, asking for the user to confirm the deletion
            var confirmationBox = MessageBox.Show("Er du sikker på du vil slette denne vare?", "Slet vare", MessageBoxButtons.YesNo);

            //the if statement checks if the Yes button is pressed
            if (confirmationBox == DialogResult.Yes)
            {
                //if the if statement is true, a ItemService method is called, which will delete the SelectedItem from the database
                ItemsService.DeleteItem(SelectedItem);
                this.Close();
            }
        }
    }
}
