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
            this.SuspendLayout();
            // 
            // comBEmpfanger
            // 
            this.comBEmpfanger.FormattingEnabled = true;
            this.comBEmpfanger.Location = new System.Drawing.Point(137, 81);
            this.comBEmpfanger.Name = "comBEmpfanger";
            this.comBEmpfanger.Size = new System.Drawing.Size(121, 21);
            this.comBEmpfanger.TabIndex = 0;
            // 
            // lBoxNachrichten
            // 
            this.lBoxNachrichten.FormattingEnabled = true;
            this.lBoxNachrichten.Location = new System.Drawing.Point(337, 127);
            this.lBoxNachrichten.Name = "lBoxNachrichten";
            this.lBoxNachrichten.Size = new System.Drawing.Size(120, 95);
            this.lBoxNachrichten.TabIndex = 1;
            // 
            // txBNachricht
            // 
            this.txBNachricht.Location = new System.Drawing.Point(119, 247);
            this.txBNachricht.Name = "txBNachricht";
            this.txBNachricht.Size = new System.Drawing.Size(100, 20);
            this.txBNachricht.TabIndex = 2;
            // 
            // btnSenden
            // 
            this.btnSenden.Location = new System.Drawing.Point(137, 298);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 23);
            this.btnSenden.TabIndex = 3;
            this.btnSenden.Text = "button1";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSenden);
            this.Controls.Add(this.txBNachricht);
            this.Controls.Add(this.lBoxNachrichten);
            this.Controls.Add(this.comBEmpfanger);
            this.Name = "Messenger";
            this.Text = "Messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Messenger_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBEmpfanger;
        private System.Windows.Forms.ListBox lBoxNachrichten;
        private System.Windows.Forms.TextBox txBNachricht;
        private System.Windows.Forms.Button btnSenden;
    }
}