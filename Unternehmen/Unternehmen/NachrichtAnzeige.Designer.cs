﻿namespace Unternehmen
{
    partial class NachrichtAnzeige
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
            this.btnLoschen = new System.Windows.Forms.Button();
            this.lbAnzeige = new System.Windows.Forms.Label();
            this.lbSender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoschen
            // 
            this.btnLoschen.Location = new System.Drawing.Point(48, 103);
            this.btnLoschen.Name = "btnLoschen";
            this.btnLoschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoschen.TabIndex = 0;
            this.btnLoschen.Text = "button1";
            this.btnLoschen.UseVisualStyleBackColor = true;
            this.btnLoschen.Click += new System.EventHandler(this.btnLoschen_Click);
            // 
            // lbAnzeige
            // 
            this.lbAnzeige.AutoSize = true;
            this.lbAnzeige.Location = new System.Drawing.Point(28, 37);
            this.lbAnzeige.Name = "lbAnzeige";
            this.lbAnzeige.Size = new System.Drawing.Size(35, 13);
            this.lbAnzeige.TabIndex = 1;
            this.lbAnzeige.Text = "label1";
            // 
            // lbSender
            // 
            this.lbSender.AutoSize = true;
            this.lbSender.Location = new System.Drawing.Point(28, 9);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(35, 13);
            this.lbSender.TabIndex = 2;
            this.lbSender.Text = "label1";
            // 
            // NachrichtAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSender);
            this.Controls.Add(this.lbAnzeige);
            this.Controls.Add(this.btnLoschen);
            this.Name = "NachrichtAnzeige";
            this.Text = "NachrichtAnzeige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoschen;
        private System.Windows.Forms.Label lbAnzeige;
        private System.Windows.Forms.Label lbSender;
    }
}