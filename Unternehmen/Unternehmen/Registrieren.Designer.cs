namespace Unternehmen
{
    partial class Registrieren
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
            this.txBInhaber = new System.Windows.Forms.TextBox();
            this.txBBenutzername = new System.Windows.Forms.TextBox();
            this.txBPasswort = new System.Windows.Forms.TextBox();
            this.txBPasswort2 = new System.Windows.Forms.TextBox();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.txBPasswortA = new System.Windows.Forms.TextBox();
            this.btnLoschen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // txBInhaber
            // 
            this.txBInhaber.Location = new System.Drawing.Point(357, 123);
            this.txBInhaber.Name = "txBInhaber";
            this.txBInhaber.Size = new System.Drawing.Size(100, 20);
            this.txBInhaber.TabIndex = 0;
            // 
            // txBBenutzername
            // 
            this.txBBenutzername.Location = new System.Drawing.Point(357, 149);
            this.txBBenutzername.Name = "txBBenutzername";
            this.txBBenutzername.Size = new System.Drawing.Size(100, 20);
            this.txBBenutzername.TabIndex = 1;
            // 
            // txBPasswort
            // 
            this.txBPasswort.Location = new System.Drawing.Point(357, 232);
            this.txBPasswort.Name = "txBPasswort";
            this.txBPasswort.Size = new System.Drawing.Size(100, 20);
            this.txBPasswort.TabIndex = 2;
            // 
            // txBPasswort2
            // 
            this.txBPasswort2.Location = new System.Drawing.Point(357, 258);
            this.txBPasswort2.Name = "txBPasswort2";
            this.txBPasswort2.Size = new System.Drawing.Size(100, 20);
            this.txBPasswort2.TabIndex = 3;
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(357, 193);
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(120, 20);
            this.numDay.TabIndex = 4;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(609, 193);
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 20);
            this.numYear.TabIndex = 5;
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(483, 193);
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(120, 20);
            this.numMonth.TabIndex = 6;
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.Location = new System.Drawing.Point(357, 335);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrieren.TabIndex = 7;
            this.btnRegistrieren.Text = "button1";
            this.btnRegistrieren.UseVisualStyleBackColor = true;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegistrieren_Click);
            // 
            // txBPasswortA
            // 
            this.txBPasswortA.Location = new System.Drawing.Point(357, 284);
            this.txBPasswortA.Name = "txBPasswortA";
            this.txBPasswortA.Size = new System.Drawing.Size(100, 20);
            this.txBPasswortA.TabIndex = 8;
            this.txBPasswortA.Visible = false;
            // 
            // btnLoschen
            // 
            this.btnLoschen.Location = new System.Drawing.Point(474, 335);
            this.btnLoschen.Name = "btnLoschen";
            this.btnLoschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoschen.TabIndex = 9;
            this.btnLoschen.Text = "button1";
            this.btnLoschen.UseVisualStyleBackColor = true;
            this.btnLoschen.Visible = false;
            this.btnLoschen.Click += new System.EventHandler(this.btnLoschen_Click);
            // 
            // Registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoschen);
            this.Controls.Add(this.txBPasswortA);
            this.Controls.Add(this.btnRegistrieren);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.numDay);
            this.Controls.Add(this.txBPasswort2);
            this.Controls.Add(this.txBPasswort);
            this.Controls.Add(this.txBBenutzername);
            this.Controls.Add(this.txBInhaber);
            this.Name = "Registrieren";
            this.Text = "Registrieren";
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBInhaber;
        private System.Windows.Forms.TextBox txBBenutzername;
        private System.Windows.Forms.TextBox txBPasswort;
        private System.Windows.Forms.TextBox txBPasswort2;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.TextBox txBPasswortA;
        private System.Windows.Forms.Button btnLoschen;
    }
}