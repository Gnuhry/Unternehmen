﻿namespace Unternehmen
{
    partial class Messenger
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
            this.comBEmpfanger = new System.Windows.Forms.ComboBox();
            this.lBoxNachrichten = new System.Windows.Forms.ListBox();
            this.txBNachricht = new System.Windows.Forms.TextBox();
            this.btnSenden = new System.Windows.Forms.Button();
            this.pcBAnhang = new System.Windows.Forms.PictureBox();
            this.btnBildHochladen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoschen = new System.Windows.Forms.Button();
            this.pcBAnhangEingang = new System.Windows.Forms.PictureBox();
            this.lbSendeDatum = new System.Windows.Forms.Label();
            this.lbNachricht = new System.Windows.Forms.Label();
            this.lbSender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBAnhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBAnhangEingang)).BeginInit();
            this.SuspendLayout();
            // 
            // comBEmpfanger
            // 
            this.comBEmpfanger.FormattingEnabled = true;
            this.comBEmpfanger.Location = new System.Drawing.Point(256, 51);
            this.comBEmpfanger.Name = "comBEmpfanger";
            this.comBEmpfanger.Size = new System.Drawing.Size(147, 21);
            this.comBEmpfanger.TabIndex = 0;
            // 
            // lBoxNachrichten
            // 
            this.lBoxNachrichten.FormattingEnabled = true;
            this.lBoxNachrichten.Location = new System.Drawing.Point(42, 37);
            this.lBoxNachrichten.Name = "lBoxNachrichten";
            this.lBoxNachrichten.Size = new System.Drawing.Size(289, 95);
            this.lBoxNachrichten.TabIndex = 1;
            // 
            // txBNachricht
            // 
            this.txBNachricht.Location = new System.Drawing.Point(57, 37);
            this.txBNachricht.Multiline = true;
            this.txBNachricht.Name = "txBNachricht";
            this.txBNachricht.Size = new System.Drawing.Size(193, 143);
            this.txBNachricht.TabIndex = 2;
            // 
            // btnSenden
            // 
            this.btnSenden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenden.ForeColor = System.Drawing.Color.White;
            this.btnSenden.Location = new System.Drawing.Point(163, 327);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(193, 23);
            this.btnSenden.TabIndex = 3;
            this.btnSenden.Text = "Senden";
            this.btnSenden.UseVisualStyleBackColor = false;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // pcBAnhang
            // 
            this.pcBAnhang.Location = new System.Drawing.Point(57, 202);
            this.pcBAnhang.Name = "pcBAnhang";
            this.pcBAnhang.Size = new System.Drawing.Size(193, 103);
            this.pcBAnhang.TabIndex = 4;
            this.pcBAnhang.TabStop = false;
            // 
            // btnBildHochladen
            // 
            this.btnBildHochladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnBildHochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBildHochladen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBildHochladen.ForeColor = System.Drawing.Color.White;
            this.btnBildHochladen.Location = new System.Drawing.Point(57, 327);
            this.btnBildHochladen.Name = "btnBildHochladen";
            this.btnBildHochladen.Size = new System.Drawing.Size(100, 23);
            this.btnBildHochladen.TabIndex = 5;
            this.btnBildHochladen.Text = "Hochladen";
            this.btnBildHochladen.UseVisualStyleBackColor = false;
            this.btnBildHochladen.Click += new System.EventHandler(this.btnBildHochladen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 108);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(692, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ausgang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eingang";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(388, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 477);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txBNachricht);
            this.panel3.Controls.Add(this.pcBAnhang);
            this.panel3.Controls.Add(this.btnBildHochladen);
            this.panel3.Controls.Add(this.comBEmpfanger);
            this.panel3.Controls.Add(this.btnSenden);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(398, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 477);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLoschen);
            this.panel4.Controls.Add(this.pcBAnhangEingang);
            this.panel4.Controls.Add(this.lbSendeDatum);
            this.panel4.Controls.Add(this.lbNachricht);
            this.panel4.Controls.Add(this.lbSender);
            this.panel4.Controls.Add(this.lBoxNachrichten);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 477);
            this.panel4.TabIndex = 9;
            // 
            // btnLoschen
            // 
            this.btnLoschen.Location = new System.Drawing.Point(45, 299);
            this.btnLoschen.Name = "btnLoschen";
            this.btnLoschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoschen.TabIndex = 6;
            this.btnLoschen.Text = "button1";
            this.btnLoschen.UseVisualStyleBackColor = true;
            this.btnLoschen.Visible = false;
            this.btnLoschen.Click += new System.EventHandler(this.btnLoschen_Click);
            // 
            // pcBAnhangEingang
            // 
            this.pcBAnhangEingang.Location = new System.Drawing.Point(86, 238);
            this.pcBAnhangEingang.Name = "pcBAnhangEingang";
            this.pcBAnhangEingang.Size = new System.Drawing.Size(100, 50);
            this.pcBAnhangEingang.TabIndex = 5;
            this.pcBAnhangEingang.TabStop = false;
            this.pcBAnhangEingang.Visible = false;
            // 
            // lbSendeDatum
            // 
            this.lbSendeDatum.AutoSize = true;
            this.lbSendeDatum.Location = new System.Drawing.Point(117, 202);
            this.lbSendeDatum.Name = "lbSendeDatum";
            this.lbSendeDatum.Size = new System.Drawing.Size(35, 13);
            this.lbSendeDatum.TabIndex = 4;
            this.lbSendeDatum.Text = "label1";
            this.lbSendeDatum.Visible = false;
            // 
            // lbNachricht
            // 
            this.lbNachricht.AutoSize = true;
            this.lbNachricht.Location = new System.Drawing.Point(45, 238);
            this.lbNachricht.Name = "lbNachricht";
            this.lbNachricht.Size = new System.Drawing.Size(35, 13);
            this.lbNachricht.TabIndex = 3;
            this.lbNachricht.Text = "label4";
            this.lbNachricht.Visible = false;
            // 
            // lbSender
            // 
            this.lbSender.AutoSize = true;
            this.lbSender.Location = new System.Drawing.Point(45, 202);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(35, 13);
            this.lbSender.TabIndex = 2;
            this.lbSender.Text = "label1";
            this.lbSender.Visible = false;
            // 
            // Messenger
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 585);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Messenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Messenger_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Messenger_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Messenger_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pcBAnhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBAnhangEingang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comBEmpfanger;
        private System.Windows.Forms.ListBox lBoxNachrichten;
        private System.Windows.Forms.TextBox txBNachricht;
        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.PictureBox pcBAnhang;
        private System.Windows.Forms.Button btnBildHochladen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbNachricht;
        private System.Windows.Forms.Label lbSender;
        private System.Windows.Forms.Label lbSendeDatum;
        private System.Windows.Forms.PictureBox pcBAnhangEingang;
        private System.Windows.Forms.Button btnLoschen;
    }
}