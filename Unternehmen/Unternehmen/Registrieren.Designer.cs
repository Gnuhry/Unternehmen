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
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.txBPasswortA = new System.Windows.Forms.TextBox();
            this.btnLoschen = new System.Windows.Forms.Button();
            this.pcBProfilbild = new System.Windows.Forms.PictureBox();
            this.cBoxTag = new System.Windows.Forms.ComboBox();
            this.cBoxMonat = new System.Windows.Forms.ComboBox();
            this.cBoxJahr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfilbild)).BeginInit();
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
            // pcBProfilbild
            // 
            this.pcBProfilbild.Location = new System.Drawing.Point(518, 37);
            this.pcBProfilbild.Name = "pcBProfilbild";
            this.pcBProfilbild.Size = new System.Drawing.Size(100, 50);
            this.pcBProfilbild.TabIndex = 10;
            this.pcBProfilbild.TabStop = false;
            // 
            // cBoxTag
            // 
            this.cBoxTag.FormattingEnabled = true;
            this.cBoxTag.Location = new System.Drawing.Point(357, 205);
            this.cBoxTag.Name = "cBoxTag";
            this.cBoxTag.Size = new System.Drawing.Size(121, 21);
            this.cBoxTag.TabIndex = 11;
            // 
            // cBoxMonat
            // 
            this.cBoxMonat.FormattingEnabled = true;
            this.cBoxMonat.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "März",
            "April",
            "Mai",
            "Juni",
            "Juli",
            "August",
            "September",
            "Oktober",
            "November",
            "Dezember"});
            this.cBoxMonat.Location = new System.Drawing.Point(511, 206);
            this.cBoxMonat.Name = "cBoxMonat";
            this.cBoxMonat.Size = new System.Drawing.Size(121, 21);
            this.cBoxMonat.TabIndex = 12;
            this.cBoxMonat.SelectedIndexChanged += new System.EventHandler(this.cBoxMonat_SelectedIndexChanged);
            // 
            // cBoxJahr
            // 
            this.cBoxJahr.FormattingEnabled = true;
            this.cBoxJahr.Location = new System.Drawing.Point(638, 206);
            this.cBoxJahr.Name = "cBoxJahr";
            this.cBoxJahr.Size = new System.Drawing.Size(121, 21);
            this.cBoxJahr.TabIndex = 13;
            // 
            // Registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxJahr);
            this.Controls.Add(this.cBoxMonat);
            this.Controls.Add(this.cBoxTag);
            this.Controls.Add(this.pcBProfilbild);
            this.Controls.Add(this.btnLoschen);
            this.Controls.Add(this.txBPasswortA);
            this.Controls.Add(this.btnRegistrieren);
            this.Controls.Add(this.txBPasswort2);
            this.Controls.Add(this.txBPasswort);
            this.Controls.Add(this.txBBenutzername);
            this.Controls.Add(this.txBInhaber);
            this.Name = "Registrieren";
            this.Text = "Registrieren";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Registrieren_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Registrieren_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfilbild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBInhaber;
        private System.Windows.Forms.TextBox txBBenutzername;
        private System.Windows.Forms.TextBox txBPasswort;
        private System.Windows.Forms.TextBox txBPasswort2;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.TextBox txBPasswortA;
        private System.Windows.Forms.Button btnLoschen;
        private System.Windows.Forms.PictureBox pcBProfilbild;
        private System.Windows.Forms.ComboBox cBoxTag;
        private System.Windows.Forms.ComboBox cBoxMonat;
        private System.Windows.Forms.ComboBox cBoxJahr;
    }
}