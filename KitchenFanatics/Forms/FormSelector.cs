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
            //call to a method, which will show a login box when the program starts 
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
            //a new instance of the ItemOverviewIntCou form is created
            ItemOverviewIntCou ItemOverviewIntCouForm = new ItemOverviewIntCou();
            //the form is opened
            ItemOverviewIntCouForm.ShowDialog();
        }

        /// <summary>
        /// Shows the Login form
        /// </summary>
        public void ShowLoginBox()
        {
            //a new instance of the Login form is created
            Login loginForm = new Login();
            //the form is opened
            var loginResult = loginForm.ShowDialog();

            //checks if the dialogresult of the login form is NOT ok
            if (loginResult != DialogResult.OK)
            {
                //if the dialogresult is NOT ok the application will close 
                //this prevents the user from using the program without logging in 
                Application.Exit();
            }
        }
    }
}
