namespace Unternehmen
{
    partial class Admin
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
            this.chBWebsite = new System.Windows.Forms.CheckBox();
            this.txBWebsite = new System.Windows.Forms.TextBox();
            this.btnEinsehen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numUrlaubstage = new System.Windows.Forms.NumericUpDown();
            this.btnPassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chbLArbeitstage = new System.Windows.Forms.CheckedListBox();
            this.btnSperren = new System.Windows.Forms.Button();
            this.btnAktivieren = new System.Windows.Forms.Button();
            this.comBMitarbeiter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFeuern = new System.Windows.Forms.Button();
            this.chBAutoAktiv = new System.Windows.Forms.CheckBox();
            this.btnLogoHochladen = new System.Windows.Forms.Button();
            this.pcBFirmenlogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numUrlaubstage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBFirmenlogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chBWebsite
            // 
            this.chBWebsite.AutoSize = true;
            this.chBWebsite.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chBWebsite.Checked = true;
            this.chBWebsite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBWebsite.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBWebsite.Location = new System.Drawing.Point(16, 456);
            this.chBWebsite.Name = "chBWebsite";
            this.chBWebsite.Size = new System.Drawing.Size(92, 17);
            this.chBWebsite.TabIndex = 32;
            this.chBWebsite.Text = "Website-Link";
            this.chBWebsite.UseVisualStyleBackColor = true;
            this.chBWebsite.CheckedChanged += new System.EventHandler(this.chBWebsite_CheckedChanged);
            // 
            // txBWebsite
            // 
            this.txBWebsite.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBWebsite.Location = new System.Drawing.Point(16, 478);
            this.txBWebsite.Name = "txBWebsite";
            this.txBWebsite.Size = new System.Drawing.Size(209, 21);
            this.txBWebsite.TabIndex = 31;
            this.txBWebsite.TextChanged += new System.EventHandler(this.txBWebsite_TextChanged);
            // 
            // btnEinsehen
            // 
            this.btnEinsehen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnEinsehen.Enabled = false;
            this.btnEinsehen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEinsehen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinsehen.ForeColor = System.Drawing.Color.White;
            this.btnEinsehen.Location = new System.Drawing.Point(476, 416);
            this.btnEinsehen.Name = "btnEinsehen";
            this.btnEinsehen.Size = new System.Drawing.Size(172, 34);
            this.btnEinsehen.TabIndex = 30;
            this.btnEinsehen.Text = "Einsehen";
            this.btnEinsehen.UseVisualStyleBackColor = false;
            this.btnEinsehen.Click += new System.EventHandler(this.btnEinsehen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Urlaubstage:";
            // 
            // numUrlaubstage
            // 
            this.numUrlaubstage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUrlaubstage.Location = new System.Drawing.Point(95, 420);
            this.numUrlaubstage.Name = "numUrlaubstage";
            this.numUrlaubstage.Size = new System.Drawing.Size(40, 21);
            this.numUrlaubstage.TabIndex = 28;
            this.numUrlaubstage.ValueChanged += new System.EventHandler(this.numUrlaubstage_ValueChanged);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnPassword.Enabled = false;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.Location = new System.Drawing.Point(476, 364);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(172, 34);
            this.btnPassword.TabIndex = 27;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Arbeitstage:";
            // 
            // chbLArbeitstage
            // 
            this.chbLArbeitstage.BackColor = System.Drawing.Color.White;
            this.chbLArbeitstage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chbLArbeitstage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLArbeitstage.FormattingEnabled = true;
            this.chbLArbeitstage.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.chbLArbeitstage.Location = new System.Drawing.Point(16, 194);
            this.chbLArbeitstage.Name = "chbLArbeitstage";
            this.chbLArbeitstage.Size = new System.Drawing.Size(120, 154);
            this.chbLArbeitstage.TabIndex = 25;
            this.chbLArbeitstage.SelectedValueChanged += new System.EventHandler(this.chbLArbeitstage_SelectedValueChanged);
            // 
            // btnSperren
            // 
            this.btnSperren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnSperren.Enabled = false;
            this.btnSperren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSperren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSperren.ForeColor = System.Drawing.Color.White;
            this.btnSperren.Location = new System.Drawing.Point(476, 314);
            this.btnSperren.Name = "btnSperren";
            this.btnSperren.Size = new System.Drawing.Size(172, 34);
            this.btnSperren.TabIndex = 24;
            this.btnSperren.Text = "Lock";
            this.btnSperren.UseVisualStyleBackColor = false;
            this.btnSperren.Click += new System.EventHandler(this.btnSperren_Click);
            // 
            // btnAktivieren
            // 
            this.btnAktivieren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnAktivieren.Enabled = false;
            this.btnAktivieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktivieren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktivieren.ForeColor = System.Drawing.Color.White;
            this.btnAktivieren.Location = new System.Drawing.Point(476, 261);
            this.btnAktivieren.Name = "btnAktivieren";
            this.btnAktivieren.Size = new System.Drawing.Size(172, 34);
            this.btnAktivieren.TabIndex = 23;
            this.btnAktivieren.Text = "Activate";
            this.btnAktivieren.UseVisualStyleBackColor = false;
            this.btnAktivieren.Click += new System.EventHandler(this.btnAktivieren_Click);
            // 
            // comBMitarbeiter
            // 
            this.comBMitarbeiter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBMitarbeiter.FormattingEnabled = true;
            this.comBMitarbeiter.Location = new System.Drawing.Point(476, 170);
            this.comBMitarbeiter.Name = "comBMitarbeiter";
            this.comBMitarbeiter.Size = new System.Drawing.Size(172, 21);
            this.comBMitarbeiter.TabIndex = 22;
            this.comBMitarbeiter.SelectedIndexChanged += new System.EventHandler(this.comBMitarbeiter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Administration";
            // 
            // btnFeuern
            // 
            this.btnFeuern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnFeuern.Enabled = false;
            this.btnFeuern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeuern.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeuern.ForeColor = System.Drawing.Color.White;
            this.btnFeuern.Location = new System.Drawing.Point(476, 209);
            this.btnFeuern.Name = "btnFeuern";
            this.btnFeuern.Size = new System.Drawing.Size(172, 34);
            this.btnFeuern.TabIndex = 19;
            this.btnFeuern.Text = "Fire";
            this.btnFeuern.UseVisualStyleBackColor = false;
            this.btnFeuern.Click += new System.EventHandler(this.btnFeuern_Click);
            // 
            // chBAutoAktiv
            // 
            this.chBAutoAktiv.AutoSize = true;
            this.chBAutoAktiv.Checked = true;
            this.chBAutoAktiv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBAutoAktiv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBAutoAktiv.Location = new System.Drawing.Point(89, 18);
            this.chBAutoAktiv.Name = "chBAutoAktiv";
            this.chBAutoAktiv.Size = new System.Drawing.Size(263, 24);
            this.chBAutoAktiv.TabIndex = 33;
            this.chBAutoAktiv.Text = "Activate Accounts at Sign Up";
            this.chBAutoAktiv.UseVisualStyleBackColor = true;
            this.chBAutoAktiv.CheckedChanged += new System.EventHandler(this.chBAutoAktiv_CheckedChanged);
            // 
            // btnLogoHochladen
            // 
            this.btnLogoHochladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnLogoHochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoHochladen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoHochladen.ForeColor = System.Drawing.Color.White;
            this.btnLogoHochladen.Location = new System.Drawing.Point(176, 278);
            this.btnLogoHochladen.Name = "btnLogoHochladen";
            this.btnLogoHochladen.Size = new System.Drawing.Size(127, 34);
            this.btnLogoHochladen.TabIndex = 35;
            this.btnLogoHochladen.Text = "Upload Logo";
            this.btnLogoHochladen.UseVisualStyleBackColor = false;
            this.btnLogoHochladen.Click += new System.EventHandler(this.btnLogoHochladen_Click);
            // 
            // pcBFirmenlogo
            // 
            this.pcBFirmenlogo.BackColor = System.Drawing.Color.White;
            this.pcBFirmenlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcBFirmenlogo.Location = new System.Drawing.Point(189, 172);
            this.pcBFirmenlogo.Name = "pcBFirmenlogo";
            this.pcBFirmenlogo.Size = new System.Drawing.Size(100, 100);
            this.pcBFirmenlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBFirmenlogo.TabIndex = 36;
            this.pcBFirmenlogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnLogoHochladen);
            this.panel2.Controls.Add(this.pcBFirmenlogo);
            this.panel2.Controls.Add(this.chbLArbeitstage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numUrlaubstage);
            this.panel2.Controls.Add(this.chBWebsite);
            this.panel2.Controls.Add(this.txBWebsite);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 585);
            this.panel2.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 59);
            this.panel5.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 57);
            this.panel3.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(319, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 57);
            this.panel1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Management";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.chBAutoAktiv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(319, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 59);
            this.panel4.TabIndex = 40;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 585);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEinsehen);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnSperren);
            this.Controls.Add(this.btnAktivieren);
            this.Controls.Add(this.comBMitarbeiter);
            this.Controls.Add(this.btnFeuern);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Admin_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Admin_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numUrlaubstage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBFirmenlogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chBWebsite;
        private System.Windows.Forms.TextBox txBWebsite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUrlaubstage;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chbLArbeitstage;
        private System.Windows.Forms.Button btnSperren;
        private System.Windows.Forms.Button btnAktivieren;
        private System.Windows.Forms.ComboBox comBMitarbeiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFeuern;
        private System.Windows.Forms.CheckBox chBAutoAktiv;
        private System.Windows.Forms.Button btnLogoHochladen;
        private System.Windows.Forms.PictureBox pcBFirmenlogo;
        private System.Windows.Forms.Button btnEinsehen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}