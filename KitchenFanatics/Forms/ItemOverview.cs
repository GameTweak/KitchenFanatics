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
        public List<Models.Item> AllItems { get; set; }

        public ItemOverview()
        {
            InitializeComponent(); 
        }

        private void ItemOverview_Load(object sender, EventArgs e)
        {
            LoadItemData();
        }

        private void btn_edititem_Click(object sender, EventArgs e)
        {
            OpenUpdateItem();
        }

        private void btn_createnewitem_Click(object sender, EventArgs e)
        {
            OpenCreateItem(); 
        }

        public void LoadItemData()
        {
            var itemsService = new Services.ItemService();
            AllItems = itemsService.GetAllItems();
            dgw_itemoverview.DataSource = AllItems; 
        }

        public void OpenUpdateItem()
        {
            Models.Item selectedItem = (Models.Item)dgw_itemoverview.SelectedRows[0].DataBoundItem;

            ItemUpdate ItemUpdateForm = new ItemUpdate(selectedItem);
            ItemUpdateForm.ShowDialog();
            LoadItemData(); 
        }

        public void OpenCreateItem()
        {
            ItemCreate ItemCreateForm = new ItemCreate();
            ItemCreateForm.ShowDialog();
            LoadItemData(); 
        }
    }
}
