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
    public partial class Login : Form

        //Written by Johanne
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //the forms dialogresult is set to None when the form loads
            DialogResult = DialogResult.None;
            //the content of the lb_wrong label is set to empty
            lb_wrong.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //checks if the DoLogin (which returns a bool) is true 
            if (DoLogin())
            {
                //the form's dialogresult is set to OK  
                DialogResult = DialogResult.OK;
                //the Login form is closed
                this.Close();
            }
            //if the DoLogin is false
            else
            {
                //the user is informaed that either the username or password is wrong
                lb_wrong.Text = "Forkert brugernavn eller kodeord"; 
            }
        }

        /// <summary>
        /// Checks whether the login information in the textboxes is correct
        /// </summary>
        /// <returns></returns>
        public bool DoLogin()
        {
            //the standard value of the method is set to false
            bool result = false; 

            //checks if the password and username matches those created in Properties
            if(txt_username.Text == Properties.Resources.Username && txt_password.Text == Properties.Resources.Password)
            {
                //if true the value of the method is set to true
                result = true; 
            }
            //the method returns the result which is either true or false
            return result; 
        }
    }
}
