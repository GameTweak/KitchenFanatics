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
    public partial class ItemCreate : Form
    {
        //an instance of the ItemService class and the Item class are instantiated
        public Services.ItemService ItemsService { get; set; }
        public Models.Item NewItem { get; set; }

        public ItemCreate()
        {
            InitializeComponent();
            //the ItemsService is a new instance of the ItemService class 
            ItemsService = new Services.ItemService();
        }

        private void btn_createitem_Click(object sender, EventArgs e)
        {
            //call to a method which saves the new item in the database, when the save button is pressed 
            SaveCreatedItem();
        }

        /// <summary>
        /// Saves the NewItem as a row in the Products table in the database
        /// </summary>
        public void SaveCreatedItem()
        {
            //instantiation of a new string with the value of the itemname textbox
            string newTitle = txt_itemname.Text;
            //checks if the newTitle is null/empty, and in that case gives an error message
            if (String.IsNullOrEmpty(newTitle))
            {
                MessageBox.Show("Varenavn skal udfyldes", "Fejl");
                return;
            }

            //checks whether the decimals and integers can NOT be parsed, and saves them in a new variable 
            //also checks if the value of the new variable is NOT above or equal to 0
            if (!((decimal.TryParse(txt_itemprice.Text, out decimal newPrice) && newPrice >= 0) &&
               (decimal.TryParse(txt_itemwidth.Text, out decimal newWidth) && newWidth >= 0) &&
               (decimal.TryParse(txt_itemheight.Text, out decimal newHeight) && newHeight >= 0) &&
               (decimal.TryParse(txt_itemdepth.Text, out decimal newDepth) && newDepth >= 0) &&
               (decimal.TryParse(txt_itemweight.Text, out decimal newWeight) && newWeight >= 0) &&
               (int.TryParse(txt_iteminstock.Text, out int newInStock) && newInStock >= 0) &&
               (int.TryParse(txt_itemcategory.Text, out int newCategory) && newCategory > 0)))
            {
                //if the if statement is true an error message is displayed
                MessageBox.Show("Felterne skal indeholde tal", "Fejl");
                return;
            }

            //instantiation of a new string with the value of the itemtags textbox
            string newTags = txt_itemtags.Text;

            //the NewItem is a new instance of the Item class and is given the new variables as the parameters 
            NewItem = new Models.Item(newTitle, newPrice, newInStock, newCategory, newWidth, newHeight, newDepth, newWeight, newTags);

            //call to an ItemService method whick saves the NewItem in the database
            ItemsService.CreateItem(NewItem);
            this.Close();
        }
    }
}
