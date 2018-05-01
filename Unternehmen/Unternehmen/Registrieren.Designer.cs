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
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Firmen_Motto = new System.Windows.Forms.Label();
            this.Logo_Picturebox = new System.Windows.Forms.PictureBox();
            this.Panel_right = new System.Windows.Forms.Panel();
            this.rbtnWoman = new System.Windows.Forms.RadioButton();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.lbFehlermeldung = new System.Windows.Forms.Label();
            this.btnHochladen = new System.Windows.Forms.Button();
            this.cBoxJahr = new System.Windows.Forms.ComboBox();
            this.cBoxMonat = new System.Windows.Forms.ComboBox();
            this.cBoxTag = new System.Windows.Forms.ComboBox();
            this.pcBProfilbild = new System.Windows.Forms.PictureBox();
            this.Beenden_Label = new System.Windows.Forms.Label();
            this.Termsandconditions_Label = new System.Windows.Forms.Label();
            this.TermsandConditionsCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txBPasswort2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Passwort_Label = new System.Windows.Forms.Label();
            this.txBPasswort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Geburtstag_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.txBBenutzername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Ownername_Label = new System.Windows.Forms.Label();
            this.txBInhaber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Sign_Up_Label = new System.Windows.Forms.Label();
            this.Panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Picturebox)).BeginInit();
            this.Panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfilbild)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnRegistrieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrieren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrieren.ForeColor = System.Drawing.Color.White;
            this.btnRegistrieren.Location = new System.Drawing.Point(350, 605);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(300, 38);
            this.btnRegistrieren.TabIndex = 7;
            this.btnRegistrieren.Text = "Sign Up";
            this.btnRegistrieren.UseVisualStyleBackColor = false;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegistrieren_Click);
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
            this.Panel_Left.Size = new System.Drawing.Size(325, 707);
            this.Panel_Left.TabIndex = 10;
            this.Panel_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseDown);
            this.Panel_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseMove);
            this.Panel_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseUp);
            // 
            // Firmen_Motto
            // 
            this.Firmen_Motto.AutoSize = true;
            this.Firmen_Motto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firmen_Motto.ForeColor = System.Drawing.Color.White;
            this.Firmen_Motto.Location = new System.Drawing.Point(49, 386);
            this.Firmen_Motto.Name = "Firmen_Motto";
            this.Firmen_Motto.Size = new System.Drawing.Size(223, 50);
            this.Firmen_Motto.TabIndex = 4;
            this.Firmen_Motto.Text = "We Create, We Plan \r\n       in your Way";
            // 
            // Logo_Picturebox
            // 
            this.Logo_Picturebox.Image = global::Unternehmen.Properties.Resources.japanese_kanji;
            this.Logo_Picturebox.Location = new System.Drawing.Point(54, 168);
            this.Logo_Picturebox.Name = "Logo_Picturebox";
            this.Logo_Picturebox.Size = new System.Drawing.Size(200, 200);
            this.Logo_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_Picturebox.TabIndex = 0;
            this.Logo_Picturebox.TabStop = false;
            // 
            // Panel_right
            // 
            this.Panel_right.BackColor = System.Drawing.Color.White;
            this.Panel_right.Controls.Add(this.rbtnWoman);
            this.Panel_right.Controls.Add(this.rbtnMan);
            this.Panel_right.Controls.Add(this.lbFehlermeldung);
            this.Panel_right.Controls.Add(this.btnHochladen);
            this.Panel_right.Controls.Add(this.cBoxJahr);
            this.Panel_right.Controls.Add(this.cBoxMonat);
            this.Panel_right.Controls.Add(this.cBoxTag);
            this.Panel_right.Controls.Add(this.pcBProfilbild);
            this.Panel_right.Controls.Add(this.Beenden_Label);
            this.Panel_right.Controls.Add(this.Termsandconditions_Label);
            this.Panel_right.Controls.Add(this.TermsandConditionsCheckbox);
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
            this.Panel_right.Controls.Add(this.btnRegistrieren);
            this.Panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_right.Location = new System.Drawing.Point(0, 0);
            this.Panel_right.Name = "Panel_right";
            this.Panel_right.Size = new System.Drawing.Size(682, 707);
            this.Panel_right.TabIndex = 11;
            this.Panel_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseDown);
            this.Panel_right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseMove);
            this.Panel_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseUp);
            // 
            // rbtnWoman
            // 
            this.rbtnWoman.AutoSize = true;
            this.rbtnWoman.Location = new System.Drawing.Point(406, 115);
            this.rbtnWoman.Name = "rbtnWoman";
            this.rbtnWoman.Size = new System.Drawing.Size(59, 17);
            this.rbtnWoman.TabIndex = 35;
            this.rbtnWoman.TabStop = true;
            this.rbtnWoman.Text = "Female";
            this.rbtnWoman.UseVisualStyleBackColor = true;
            this.rbtnWoman.CheckedChanged += new System.EventHandler(this.rbtnWoman_CheckedChanged);
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Location = new System.Drawing.Point(354, 115);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(48, 17);
            this.rbtnMan.TabIndex = 34;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "Male";
            this.rbtnMan.UseVisualStyleBackColor = true;
            this.rbtnMan.CheckedChanged += new System.EventHandler(this.rbtnMan_CheckedChanged);
            // 
            // lbFehlermeldung
            // 
            this.lbFehlermeldung.AutoSize = true;
            this.lbFehlermeldung.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFehlermeldung.ForeColor = System.Drawing.Color.Red;
            this.lbFehlermeldung.Location = new System.Drawing.Point(350, 549);
            this.lbFehlermeldung.Name = "lbFehlermeldung";
            this.lbFehlermeldung.Size = new System.Drawing.Size(36, 16);
            this.lbFehlermeldung.TabIndex = 33;
            this.lbFehlermeldung.Text = "Error";
            // 
            // btnHochladen
            // 
            this.btnHochladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnHochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHochladen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHochladen.ForeColor = System.Drawing.Color.White;
            this.btnHochladen.Location = new System.Drawing.Point(350, 65);
            this.btnHochladen.Name = "btnHochladen";
            this.btnHochladen.Size = new System.Drawing.Size(139, 25);
            this.btnHochladen.TabIndex = 32;
            this.btnHochladen.Text = "Profilbild hochladen";
            this.btnHochladen.UseVisualStyleBackColor = false;
            this.btnHochladen.Click += new System.EventHandler(this.btnHochladen_Click);
            // 
            // cBoxJahr
            // 
            this.cBoxJahr.FormattingEnabled = true;
            this.cBoxJahr.Location = new System.Drawing.Point(551, 314);
            this.cBoxJahr.Name = "cBoxJahr";
            this.cBoxJahr.Size = new System.Drawing.Size(121, 21);
            this.cBoxJahr.TabIndex = 31;
            // 
            // cBoxMonat
            // 
            this.cBoxMonat.FormattingEnabled = true;
            this.cBoxMonat.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "Juli",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cBoxMonat.Location = new System.Drawing.Point(418, 314);
            this.cBoxMonat.Name = "cBoxMonat";
            this.cBoxMonat.Size = new System.Drawing.Size(121, 21);
            this.cBoxMonat.TabIndex = 30;
            this.cBoxMonat.SelectedIndexChanged += new System.EventHandler(this.cBoxMonat_SelectedIndexChanged);
            // 
            // cBoxTag
            // 
            this.cBoxTag.FormattingEnabled = true;
            this.cBoxTag.Location = new System.Drawing.Point(353, 314);
            this.cBoxTag.Name = "cBoxTag";
            this.cBoxTag.Size = new System.Drawing.Size(49, 21);
            this.cBoxTag.TabIndex = 29;
            // 
            // pcBProfilbild
            // 
            this.pcBProfilbild.Location = new System.Drawing.Point(531, 22);
            this.pcBProfilbild.Name = "pcBProfilbild";
            this.pcBProfilbild.Size = new System.Drawing.Size(100, 100);
            this.pcBProfilbild.TabIndex = 28;
            this.pcBProfilbild.TabStop = false;
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
            // Termsandconditions_Label
            // 
            this.Termsandconditions_Label.AutoSize = true;
            this.Termsandconditions_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Termsandconditions_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Termsandconditions_Label.Location = new System.Drawing.Point(393, 568);
            this.Termsandconditions_Label.Name = "Termsandconditions_Label";
            this.Termsandconditions_Label.Size = new System.Drawing.Size(238, 20);
            this.Termsandconditions_Label.TabIndex = 26;
            this.Termsandconditions_Label.Text = "I Agree Terms and Conditions";
            // 
            // TermsandConditionsCheckbox
            // 
            this.TermsandConditionsCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.TermsandConditionsCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.TermsandConditionsCheckbox.Checked = false;
            this.TermsandConditionsCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.TermsandConditionsCheckbox.ForeColor = System.Drawing.Color.White;
            this.TermsandConditionsCheckbox.Location = new System.Drawing.Point(351, 568);
            this.TermsandConditionsCheckbox.Name = "TermsandConditionsCheckbox";
            this.TermsandConditionsCheckbox.Size = new System.Drawing.Size(20, 20);
            this.TermsandConditionsCheckbox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(348, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Repeat Password:";
            // 
            // txBPasswort2
            // 
            this.txBPasswort2.BackColor = System.Drawing.Color.White;
            this.txBPasswort2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBPasswort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswort2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswort2.ForeColor = System.Drawing.Color.Black;
            this.txBPasswort2.HintForeColor = System.Drawing.Color.Black;
            this.txBPasswort2.HintText = "";
            this.txBPasswort2.isPassword = true;
            this.txBPasswort2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineThickness = 3;
            this.txBPasswort2.Location = new System.Drawing.Point(351, 445);
            this.txBPasswort2.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswort2.Name = "txBPasswort2";
            this.txBPasswort2.Size = new System.Drawing.Size(300, 33);
            this.txBPasswort2.TabIndex = 21;
            this.txBPasswort2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Passwort_Label
            // 
            this.Passwort_Label.AutoSize = true;
            this.Passwort_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwort_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Passwort_Label.Location = new System.Drawing.Point(348, 351);
            this.Passwort_Label.Name = "Passwort_Label";
            this.Passwort_Label.Size = new System.Drawing.Size(85, 20);
            this.Passwort_Label.TabIndex = 20;
            this.Passwort_Label.Text = "Password:";
            // 
            // txBPasswort
            // 
            this.txBPasswort.BackColor = System.Drawing.Color.White;
            this.txBPasswort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txBPasswort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswort.ForeColor = System.Drawing.Color.Black;
            this.txBPasswort.HintForeColor = System.Drawing.Color.Black;
            this.txBPasswort.HintText = "";
            this.txBPasswort.isPassword = true;
            this.txBPasswort.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineThickness = 3;
            this.txBPasswort.Location = new System.Drawing.Point(351, 375);
            this.txBPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswort.Name = "txBPasswort";
            this.txBPasswort.Size = new System.Drawing.Size(300, 33);
            this.txBPasswort.TabIndex = 19;
            this.txBPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Geburtstag_Label
            // 
            this.Geburtstag_Label.AutoSize = true;
            this.Geburtstag_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geburtstag_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Geburtstag_Label.Location = new System.Drawing.Point(348, 290);
            this.Geburtstag_Label.Name = "Geburtstag_Label";
            this.Geburtstag_Label.Size = new System.Drawing.Size(77, 20);
            this.Geburtstag_Label.TabIndex = 16;
            this.Geburtstag_Label.Text = "Birthday:";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Username_Label.Location = new System.Drawing.Point(347, 222);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(91, 20);
            this.Username_Label.TabIndex = 14;
            this.Username_Label.Text = "Username:";
            // 
            // txBBenutzername
            // 
            this.txBBenutzername.BackColor = System.Drawing.Color.White;
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
            this.txBBenutzername.Location = new System.Drawing.Point(350, 246);
            this.txBBenutzername.Margin = new System.Windows.Forms.Padding(4);
            this.txBBenutzername.Name = "txBBenutzername";
            this.txBBenutzername.Size = new System.Drawing.Size(300, 33);
            this.txBBenutzername.TabIndex = 13;
            this.txBBenutzername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Ownername_Label
            // 
            this.Ownername_Label.AutoSize = true;
            this.Ownername_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ownername_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Ownername_Label.Location = new System.Drawing.Point(346, 135);
            this.Ownername_Label.Name = "Ownername_Label";
            this.Ownername_Label.Size = new System.Drawing.Size(112, 20);
            this.Ownername_Label.TabIndex = 12;
            this.Ownername_Label.Text = "Ownername:";
            // 
            // txBInhaber
            // 
            this.txBInhaber.BackColor = System.Drawing.Color.White;
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
            this.txBInhaber.Location = new System.Drawing.Point(350, 159);
            this.txBInhaber.Margin = new System.Windows.Forms.Padding(4);
            this.txBInhaber.Name = "txBInhaber";
            this.txBInhaber.Size = new System.Drawing.Size(300, 33);
            this.txBInhaber.TabIndex = 11;
            this.txBInhaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Sign_Up_Label
            // 
            this.Sign_Up_Label.AutoSize = true;
            this.Sign_Up_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Sign_Up_Label.Location = new System.Drawing.Point(348, 22);
            this.Sign_Up_Label.Name = "Sign_Up_Label";
            this.Sign_Up_Label.Size = new System.Drawing.Size(92, 25);
            this.Sign_Up_Label.TabIndex = 10;
            this.Sign_Up_Label.Text = "Sign Up";
            // 
            // Registrieren
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 707);
            this.Controls.Add(this.Panel_Left);
            this.Controls.Add(this.Panel_right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrieren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrieren";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Registrieren_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Registrieren_DragEnter);
            this.Panel_Left.ResumeLayout(false);
            this.Panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Picturebox)).EndInit();
            this.Panel_right.ResumeLayout(false);
            this.Panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfilbild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrieren;
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
        private System.Windows.Forms.Label Beenden_Label;
        private System.Windows.Forms.PictureBox pcBProfilbild;
        private System.Windows.Forms.ComboBox cBoxJahr;
        private System.Windows.Forms.ComboBox cBoxMonat;
        private System.Windows.Forms.ComboBox cBoxTag;
        private System.Windows.Forms.Button btnHochladen;
        private System.Windows.Forms.Label lbFehlermeldung;
        private System.Windows.Forms.RadioButton rbtnWoman;
        private System.Windows.Forms.RadioButton rbtnMan;
    }
}