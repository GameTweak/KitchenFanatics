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
        //Written by Johanne 

        public FormSelector()
        {
            InitializeComponent();
        }

        private void FormSelector_Load(object sender, EventArgs e)
        {
            //when the program is started, the login form will show 
            ShowLoginBox(); 
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            //a new instance of the CustomerOverview form is created
            CustomerOverview customerOverviewForm = new CustomerOverview();
            //the form is opened
            customerOverviewForm.ShowDialog(); 
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            //a new instance of the ItemOverview form is created
            ItemOverview itemOverviewForm = new ItemOverview();
            //the form is opened
            itemOverviewForm.ShowDialog(); 
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            //a new instance of the SalesModule form is created
            SalesModule saleModuleForm = new SalesModule();
            //the form is opened
            saleModuleForm.ShowDialog(); 
        }

        private void btn_intelligentcounselling_Click(object sender, EventArgs e)
        {
            //a new instance of the Intellectual_Counceiling form is created
            Intellectual_Counceling intellectualCounceilingForm = new Intellectual_Counceling();
            //the form is opened
            intellectualCounceilingForm.ShowDialog(); 
        }

        public void ShowLoginBox()
        {
            Login loginForm = new Login();
            var loginResult = loginForm.ShowDialog(); 
            if(loginResult != DialogResult.OK)
            {
                Application.Exit(); 
            }
        }

        private void btn_IntelligentCouncel_Click(object sender, EventArgs e)
        {
            ItemOverviewIntCou itemOverviewIntCou = new ItemOverviewIntCou();
            itemOverviewIntCou.ShowDialog();
        }
    }
}
