namespace KitchenFanatics.Forms
{
    partial class CustomerOverview
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
            this.components = new System.ComponentModel.Container();
            this.customerFullName_lb = new System.Windows.Forms.Label();
            this.customerOverview_dgv = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitchenFanaticDataSet = new KitchenFanatics.KitchenFanaticDataSet();
            this.customerTableAdapter = new KitchenFanatics.KitchenFanaticDataSetTableAdapters.CustomerTableAdapter();
            this.createCustomer = new System.Windows.Forms.Button();
            this.customerMail_lb = new System.Windows.Forms.Label();
            this.customerPhoneNumber_lb = new System.Windows.Forms.Label();
            this.customerAddress_lb = new System.Windows.Forms.Label();
            this.customerFullName_tb = new System.Windows.Forms.TextBox();
            this.customerMail_tb = new System.Windows.Forms.TextBox();
            this.customerPhoneNumber_tb = new System.Windows.Forms.TextBox();
            this.customerAddress_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerOverview_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customerFullName_lb
            // 
            this.customerFullName_lb.AutoSize = true;
            this.customerFullName_lb.Location = new System.Drawing.Point(12, 18);
            this.customerFullName_lb.Name = "customerFullName_lb";
            this.customerFullName_lb.Size = new System.Drawing.Size(44, 16);
            this.customerFullName_lb.TabIndex = 0;
            this.customerFullName_lb.Text = "Name";
            // 
            // customerOverview_dgv
            // 
            this.customerOverview_dgv.AutoGenerateColumns = false;
            this.customerOverview_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOverview_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.customerOverview_dgv.DataSource = this.customerBindingSource;
            this.customerOverview_dgv.Location = new System.Drawing.Point(12, 89);
            this.customerOverview_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerOverview_dgv.MultiSelect = false;
            this.customerOverview_dgv.Name = "customerOverview_dgv";
            this.customerOverview_dgv.RowHeadersWidth = 51;
            this.customerOverview_dgv.RowTemplate.Height = 24;
            this.customerOverview_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerOverview_dgv.Size = new System.Drawing.Size(1039, 281);
            this.customerOverview_dgv.TabIndex = 1;
            this.customerOverview_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerOverview_dgv_CellDoubleClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.kitchenFanaticDataSet;
            // 
            // kitchenFanaticDataSet
            // 
            this.kitchenFanaticDataSet.DataSetName = "KitchenFanaticDataSet";
            this.kitchenFanaticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // createCustomer
            // 
            this.createCustomer.Location = new System.Drawing.Point(873, 384);
            this.createCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new System.Drawing.Size(177, 60);
            this.createCustomer.TabIndex = 2;
            this.createCustomer.Text = "Create Customer";
            this.createCustomer.UseVisualStyleBackColor = true;
            this.createCustomer.Click += new System.EventHandler(this.createCustomer_Click);
            // 
            // customerMail_lb
            // 
            this.customerMail_lb.AutoSize = true;
            this.customerMail_lb.Location = new System.Drawing.Point(211, 18);
            this.customerMail_lb.Name = "customerMail_lb";
            this.customerMail_lb.Size = new System.Drawing.Size(32, 16);
            this.customerMail_lb.TabIndex = 3;
            this.customerMail_lb.Text = "Mail";
            // 
            // customerPhoneNumber_lb
            // 
            this.customerPhoneNumber_lb.AutoSize = true;
            this.customerPhoneNumber_lb.Location = new System.Drawing.Point(439, 18);
            this.customerPhoneNumber_lb.Name = "customerPhoneNumber_lb";
            this.customerPhoneNumber_lb.Size = new System.Drawing.Size(104, 16);
            this.customerPhoneNumber_lb.TabIndex = 4;
            this.customerPhoneNumber_lb.Text = "TelefonNummer";
            // 
            // customerAddress_lb
            // 
            this.customerAddress_lb.AutoSize = true;
            this.customerAddress_lb.Location = new System.Drawing.Point(572, 20);
            this.customerAddress_lb.Name = "customerAddress_lb";
            this.customerAddress_lb.Size = new System.Drawing.Size(58, 16);
            this.customerAddress_lb.TabIndex = 5;
            this.customerAddress_lb.Text = "Address";
            // 
            // customerFullName_tb
            // 
            this.customerFullName_tb.Location = new System.Drawing.Point(12, 39);
            this.customerFullName_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerFullName_tb.Name = "customerFullName_tb";
            this.customerFullName_tb.Size = new System.Drawing.Size(195, 22);
            this.customerFullName_tb.TabIndex = 6;
            // 
            // customerMail_tb
            // 
            this.customerMail_tb.Location = new System.Drawing.Point(213, 39);
            this.customerMail_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerMail_tb.Name = "customerMail_tb";
            this.customerMail_tb.Size = new System.Drawing.Size(223, 22);
            this.customerMail_tb.TabIndex = 7;
            // 
            // customerPhoneNumber_tb
            // 
            this.customerPhoneNumber_tb.Location = new System.Drawing.Point(443, 39);
            this.customerPhoneNumber_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerPhoneNumber_tb.Name = "customerPhoneNumber_tb";
            this.customerPhoneNumber_tb.Size = new System.Drawing.Size(101, 22);
            this.customerPhoneNumber_tb.TabIndex = 8;
            // 
            // customerAddress_tb
            // 
            this.customerAddress_tb.Location = new System.Drawing.Point(575, 39);
            this.customerAddress_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerAddress_tb.Name = "customerAddress_tb";
            this.customerAddress_tb.Size = new System.Drawing.Size(192, 22);
            this.customerAddress_tb.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sort CustomerID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SortCustomerId_BtnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sort Firstname";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SortCustomerFirstName_btnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 384);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sort Lastname";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SortCustomerLastName_btnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(397, 384);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 60);
            this.button4.TabIndex = 13;
            this.button4.Text = "Sort Address";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SortCustomerAddress_btnCLick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(519, 384);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 60);
            this.button5.TabIndex = 14;
            this.button5.Text = "Sort Email";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SortCustomerEmail_btnCLick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(640, 384);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 60);
            this.button6.TabIndex = 15;
            this.button6.Text = "Sort PhoneNumber";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SortCustomerPhoneNumber_btnCLick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(873, 21);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 60);
            this.button7.TabIndex = 16;
            this.button7.Text = "Filter Customers";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // CustomerOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerAddress_tb);
            this.Controls.Add(this.customerPhoneNumber_tb);
            this.Controls.Add(this.customerMail_tb);
            this.Controls.Add(this.customerFullName_tb);
            this.Controls.Add(this.customerAddress_lb);
            this.Controls.Add(this.customerPhoneNumber_lb);
            this.Controls.Add(this.customerMail_lb);
            this.Controls.Add(this.createCustomer);
            this.Controls.Add(this.customerOverview_dgv);
            this.Controls.Add(this.customerFullName_lb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOverview";
            ((System.ComponentModel.ISupportInitialize)(this.customerOverview_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerFullName_lb;
        private System.Windows.Forms.DataGridView customerOverview_dgv;
        private KitchenFanaticDataSet kitchenFanaticDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private KitchenFanaticDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button createCustomer;
        private System.Windows.Forms.Label customerMail_lb;
        private System.Windows.Forms.Label customerPhoneNumber_lb;
        private System.Windows.Forms.Label customerAddress_lb;
        private System.Windows.Forms.TextBox customerFullName_tb;
        private System.Windows.Forms.TextBox customerMail_tb;
        private System.Windows.Forms.TextBox customerPhoneNumber_tb;
        private System.Windows.Forms.TextBox customerAddress_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}