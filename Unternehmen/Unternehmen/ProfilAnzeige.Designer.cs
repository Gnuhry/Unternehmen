namespace Unternehmen
{
    partial class ProfilAnzeige
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
            this.lbInhaber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGeburtstag = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pcBProfil = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cBoxJahr = new System.Windows.Forms.ComboBox();
            this.cBoxMonat = new System.Windows.Forms.ComboBox();
            this.cBoxTag = new System.Windows.Forms.ComboBox();
            this.lbFehlermeldung = new System.Windows.Forms.Label();
            this.btnAndern = new System.Windows.Forms.Button();
            this.txBStatus = new System.Windows.Forms.TextBox();
            this.btnProfilbildHochladen = new System.Windows.Forms.Button();
            this.txBPasswortA = new System.Windows.Forms.TextBox();
            this.txBPasswort2 = new System.Windows.Forms.TextBox();
            this.txBPasswort = new System.Windows.Forms.TextBox();
            this.txBBenutzername = new System.Windows.Forms.TextBox();
            this.txBInhaber = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfil)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInhaber
            // 
            this.lbInhaber.AutoSize = true;
            this.lbInhaber.Location = new System.Drawing.Point(74, 55);
            this.lbInhaber.Name = "lbInhaber";
            this.lbInhaber.Size = new System.Drawing.Size(35, 13);
            this.lbInhaber.TabIndex = 1;
            this.lbInhaber.Text = "label1";
            this.lbInhaber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbInhaber.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbInhaber.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbGeburtstag);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.lbInhaber);
            this.panel2.Controls.Add(this.pcBProfil);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 378);
            this.panel2.TabIndex = 3;
            // 
            // lbGeburtstag
            // 
            this.lbGeburtstag.AutoSize = true;
            this.lbGeburtstag.Location = new System.Drawing.Point(216, 127);
            this.lbGeburtstag.Name = "lbGeburtstag";
            this.lbGeburtstag.Size = new System.Drawing.Size(35, 13);
            this.lbGeburtstag.TabIndex = 3;
            this.lbGeburtstag.Text = "label1";
            this.lbGeburtstag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbGeburtstag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbGeburtstag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(74, 98);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "label1";
            this.lbStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // pcBProfil
            // 
            this.pcBProfil.Location = new System.Drawing.Point(227, 39);
            this.pcBProfil.Name = "pcBProfil";
            this.pcBProfil.Size = new System.Drawing.Size(100, 50);
            this.pcBProfil.TabIndex = 0;
            this.pcBProfil.TabStop = false;
            this.pcBProfil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.pcBProfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.pcBProfil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cBoxJahr);
            this.panel3.Controls.Add(this.cBoxMonat);
            this.panel3.Controls.Add(this.cBoxTag);
            this.panel3.Controls.Add(this.lbFehlermeldung);
            this.panel3.Controls.Add(this.btnAndern);
            this.panel3.Controls.Add(this.txBStatus);
            this.panel3.Controls.Add(this.btnProfilbildHochladen);
            this.panel3.Controls.Add(this.txBPasswortA);
            this.panel3.Controls.Add(this.txBPasswort2);
            this.panel3.Controls.Add(this.txBPasswort);
            this.panel3.Controls.Add(this.txBBenutzername);
            this.panel3.Controls.Add(this.txBInhaber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(556, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 378);
            this.panel3.TabIndex = 4;
            // 
            // cBoxJahr
            // 
            this.cBoxJahr.FormattingEnabled = true;
            this.cBoxJahr.Location = new System.Drawing.Point(5, 334);
            this.cBoxJahr.Name = "cBoxJahr";
            this.cBoxJahr.Size = new System.Drawing.Size(121, 21);
            this.cBoxJahr.TabIndex = 34;
            this.cBoxJahr.SelectedIndexChanged += new System.EventHandler(this.cBoxJahr_SelectedIndexChanged);
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
            this.cBoxMonat.Location = new System.Drawing.Point(5, 307);
            this.cBoxMonat.Name = "cBoxMonat";
            this.cBoxMonat.Size = new System.Drawing.Size(121, 21);
            this.cBoxMonat.TabIndex = 33;
            this.cBoxMonat.SelectedIndexChanged += new System.EventHandler(this.cBoxMonat_SelectedIndexChanged);
            // 
            // cBoxTag
            // 
            this.cBoxTag.FormattingEnabled = true;
            this.cBoxTag.Location = new System.Drawing.Point(5, 280);
            this.cBoxTag.Name = "cBoxTag";
            this.cBoxTag.Size = new System.Drawing.Size(49, 21);
            this.cBoxTag.TabIndex = 32;
            this.cBoxTag.SelectedIndexChanged += new System.EventHandler(this.cBoxTag_SelectedIndexChanged);
            // 
            // lbFehlermeldung
            // 
            this.lbFehlermeldung.AutoSize = true;
            this.lbFehlermeldung.Location = new System.Drawing.Point(141, 164);
            this.lbFehlermeldung.Name = "lbFehlermeldung";
            this.lbFehlermeldung.Size = new System.Drawing.Size(35, 13);
            this.lbFehlermeldung.TabIndex = 8;
            this.lbFehlermeldung.Text = "label1";
            // 
            // btnAndern
            // 
            this.btnAndern.Location = new System.Drawing.Point(132, 127);
            this.btnAndern.Name = "btnAndern";
            this.btnAndern.Size = new System.Drawing.Size(100, 23);
            this.btnAndern.TabIndex = 7;
            this.btnAndern.Text = "button1";
            this.btnAndern.UseVisualStyleBackColor = true;
            this.btnAndern.Click += new System.EventHandler(this.btnAndern_Click);
            // 
            // txBStatus
            // 
            this.txBStatus.Location = new System.Drawing.Point(132, 281);
            this.txBStatus.Multiline = true;
            this.txBStatus.Name = "txBStatus";
            this.txBStatus.Size = new System.Drawing.Size(100, 85);
            this.txBStatus.TabIndex = 6;
            this.txBStatus.TextChanged += new System.EventHandler(this.txBStatus_TextChanged);
            // 
            // btnProfilbildHochladen
            // 
            this.btnProfilbildHochladen.Location = new System.Drawing.Point(132, 252);
            this.btnProfilbildHochladen.Name = "btnProfilbildHochladen";
            this.btnProfilbildHochladen.Size = new System.Drawing.Size(100, 23);
            this.btnProfilbildHochladen.TabIndex = 5;
            this.btnProfilbildHochladen.Text = "button1";
            this.btnProfilbildHochladen.UseVisualStyleBackColor = true;
            this.btnProfilbildHochladen.Click += new System.EventHandler(this.btnProfilbildHochladen_Click);
            // 
            // txBPasswortA
            // 
            this.txBPasswortA.Location = new System.Drawing.Point(132, 100);
            this.txBPasswortA.Name = "txBPasswortA";
            this.txBPasswortA.Size = new System.Drawing.Size(100, 20);
            this.txBPasswortA.TabIndex = 4;
            // 
            // txBPasswort2
            // 
            this.txBPasswort2.Location = new System.Drawing.Point(132, 74);
            this.txBPasswort2.Name = "txBPasswort2";
            this.txBPasswort2.Size = new System.Drawing.Size(100, 20);
            this.txBPasswort2.TabIndex = 3;
            // 
            // txBPasswort
            // 
            this.txBPasswort.Location = new System.Drawing.Point(132, 48);
            this.txBPasswort.Name = "txBPasswort";
            this.txBPasswort.Size = new System.Drawing.Size(100, 20);
            this.txBPasswort.TabIndex = 2;
            // 
            // txBBenutzername
            // 
            this.txBBenutzername.Location = new System.Drawing.Point(132, 21);
            this.txBBenutzername.Name = "txBBenutzername";
            this.txBBenutzername.Size = new System.Drawing.Size(100, 20);
            this.txBBenutzername.TabIndex = 1;
            // 
            // txBInhaber
            // 
            this.txBInhaber.Location = new System.Drawing.Point(132, 226);
            this.txBInhaber.Name = "txBInhaber";
            this.txBInhaber.Size = new System.Drawing.Size(100, 20);
            this.txBInhaber.TabIndex = 0;
            this.txBInhaber.TextChanged += new System.EventHandler(this.txBInhaber_TextChanged_1);
            // 
            // ProfilAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProfilAnzeige";
            this.Text = "ProfilAnzeige";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfil)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBProfil;
        private System.Windows.Forms.Label lbInhaber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txBStatus;
        private System.Windows.Forms.Button btnProfilbildHochladen;
        private System.Windows.Forms.TextBox txBPasswortA;
        private System.Windows.Forms.TextBox txBPasswort2;
        private System.Windows.Forms.TextBox txBPasswort;
        private System.Windows.Forms.TextBox txBBenutzername;
        private System.Windows.Forms.TextBox txBInhaber;
        private System.Windows.Forms.Button btnAndern;
        private System.Windows.Forms.Label lbFehlermeldung;
        private System.Windows.Forms.Label lbGeburtstag;
        private System.Windows.Forms.ComboBox cBoxJahr;
        private System.Windows.Forms.ComboBox cBoxMonat;
        private System.Windows.Forms.ComboBox cBoxTag;
    }
}