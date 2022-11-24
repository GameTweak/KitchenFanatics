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
    public partial class ItemCreate : Form
    {
        public Services.ItemService ItemsService { get; set; }
        public Models.Item NewItem { get; set; }

        public ItemCreate()
        {
            InitializeComponent();
            ItemsService = new Services.ItemService();
        }

        private void btn_createitem_Click(object sender, EventArgs e)
        {
            SaveCreatedItem(); 
        }

        /*
        public void OLDSaveCreatedItem()
        {
            if (String.IsNullOrEmpty(txt_itemname.Text))
            {
                MessageBox.Show("Varenavn skal udfyldes", "Fejl");
            }
            else
            {
                try
                {
                    var newTitle = txt_itemname.Text;
                    var newPrice = decimal.Parse(txt_itemprice.Text);
                    var newInStock = int.Parse(txt_iteminstock.Text);
                    var newCategory = int.Parse(txt_itemcategory.Text);
                    var newWidth = decimal.Parse(txt_itemwidth.Text);
                    var newHeight = decimal.Parse(txt_itemheight.Text);
                    var newDepth = decimal.Parse(txt_itemdepth.Text);
                    var newWeight = decimal.Parse(txt_itemweight.Text);
                    var newTags = txt_itemtags.Text;

                    NewItem = new Models.Item(newTitle, newPrice, newInStock, newCategory, newWidth, newHeight, newDepth, newWeight, newTags);

                    ItemsService.CreateItem(NewItem);
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Udfyld venligst felterne korrekt", "Fejl");
                }
            }
        }
        */

        public void SaveCreatedItem()
        {
            string newTitle = txt_itemname.Text;
            if (String.IsNullOrEmpty(newTitle))
            {
                MessageBox.Show("Varenavn skal udfyldes", "Fejl");
                return;
            }

            if (!((decimal.TryParse(txt_itemprice.Text, out decimal newPrice) && newPrice >= 0) &&
               (decimal.TryParse(txt_itemwidth.Text, out decimal newWidth) && newWidth >= 0) &&
               (decimal.TryParse(txt_itemheight.Text, out decimal newHeight) && newHeight >= 0) &&
               (decimal.TryParse(txt_itemdepth.Text, out decimal newDepth) && newDepth >= 0) &&
               (decimal.TryParse(txt_itemweight.Text, out decimal newWeight) && newWeight >= 0) &&
               (int.TryParse(txt_iteminstock.Text, out int newInStock) && newInStock >= 0) &&
               (int.TryParse(txt_itemcategory.Text, out int newCategory) && newCategory > 0)))
            {
                MessageBox.Show("Felterne skal indeholde tal", "Fejl");
                return;
            }

            string newTags = txt_itemtags.Text;

            NewItem = new Models.Item(newTitle, newPrice, newInStock, newCategory, newWidth, newHeight, newDepth, newWeight, newTags);

            ItemsService.CreateItem(NewItem);
            this.Close();
        }
    }
}
