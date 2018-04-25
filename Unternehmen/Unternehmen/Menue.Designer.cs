namespace Unternehmen
{
    partial class Menue
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnAktiv = new System.Windows.Forms.Panel();
            this.btnWebsite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMessenger = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Daten_andern_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KalenderButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminPostfach = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminKalender = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Beenden_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Aktive_Form_Name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Firmenlogo_pictureBox = new System.Windows.Forms.PictureBox();
            this.pcBExit = new System.Windows.Forms.PictureBox();
            this.pcBWebsite = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Firmenlogo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBWebsite)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.pnAktiv);
            this.panel2.Controls.Add(this.btnWebsite);
            this.panel2.Controls.Add(this.btnMessenger);
            this.panel2.Controls.Add(this.Daten_andern_Button);
            this.panel2.Controls.Add(this.KalenderButton);
            this.panel2.Controls.Add(this.btnMenue);
            this.panel2.Controls.Add(this.btnAdminPostfach);
            this.panel2.Controls.Add(this.btnAdminKalender);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.Beenden_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 585);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // pnAktiv
            // 
            this.pnAktiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.pnAktiv.Location = new System.Drawing.Point(0, 0);
            this.pnAktiv.Name = "pnAktiv";
            this.pnAktiv.Size = new System.Drawing.Size(5, 48);
            this.pnAktiv.TabIndex = 14;
            // 
            // btnWebsite
            // 
            this.btnWebsite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWebsite.BorderRadius = 0;
            this.btnWebsite.ButtonText = "Website";
            this.btnWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWebsite.DisabledColor = System.Drawing.Color.Gray;
            this.btnWebsite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWebsite.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWebsite.Iconimage = global::Unternehmen.Properties.Resources.wifi;
            this.btnWebsite.Iconimage_right = null;
            this.btnWebsite.Iconimage_right_Selected = null;
            this.btnWebsite.Iconimage_Selected = null;
            this.btnWebsite.IconMarginLeft = 15;
            this.btnWebsite.IconMarginRight = 0;
            this.btnWebsite.IconRightVisible = true;
            this.btnWebsite.IconRightZoom = 0D;
            this.btnWebsite.IconVisible = true;
            this.btnWebsite.IconZoom = 90D;
            this.btnWebsite.IsTab = false;
            this.btnWebsite.Location = new System.Drawing.Point(0, 192);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnWebsite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnWebsite.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.btnWebsite.selected = false;
            this.btnWebsite.Size = new System.Drawing.Size(233, 48);
            this.btnWebsite.TabIndex = 10;
            this.btnWebsite.Text = "Website";
            this.btnWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWebsite.Textcolor = System.Drawing.Color.White;
            this.btnWebsite.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // btnMessenger
            // 
            this.btnMessenger.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMessenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMessenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMessenger.BorderRadius = 0;
            this.btnMessenger.ButtonText = "Messenger";
            this.btnMessenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessenger.DisabledColor = System.Drawing.Color.Gray;
            this.btnMessenger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMessenger.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMessenger.Iconimage = global::Unternehmen.Properties.Resources.speech_bubbles_comment_option;
            this.btnMessenger.Iconimage_right = null;
            this.btnMessenger.Iconimage_right_Selected = null;
            this.btnMessenger.Iconimage_Selected = null;
            this.btnMessenger.IconMarginLeft = 15;
            this.btnMessenger.IconMarginRight = 0;
            this.btnMessenger.IconRightVisible = true;
            this.btnMessenger.IconRightZoom = 0D;
            this.btnMessenger.IconVisible = true;
            this.btnMessenger.IconZoom = 90D;
            this.btnMessenger.IsTab = false;
            this.btnMessenger.Location = new System.Drawing.Point(0, 144);
            this.btnMessenger.Name = "btnMessenger";
            this.btnMessenger.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMessenger.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMessenger.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.btnMessenger.selected = false;
            this.btnMessenger.Size = new System.Drawing.Size(233, 48);
            this.btnMessenger.TabIndex = 7;
            this.btnMessenger.Text = "Messenger";
            this.btnMessenger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMessenger.Textcolor = System.Drawing.Color.White;
            this.btnMessenger.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessenger.Click += new System.EventHandler(this.btnMessenger_Click);
            // 
            // Daten_andern_Button
            // 
            this.Daten_andern_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Daten_andern_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Daten_andern_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Daten_andern_Button.BorderRadius = 0;
            this.Daten_andern_Button.ButtonText = "Edit profile";
            this.Daten_andern_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Daten_andern_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Daten_andern_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Daten_andern_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Daten_andern_Button.Iconimage = null;
            this.Daten_andern_Button.Iconimage_right = null;
            this.Daten_andern_Button.Iconimage_right_Selected = null;
            this.Daten_andern_Button.Iconimage_Selected = null;
            this.Daten_andern_Button.IconMarginLeft = 0;
            this.Daten_andern_Button.IconMarginRight = 0;
            this.Daten_andern_Button.IconRightVisible = true;
            this.Daten_andern_Button.IconRightZoom = 0D;
            this.Daten_andern_Button.IconVisible = true;
            this.Daten_andern_Button.IconZoom = 90D;
            this.Daten_andern_Button.IsTab = false;
            this.Daten_andern_Button.Location = new System.Drawing.Point(0, 96);
            this.Daten_andern_Button.Name = "Daten_andern_Button";
            this.Daten_andern_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Daten_andern_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Daten_andern_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.Daten_andern_Button.selected = false;
            this.Daten_andern_Button.Size = new System.Drawing.Size(233, 48);
            this.Daten_andern_Button.TabIndex = 5;
            this.Daten_andern_Button.Text = "Edit profile";
            this.Daten_andern_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Daten_andern_Button.Textcolor = System.Drawing.Color.White;
            this.Daten_andern_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daten_andern_Button.Click += new System.EventHandler(this.btnAndern_Click);
            // 
            // KalenderButton
            // 
            this.KalenderButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.KalenderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.KalenderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KalenderButton.BorderRadius = 0;
            this.KalenderButton.ButtonText = "Calendar";
            this.KalenderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KalenderButton.DisabledColor = System.Drawing.Color.Gray;
            this.KalenderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.KalenderButton.Iconcolor = System.Drawing.Color.Transparent;
            this.KalenderButton.Iconimage = null;
            this.KalenderButton.Iconimage_right = null;
            this.KalenderButton.Iconimage_right_Selected = null;
            this.KalenderButton.Iconimage_Selected = null;
            this.KalenderButton.IconMarginLeft = 0;
            this.KalenderButton.IconMarginRight = 0;
            this.KalenderButton.IconRightVisible = true;
            this.KalenderButton.IconRightZoom = 0D;
            this.KalenderButton.IconVisible = true;
            this.KalenderButton.IconZoom = 90D;
            this.KalenderButton.IsTab = false;
            this.KalenderButton.Location = new System.Drawing.Point(0, 48);
            this.KalenderButton.Name = "KalenderButton";
            this.KalenderButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.KalenderButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.KalenderButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.KalenderButton.selected = false;
            this.KalenderButton.Size = new System.Drawing.Size(233, 48);
            this.KalenderButton.TabIndex = 4;
            this.KalenderButton.Text = "Calendar";
            this.KalenderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KalenderButton.Textcolor = System.Drawing.Color.White;
            this.KalenderButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KalenderButton.Click += new System.EventHandler(this.btnKalender_Click);
            // 
            // btnMenue
            // 
            this.btnMenue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenue.BorderRadius = 0;
            this.btnMenue.ButtonText = "Dashboard";
            this.btnMenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenue.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenue.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenue.Iconimage = null;
            this.btnMenue.Iconimage_right = null;
            this.btnMenue.Iconimage_right_Selected = null;
            this.btnMenue.Iconimage_Selected = null;
            this.btnMenue.IconMarginLeft = 0;
            this.btnMenue.IconMarginRight = 0;
            this.btnMenue.IconRightVisible = true;
            this.btnMenue.IconRightZoom = 0D;
            this.btnMenue.IconVisible = true;
            this.btnMenue.IconZoom = 90D;
            this.btnMenue.IsTab = false;
            this.btnMenue.Location = new System.Drawing.Point(0, 0);
            this.btnMenue.Name = "btnMenue";
            this.btnMenue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMenue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnMenue.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.btnMenue.selected = false;
            this.btnMenue.Size = new System.Drawing.Size(233, 48);
            this.btnMenue.TabIndex = 3;
            this.btnMenue.Text = "Dashboard";
            this.btnMenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenue.Textcolor = System.Drawing.Color.White;
            this.btnMenue.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenue.Click += new System.EventHandler(this.btnMenue_Click);
            // 
            // btnAdminPostfach
            // 
            this.btnAdminPostfach.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminPostfach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminPostfach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminPostfach.BorderRadius = 0;
            this.btnAdminPostfach.ButtonText = "Admin Messages";
            this.btnAdminPostfach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminPostfach.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminPostfach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdminPostfach.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminPostfach.Iconimage = null;
            this.btnAdminPostfach.Iconimage_right = null;
            this.btnAdminPostfach.Iconimage_right_Selected = null;
            this.btnAdminPostfach.Iconimage_Selected = null;
            this.btnAdminPostfach.IconMarginLeft = 0;
            this.btnAdminPostfach.IconMarginRight = 0;
            this.btnAdminPostfach.IconRightVisible = true;
            this.btnAdminPostfach.IconRightZoom = 0D;
            this.btnAdminPostfach.IconVisible = true;
            this.btnAdminPostfach.IconZoom = 90D;
            this.btnAdminPostfach.IsTab = false;
            this.btnAdminPostfach.Location = new System.Drawing.Point(0, 346);
            this.btnAdminPostfach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdminPostfach.Name = "btnAdminPostfach";
            this.btnAdminPostfach.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminPostfach.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminPostfach.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.btnAdminPostfach.selected = false;
            this.btnAdminPostfach.Size = new System.Drawing.Size(233, 59);
            this.btnAdminPostfach.TabIndex = 18;
            this.btnAdminPostfach.Text = "Admin Messages";
            this.btnAdminPostfach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminPostfach.Textcolor = System.Drawing.Color.White;
            this.btnAdminPostfach.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPostfach.Visible = false;
            this.btnAdminPostfach.Click += new System.EventHandler(this.btnAdminPostfach_Click);
            // 
            // btnAdminKalender
            // 
            this.btnAdminKalender.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminKalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminKalender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminKalender.BorderRadius = 0;
            this.btnAdminKalender.ButtonText = "Admin Calendar";
            this.btnAdminKalender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminKalender.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminKalender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdminKalender.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminKalender.Iconimage = null;
            this.btnAdminKalender.Iconimage_right = null;
            this.btnAdminKalender.Iconimage_right_Selected = null;
            this.btnAdminKalender.Iconimage_Selected = null;
            this.btnAdminKalender.IconMarginLeft = 0;
            this.btnAdminKalender.IconMarginRight = 0;
            this.btnAdminKalender.IconRightVisible = true;
            this.btnAdminKalender.IconRightZoom = 0D;
            this.btnAdminKalender.IconVisible = true;
            this.btnAdminKalender.IconZoom = 90D;
            this.btnAdminKalender.IsTab = false;
            this.btnAdminKalender.Location = new System.Drawing.Point(0, 405);
            this.btnAdminKalender.Name = "btnAdminKalender";
            this.btnAdminKalender.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminKalender.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdminKalender.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.btnAdminKalender.selected = false;
            this.btnAdminKalender.Size = new System.Drawing.Size(233, 73);
            this.btnAdminKalender.TabIndex = 16;
            this.btnAdminKalender.Text = "Admin Calendar";
            this.btnAdminKalender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminKalender.Textcolor = System.Drawing.Color.White;
            this.btnAdminKalender.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminKalender.Visible = false;
            this.btnAdminKalender.Click += new System.EventHandler(this.btnAdminKalender_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = "Admin Dashboard";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = null;
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 90D;
            this.btnAdmin.IsTab = false;
            this.btnAdmin.Location = new System.Drawing.Point(0, 478);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(233, 59);
            this.btnAdmin.TabIndex = 15;
            this.btnAdmin.Text = "Admin Dashboard";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmin.Textcolor = System.Drawing.Color.White;
            this.btnAdmin.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Beenden_Button
            // 
            this.Beenden_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beenden_Button.BorderRadius = 0;
            this.Beenden_Button.ButtonText = "Close";
            this.Beenden_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beenden_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Beenden_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Beenden_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Beenden_Button.Iconimage = global::Unternehmen.Properties.Resources.logout;
            this.Beenden_Button.Iconimage_right = null;
            this.Beenden_Button.Iconimage_right_Selected = null;
            this.Beenden_Button.Iconimage_Selected = null;
            this.Beenden_Button.IconMarginLeft = 15;
            this.Beenden_Button.IconMarginRight = 0;
            this.Beenden_Button.IconRightVisible = true;
            this.Beenden_Button.IconRightZoom = 0D;
            this.Beenden_Button.IconVisible = true;
            this.Beenden_Button.IconZoom = 90D;
            this.Beenden_Button.IsTab = false;
            this.Beenden_Button.Location = new System.Drawing.Point(0, 537);
            this.Beenden_Button.Name = "Beenden_Button";
            this.Beenden_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.Beenden_Button.selected = false;
            this.Beenden_Button.Size = new System.Drawing.Size(233, 48);
            this.Beenden_Button.TabIndex = 9;
            this.Beenden_Button.Text = "Close";
            this.Beenden_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Beenden_Button.Textcolor = System.Drawing.Color.White;
            this.Beenden_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beenden_Button.Click += new System.EventHandler(this.Beenden_Button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel3.Controls.Add(this.Firmenlogo_pictureBox);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 124);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Aktive_Form_Name
            // 
            this.Aktive_Form_Name.AutoSize = true;
            this.Aktive_Form_Name.BackColor = System.Drawing.Color.Transparent;
            this.Aktive_Form_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aktive_Form_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Aktive_Form_Name.Location = new System.Drawing.Point(288, 52);
            this.Aktive_Form_Name.Name = "Aktive_Form_Name";
            this.Aktive_Form_Name.Size = new System.Drawing.Size(123, 24);
            this.Aktive_Form_Name.TabIndex = 1;
            this.Aktive_Form_Name.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pcBWebsite);
            this.panel1.Controls.Add(this.pcBExit);
            this.panel1.Controls.Add(this.Aktive_Form_Name);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 124);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Firmenlogo_pictureBox
            // 
            this.Firmenlogo_pictureBox.Image = global::Unternehmen.Properties.Resources.japanese_kanji;
            this.Firmenlogo_pictureBox.Location = new System.Drawing.Point(70, 18);
            this.Firmenlogo_pictureBox.Name = "Firmenlogo_pictureBox";
            this.Firmenlogo_pictureBox.Size = new System.Drawing.Size(90, 90);
            this.Firmenlogo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Firmenlogo_pictureBox.TabIndex = 1;
            this.Firmenlogo_pictureBox.TabStop = false;
            // 
            // pcBExit
            // 
            this.pcBExit.BackColor = System.Drawing.Color.Red;
            this.pcBExit.Image = global::Unternehmen.Properties.Resources.logout;
            this.pcBExit.Location = new System.Drawing.Point(1103, 52);
            this.pcBExit.Name = "pcBExit";
            this.pcBExit.Size = new System.Drawing.Size(66, 50);
            this.pcBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBExit.TabIndex = 2;
            this.pcBExit.TabStop = false;
            this.pcBExit.Click += new System.EventHandler(this.Beenden_Button_Click);
            // 
            // pcBWebsite
            // 
            this.pcBWebsite.BackColor = System.Drawing.Color.Red;
            this.pcBWebsite.Image = global::Unternehmen.Properties.Resources.wifi;
            this.pcBWebsite.Location = new System.Drawing.Point(1011, 52);
            this.pcBWebsite.Name = "pcBWebsite";
            this.pcBWebsite.Size = new System.Drawing.Size(66, 50);
            this.pcBWebsite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBWebsite.TabIndex = 3;
            this.pcBWebsite.TabStop = false;
            this.pcBWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Menue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menue";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Firmenlogo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBWebsite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenue;
        private Bunifu.Framework.UI.BunifuFlatButton KalenderButton;
        private Bunifu.Framework.UI.BunifuFlatButton Beenden_Button;
        private Bunifu.Framework.UI.BunifuFlatButton btnMessenger;
        private Bunifu.Framework.UI.BunifuFlatButton Daten_andern_Button;
        private Bunifu.Framework.UI.BunifuFlatButton btnWebsite;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Aktive_Form_Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Firmenlogo_pictureBox;
        private System.Windows.Forms.Panel pnAktiv;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminKalender;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminPostfach;
        private System.Windows.Forms.PictureBox pcBWebsite;
        private System.Windows.Forms.PictureBox pcBExit;
    }
}