namespace KitchenFanatics.Forms
{
    partial class SalesModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_SaleHistories = new System.Windows.Forms.DataGridView();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kitchenFanaticDataSet = new KitchenFanatics.KitchenFanaticDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new KitchenFanatics.KitchenFanaticDataSetTableAdapters.CustomerTableAdapter();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_EditSale = new System.Windows.Forms.Button();
            this.btn_PrintData = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleHistories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales History Overview";
            // 
            // DGV_SaleHistories
            // 
            this.DGV_SaleHistories.AllowUserToAddRows = false;
            this.DGV_SaleHistories.AllowUserToDeleteRows = false;
            this.DGV_SaleHistories.AllowUserToResizeColumns = false;
            this.DGV_SaleHistories.AllowUserToResizeRows = false;
            this.DGV_SaleHistories.AutoGenerateColumns = false;
            this.DGV_SaleHistories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SaleHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SaleHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.saleStatusDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.DGV_SaleHistories.DataSource = this.saleHistoryBindingSource;
            this.DGV_SaleHistories.Location = new System.Drawing.Point(11, 124);
            this.DGV_SaleHistories.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_SaleHistories.MultiSelect = false;
            this.DGV_SaleHistories.Name = "DGV_SaleHistories";
            this.DGV_SaleHistories.ReadOnly = true;
            this.DGV_SaleHistories.RowHeadersVisible = false;
            this.DGV_SaleHistories.RowHeadersWidth = 51;
            this.DGV_SaleHistories.RowTemplate.Height = 24;
            this.DGV_SaleHistories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SaleHistories.Size = new System.Drawing.Size(688, 248);
            this.DGV_SaleHistories.TabIndex = 1;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(383, 56);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(180, 21);
            this.tb_Phone.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(569, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickToFilter);
            // 
            // dtp_End
            // 
            this.dtp_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_End.Location = new System.Drawing.Point(292, 98);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(271, 21);
            this.dtp_End.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Slut Dato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kunde navn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefon Nummer";
            // 
            // kitchenFanaticDataSet
            // 
            this.kitchenFanaticDataSet.DataSetName = "KitchenFanaticDataSet";
            this.kitchenFanaticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.kitchenFanaticDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(197, 56);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(180, 21);
            this.tb_Email.TabIndex = 15;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(11, 56);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(180, 21);
            this.tb_Name.TabIndex = 16;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Start.Location = new System.Drawing.Point(11, 98);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(271, 21);
            this.dtp_Start.TabIndex = 17;
            this.dtp_Start.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(592, 379);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Slet Salg";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.DeleteEntry);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(481, 379);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(107, 31);
            this.btn_Create.TabIndex = 19;
            this.btn_Create.Text = "Opret Salg";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.CreateSale);
            // 
            // btn_EditSale
            // 
            this.btn_EditSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditSale.Location = new System.Drawing.Point(370, 379);
            this.btn_EditSale.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditSale.Name = "btn_EditSale";
            this.btn_EditSale.Size = new System.Drawing.Size(107, 31);
            this.btn_EditSale.TabIndex = 20;
            this.btn_EditSale.Text = "Redigere Salg";
            this.btn_EditSale.UseVisualStyleBackColor = true;
            this.btn_EditSale.Click += new System.EventHandler(this.EditSale);
            // 
            // btn_PrintData
            // 
            this.btn_PrintData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintData.Location = new System.Drawing.Point(259, 379);
            this.btn_PrintData.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrintData.Name = "btn_PrintData";
            this.btn_PrintData.Size = new System.Drawing.Size(107, 31);
            this.btn_PrintData.TabIndex = 21;
            this.btn_PrintData.Text = "Udskriv Data";
            this.btn_PrintData.UseVisualStyleBackColor = true;
            this.btn_PrintData.Click += new System.EventHandler(this.PrintData);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Købsdato";
            this.saleDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Pris";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "Leveringsaddresse";
            this.deliveryAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleStatusDataGridViewTextBoxColumn
            // 
            this.saleStatusDataGridViewTextBoxColumn.DataPropertyName = "SaleStatus";
            this.saleStatusDataGridViewTextBoxColumn.HeaderText = "Køb Status";
            this.saleStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleStatusDataGridViewTextBoxColumn.Name = "saleStatusDataGridViewTextBoxColumn";
            this.saleStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Kunde";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleHistoryBindingSource
            // 
            this.saleHistoryBindingSource.DataSource = typeof(KitchenFanatics.Models.SaleHistory);
            // 
            // SalesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 421);
            this.Controls.Add(this.btn_PrintData);
            this.Controls.Add(this.btn_EditSale);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.DGV_SaleHistories);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(726, 460);
            this.MinimumSize = new System.Drawing.Size(726, 460);
            this.Name = "SalesModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesModul";
            this.Load += new System.EventHandler(this.SalesModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SaleHistories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenFanaticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_SaleHistories;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private KitchenFanaticDataSet kitchenFanaticDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private KitchenFanaticDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource saleHistoryBindingSource;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_EditSale;
        private System.Windows.Forms.Button btn_PrintData;
    }
}