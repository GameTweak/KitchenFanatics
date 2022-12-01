namespace KitchenFanatics.Forms
{
    partial class CreateCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerFirstName_lb = new System.Windows.Forms.Label();
            this.customerLastName_lb = new System.Windows.Forms.Label();
            this.customerCreateMail_lb = new System.Windows.Forms.Label();
            this.customerCreatePhoneNumber_lb = new System.Windows.Forms.Label();
            this.createCustomerFirstName_tb = new System.Windows.Forms.TextBox();
            this.createCustomerLastName_tb = new System.Windows.Forms.TextBox();
            this.createCustomerPhoneNumber_tb = new System.Windows.Forms.TextBox();
            this.createCustomerMail_tb = new System.Windows.Forms.TextBox();
            this.createCustomerAddress_tb = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.saveCustomer_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Missing_lb = new System.Windows.Forms.Label();
            this.MissingData_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerFirstName_lb
            // 
            this.customerFirstName_lb.AutoSize = true;
            this.customerFirstName_lb.Location = new System.Drawing.Point(12, 9);
            this.customerFirstName_lb.Name = "customerFirstName_lb";
            this.customerFirstName_lb.Size = new System.Drawing.Size(66, 16);
            this.customerFirstName_lb.TabIndex = 0;
            this.customerFirstName_lb.Text = "Firstname";
            // 
            // customerLastName_lb
            // 
            this.customerLastName_lb.AutoSize = true;
            this.customerLastName_lb.Location = new System.Drawing.Point(12, 67);
            this.customerLastName_lb.Name = "customerLastName_lb";
            this.customerLastName_lb.Size = new System.Drawing.Size(66, 16);
            this.customerLastName_lb.TabIndex = 1;
            this.customerLastName_lb.Text = "Lastname";
            // 
            // customerCreateMail_lb
            // 
            this.customerCreateMail_lb.AutoSize = true;
            this.customerCreateMail_lb.Location = new System.Drawing.Point(12, 132);
            this.customerCreateMail_lb.Name = "customerCreateMail_lb";
            this.customerCreateMail_lb.Size = new System.Drawing.Size(32, 16);
            this.customerCreateMail_lb.TabIndex = 2;
            this.customerCreateMail_lb.Text = "Mail";
            // 
            // customerCreatePhoneNumber_lb
            // 
            this.customerCreatePhoneNumber_lb.AutoSize = true;
            this.customerCreatePhoneNumber_lb.Location = new System.Drawing.Point(12, 196);
            this.customerCreatePhoneNumber_lb.Name = "customerCreatePhoneNumber_lb";
            this.customerCreatePhoneNumber_lb.Size = new System.Drawing.Size(91, 16);
            this.customerCreatePhoneNumber_lb.TabIndex = 3;
            this.customerCreatePhoneNumber_lb.Text = "Phonenumber";
            // 
            // createCustomerFirstName_tb
            // 
            this.createCustomerFirstName_tb.Location = new System.Drawing.Point(15, 28);
            this.createCustomerFirstName_tb.Name = "createCustomerFirstName_tb";
            this.createCustomerFirstName_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerFirstName_tb.TabIndex = 4;
            // 
            // createCustomerLastName_tb
            // 
            this.createCustomerLastName_tb.Location = new System.Drawing.Point(15, 86);
            this.createCustomerLastName_tb.Name = "createCustomerLastName_tb";
            this.createCustomerLastName_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerLastName_tb.TabIndex = 5;
            // 
            // createCustomerPhoneNumber_tb
            // 
            this.createCustomerPhoneNumber_tb.Location = new System.Drawing.Point(12, 215);
            this.createCustomerPhoneNumber_tb.Name = "createCustomerPhoneNumber_tb";
            this.createCustomerPhoneNumber_tb.Size = new System.Drawing.Size(202, 22);
            this.createCustomerPhoneNumber_tb.TabIndex = 6;
            // 
            // createCustomerMail_tb
            // 
            this.createCustomerMail_tb.Location = new System.Drawing.Point(15, 151);
            this.createCustomerMail_tb.Name = "createCustomerMail_tb";
            this.createCustomerMail_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerMail_tb.TabIndex = 7;
            // 
            // createCustomerAddress_tb
            // 
            this.createCustomerAddress_tb.Location = new System.Drawing.Point(12, 283);
            this.createCustomerAddress_tb.Name = "createCustomerAddress_tb";
            this.createCustomerAddress_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerAddress_tb.TabIndex = 8;
            this.createCustomerAddress_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.createCustomerPhoneNumber_tb_KeyPress);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(12, 264);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // saveCustomer_btn
            // 
            this.saveCustomer_btn.Location = new System.Drawing.Point(12, 387);
            this.saveCustomer_btn.Name = "saveCustomer_btn";
            this.saveCustomer_btn.Size = new System.Drawing.Size(151, 51);
            this.saveCustomer_btn.TabIndex = 10;
            this.saveCustomer_btn.Text = "Save Customer";
            this.saveCustomer_btn.UseVisualStyleBackColor = true;
            this.saveCustomer_btn.Click += new System.EventHandler(this.saveCustomer_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.Location = new System.Drawing.Point(175, 387);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(151, 51);
            this.Cancel_btn.TabIndex = 11;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Missing_lb
            // 
            this.Missing_lb.AutoSize = true;
            this.Missing_lb.Location = new System.Drawing.Point(12, 312);
            this.Missing_lb.Name = "Missing_lb";
            this.Missing_lb.Size = new System.Drawing.Size(174, 16);
            this.Missing_lb.TabIndex = 12;
            this.Missing_lb.Text = "The following data is invalid:";
            this.Missing_lb.Visible = false;
            // 
            // MissingData_lb
            // 
            this.MissingData_lb.AutoSize = true;
            this.MissingData_lb.Location = new System.Drawing.Point(12, 337);
            this.MissingData_lb.Name = "MissingData_lb";
            this.MissingData_lb.Size = new System.Drawing.Size(80, 16);
            this.MissingData_lb.TabIndex = 13;
            this.MissingData_lb.Text = "Placeholder";
            this.MissingData_lb.Visible = false;
            // 
            // CreateCustomer
            // 
            this.AcceptButton = this.saveCustomer_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_btn;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.MissingData_lb);
            this.Controls.Add(this.Missing_lb);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.saveCustomer_btn);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.createCustomerAddress_tb);
            this.Controls.Add(this.createCustomerMail_tb);
            this.Controls.Add(this.createCustomerPhoneNumber_tb);
            this.Controls.Add(this.createCustomerLastName_tb);
            this.Controls.Add(this.createCustomerFirstName_tb);
            this.Controls.Add(this.customerCreatePhoneNumber_lb);
            this.Controls.Add(this.customerCreateMail_lb);
            this.Controls.Add(this.customerLastName_lb);
            this.Controls.Add(this.customerFirstName_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateCustomer";
            this.Text = "CreateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerFirstName_lb;
        private System.Windows.Forms.Label customerLastName_lb;
        private System.Windows.Forms.Label customerCreateMail_lb;
        private System.Windows.Forms.Label customerCreatePhoneNumber_lb;
        private System.Windows.Forms.TextBox createCustomerFirstName_tb;
        private System.Windows.Forms.TextBox createCustomerLastName_tb;
        private System.Windows.Forms.TextBox createCustomerPhoneNumber_tb;
        private System.Windows.Forms.TextBox createCustomerMail_tb;
        private System.Windows.Forms.TextBox createCustomerAddress_tb;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button saveCustomer_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label Missing_lb;
        private System.Windows.Forms.Label MissingData_lb;
    }
}