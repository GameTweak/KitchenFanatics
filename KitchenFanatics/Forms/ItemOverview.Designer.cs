
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgw_itemoverview = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDepthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_itemoverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1141, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rediger vare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1001, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Opret ny vare";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgw_itemoverview
            // 
            this.dgw_itemoverview.AllowUserToAddRows = false;
            this.dgw_itemoverview.AllowUserToDeleteRows = false;
            this.dgw_itemoverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_itemoverview.AutoGenerateColumns = false;
            this.dgw_itemoverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_itemoverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNRDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemStockDataGridViewTextBoxColumn,
            this.itemCategoryDataGridViewTextBoxColumn,
            this.itemWidthDataGridViewTextBoxColumn,
            this.itemHeightDataGridViewTextBoxColumn,
            this.itemDepthDataGridViewTextBoxColumn,
            this.itemWeightDataGridViewTextBoxColumn,
            this.itemTagsDataGridViewTextBoxColumn});
            this.dgw_itemoverview.DataSource = this.productBindingSource;
            this.dgw_itemoverview.Location = new System.Drawing.Point(21, 40);
            this.dgw_itemoverview.MultiSelect = false;
            this.dgw_itemoverview.Name = "dgw_itemoverview";
            this.dgw_itemoverview.ReadOnly = true;
            this.dgw_itemoverview.RowHeadersVisible = false;
            this.dgw_itemoverview.RowHeadersWidth = 51;
            this.dgw_itemoverview.RowTemplate.Height = 24;
            this.dgw_itemoverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_itemoverview.Size = new System.Drawing.Size(1254, 446);
            this.dgw_itemoverview.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(21, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Udskriv alle varer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(KitchenFanatics.Database.Product);
            // 
            // itemNRDataGridViewTextBoxColumn
            // 
            this.itemNRDataGridViewTextBoxColumn.DataPropertyName = "ItemNR";
            this.itemNRDataGridViewTextBoxColumn.HeaderText = "Varenummer";
            this.itemNRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNRDataGridViewTextBoxColumn.Name = "itemNRDataGridViewTextBoxColumn";
            this.itemNRDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNRDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Varenavn";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.itemPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemStockDataGridViewTextBoxColumn
            // 
            this.itemStockDataGridViewTextBoxColumn.DataPropertyName = "ItemStock";
            this.itemStockDataGridViewTextBoxColumn.HeaderText = "På lager";
            this.itemStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemStockDataGridViewTextBoxColumn.Name = "itemStockDataGridViewTextBoxColumn";
            this.itemStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemCategoryDataGridViewTextBoxColumn
            // 
            this.itemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory";
            this.itemCategoryDataGridViewTextBoxColumn.HeaderText = "Varekategori";
            this.itemCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCategoryDataGridViewTextBoxColumn.Name = "itemCategoryDataGridViewTextBoxColumn";
            this.itemCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemWidthDataGridViewTextBoxColumn
            // 
            this.itemWidthDataGridViewTextBoxColumn.DataPropertyName = "ItemWidth";
            this.itemWidthDataGridViewTextBoxColumn.HeaderText = "Bredde";
            this.itemWidthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemWidthDataGridViewTextBoxColumn.Name = "itemWidthDataGridViewTextBoxColumn";
            this.itemWidthDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemWidthDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemHeightDataGridViewTextBoxColumn
            // 
            this.itemHeightDataGridViewTextBoxColumn.DataPropertyName = "ItemHeight";
            this.itemHeightDataGridViewTextBoxColumn.HeaderText = "Højde";
            this.itemHeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemHeightDataGridViewTextBoxColumn.Name = "itemHeightDataGridViewTextBoxColumn";
            this.itemHeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemHeightDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDepthDataGridViewTextBoxColumn
            // 
            this.itemDepthDataGridViewTextBoxColumn.DataPropertyName = "ItemDepth";
            this.itemDepthDataGridViewTextBoxColumn.HeaderText = "Dybde";
            this.itemDepthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDepthDataGridViewTextBoxColumn.Name = "itemDepthDataGridViewTextBoxColumn";
            this.itemDepthDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDepthDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemWeightDataGridViewTextBoxColumn
            // 
            this.itemWeightDataGridViewTextBoxColumn.DataPropertyName = "ItemWeight";
            this.itemWeightDataGridViewTextBoxColumn.HeaderText = "Vægt";
            this.itemWeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemWeightDataGridViewTextBoxColumn.Name = "itemWeightDataGridViewTextBoxColumn";
            this.itemWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemWeightDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemTagsDataGridViewTextBoxColumn
            // 
            this.itemTagsDataGridViewTextBoxColumn.DataPropertyName = "ItemTags";
            this.itemTagsDataGridViewTextBoxColumn.HeaderText = "Tags";
            this.itemTagsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemTagsDataGridViewTextBoxColumn.Name = "itemTagsDataGridViewTextBoxColumn";
            this.itemTagsDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTagsDataGridViewTextBoxColumn.Width = 125;
            // 
            // ItemOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 570);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgw_itemoverview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ItemOverview";
            this.Text = "Vareoversigt";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_itemoverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView dgw_itemoverview;
    }
}