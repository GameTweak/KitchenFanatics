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
    public partial class FormSelector : Form
    {
        public FormSelector()
        {
            InitializeComponent();
        }

        private void btn_CustomerOverview_Click(object sender, EventArgs e)
        {
            CustomerOverview customerOverview = new CustomerOverview();
            customerOverview.ShowDialog();
        }

        private void btn_CustomerCreate_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.ShowDialog();
        }

        private void btn_ItemOverview_Click(object sender, EventArgs e)
        {
            ItemOverview itemOverview = new ItemOverview();
            itemOverview.ShowDialog();
        }

        private void btn_ItemUpdateNCreate_Click(object sender, EventArgs e)
        {
            ItemUpdateAndCreate itemUpdateAndCreate = new ItemUpdateAndCreate();
            itemUpdateAndCreate.ShowDialog();
        }

        private void btn_SaleModule_Click(object sender, EventArgs e)
        {
            SalesModule salesModul = new SalesModule();
            salesModul.ShowDialog();
        }
    }
}
