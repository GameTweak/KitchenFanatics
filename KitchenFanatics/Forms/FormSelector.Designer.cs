namespace KitchenFanatics.Forms
{
    partial class FormSelector
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
            this.btn_CustomerOverview = new System.Windows.Forms.Button();
            this.btn_CustomerCreate = new System.Windows.Forms.Button();
            this.btn_ItemOverview = new System.Windows.Forms.Button();
            this.btn_ItemUpdateNCreate = new System.Windows.Forms.Button();
            this.btn_SaleModule = new System.Windows.Forms.Button();
            this.btn_IntelligentCouncel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CustomerOverview
            // 
            this.btn_CustomerOverview.Location = new System.Drawing.Point(16, 37);
            this.btn_CustomerOverview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CustomerOverview.Name = "btn_CustomerOverview";
            this.btn_CustomerOverview.Size = new System.Drawing.Size(207, 69);
            this.btn_CustomerOverview.TabIndex = 0;
            this.btn_CustomerOverview.Text = "Åben Customer Overview";
            this.btn_CustomerOverview.UseVisualStyleBackColor = true;
            this.btn_CustomerOverview.Click += new System.EventHandler(this.btn_CustomerOverview_Click);
            // 
            // btn_CustomerCreate
            // 
            this.btn_CustomerCreate.Location = new System.Drawing.Point(16, 113);
            this.btn_CustomerCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CustomerCreate.Name = "btn_CustomerCreate";
            this.btn_CustomerCreate.Size = new System.Drawing.Size(207, 69);
            this.btn_CustomerCreate.TabIndex = 1;
            this.btn_CustomerCreate.Text = "Åben Customer Create";
            this.btn_CustomerCreate.UseVisualStyleBackColor = true;
            this.btn_CustomerCreate.Click += new System.EventHandler(this.btn_CustomerCreate_Click);
            // 
            // btn_ItemOverview
            // 
            this.btn_ItemOverview.Location = new System.Drawing.Point(16, 190);
            this.btn_ItemOverview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ItemOverview.Name = "btn_ItemOverview";
            this.btn_ItemOverview.Size = new System.Drawing.Size(207, 69);
            this.btn_ItemOverview.TabIndex = 2;
            this.btn_ItemOverview.Text = "Åben Item Overview";
            this.btn_ItemOverview.UseVisualStyleBackColor = true;
            this.btn_ItemOverview.Click += new System.EventHandler(this.btn_ItemOverview_Click);
            // 
            // btn_ItemUpdateNCreate
            // 
            this.btn_ItemUpdateNCreate.Location = new System.Drawing.Point(16, 266);
            this.btn_ItemUpdateNCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ItemUpdateNCreate.Name = "btn_ItemUpdateNCreate";
            this.btn_ItemUpdateNCreate.Size = new System.Drawing.Size(207, 69);
            this.btn_ItemUpdateNCreate.TabIndex = 3;
            this.btn_ItemUpdateNCreate.Text = "Åben Item Update and Create";
            this.btn_ItemUpdateNCreate.UseVisualStyleBackColor = true;
            // 
            // btn_SaleModule
            // 
            this.btn_SaleModule.Location = new System.Drawing.Point(16, 342);
            this.btn_SaleModule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SaleModule.Name = "btn_SaleModule";
            this.btn_SaleModule.Size = new System.Drawing.Size(207, 69);
            this.btn_SaleModule.TabIndex = 4;
            this.btn_SaleModule.Text = "Åben SaleModule";
            this.btn_SaleModule.UseVisualStyleBackColor = true;
            this.btn_SaleModule.Click += new System.EventHandler(this.btn_SaleModule_Click);
            // 
            // btn_IntelligentCouncel
            // 
            this.btn_IntelligentCouncel.Location = new System.Drawing.Point(16, 419);
            this.btn_IntelligentCouncel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_IntelligentCouncel.Name = "btn_IntelligentCouncel";
            this.btn_IntelligentCouncel.Size = new System.Drawing.Size(207, 69);
            this.btn_IntelligentCouncel.TabIndex = 5;
            this.btn_IntelligentCouncel.Text = "Åben Intelligent rådgivning";
            this.btn_IntelligentCouncel.UseVisualStyleBackColor = true;
            this.btn_IntelligentCouncel.Click += new System.EventHandler(this.btn_IntelligentCouncel_Click);
            // 
            // FormSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_IntelligentCouncel);
            this.Controls.Add(this.btn_SaleModule);
            this.Controls.Add(this.btn_ItemUpdateNCreate);
            this.Controls.Add(this.btn_ItemOverview);
            this.Controls.Add(this.btn_CustomerCreate);
            this.Controls.Add(this.btn_CustomerOverview);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CustomerOverview;
        private System.Windows.Forms.Button btn_CustomerCreate;
        private System.Windows.Forms.Button btn_ItemOverview;
        private System.Windows.Forms.Button btn_ItemUpdateNCreate;
        private System.Windows.Forms.Button btn_SaleModule;
        private System.Windows.Forms.Button btn_IntelligentCouncel;
    }
}