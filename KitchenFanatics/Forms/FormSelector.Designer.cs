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
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_item = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_intelligentcounselling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(96, 174);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(207, 69);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Text = "Kunder";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_item
            // 
            this.btn_item.Location = new System.Drawing.Point(350, 174);
            this.btn_item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(207, 69);
            this.btn_item.TabIndex = 2;
            this.btn_item.Text = "Varer";
            this.btn_item.UseVisualStyleBackColor = true;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.Location = new System.Drawing.Point(602, 174);
            this.btn_sale.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(207, 69);
            this.btn_sale.TabIndex = 4;
            this.btn_sale.Text = "Salg";
            this.btn_sale.UseVisualStyleBackColor = true;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // btn_intelligentcounselling
            // 

            this.btn_intelligentcounselling.Location = new System.Drawing.Point(350, 276);
            this.btn_intelligentcounselling.Name = "btn_intelligentcounselling";
            this.btn_intelligentcounselling.Size = new System.Drawing.Size(207, 69);
            this.btn_intelligentcounselling.TabIndex = 5;
            this.btn_intelligentcounselling.Text = "Intelligent rådgivning";
            this.btn_intelligentcounselling.UseVisualStyleBackColor = true;
            this.btn_intelligentcounselling.Click += new System.EventHandler(this.btn_intelligentcounselling_Click);

            // 
            // label1
            // 

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "KøkkenFanatikeren";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // FormSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(904, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_intelligentcounselling);
            this.Controls.Add(this.btn_sale);
            this.Controls.Add(this.btn_item);
            this.Controls.Add(this.btn_customer);
            this.Margin = new System.Windows.Forms.Padding(4);

            this.Name = "FormSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KøkkenFanatikeren";
            this.Load += new System.EventHandler(this.FormSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Button btn_intelligentcounselling;
        private System.Windows.Forms.Label label1;

    }
}