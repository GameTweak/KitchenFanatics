﻿namespace KitchenFanatics.Forms
{
    partial class Intellectual_Counceling
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
            this.lb_question = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_skip = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_number1 = new System.Windows.Forms.Label();
            this.lb_number2 = new System.Windows.Forms.Label();
            this.lb_number3 = new System.Windows.Forms.Label();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.txt_number2 = new System.Windows.Forms.TextBox();
            this.txt_number3 = new System.Windows.Forms.TextBox();
            this.txt_number6 = new System.Windows.Forms.TextBox();
            this.txt_number5 = new System.Windows.Forms.TextBox();
            this.txt_number4 = new System.Windows.Forms.TextBox();
            this.lb_number6 = new System.Windows.Forms.Label();
            this.lb_number5 = new System.Windows.Forms.Label();
            this.lb_number4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_question.Location = new System.Drawing.Point(12, 9);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(217, 25);
            this.lb_question.TabIndex = 0;
            this.lb_question.Text = "Question placeholder";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(12, 66);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(311, 160);
            this.txt_input.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_submit.Location = new System.Drawing.Point(12, 290);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(92, 54);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_skip
            // 
            this.btn_skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_skip.Location = new System.Drawing.Point(110, 290);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(92, 54);
            this.btn_skip.TabIndex = 3;
            this.btn_skip.Text = "Skip";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(208, 290);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(92, 54);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lb_number1
            // 
            this.lb_number1.AutoSize = true;
            this.lb_number1.Location = new System.Drawing.Point(25, 69);
            this.lb_number1.Name = "lb_number1";
            this.lb_number1.Size = new System.Drawing.Size(79, 16);
            this.lb_number1.TabIndex = 6;
            this.lb_number1.Text = "Max bredde";
            this.lb_number1.Visible = false;
            // 
            // lb_number2
            // 
            this.lb_number2.AutoSize = true;
            this.lb_number2.Location = new System.Drawing.Point(25, 106);
            this.lb_number2.Name = "lb_number2";
            this.lb_number2.Size = new System.Drawing.Size(69, 16);
            this.lb_number2.TabIndex = 7;
            this.lb_number2.Text = "Max højde";
            this.lb_number2.Visible = false;
            // 
            // lb_number3
            // 
            this.lb_number3.AutoSize = true;
            this.lb_number3.Location = new System.Drawing.Point(25, 142);
            this.lb_number3.Name = "lb_number3";
            this.lb_number3.Size = new System.Drawing.Size(74, 16);
            this.lb_number3.TabIndex = 8;
            this.lb_number3.Text = "Max dybde";
            this.lb_number3.Visible = false;
            // 
            // txt_number1
            // 
            this.txt_number1.Location = new System.Drawing.Point(110, 66);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(61, 22);
            this.txt_number1.TabIndex = 9;
            this.txt_number1.Visible = false;
            this.txt_number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_number2
            // 
            this.txt_number2.Location = new System.Drawing.Point(110, 103);
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(61, 22);
            this.txt_number2.TabIndex = 10;
            this.txt_number2.Visible = false;
            this.txt_number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_number3
            // 
            this.txt_number3.Location = new System.Drawing.Point(110, 139);
            this.txt_number3.Name = "txt_number3";
            this.txt_number3.Size = new System.Drawing.Size(61, 22);
            this.txt_number3.TabIndex = 11;
            this.txt_number3.Visible = false;
            this.txt_number3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_number6
            // 
            this.txt_number6.Location = new System.Drawing.Point(110, 247);
            this.txt_number6.Name = "txt_number6";
            this.txt_number6.Size = new System.Drawing.Size(61, 22);
            this.txt_number6.TabIndex = 17;
            this.txt_number6.Visible = false;
            this.txt_number6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_number5
            // 
            this.txt_number5.Location = new System.Drawing.Point(110, 211);
            this.txt_number5.Name = "txt_number5";
            this.txt_number5.Size = new System.Drawing.Size(61, 22);
            this.txt_number5.TabIndex = 16;
            this.txt_number5.Visible = false;
            this.txt_number5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_number4
            // 
            this.txt_number4.Location = new System.Drawing.Point(110, 174);
            this.txt_number4.Name = "txt_number4";
            this.txt_number4.Size = new System.Drawing.Size(61, 22);
            this.txt_number4.TabIndex = 15;
            this.txt_number4.Visible = false;
            this.txt_number4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // lb_number6
            // 
            this.lb_number6.AutoSize = true;
            this.lb_number6.Location = new System.Drawing.Point(25, 250);
            this.lb_number6.Name = "lb_number6";
            this.lb_number6.Size = new System.Drawing.Size(70, 16);
            this.lb_number6.TabIndex = 14;
            this.lb_number6.Text = "Min dybde";
            this.lb_number6.Visible = false;
            // 
            // lb_number5
            // 
            this.lb_number5.AutoSize = true;
            this.lb_number5.Location = new System.Drawing.Point(25, 214);
            this.lb_number5.Name = "lb_number5";
            this.lb_number5.Size = new System.Drawing.Size(65, 16);
            this.lb_number5.TabIndex = 13;
            this.lb_number5.Text = "Min højde";
            this.lb_number5.Visible = false;
            // 
            // lb_number4
            // 
            this.lb_number4.AutoSize = true;
            this.lb_number4.Location = new System.Drawing.Point(25, 177);
            this.lb_number4.Name = "lb_number4";
            this.lb_number4.Size = new System.Drawing.Size(75, 16);
            this.lb_number4.TabIndex = 12;
            this.lb_number4.Text = "Min bredde";
            this.lb_number4.Visible = false;
            // 
            // Intellectual_Counceling
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(560, 356);
            this.Controls.Add(this.txt_number6);
            this.Controls.Add(this.txt_number5);
            this.Controls.Add(this.txt_number4);
            this.Controls.Add(this.lb_number6);
            this.Controls.Add(this.lb_number5);
            this.Controls.Add(this.lb_number4);
            this.Controls.Add(this.txt_number3);
            this.Controls.Add(this.txt_number2);
            this.Controls.Add(this.txt_number1);
            this.Controls.Add(this.lb_number3);
            this.Controls.Add(this.lb_number2);
            this.Controls.Add(this.lb_number1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lb_question);
            this.Name = "Intellectual_Counceling";
            this.Text = "Intellectual_Counceling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lb_number1;
        private System.Windows.Forms.Label lb_number2;
        private System.Windows.Forms.Label lb_number3;
        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.TextBox txt_number2;
        private System.Windows.Forms.TextBox txt_number3;
        private System.Windows.Forms.TextBox txt_number6;
        private System.Windows.Forms.TextBox txt_number5;
        private System.Windows.Forms.TextBox txt_number4;
        private System.Windows.Forms.Label lb_number6;
        private System.Windows.Forms.Label lb_number5;
        private System.Windows.Forms.Label lb_number4;
    }
}