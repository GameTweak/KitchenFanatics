﻿using KitchenFanatics.Models;
using KitchenFanatics.Services;
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
    public partial class SalesModule : Form
    {

        private SaleService saleService = new SaleService();
        private List<SaleHistory> history { get; set; }


        public SalesModule()
        {
            InitializeComponent();
        }

        private void SalesModul_Load(object sender, EventArgs e)
        {
            history = saleService.GetSaleHistories();

            DGV_SaleHistories.DataSource = history;
        }

        private void DeleteEntry(object sender, EventArgs e)
        {
            saleService.DeleteEntry((SaleHistory) DGV_SaleHistories.CurrentRow.DataBoundItem);
            DGV_SaleHistories.Rows.Remove(DGV_SaleHistories.CurrentRow);
            MessageBox.Show($"Deleted");
        }
    }
}
