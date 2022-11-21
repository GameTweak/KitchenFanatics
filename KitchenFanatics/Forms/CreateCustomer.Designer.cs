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
            this.SuspendLayout();
            // 
            // customerFirstName_lb
            // 
            this.customerFirstName_lb.AutoSize = true;
            this.customerFirstName_lb.Location = new System.Drawing.Point(13, 13);
            this.customerFirstName_lb.Name = "customerFirstName_lb";
            this.customerFirstName_lb.Size = new System.Drawing.Size(66, 16);
            this.customerFirstName_lb.TabIndex = 0;
            this.customerFirstName_lb.Text = "Firstname";
            // 
            // customerLastName_lb
            // 
            this.customerLastName_lb.AutoSize = true;
            this.customerLastName_lb.Location = new System.Drawing.Point(287, 13);
            this.customerLastName_lb.Name = "customerLastName_lb";
            this.customerLastName_lb.Size = new System.Drawing.Size(66, 16);
            this.customerLastName_lb.TabIndex = 1;
            this.customerLastName_lb.Text = "Lastname";
            // 
            // customerCreateMail_lb
            // 
            this.customerCreateMail_lb.AutoSize = true;
            this.customerCreateMail_lb.Location = new System.Drawing.Point(12, 104);
            this.customerCreateMail_lb.Name = "customerCreateMail_lb";
            this.customerCreateMail_lb.Size = new System.Drawing.Size(32, 16);
            this.customerCreateMail_lb.TabIndex = 2;
            this.customerCreateMail_lb.Text = "Mail";
            // 
            // customerCreatePhoneNumber_lb
            // 
            this.customerCreatePhoneNumber_lb.AutoSize = true;
            this.customerCreatePhoneNumber_lb.Location = new System.Drawing.Point(587, 13);
            this.customerCreatePhoneNumber_lb.Name = "customerCreatePhoneNumber_lb";
            this.customerCreatePhoneNumber_lb.Size = new System.Drawing.Size(91, 16);
            this.customerCreatePhoneNumber_lb.TabIndex = 3;
            this.customerCreatePhoneNumber_lb.Text = "Phonenumber";
            // 
            // createCustomerFirstName_tb
            // 
            this.createCustomerFirstName_tb.Location = new System.Drawing.Point(12, 32);
            this.createCustomerFirstName_tb.Name = "createCustomerFirstName_tb";
            this.createCustomerFirstName_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerFirstName_tb.TabIndex = 4;
            // 
            // createCustomerLastName_tb
            // 
            this.createCustomerLastName_tb.Location = new System.Drawing.Point(290, 32);
            this.createCustomerLastName_tb.Name = "createCustomerLastName_tb";
            this.createCustomerLastName_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerLastName_tb.TabIndex = 5;
            // 
            // createCustomerPhoneNumber_tb
            // 
            this.createCustomerPhoneNumber_tb.Location = new System.Drawing.Point(590, 32);
            this.createCustomerPhoneNumber_tb.Name = "createCustomerPhoneNumber_tb";
            this.createCustomerPhoneNumber_tb.Size = new System.Drawing.Size(161, 22);
            this.createCustomerPhoneNumber_tb.TabIndex = 6;
            // 
            // createCustomerMail_tb
            // 
            this.createCustomerMail_tb.Location = new System.Drawing.Point(12, 132);
            this.createCustomerMail_tb.Name = "createCustomerMail_tb";
            this.createCustomerMail_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerMail_tb.TabIndex = 7;
            // 
            // createCustomerAddress_tb
            // 
            this.createCustomerAddress_tb.Location = new System.Drawing.Point(290, 132);
            this.createCustomerAddress_tb.Name = "createCustomerAddress_tb";
            this.createCustomerAddress_tb.Size = new System.Drawing.Size(205, 22);
            this.createCustomerAddress_tb.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(287, 113);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // saveCustomer_btn
            // 
            this.saveCustomer_btn.Location = new System.Drawing.Point(602, 409);
            this.saveCustomer_btn.Name = "saveCustomer_btn";
            this.saveCustomer_btn.Size = new System.Drawing.Size(129, 23);
            this.saveCustomer_btn.TabIndex = 10;
            this.saveCustomer_btn.Text = "Save Customer";
            this.saveCustomer_btn.UseVisualStyleBackColor = true;
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}