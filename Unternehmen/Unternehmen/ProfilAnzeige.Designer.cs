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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAbteilung = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbHobby = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbGeburtstag = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pcBProfil = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txBTelefon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txBHobbys = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txBInhaber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txBEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txBAbteilung = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txBPasswortA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txBPasswort2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txBPasswort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txBBenutzername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxJahr = new System.Windows.Forms.ComboBox();
            this.cBoxMonat = new System.Windows.Forms.ComboBox();
            this.cBoxTag = new System.Windows.Forms.ComboBox();
            this.lbFehlermeldung = new System.Windows.Forms.Label();
            this.btnAndern = new System.Windows.Forms.Button();
            this.txBStatus = new System.Windows.Forms.TextBox();
            this.btnProfilbildHochladen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfil)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInhaber
            // 
            this.lbInhaber.AutoSize = true;
            this.lbInhaber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInhaber.Location = new System.Drawing.Point(12, 21);
            this.lbInhaber.Name = "lbInhaber";
            this.lbInhaber.Size = new System.Drawing.Size(164, 22);
            this.lbInhaber.TabIndex = 1;
            this.lbInhaber.Text = "Max Lukas Stolz";
            this.lbInhaber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbInhaber.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbInhaber.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Edit profile";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbAbteilung);
            this.panel2.Controls.Add(this.lbTelefon);
            this.panel2.Controls.Add(this.lbHobby);
            this.panel2.Controls.Add(this.lbEmail);
            this.panel2.Controls.Add(this.lbGeburtstag);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.lbInhaber);
            this.panel2.Controls.Add(this.pcBProfil);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 393);
            this.panel2.TabIndex = 3;
            // 
            // lbAbteilung
            // 
            this.lbAbteilung.AutoSize = true;
            this.lbAbteilung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbteilung.Location = new System.Drawing.Point(278, 139);
            this.lbAbteilung.Name = "lbAbteilung";
            this.lbAbteilung.Size = new System.Drawing.Size(81, 20);
            this.lbAbteilung.TabIndex = 7;
            this.lbAbteilung.Text = "ELEKtriker";
            this.lbAbteilung.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbAbteilung.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbAbteilung.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefon.Location = new System.Drawing.Point(12, 130);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(117, 20);
            this.lbTelefon.TabIndex = 6;
            this.lbTelefon.Text = "015209440971";
            this.lbTelefon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbTelefon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbTelefon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // lbHobby
            // 
            this.lbHobby.AutoSize = true;
            this.lbHobby.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHobby.Location = new System.Drawing.Point(10, 172);
            this.lbHobby.Name = "lbHobby";
            this.lbHobby.Size = new System.Drawing.Size(288, 20);
            this.lbHobby.TabIndex = 5;
            this.lbHobby.Text = "Hobbies:Schwimmen und Basketball";
            this.lbHobby.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbHobby.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbHobby.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 98);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(206, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email: Trottel@blödian.de";
            this.lbEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbEmail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbEmail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // lbGeburtstag
            // 
            this.lbGeburtstag.AutoSize = true;
            this.lbGeburtstag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeburtstag.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbGeburtstag.Location = new System.Drawing.Point(12, 48);
            this.lbGeburtstag.Name = "lbGeburtstag";
            this.lbGeburtstag.Size = new System.Drawing.Size(89, 20);
            this.lbGeburtstag.TabIndex = 3;
            this.lbGeburtstag.Text = "24.01.2000";
            this.lbGeburtstag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbGeburtstag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbGeburtstag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(97, 252);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(161, 20);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Ich Lebe wie ich will";
            this.lbStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.lbStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.lbStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // pcBProfil
            // 
            this.pcBProfil.Location = new System.Drawing.Point(258, 6);
            this.pcBProfil.Name = "pcBProfil";
            this.pcBProfil.Size = new System.Drawing.Size(130, 130);
            this.pcBProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBProfil.TabIndex = 0;
            this.pcBProfil.TabStop = false;
            this.pcBProfil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseDown);
            this.pcBProfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseMove);
            this.pcBProfil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bewegen_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txBTelefon);
            this.panel3.Controls.Add(this.txBHobbys);
            this.panel3.Controls.Add(this.txBInhaber);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txBEmail);
            this.panel3.Controls.Add(this.txBAbteilung);
            this.panel3.Controls.Add(this.txBPasswortA);
            this.panel3.Controls.Add(this.txBPasswort2);
            this.panel3.Controls.Add(this.txBPasswort);
            this.panel3.Controls.Add(this.txBBenutzername);
            this.panel3.Controls.Add(this.cBoxJahr);
            this.panel3.Controls.Add(this.cBoxMonat);
            this.panel3.Controls.Add(this.cBoxTag);
            this.panel3.Controls.Add(this.lbFehlermeldung);
            this.panel3.Controls.Add(this.btnAndern);
            this.panel3.Controls.Add(this.txBStatus);
            this.panel3.Controls.Add(this.btnProfilbildHochladen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(412, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 393);
            this.panel3.TabIndex = 4;
            // 
            // txBTelefon
            // 
            this.txBTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBTelefon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txBTelefon.HintForeColor = System.Drawing.Color.Silver;
            this.txBTelefon.HintText = "Tele-Number";
            this.txBTelefon.isPassword = false;
            this.txBTelefon.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBTelefon.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBTelefon.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBTelefon.LineThickness = 3;
            this.txBTelefon.Location = new System.Drawing.Point(4, 47);
            this.txBTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txBTelefon.Name = "txBTelefon";
            this.txBTelefon.Size = new System.Drawing.Size(136, 33);
            this.txBTelefon.TabIndex = 50;
            this.txBTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txBHobbys
            // 
            this.txBHobbys.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBHobbys.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBHobbys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txBHobbys.HintForeColor = System.Drawing.Color.Silver;
            this.txBHobbys.HintText = "Hobbies";
            this.txBHobbys.isPassword = false;
            this.txBHobbys.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBHobbys.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBHobbys.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBHobbys.LineThickness = 3;
            this.txBHobbys.Location = new System.Drawing.Point(4, 167);
            this.txBHobbys.Margin = new System.Windows.Forms.Padding(4);
            this.txBHobbys.Name = "txBHobbys";
            this.txBHobbys.Size = new System.Drawing.Size(136, 33);
            this.txBHobbys.TabIndex = 49;
            this.txBHobbys.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txBHobbys.OnValueChanged += new System.EventHandler(this.txBHobbys_TextChanged);
            // 
            // txBInhaber
            // 
            this.txBInhaber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBInhaber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBInhaber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txBInhaber.HintForeColor = System.Drawing.Color.Silver;
            this.txBInhaber.HintText = "Ownername";
            this.txBInhaber.isPassword = false;
            this.txBInhaber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBInhaber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBInhaber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBInhaber.LineThickness = 3;
            this.txBInhaber.Location = new System.Drawing.Point(4, 10);
            this.txBInhaber.Margin = new System.Windows.Forms.Padding(4);
            this.txBInhaber.Name = "txBInhaber";
            this.txBInhaber.Size = new System.Drawing.Size(136, 33);
            this.txBInhaber.TabIndex = 48;
            this.txBInhaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txBInhaber.OnValueChanged += new System.EventHandler(this.txBInhaber_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Status";
            // 
            // txBEmail
            // 
            this.txBEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txBEmail.HintForeColor = System.Drawing.Color.Silver;
            this.txBEmail.HintText = "Email";
            this.txBEmail.isPassword = false;
            this.txBEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBEmail.LineThickness = 3;
            this.txBEmail.Location = new System.Drawing.Point(4, 126);
            this.txBEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txBEmail.Name = "txBEmail";
            this.txBEmail.Size = new System.Drawing.Size(136, 33);
            this.txBEmail.TabIndex = 46;
            this.txBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txBEmail.OnValueChanged += new System.EventHandler(this.txBEmail_TextChanged);
            // 
            // txBAbteilung
            // 
            this.txBAbteilung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBAbteilung.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBAbteilung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txBAbteilung.HintForeColor = System.Drawing.Color.Silver;
            this.txBAbteilung.HintText = "Job Name";
            this.txBAbteilung.isPassword = false;
            this.txBAbteilung.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBAbteilung.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBAbteilung.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBAbteilung.LineThickness = 3;
            this.txBAbteilung.Location = new System.Drawing.Point(4, 85);
            this.txBAbteilung.Margin = new System.Windows.Forms.Padding(4);
            this.txBAbteilung.Name = "txBAbteilung";
            this.txBAbteilung.Size = new System.Drawing.Size(136, 33);
            this.txBAbteilung.TabIndex = 45;
            this.txBAbteilung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txBAbteilung.OnValueChanged += new System.EventHandler(this.txBAbteilung_TextChanged);
            // 
            // txBPasswortA
            // 
            this.txBPasswortA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswortA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswortA.ForeColor = System.Drawing.Color.Black;
            this.txBPasswortA.HintForeColor = System.Drawing.Color.Silver;
            this.txBPasswortA.HintText = "Old Password";
            this.txBPasswortA.isPassword = false;
            this.txBPasswortA.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswortA.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswortA.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswortA.LineThickness = 3;
            this.txBPasswortA.Location = new System.Drawing.Point(240, 46);
            this.txBPasswortA.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswortA.Name = "txBPasswortA";
            this.txBPasswortA.Size = new System.Drawing.Size(136, 33);
            this.txBPasswortA.TabIndex = 43;
            this.txBPasswortA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txBPasswort2
            // 
            this.txBPasswort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswort2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswort2.ForeColor = System.Drawing.Color.Black;
            this.txBPasswort2.HintForeColor = System.Drawing.Color.Silver;
            this.txBPasswort2.HintText = "Repeat Password";
            this.txBPasswort2.isPassword = false;
            this.txBPasswort2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort2.LineThickness = 3;
            this.txBPasswort2.Location = new System.Drawing.Point(240, 125);
            this.txBPasswort2.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswort2.Name = "txBPasswort2";
            this.txBPasswort2.Size = new System.Drawing.Size(136, 33);
            this.txBPasswort2.TabIndex = 42;
            this.txBPasswort2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txBPasswort
            // 
            this.txBPasswort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBPasswort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBPasswort.ForeColor = System.Drawing.Color.Black;
            this.txBPasswort.HintForeColor = System.Drawing.Color.Silver;
            this.txBPasswort.HintText = "Password";
            this.txBPasswort.isPassword = false;
            this.txBPasswort.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBPasswort.LineThickness = 3;
            this.txBPasswort.Location = new System.Drawing.Point(240, 84);
            this.txBPasswort.Margin = new System.Windows.Forms.Padding(4);
            this.txBPasswort.Name = "txBPasswort";
            this.txBPasswort.Size = new System.Drawing.Size(136, 33);
            this.txBPasswort.TabIndex = 41;
            this.txBPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txBBenutzername
            // 
            this.txBBenutzername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBBenutzername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBBenutzername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txBBenutzername.HintForeColor = System.Drawing.Color.Silver;
            this.txBBenutzername.HintText = "Username";
            this.txBBenutzername.isPassword = false;
            this.txBBenutzername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBenutzername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBenutzername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBenutzername.LineThickness = 3;
            this.txBBenutzername.Location = new System.Drawing.Point(240, 8);
            this.txBBenutzername.Margin = new System.Windows.Forms.Padding(4);
            this.txBBenutzername.Name = "txBBenutzername";
            this.txBBenutzername.Size = new System.Drawing.Size(136, 33);
            this.txBBenutzername.TabIndex = 40;
            this.txBBenutzername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cBoxJahr
            // 
            this.cBoxJahr.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxJahr.FormattingEnabled = true;
            this.cBoxJahr.Location = new System.Drawing.Point(5, 261);
            this.cBoxJahr.Name = "cBoxJahr";
            this.cBoxJahr.Size = new System.Drawing.Size(121, 21);
            this.cBoxJahr.TabIndex = 34;
            this.cBoxJahr.SelectedIndexChanged += new System.EventHandler(this.cBoxJahr_SelectedIndexChanged);
            // 
            // cBoxMonat
            // 
            this.cBoxMonat.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cBoxMonat.Location = new System.Drawing.Point(5, 234);
            this.cBoxMonat.Name = "cBoxMonat";
            this.cBoxMonat.Size = new System.Drawing.Size(121, 21);
            this.cBoxMonat.TabIndex = 33;
            this.cBoxMonat.SelectedIndexChanged += new System.EventHandler(this.cBoxMonat_SelectedIndexChanged);
            // 
            // cBoxTag
            // 
            this.cBoxTag.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTag.FormattingEnabled = true;
            this.cBoxTag.Location = new System.Drawing.Point(5, 207);
            this.cBoxTag.Name = "cBoxTag";
            this.cBoxTag.Size = new System.Drawing.Size(49, 21);
            this.cBoxTag.TabIndex = 32;
            this.cBoxTag.SelectedIndexChanged += new System.EventHandler(this.cBoxTag_SelectedIndexChanged);
            // 
            // lbFehlermeldung
            // 
            this.lbFehlermeldung.AutoSize = true;
            this.lbFehlermeldung.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFehlermeldung.ForeColor = System.Drawing.Color.Red;
            this.lbFehlermeldung.Location = new System.Drawing.Point(3, 317);
            this.lbFehlermeldung.Name = "lbFehlermeldung";
            this.lbFehlermeldung.Size = new System.Drawing.Size(36, 16);
            this.lbFehlermeldung.TabIndex = 8;
            this.lbFehlermeldung.Text = "Error";
            // 
            // btnAndern
            // 
            this.btnAndern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnAndern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAndern.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndern.ForeColor = System.Drawing.Color.White;
            this.btnAndern.Location = new System.Drawing.Point(240, 163);
            this.btnAndern.Name = "btnAndern";
            this.btnAndern.Size = new System.Drawing.Size(136, 34);
            this.btnAndern.TabIndex = 7;
            this.btnAndern.Text = "Change Password";
            this.btnAndern.UseVisualStyleBackColor = false;
            this.btnAndern.Click += new System.EventHandler(this.btnAndern_Click);
            // 
            // txBStatus
            // 
            this.txBStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBStatus.Location = new System.Drawing.Point(276, 223);
            this.txBStatus.Multiline = true;
            this.txBStatus.Name = "txBStatus";
            this.txBStatus.Size = new System.Drawing.Size(100, 85);
            this.txBStatus.TabIndex = 6;
            this.txBStatus.TextChanged += new System.EventHandler(this.txBStatus_TextChanged);
            // 
            // btnProfilbildHochladen
            // 
            this.btnProfilbildHochladen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnProfilbildHochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilbildHochladen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilbildHochladen.ForeColor = System.Drawing.Color.White;
            this.btnProfilbildHochladen.Location = new System.Drawing.Point(240, 328);
            this.btnProfilbildHochladen.Name = "btnProfilbildHochladen";
            this.btnProfilbildHochladen.Size = new System.Drawing.Size(136, 34);
            this.btnProfilbildHochladen.TabIndex = 5;
            this.btnProfilbildHochladen.Text = "Upload";
            this.btnProfilbildHochladen.UseVisualStyleBackColor = false;
            this.btnProfilbildHochladen.Click += new System.EventHandler(this.btnProfilbildHochladen_Click);
            // 
            // ProfilAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilAnzeige";
            this.Text = "ProfilAnzeige";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfilAnzeige_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnAndern;
        private System.Windows.Forms.Label lbFehlermeldung;
        private System.Windows.Forms.Label lbGeburtstag;
        private System.Windows.Forms.ComboBox cBoxJahr;
        private System.Windows.Forms.ComboBox cBoxMonat;
        private System.Windows.Forms.ComboBox cBoxTag;
        private System.Windows.Forms.Label lbAbteilung;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbHobby;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBHobbys;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBInhaber;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBAbteilung;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBPasswortA;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBPasswort2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBPasswort;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBBenutzername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txBTelefon;
    }
}