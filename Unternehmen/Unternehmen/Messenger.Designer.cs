namespace Unternehmen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcBAnhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBEmpfanger
            // 
            this.comBEmpfanger.FormattingEnabled = true;
            this.comBEmpfanger.Location = new System.Drawing.Point(648, 171);
            this.comBEmpfanger.Name = "comBEmpfanger";
            this.comBEmpfanger.Size = new System.Drawing.Size(147, 21);
            this.comBEmpfanger.TabIndex = 0;
            // 
            // lBoxNachrichten
            // 
            this.lBoxNachrichten.FormattingEnabled = true;
            this.lBoxNachrichten.Location = new System.Drawing.Point(17, 125);
            this.lBoxNachrichten.Name = "lBoxNachrichten";
            this.lBoxNachrichten.Size = new System.Drawing.Size(289, 95);
            this.lBoxNachrichten.TabIndex = 1;
            // 
            // txBNachricht
            // 
            this.txBNachricht.Location = new System.Drawing.Point(439, 171);
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
            this.btnSenden.Location = new System.Drawing.Point(439, 506);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(193, 23);
            this.btnSenden.TabIndex = 3;
            this.btnSenden.Text = "Senden";
            this.btnSenden.UseVisualStyleBackColor = false;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // pcBAnhang
            // 
            this.pcBAnhang.Location = new System.Drawing.Point(439, 320);
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
            this.btnBildHochladen.Location = new System.Drawing.Point(439, 429);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eingang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(692, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ausgang";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel2.Location = new System.Drawing.Point(386, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 495);
            this.panel2.TabIndex = 7;
            // 
            // Messenger
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lBoxNachrichten);
            this.Controls.Add(this.btnBildHochladen);
            this.Controls.Add(this.pcBAnhang);
            this.Controls.Add(this.btnSenden);
            this.Controls.Add(this.txBNachricht);
            this.Controls.Add(this.comBEmpfanger);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}