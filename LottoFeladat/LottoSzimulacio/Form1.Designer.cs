﻿
namespace LottoSzimulacio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSorsol = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 550);
            this.panel1.TabIndex = 0;
            // 
            // btnSorsol
            // 
            this.btnSorsol.Location = new System.Drawing.Point(691, 50);
            this.btnSorsol.Name = "btnSorsol";
            this.btnSorsol.Size = new System.Drawing.Size(94, 29);
            this.btnSorsol.TabIndex = 1;
            this.btnSorsol.Text = "Sorsol";
            this.btnSorsol.UseVisualStyleBackColor = true;
            this.btnSorsol.Click += new System.EventHandler(this.btnSorsol_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(694, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Bezár";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSorsol);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSorsol;
        private System.Windows.Forms.Button btnClose;
    }
}
