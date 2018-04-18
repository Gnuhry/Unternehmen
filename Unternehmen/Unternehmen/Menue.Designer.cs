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
            this.btnAnwesend = new System.Windows.Forms.Button();
            this.btnGehen = new System.Windows.Forms.Button();
            this.btnZeiten = new System.Windows.Forms.Button();
            this.numKrankentage = new System.Windows.Forms.NumericUpDown();
            this.lbStatus = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Messenger_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Firmenname_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Firmenlogo_pictureBox = new System.Windows.Forms.PictureBox();
            this.KalenderButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Daten_andern_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Webseite_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Krankentage_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Beenden_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Firmenlogo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnwesend
            // 
            this.btnAnwesend.Location = new System.Drawing.Point(601, 209);
            this.btnAnwesend.Name = "btnAnwesend";
            this.btnAnwesend.Size = new System.Drawing.Size(150, 23);
            this.btnAnwesend.TabIndex = 2;
            this.btnAnwesend.Text = "Anwesend";
            this.btnAnwesend.UseVisualStyleBackColor = true;
            this.btnAnwesend.Click += new System.EventHandler(this.btnAnwesend_Click);
            // 
            // btnGehen
            // 
            this.btnGehen.Location = new System.Drawing.Point(601, 238);
            this.btnGehen.Name = "btnGehen";
            this.btnGehen.Size = new System.Drawing.Size(150, 23);
            this.btnGehen.TabIndex = 3;
            this.btnGehen.Text = "Gehen";
            this.btnGehen.UseVisualStyleBackColor = true;
            this.btnGehen.Click += new System.EventHandler(this.btnGehen_Click);
            // 
            // btnZeiten
            // 
            this.btnZeiten.Location = new System.Drawing.Point(601, 268);
            this.btnZeiten.Name = "btnZeiten";
            this.btnZeiten.Size = new System.Drawing.Size(149, 23);
            this.btnZeiten.TabIndex = 4;
            this.btnZeiten.Text = "Zeiten einsehen";
            this.btnZeiten.UseVisualStyleBackColor = true;
            this.btnZeiten.Click += new System.EventHandler(this.btnZeiten_Click);
            // 
            // numKrankentage
            // 
            this.numKrankentage.Location = new System.Drawing.Point(601, 297);
            this.numKrankentage.Name = "numKrankentage";
            this.numKrankentage.Size = new System.Drawing.Size(54, 21);
            this.numKrankentage.TabIndex = 5;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(614, 193);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "label1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 124);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.Beenden_Button);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Controls.Add(this.Krankentage_Button);
            this.panel2.Controls.Add(this.Webseite_Button);
            this.panel2.Controls.Add(this.Daten_andern_Button);
            this.panel2.Controls.Add(this.KalenderButton);
            this.panel2.Controls.Add(this.Messenger_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 441);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.Firmenlogo_pictureBox);
            this.panel3.Controls.Add(this.Firmenname_Label);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 124);
            this.panel3.TabIndex = 0;
            // 
            // Messenger_Button
            // 
            this.Messenger_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Messenger_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Messenger_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Messenger_Button.BorderRadius = 0;
            this.Messenger_Button.ButtonText = "Messenger";
            this.Messenger_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Messenger_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Messenger_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Messenger_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Messenger_Button.Iconimage = null;
            this.Messenger_Button.Iconimage_right = null;
            this.Messenger_Button.Iconimage_right_Selected = null;
            this.Messenger_Button.Iconimage_Selected = null;
            this.Messenger_Button.IconMarginLeft = 0;
            this.Messenger_Button.IconMarginRight = 0;
            this.Messenger_Button.IconRightVisible = true;
            this.Messenger_Button.IconRightZoom = 0D;
            this.Messenger_Button.IconVisible = true;
            this.Messenger_Button.IconZoom = 90D;
            this.Messenger_Button.IsTab = false;
            this.Messenger_Button.Location = new System.Drawing.Point(0, 0);
            this.Messenger_Button.Name = "Messenger_Button";
            this.Messenger_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Messenger_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Messenger_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.Messenger_Button.selected = false;
            this.Messenger_Button.Size = new System.Drawing.Size(233, 48);
            this.Messenger_Button.TabIndex = 3;
            this.Messenger_Button.Text = "Messenger";
            this.Messenger_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Messenger_Button.Textcolor = System.Drawing.Color.White;
            this.Messenger_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messenger_Button.Click += new System.EventHandler(this.btnMessenger_Click);
            // 
            // Firmenname_Label
            // 
            this.Firmenname_Label.AutoSize = true;
            this.Firmenname_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firmenname_Label.ForeColor = System.Drawing.Color.White;
            this.Firmenname_Label.Location = new System.Drawing.Point(99, 52);
            this.Firmenname_Label.Name = "Firmenname_Label";
            this.Firmenname_Label.Size = new System.Drawing.Size(92, 25);
            this.Firmenname_Label.TabIndex = 0;
            this.Firmenname_Label.Text = "FirmaXY";
            // 
            // Firmenlogo_pictureBox
            // 
            this.Firmenlogo_pictureBox.Image = global::Unternehmen.Properties.Resources.gold_ingots;
            this.Firmenlogo_pictureBox.Location = new System.Drawing.Point(43, 37);
            this.Firmenlogo_pictureBox.Name = "Firmenlogo_pictureBox";
            this.Firmenlogo_pictureBox.Size = new System.Drawing.Size(50, 50);
            this.Firmenlogo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Firmenlogo_pictureBox.TabIndex = 1;
            this.Firmenlogo_pictureBox.TabStop = false;
            // 
            // KalenderButton
            // 
            this.KalenderButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.KalenderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.KalenderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KalenderButton.BorderRadius = 0;
            this.KalenderButton.ButtonText = "Kalender";
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
            this.KalenderButton.Text = "Kalender";
            this.KalenderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KalenderButton.Textcolor = System.Drawing.Color.White;
            this.KalenderButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KalenderButton.Click += new System.EventHandler(this.btnKalender_Click);
            // 
            // Daten_andern_Button
            // 
            this.Daten_andern_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Daten_andern_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Daten_andern_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Daten_andern_Button.BorderRadius = 0;
            this.Daten_andern_Button.ButtonText = "Daten ändern";
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
            this.Daten_andern_Button.Text = "Daten ändern";
            this.Daten_andern_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Daten_andern_Button.Textcolor = System.Drawing.Color.White;
            this.Daten_andern_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daten_andern_Button.Click += new System.EventHandler(this.btnAndern_Click);
            // 
            // Webseite_Button
            // 
            this.Webseite_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Webseite_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Webseite_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Webseite_Button.BorderRadius = 0;
            this.Webseite_Button.ButtonText = "Webseite";
            this.Webseite_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Webseite_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Webseite_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Webseite_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Webseite_Button.Iconimage = null;
            this.Webseite_Button.Iconimage_right = null;
            this.Webseite_Button.Iconimage_right_Selected = null;
            this.Webseite_Button.Iconimage_Selected = null;
            this.Webseite_Button.IconMarginLeft = 0;
            this.Webseite_Button.IconMarginRight = 0;
            this.Webseite_Button.IconRightVisible = true;
            this.Webseite_Button.IconRightZoom = 0D;
            this.Webseite_Button.IconVisible = true;
            this.Webseite_Button.IconZoom = 90D;
            this.Webseite_Button.IsTab = false;
            this.Webseite_Button.Location = new System.Drawing.Point(0, 144);
            this.Webseite_Button.Name = "Webseite_Button";
            this.Webseite_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Webseite_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Webseite_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.Webseite_Button.selected = false;
            this.Webseite_Button.Size = new System.Drawing.Size(233, 48);
            this.Webseite_Button.TabIndex = 6;
            this.Webseite_Button.Text = "Webseite";
            this.Webseite_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Webseite_Button.Textcolor = System.Drawing.Color.White;
            this.Webseite_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Webseite_Button.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // Krankentage_Button
            // 
            this.Krankentage_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Krankentage_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Krankentage_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Krankentage_Button.BorderRadius = 0;
            this.Krankentage_Button.ButtonText = "Krankentage";
            this.Krankentage_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Krankentage_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Krankentage_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Krankentage_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Krankentage_Button.Iconimage = null;
            this.Krankentage_Button.Iconimage_right = null;
            this.Krankentage_Button.Iconimage_right_Selected = null;
            this.Krankentage_Button.Iconimage_Selected = null;
            this.Krankentage_Button.IconMarginLeft = 0;
            this.Krankentage_Button.IconMarginRight = 0;
            this.Krankentage_Button.IconRightVisible = true;
            this.Krankentage_Button.IconRightZoom = 0D;
            this.Krankentage_Button.IconVisible = true;
            this.Krankentage_Button.IconZoom = 90D;
            this.Krankentage_Button.IsTab = false;
            this.Krankentage_Button.Location = new System.Drawing.Point(0, 192);
            this.Krankentage_Button.Name = "Krankentage_Button";
            this.Krankentage_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Krankentage_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Krankentage_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.Krankentage_Button.selected = false;
            this.Krankentage_Button.Size = new System.Drawing.Size(233, 48);
            this.Krankentage_Button.TabIndex = 7;
            this.Krankentage_Button.Text = "Krankentage";
            this.Krankentage_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Krankentage_Button.Textcolor = System.Drawing.Color.White;
            this.Krankentage_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Krankentage_Button.Click += new System.EventHandler(this.btnKrankentage_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "BeispielButton";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 240);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(233, 48);
            this.bunifuFlatButton4.TabIndex = 8;
            this.bunifuFlatButton4.Text = "BeispielButton";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Beenden_Button
            // 
            this.Beenden_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Beenden_Button.BorderRadius = 0;
            this.Beenden_Button.ButtonText = "Beenden";
            this.Beenden_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beenden_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Beenden_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Beenden_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Beenden_Button.Iconimage = null;
            this.Beenden_Button.Iconimage_right = null;
            this.Beenden_Button.Iconimage_right_Selected = null;
            this.Beenden_Button.Iconimage_Selected = null;
            this.Beenden_Button.IconMarginLeft = 0;
            this.Beenden_Button.IconMarginRight = 0;
            this.Beenden_Button.IconRightVisible = true;
            this.Beenden_Button.IconRightZoom = 0D;
            this.Beenden_Button.IconVisible = true;
            this.Beenden_Button.IconZoom = 90D;
            this.Beenden_Button.IsTab = false;
            this.Beenden_Button.Location = new System.Drawing.Point(0, 393);
            this.Beenden_Button.Name = "Beenden_Button";
            this.Beenden_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Beenden_Button.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(180)))));
            this.Beenden_Button.selected = false;
            this.Beenden_Button.Size = new System.Drawing.Size(233, 48);
            this.Beenden_Button.TabIndex = 9;
            this.Beenden_Button.Text = "Beenden";
            this.Beenden_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Beenden_Button.Textcolor = System.Drawing.Color.White;
            this.Beenden_Button.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beenden_Button.Click += new System.EventHandler(this.Beenden_Button_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(288, 52);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Menü";
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.numKrankentage);
            this.Controls.Add(this.btnZeiten);
            this.Controls.Add(this.btnGehen);
            this.Controls.Add(this.btnAnwesend);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menue";
            this.Text = "Menue";
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Firmenlogo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnwesend;
        private System.Windows.Forms.Button btnGehen;
        private System.Windows.Forms.Button btnZeiten;
        private System.Windows.Forms.NumericUpDown numKrankentage;
        private System.Windows.Forms.Label lbStatus;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Messenger_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Firmenlogo_pictureBox;
        private Bunifu.Framework.UI.BunifuCustomLabel Firmenname_Label;
        private Bunifu.Framework.UI.BunifuFlatButton KalenderButton;
        private Bunifu.Framework.UI.BunifuFlatButton Beenden_Button;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton Krankentage_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Webseite_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Daten_andern_Button;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}