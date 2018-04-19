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
            this.components = new System.ComponentModel.Container();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.btnLoschen = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Firmen_Motto = new System.Windows.Forms.Label();
            this.Logo_Picturebox = new System.Windows.Forms.PictureBox();
            this.Panel_right = new System.Windows.Forms.Panel();
            this.Sign_Up_Label = new System.Windows.Forms.Label();
            this.Ownername_Label = new System.Windows.Forms.Label();
            this.txBInhaber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.txBBenutzername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Geburtstag_Label = new System.Windows.Forms.Label();
            this.Passwort_Label = new System.Windows.Forms.Label();
            this.txBPasswort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txBPasswort2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.New_Password_Label = new System.Windows.Forms.Label();
            this.txBPasswortA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TermsandConditionsCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Termsandconditions_Label = new System.Windows.Forms.Label();
            this.Beenden_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.Panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Picturebox)).BeginInit();
            this.Panel_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(348, 255);
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(66, 20);
            this.numDay.TabIndex = 4;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(499, 255);
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(70, 20);
            this.numYear.TabIndex = 5;
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(420, 255);
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(73, 20);
            this.numMonth.TabIndex = 6;
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnRegistrieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrieren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrieren.ForeColor = System.Drawing.Color.White;
            this.btnRegistrieren.Location = new System.Drawing.Point(348, 535);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(300, 38);
            this.btnRegistrieren.TabIndex = 7;
            this.btnRegistrieren.Text = "Sign Up";
            this.btnRegistrieren.UseVisualStyleBackColor = false;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegistrieren_Click);
            // 
            // btnLoschen
            // 
            this.btnLoschen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnLoschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoschen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoschen.ForeColor = System.Drawing.Color.White;
            this.btnLoschen.Location = new System.Drawing.Point(349, 592);
            this.btnLoschen.Name = "btnLoschen";
            this.btnLoschen.Size = new System.Drawing.Size(299, 38);
            this.btnLoschen.TabIndex = 9;
            this.btnLoschen.Text = "Delete";
            this.btnLoschen.UseVisualStyleBackColor = false;
            this.btnLoschen.Visible = false;
            this.btnLoschen.Click += new System.EventHandler(this.btnLoschen_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Panel_Left.Controls.Add(this.Firmen_Motto);
            this.Panel_Left.Controls.Add(this.Logo_Picturebox);
            this.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(325, 658);
            this.Panel_Left.TabIndex = 10;
            // 
            // Firmen_Motto
            // 
            this.Firmen_Motto.AutoSize = true;
            this.Firmen_Motto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firmen_Motto.ForeColor = System.Drawing.Color.White;
            this.Firmen_Motto.Location = new System.Drawing.Point(49, 325);
            this.Firmen_Motto.Name = "Firmen_Motto";
            this.Firmen_Motto.Size = new System.Drawing.Size(223, 50);
            this.Firmen_Motto.TabIndex = 4;
            this.Firmen_Motto.Text = "We Create, We Plan \r\n       in your Way";
            // 
            // Logo_Picturebox
            // 
            this.Logo_Picturebox.Image = global::Unternehmen.Properties.Resources.japanese_kanji;
            this.Logo_Picturebox.Location = new System.Drawing.Point(54, 110);
            this.Logo_Picturebox.Name = "Logo_Picturebox";
            this.Logo_Picturebox.Size = new System.Drawing.Size(200, 200);
            this.Logo_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_Picturebox.TabIndex = 0;
            this.Logo_Picturebox.TabStop = false;
            // 
            // Panel_right
            // 
            this.Panel_right.Controls.Add(this.Beenden_Label);
            this.Panel_right.Controls.Add(this.Termsandconditions_Label);
            this.Panel_right.Controls.Add(this.TermsandConditionsCheckbox);
            this.Panel_right.Controls.Add(this.New_Password_Label);
            this.Panel_right.Controls.Add(this.txBPasswortA);
            this.Panel_right.Controls.Add(this.label1);
            this.Panel_right.Controls.Add(this.txBPasswort2);
            this.Panel_right.Controls.Add(this.Passwort_Label);
            this.Panel_right.Controls.Add(this.txBPasswort);
            this.Panel_right.Controls.Add(this.Geburtstag_Label);
            this.Panel_right.Controls.Add(this.Username_Label);
            this.Panel_right.Controls.Add(this.txBBenutzername);
            this.Panel_right.Controls.Add(this.Ownername_Label);
            this.Panel_right.Controls.Add(this.txBInhaber);
            this.Panel_right.Controls.Add(this.Sign_Up_Label);
            this.Panel_right.Controls.Add(this.numDay);
            this.Panel_right.Controls.Add(this.numYear);
            this.Panel_right.Controls.Add(this.numMonth);
            this.Panel_right.Controls.Add(this.btnLoschen);
            this.Panel_right.Controls.Add(this.btnRegistrieren);
            this.Panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_right.Location = new System.Drawing.Point(0, 0);
            this.Panel_right.Name = "Panel_right";
            this.Panel_right.Size = new System.Drawing.Size(683, 658);
            this.Panel_right.TabIndex = 11;
            // 
            // Sign_Up_Label
            // 
            this.Sign_Up_Label.AutoSize = true;
            this.Sign_Up_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Sign_Up_Label.Location = new System.Drawing.Point(344, 40);
            this.Sign_Up_Label.Name = "Sign_Up_Label";
            this.Sign_Up_Label.Size = new System.Drawing.Size(92, 25);
            this.Sign_Up_Label.TabIndex = 10;
            this.Sign_Up_Label.Text = "Sign Up";
            // 
            // Ownername_Label
            // 
            this.Ownername_Label.AutoSize = true;
            this.Ownername_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ownername_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Ownername_Label.Location = new System.Drawing.Point(344, 75);
            this.Ownername_Label.Name = "Ownername_Label";
            this.Ownername_Label.Size = new System.Drawing.Size(112, 20);
            this.Ownername_Label.TabIndex = 12;
            this.Ownername_Label.Text = "Ownername:";
            // 
            // txBInhaber
            // 
            this.txBInhaber.BackColor = System.Drawing.SystemColors.Control;
            this.txBInhaber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBInhaber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBInhaber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBInhaber.ForeColor = System.Drawing.Color.Black;
            this.txBInhaber.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.txBInhaber.HintText = "Ownername";
            this.txBInhaber.isPassword = false;
            this.txBInhaber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBInhaber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBInhaber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBInhaber.LineThickness = 3;
            this.txBInhaber.Location = new System.Drawing.Point(348, 99);
            this.txBInhaber.Margin = new System.Windows.Forms.Padding(4);
            this.txBInhaber.Name = "txBInhaber";
            this.txBInhaber.Size = new System.Drawing.Size(300, 33);
            this.txBInhaber.TabIndex = 11;
            this.txBInhaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Username_Label.Location = new System.Drawing.Point(345, 146);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(91, 20);
            this.Username_Label.TabIndex = 14;
            this.Username_Label.Text = "Username:";
            // 
            // txBBenutzername
            // 
            this.txBBenutzername.BackColor = System.Drawing.SystemColors.Control;
            this.txBBenutzername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBBenutzername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBBenutzername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBBenutzername.ForeColor = System.Drawing.Color.Black;
            this.txBBenutzername.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.txBBenutzername.HintText = "Username";
            this.txBBenutzername.isPassword = false;
            this.txBBenutzername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBenutzername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBenutzername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBenutzername.LineThickness = 3;
            this.txBBenutzername.Location = new System.Drawing.Point(348, 170);
            this.txBBenutzername.Margin = new System.Windows.Forms.Padding(4);
            this.txBBenutzername.Name = "txBBenutzername";
            this.txBBenutzername.Size = new System.Drawing.Size(300, 33);
            this.txBBenutzername.TabIndex = 13;
            this.txBBenutzername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Geburtstag_Label
            // 
            this.Geburtstag_Label.AutoSize = true;
            this.Geburtstag_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geburtstag_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Geburtstag_Label.Location = new System.Drawing.Point(345, 217);
            this.Geburtstag_Label.Name = "Geburtstag_Label";
            this.Geburtstag_Label.Size = new System.Drawing.Size(77, 20);
            this.Geburtstag_Label.TabIndex = 16;
            this.Geburtstag_Label.Text = "Birthday:";
            // 
            // Passwort_Label
            // 
            this.Passwort_Label.AutoSize = true;
            this.Passwort_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwort_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Passwort_Label.Location = new System.Drawing.Point(345, 278);
            this.Passwort_Label.Name = "Passwort_Label";
            this.Passwort_Label.Size = new System.Drawing.Size(85, 20);
            this.Passwort_Label.TabIndex = 20;
            this.Passwort_Label.Text = "Password:";
            // 
            // txBPasswort
            // 
            this.txBPasswort.BackColor = System.Drawing.SystemColors.Control;
            this.txBPasswort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBPasswort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswort.ForeColor = System.Drawing.Color.Black;
            this.txBPasswort.HintForeColor = System.Drawing.Color.Transparent;
            this.txBPasswort.HintText = "";
            this.txBPasswort.isPassword = true;
            this.txBPasswort.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineThickness = 3;
            this.txBPasswort.Location = new System.Drawing.Point(348, 302);
            this.txBPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswort.Name = "txBPasswort";
            this.txBPasswort.Size = new System.Drawing.Size(300, 33);
            this.txBPasswort.TabIndex = 19;
            this.txBPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(345, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Repeat Password:";
            // 
            // txBPasswort2
            // 
            this.txBPasswort2.BackColor = System.Drawing.SystemColors.Control;
            this.txBPasswort2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBPasswort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswort2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswort2.ForeColor = System.Drawing.Color.Black;
            this.txBPasswort2.HintForeColor = System.Drawing.Color.Transparent;
            this.txBPasswort2.HintText = "";
            this.txBPasswort2.isPassword = true;
            this.txBPasswort2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineThickness = 3;
            this.txBPasswort2.Location = new System.Drawing.Point(348, 372);
            this.txBPasswort2.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswort2.Name = "txBPasswort2";
            this.txBPasswort2.Size = new System.Drawing.Size(300, 33);
            this.txBPasswort2.TabIndex = 21;
            this.txBPasswort2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // New_Password_Label
            // 
            this.New_Password_Label.AutoSize = true;
            this.New_Password_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Password_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.New_Password_Label.Location = new System.Drawing.Point(345, 416);
            this.New_Password_Label.Name = "New_Password_Label";
            this.New_Password_Label.Size = new System.Drawing.Size(125, 20);
            this.New_Password_Label.TabIndex = 24;
            this.New_Password_Label.Text = "New Password:";
            this.New_Password_Label.Visible = false;
            // 
            // txBPasswortA
            // 
            this.txBPasswortA.BackColor = System.Drawing.SystemColors.Control;
            this.txBPasswortA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBPasswortA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswortA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswortA.ForeColor = System.Drawing.Color.Black;
            this.txBPasswortA.HintForeColor = System.Drawing.Color.Transparent;
            this.txBPasswortA.HintText = "";
            this.txBPasswortA.isPassword = true;
            this.txBPasswortA.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswortA.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswortA.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswortA.LineThickness = 3;
            this.txBPasswortA.Location = new System.Drawing.Point(348, 440);
            this.txBPasswortA.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswortA.Name = "txBPasswortA";
            this.txBPasswortA.Size = new System.Drawing.Size(300, 33);
            this.txBPasswortA.TabIndex = 23;
            this.txBPasswortA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txBPasswortA.Visible = false;
            // 
            // TermsandConditionsCheckbox
            // 
            this.TermsandConditionsCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.TermsandConditionsCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.TermsandConditionsCheckbox.Checked = true;
            this.TermsandConditionsCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.TermsandConditionsCheckbox.ForeColor = System.Drawing.Color.White;
            this.TermsandConditionsCheckbox.Location = new System.Drawing.Point(369, 497);
            this.TermsandConditionsCheckbox.Name = "TermsandConditionsCheckbox";
            this.TermsandConditionsCheckbox.Size = new System.Drawing.Size(20, 20);
            this.TermsandConditionsCheckbox.TabIndex = 25;
            // 
            // Termsandconditions_Label
            // 
            this.Termsandconditions_Label.AutoSize = true;
            this.Termsandconditions_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Termsandconditions_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Termsandconditions_Label.Location = new System.Drawing.Point(395, 497);
            this.Termsandconditions_Label.Name = "Termsandconditions_Label";
            this.Termsandconditions_Label.Size = new System.Drawing.Size(238, 20);
            this.Termsandconditions_Label.TabIndex = 26;
            this.Termsandconditions_Label.Text = "I Agree Terms and Conditions";
            // 
            // Beenden_Label
            // 
            this.Beenden_Label.AutoSize = true;
            this.Beenden_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beenden_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Beenden_Label.Location = new System.Drawing.Point(654, 7);
            this.Beenden_Label.Name = "Beenden_Label";
            this.Beenden_Label.Size = new System.Drawing.Size(22, 25);
            this.Beenden_Label.TabIndex = 27;
            this.Beenden_Label.Text = "x";
            this.Beenden_Label.Click += new System.EventHandler(this.Beenden_Label_Click);
            // 
            // Registrieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 658);
            this.Controls.Add(this.Panel_Left);
            this.Controls.Add(this.Panel_right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrieren";
            this.Text = "Registrieren";
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.Panel_Left.ResumeLayout(false);
            this.Panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Picturebox)).EndInit();
            this.Panel_right.ResumeLayout(false);
            this.Panel_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.Button btnLoschen;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.Label Firmen_Motto;
        private System.Windows.Forms.PictureBox Logo_Picturebox;
        private System.Windows.Forms.Panel Panel_right;
        private System.Windows.Forms.Label Sign_Up_Label;
        private System.Windows.Forms.Label Ownername_Label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBInhaber;
        private System.Windows.Forms.Label Username_Label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBBenutzername;
        private System.Windows.Forms.Label Geburtstag_Label;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBPasswort2;
        private System.Windows.Forms.Label Passwort_Label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBPasswort;
        private System.Windows.Forms.Label Termsandconditions_Label;
        private Bunifu.Framework.UI.BunifuCheckbox TermsandConditionsCheckbox;
        private System.Windows.Forms.Label New_Password_Label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBPasswortA;
        private System.Windows.Forms.Label Beenden_Label;
    }
}