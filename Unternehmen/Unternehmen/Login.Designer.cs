﻿namespace Unternehmen
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Firmen_Motto = new System.Windows.Forms.Label();
            this.Logo_Picturebox = new System.Windows.Forms.PictureBox();
            this.Panel_Right = new System.Windows.Forms.Panel();
            this.lbFehlermeldung = new System.Windows.Forms.Label();
            this.Beenden_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Log_In_Label = new System.Windows.Forms.Label();
            this.txBbenutzername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txBpasswort = new System.Windows.Forms.TextBox();
            this.Panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Picturebox)).BeginInit();
            this.Panel_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnRegistrieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrieren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrieren.ForeColor = System.Drawing.Color.White;
            this.btnRegistrieren.Location = new System.Drawing.Point(30, 480);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(300, 38);
            this.btnRegistrieren.TabIndex = 2;
            this.btnRegistrieren.Text = "Sign Up";
            this.btnRegistrieren.UseVisualStyleBackColor = false;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegistrieren_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 404);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.Panel_Left.Size = new System.Drawing.Size(325, 557);
            this.Panel_Left.TabIndex = 4;
            this.Panel_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseDown);
            this.Panel_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Right_MouseMove);
            this.Panel_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseUp);
            // 
            // Firmen_Motto
            // 
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
            // Panel_Right
            // 
            this.Panel_Right.BackColor = System.Drawing.Color.White;
            this.Panel_Right.Controls.Add(this.panel2);
            this.Panel_Right.Controls.Add(this.txBpasswort);
            this.Panel_Right.Controls.Add(this.panel1);
            this.Panel_Right.Controls.Add(this.txBbenutzername);
            this.Panel_Right.Controls.Add(this.lbFehlermeldung);
            this.Panel_Right.Controls.Add(this.Beenden_Label);
            this.Panel_Right.Controls.Add(this.Password_Label);
            this.Panel_Right.Controls.Add(this.btnRegistrieren);
            this.Panel_Right.Controls.Add(this.btnLogin);
            this.Panel_Right.Controls.Add(this.Username_Label);
            this.Panel_Right.Controls.Add(this.Log_In_Label);
            this.Panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Right.Location = new System.Drawing.Point(325, 0);
            this.Panel_Right.Name = "Panel_Right";
            this.Panel_Right.Size = new System.Drawing.Size(358, 557);
            this.Panel_Right.TabIndex = 5;
            this.Panel_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseDown);
            this.Panel_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Right_MouseMove);
            this.Panel_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Left_MouseUp);
            // 
            // lbFehlermeldung
            // 
            this.lbFehlermeldung.AutoSize = true;
            this.lbFehlermeldung.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFehlermeldung.ForeColor = System.Drawing.Color.Red;
            this.lbFehlermeldung.Location = new System.Drawing.Point(3, 345);
            this.lbFehlermeldung.Name = "lbFehlermeldung";
            this.lbFehlermeldung.Size = new System.Drawing.Size(36, 17);
            this.lbFehlermeldung.TabIndex = 29;
            this.lbFehlermeldung.Text = "Error";
            // 
            // Beenden_Label
            // 
            this.Beenden_Label.AutoSize = true;
            this.Beenden_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beenden_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Beenden_Label.Location = new System.Drawing.Point(330, 4);
            this.Beenden_Label.Name = "Beenden_Label";
            this.Beenden_Label.Size = new System.Drawing.Size(20, 24);
            this.Beenden_Label.TabIndex = 28;
            this.Beenden_Label.Text = "x";
            this.Beenden_Label.Click += new System.EventHandler(this.Beenden_Label_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Password_Label.Location = new System.Drawing.Point(26, 227);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(86, 21);
            this.Password_Label.TabIndex = 8;
            this.Password_Label.Text = "Password:";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Username_Label.Location = new System.Drawing.Point(26, 131);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(92, 21);
            this.Username_Label.TabIndex = 6;
            this.Username_Label.Text = "Username:";
            // 
            // Log_In_Label
            // 
            this.Log_In_Label.AutoSize = true;
            this.Log_In_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.Log_In_Label.Location = new System.Drawing.Point(25, 54);
            this.Log_In_Label.Name = "Log_In_Label";
            this.Log_In_Label.Size = new System.Drawing.Size(72, 25);
            this.Log_In_Label.TabIndex = 4;
            this.Log_In_Label.Text = "Log in";
            // 
            // txBbenutzername
            // 
            this.txBbenutzername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBbenutzername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBbenutzername.Location = new System.Drawing.Point(30, 158);
            this.txBbenutzername.Name = "txBbenutzername";
            this.txBbenutzername.Size = new System.Drawing.Size(300, 15);
            this.txBbenutzername.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(30, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 3);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(30, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 3);
            this.panel2.TabIndex = 33;
            // 
            // txBpasswort
            // 
            this.txBpasswort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBpasswort.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBpasswort.Location = new System.Drawing.Point(30, 252);
            this.txBpasswort.Name = "txBpasswort";
            this.txBpasswort.PasswordChar = '*';
            this.txBpasswort.Size = new System.Drawing.Size(300, 15);
            this.txBpasswort.TabIndex = 32;
            this.txBpasswort.UseSystemPasswordChar = true;
            this.txBpasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBpasswort_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 557);
            this.Controls.Add(this.Panel_Right);
            this.Controls.Add(this.Panel_Left);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Picturebox)).EndInit();
            this.Panel_Right.ResumeLayout(false);
            this.Panel_Right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.Button btnLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.PictureBox Logo_Picturebox;
        private System.Windows.Forms.Panel Panel_Right;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Log_In_Label;
        private System.Windows.Forms.Label Firmen_Motto;
        private System.Windows.Forms.Label Beenden_Label;
        private System.Windows.Forms.Label lbFehlermeldung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txBbenutzername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txBpasswort;
    }
}