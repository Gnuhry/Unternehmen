﻿namespace Unternehmen
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
            this.btnUrlaub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFeuern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUrlaubstage)).BeginInit();
            this.SuspendLayout();
            // 
            // chBWebsite
            // 
            this.chBWebsite.AutoSize = true;
            this.chBWebsite.Checked = true;
            this.chBWebsite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBWebsite.Location = new System.Drawing.Point(246, 318);
            this.chBWebsite.Name = "chBWebsite";
            this.chBWebsite.Size = new System.Drawing.Size(88, 17);
            this.chBWebsite.TabIndex = 32;
            this.chBWebsite.Text = "Website-Link";
            this.chBWebsite.UseVisualStyleBackColor = true;
            this.chBWebsite.CheckedChanged += new System.EventHandler(this.chBWebsite_CheckedChanged);
            // 
            // txBWebsite
            // 
            this.txBWebsite.Location = new System.Drawing.Point(340, 316);
            this.txBWebsite.Name = "txBWebsite";
            this.txBWebsite.Size = new System.Drawing.Size(209, 20);
            this.txBWebsite.TabIndex = 31;
            this.txBWebsite.TextChanged += new System.EventHandler(this.txBWebsite_TextChanged);
            // 
            // btnEinsehen
            // 
            this.btnEinsehen.Enabled = false;
            this.btnEinsehen.Location = new System.Drawing.Point(433, 263);
            this.btnEinsehen.Name = "btnEinsehen";
            this.btnEinsehen.Size = new System.Drawing.Size(97, 23);
            this.btnEinsehen.TabIndex = 30;
            this.btnEinsehen.Text = "Einsehen";
            this.btnEinsehen.UseVisualStyleBackColor = true;
            this.btnEinsehen.Click += new System.EventHandler(this.btnEinsehen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Urlaubstage:";
            // 
            // numUrlaubstage
            // 
            this.numUrlaubstage.Location = new System.Drawing.Point(332, 284);
            this.numUrlaubstage.Name = "numUrlaubstage";
            this.numUrlaubstage.Size = new System.Drawing.Size(40, 20);
            this.numUrlaubstage.TabIndex = 28;
            this.numUrlaubstage.ValueChanged += new System.EventHandler(this.numUrlaubstage_ValueChanged);
            // 
            // btnPassword
            // 
            this.btnPassword.Enabled = false;
            this.btnPassword.Location = new System.Drawing.Point(433, 234);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(97, 23);
            this.btnPassword.TabIndex = 27;
            this.btnPassword.Text = "Passwort ändern";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Arbeitstage:";
            // 
            // chbLArbeitstage
            // 
            this.chbLArbeitstage.BackColor = System.Drawing.SystemColors.Control;
            this.chbLArbeitstage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chbLArbeitstage.FormattingEnabled = true;
            this.chbLArbeitstage.Items.AddRange(new object[] {
            "Montag",
            "Dienstag",
            "Mittwoch",
            "Donnerstag",
            "Freitag",
            "Samstag",
            "Sontag"});
            this.chbLArbeitstage.Location = new System.Drawing.Point(252, 168);
            this.chbLArbeitstage.Name = "chbLArbeitstage";
            this.chbLArbeitstage.Size = new System.Drawing.Size(120, 105);
            this.chbLArbeitstage.TabIndex = 25;
            this.chbLArbeitstage.SelectedValueChanged += new System.EventHandler(this.chbLArbeitstage_SelectedValueChanged);
            // 
            // btnSperren
            // 
            this.btnSperren.Enabled = false;
            this.btnSperren.Location = new System.Drawing.Point(433, 205);
            this.btnSperren.Name = "btnSperren";
            this.btnSperren.Size = new System.Drawing.Size(97, 23);
            this.btnSperren.TabIndex = 24;
            this.btnSperren.Text = "Sperren";
            this.btnSperren.UseVisualStyleBackColor = true;
            this.btnSperren.Click += new System.EventHandler(this.btnSperren_Click);
            // 
            // btnAktivieren
            // 
            this.btnAktivieren.Enabled = false;
            this.btnAktivieren.Location = new System.Drawing.Point(433, 176);
            this.btnAktivieren.Name = "btnAktivieren";
            this.btnAktivieren.Size = new System.Drawing.Size(97, 23);
            this.btnAktivieren.TabIndex = 23;
            this.btnAktivieren.Text = "Aktivieren";
            this.btnAktivieren.UseVisualStyleBackColor = true;
            this.btnAktivieren.Click += new System.EventHandler(this.btnAktivieren_Click);
            // 
            // comBMitarbeiter
            // 
            this.comBMitarbeiter.FormattingEnabled = true;
            this.comBMitarbeiter.Location = new System.Drawing.Point(433, 119);
            this.comBMitarbeiter.Name = "comBMitarbeiter";
            this.comBMitarbeiter.Size = new System.Drawing.Size(121, 21);
            this.comBMitarbeiter.TabIndex = 22;
            this.comBMitarbeiter.SelectedIndexChanged += new System.EventHandler(this.comBMitarbeiter_SelectedIndexChanged);
            // 
            // btnUrlaub
            // 
            this.btnUrlaub.Location = new System.Drawing.Point(433, 292);
            this.btnUrlaub.Name = "btnUrlaub";
            this.btnUrlaub.Size = new System.Drawing.Size(97, 23);
            this.btnUrlaub.TabIndex = 21;
            this.btnUrlaub.Text = "Kalender öffnen";
            this.btnUrlaub.UseVisualStyleBackColor = true;
            this.btnUrlaub.Click += new System.EventHandler(this.btnUrlaub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chefmenü";
            // 
            // btnFeuern
            // 
            this.btnFeuern.Enabled = false;
            this.btnFeuern.Location = new System.Drawing.Point(433, 146);
            this.btnFeuern.Name = "btnFeuern";
            this.btnFeuern.Size = new System.Drawing.Size(97, 23);
            this.btnFeuern.TabIndex = 19;
            this.btnFeuern.Text = "Feuern";
            this.btnFeuern.UseVisualStyleBackColor = true;
            this.btnFeuern.Click += new System.EventHandler(this.btnFeuern_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chBWebsite);
            this.Controls.Add(this.txBWebsite);
            this.Controls.Add(this.btnEinsehen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUrlaubstage);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbLArbeitstage);
            this.Controls.Add(this.btnSperren);
            this.Controls.Add(this.btnAktivieren);
            this.Controls.Add(this.comBMitarbeiter);
            this.Controls.Add(this.btnUrlaub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFeuern);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.numUrlaubstage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chBWebsite;
        private System.Windows.Forms.TextBox txBWebsite;
        private System.Windows.Forms.Button btnEinsehen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUrlaubstage;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chbLArbeitstage;
        private System.Windows.Forms.Button btnSperren;
        private System.Windows.Forms.Button btnAktivieren;
        private System.Windows.Forms.ComboBox comBMitarbeiter;
        private System.Windows.Forms.Button btnUrlaub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFeuern;
    }
}