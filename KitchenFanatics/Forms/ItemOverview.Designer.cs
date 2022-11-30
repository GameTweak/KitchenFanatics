
namespace KitchenFanatics.Forms
{
    partial class ItemOverview
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
            this.btn_edititem = new System.Windows.Forms.Button();
            this.btn_createnewitem = new System.Windows.Forms.Button();
            this.dgw_itemoverview = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_printitems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sortby = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_itemoverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edititem
            // 
            this.btn_edititem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edititem.Location = new System.Drawing.Point(817, 511);
            this.btn_edititem.Name = "btn_edititem";
            this.btn_edititem.Size = new System.Drawing.Size(134, 39);
            this.btn_edititem.TabIndex = 0;
            this.btn_edititem.Text = "Rediger vare";
            this.btn_edititem.UseVisualStyleBackColor = true;
            this.btn_edititem.Click += new System.EventHandler(this.btn_edititem_Click);
            // 
            // btn_createnewitem
            // 
            this.btn_createnewitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createnewitem.Location = new System.Drawing.Point(677, 511);
            this.btn_createnewitem.Name = "btn_createnewitem";
            this.btn_createnewitem.Size = new System.Drawing.Size(134, 39);
            this.btn_createnewitem.TabIndex = 1;
            this.btn_createnewitem.Text = "Opret ny vare";
            this.btn_createnewitem.UseVisualStyleBackColor = true;
            this.btn_createnewitem.Click += new System.EventHandler(this.btn_createnewitem_Click);
            // 
            // dgw_itemoverview
            // 
            this.dgw_itemoverview.AllowUserToAddRows = false;
            this.dgw_itemoverview.AllowUserToDeleteRows = false;
            this.dgw_itemoverview.AllowUserToResizeColumns = false;
            this.dgw_itemoverview.AllowUserToResizeRows = false;
            this.dgw_itemoverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_itemoverview.AutoGenerateColumns = false;
            this.dgw_itemoverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw_itemoverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_itemoverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.itemCategoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.tagsDataGridViewTextBoxColumn});
            this.dgw_itemoverview.DataSource = this.itemBindingSource;
            this.dgw_itemoverview.Location = new System.Drawing.Point(21, 54);
            this.dgw_itemoverview.MultiSelect = false;
            this.dgw_itemoverview.Name = "dgw_itemoverview";
            this.dgw_itemoverview.ReadOnly = true;
            this.dgw_itemoverview.RowHeadersVisible = false;
            this.dgw_itemoverview.RowHeadersWidth = 51;
            this.dgw_itemoverview.RowTemplate.Height = 24;
            this.dgw_itemoverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_itemoverview.Size = new System.Drawing.Size(930, 438);
            this.dgw_itemoverview.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Varenummer";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 118;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Varenavn";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 98;
            // 
            // itemCategoryDataGridViewTextBoxColumn
            // 
            this.itemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory";
            this.itemCategoryDataGridViewTextBoxColumn.HeaderText = "Varekategori";
            this.itemCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCategoryDataGridViewTextBoxColumn.Name = "itemCategoryDataGridViewTextBoxColumn";
            this.itemCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCategoryDataGridViewTextBoxColumn.Width = 118;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 61;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "På lager";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            this.inStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.inStockDataGridViewTextBoxColumn.Width = 90;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Bredde";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 83;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Højde";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Width = 74;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "Dybde";
            this.depthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            this.depthDataGridViewTextBoxColumn.Width = 78;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Vægt";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 71;
            // 
            // tagsDataGridViewTextBoxColumn
            // 
            this.tagsDataGridViewTextBoxColumn.DataPropertyName = "Tags";
            this.tagsDataGridViewTextBoxColumn.HeaderText = "Tags";
            this.tagsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tagsDataGridViewTextBoxColumn.Name = "tagsDataGridViewTextBoxColumn";
            this.tagsDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagsDataGridViewTextBoxColumn.Width = 69;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(KitchenFanatics.Models.Item);
            // 
            // btn_printitems
            // 
            this.btn_printitems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_printitems.Location = new System.Drawing.Point(21, 512);
            this.btn_printitems.Name = "btn_printitems";
            this.btn_printitems.Size = new System.Drawing.Size(134, 38);
            this.btn_printitems.TabIndex = 3;
            this.btn_printitems.Text = "Udskriv alle varer";
            this.btn_printitems.UseVisualStyleBackColor = true;
            this.btn_printitems.Click += new System.EventHandler(this.btn_printitems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sorter efter:";
            // 
            // cb_sortby
            // 
            this.cb_sortby.AccessibleDescription = "";
            this.cb_sortby.AccessibleName = "";
            this.cb_sortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sortby.FormattingEnabled = true;
            this.cb_sortby.Items.AddRange(new object[] {
            "Standard",
            "Pris - Lav til høj",
            "Pris - Høj til lav",
            "Varenavn - a-å",
            "Varenavn - å-a"});
            this.cb_sortby.Location = new System.Drawing.Point(108, 13);
            this.cb_sortby.Name = "cb_sortby";
            this.cb_sortby.Size = new System.Drawing.Size(178, 24);
            this.cb_sortby.TabIndex = 9;
            this.cb_sortby.SelectedIndexChanged += new System.EventHandler(this.cb_sortby_SelectedIndexChanged);
            // 
            // ItemOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 570);
            this.Controls.Add(this.cb_sortby);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_printitems);
            this.Controls.Add(this.dgw_itemoverview);
            this.Controls.Add(this.btn_createnewitem);
            this.Controls.Add(this.btn_edititem);
            this.Name = "ItemOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vareoversigt";
            this.Load += new System.EventHandler(this.ItemOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_itemoverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edititem;
        private System.Windows.Forms.Button btn_createnewitem;
        private System.Windows.Forms.Button btn_printitems;
        private System.Windows.Forms.DataGridView dgw_itemoverview;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sortby;
    }
}