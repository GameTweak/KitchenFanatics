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
        public Models.Item SelectedItem { get; set; }
        public Services.ItemService ItemsService { get; set; }

        public ItemUpdate(Models.Item item)
        {
            InitializeComponent();
            SelectedItem = item;
            ItemsService = new Services.ItemService(); 
        }

        private void ItemUpdate_Load(object sender, EventArgs e)
        {
            LoadItemData(); 
        }

        private void btn_saveitem_Click(object sender, EventArgs e)
        {
            UpdateItemData();
        }

        private void btn_deleteitem_Click(object sender, EventArgs e)
        {
            DeleteFromDatabase(); 
        }

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

        public void UpdateItemData()
        {
            try
            {
                SelectedItem.Title = txt_itemname.Text;
                SelectedItem.Tags = txt_itemtags.Text;
                SelectedItem.Price = int.Parse(txt_itemprice.Text);
                SelectedItem.Width = int.Parse(txt_itemwidth.Text);
                SelectedItem.Height = int.Parse(txt_itemheight.Text);
                SelectedItem.Depth = int.Parse(txt_itemdepth.Text);
                SelectedItem.Weight = int.Parse(txt_itemweight.Text);
                SelectedItem.InStock = int.Parse(txt_iteminstock.Text);
                SelectedItem.ItemCategory = int.Parse(txt_itemcategory.Text);

                ItemsService.UpdateItem(SelectedItem);
                this.Close(); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Fejl: Forkert informationstype indtastet", "Fejl");
            }
        }

        public void DeleteFromDatabase()
        {
            var confirmationBox = MessageBox.Show("Er du sikker på du vil slette denne vare?","Slet vare", MessageBoxButtons.YesNo);
            
            if(confirmationBox == DialogResult.Yes)
            {
                ItemsService.DeleteItem(SelectedItem);
                this.Close();
            }
        }
    }
}
