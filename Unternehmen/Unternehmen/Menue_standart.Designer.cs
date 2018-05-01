namespace Unternehmen
{
    partial class Menue_standart
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
            this.btnKrank = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.numKrankentage = new System.Windows.Forms.NumericUpDown();
            this.btnZeiten = new System.Windows.Forms.Button();
            this.btnGehen = new System.Windows.Forms.Button();
            this.btnAnwesend = new System.Windows.Forms.Button();
            this.btnBescheinigung = new System.Windows.Forms.Button();
            this.pcBBescheinigung = new System.Windows.Forms.PictureBox();
            this.lBoxAnzeige = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAbteilung = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbHobby = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbGeburtstag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInhaber = new System.Windows.Forms.Label();
            this.pcBProfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBBescheinigung)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKrank
            // 
            this.btnKrank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnKrank.Enabled = false;
            this.btnKrank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKrank.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKrank.ForeColor = System.Drawing.Color.White;
            this.btnKrank.Location = new System.Drawing.Point(213, 331);
            this.btnKrank.Name = "btnKrank";
            this.btnKrank.Size = new System.Drawing.Size(172, 50);
            this.btnKrank.TabIndex = 20;
            this.btnKrank.Text = "Accept";
            this.btnKrank.UseVisualStyleBackColor = false;
            this.btnKrank.Click += new System.EventHandler(this.btnKrankentage_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(12, 21);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(65, 22);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "Status";
            // 
            // numKrankentage
            // 
            this.numKrankentage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKrankentage.Location = new System.Drawing.Point(331, 166);
            this.numKrankentage.Name = "numKrankentage";
            this.numKrankentage.Size = new System.Drawing.Size(54, 21);
            this.numKrankentage.TabIndex = 18;
            // 
            // btnZeiten
            // 
            this.btnZeiten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnZeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZeiten.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeiten.ForeColor = System.Drawing.Color.White;
            this.btnZeiten.Location = new System.Drawing.Point(3, 123);
            this.btnZeiten.Name = "btnZeiten";
            this.btnZeiten.Size = new System.Drawing.Size(172, 34);
            this.btnZeiten.TabIndex = 17;
            this.btnZeiten.Text = "Check Worktimes";
            this.btnZeiten.UseVisualStyleBackColor = false;
            this.btnZeiten.Click += new System.EventHandler(this.btnZeiten_Click);
            // 
            // btnGehen
            // 
            this.btnGehen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnGehen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGehen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGehen.ForeColor = System.Drawing.Color.White;
            this.btnGehen.Location = new System.Drawing.Point(3, 84);
            this.btnGehen.Name = "btnGehen";
            this.btnGehen.Size = new System.Drawing.Size(172, 34);
            this.btnGehen.TabIndex = 16;
            this.btnGehen.Text = "Absent";
            this.btnGehen.UseVisualStyleBackColor = false;
            this.btnGehen.Click += new System.EventHandler(this.btnGehen_Click);
            // 
            // btnAnwesend
            // 
            this.btnAnwesend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnAnwesend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnwesend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnwesend.ForeColor = System.Drawing.Color.White;
            this.btnAnwesend.Location = new System.Drawing.Point(3, 46);
            this.btnAnwesend.Name = "btnAnwesend";
            this.btnAnwesend.Size = new System.Drawing.Size(172, 34);
            this.btnAnwesend.TabIndex = 15;
            this.btnAnwesend.Text = "Present";
            this.btnAnwesend.UseVisualStyleBackColor = false;
            this.btnAnwesend.Click += new System.EventHandler(this.btnAnwesend_Click);
            // 
            // btnBescheinigung
            // 
            this.btnBescheinigung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnBescheinigung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBescheinigung.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBescheinigung.ForeColor = System.Drawing.Color.White;
            this.btnBescheinigung.Location = new System.Drawing.Point(213, 188);
            this.btnBescheinigung.Name = "btnBescheinigung";
            this.btnBescheinigung.Size = new System.Drawing.Size(172, 58);
            this.btnBescheinigung.TabIndex = 22;
            this.btnBescheinigung.Text = "Upload";
            this.btnBescheinigung.UseVisualStyleBackColor = false;
            this.btnBescheinigung.Click += new System.EventHandler(this.btnBescheinigung_Click);
            // 
            // pcBBescheinigung
            // 
            this.pcBBescheinigung.Location = new System.Drawing.Point(213, 252);
            this.pcBBescheinigung.Name = "pcBBescheinigung";
            this.pcBBescheinigung.Size = new System.Drawing.Size(172, 73);
            this.pcBBescheinigung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBBescheinigung.TabIndex = 23;
            this.pcBBescheinigung.TabStop = false;
            // 
            // lBoxAnzeige
            // 
            this.lBoxAnzeige.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxAnzeige.FormattingEnabled = true;
            this.lBoxAnzeige.ItemHeight = 20;
            this.lBoxAnzeige.Location = new System.Drawing.Point(3, 188);
            this.lBoxAnzeige.Name = "lBoxAnzeige";
            this.lBoxAnzeige.Size = new System.Drawing.Size(172, 164);
            this.lBoxAnzeige.TabIndex = 24;
            this.lBoxAnzeige.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxAnzeige_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(725, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnZeiten);
            this.panel2.Controls.Add(this.btnGehen);
            this.panel2.Controls.Add(this.btnKrank);
            this.panel2.Controls.Add(this.numKrankentage);
            this.panel2.Controls.Add(this.lBoxAnzeige);
            this.panel2.Controls.Add(this.pcBBescheinigung);
            this.panel2.Controls.Add(this.btnBescheinigung);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.btnAnwesend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 393);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbAbteilung);
            this.panel3.Controls.Add(this.lbTelefon);
            this.panel3.Controls.Add(this.lbHobby);
            this.panel3.Controls.Add(this.lbEmail);
            this.panel3.Controls.Add(this.lbGeburtstag);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbInhaber);
            this.panel3.Controls.Add(this.pcBProfil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(394, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 393);
            this.panel3.TabIndex = 27;
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
            // 
            // lbHobby
            // 
            this.lbHobby.AutoSize = true;
            this.lbHobby.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHobby.Location = new System.Drawing.Point(10, 172);
            this.lbHobby.Name = "lbHobby";
            this.lbHobby.Size = new System.Drawing.Size(174, 20);
            this.lbHobby.TabIndex = 5;
            this.lbHobby.Text = "Hobbies: Schwimmen";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status";
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
            // 
            // pcBProfil
            // 
            this.pcBProfil.Location = new System.Drawing.Point(258, 6);
            this.pcBProfil.Name = "pcBProfil";
            this.pcBProfil.Size = new System.Drawing.Size(130, 130);
            this.pcBProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBProfil.TabIndex = 0;
            this.pcBProfil.TabStop = false;
            // 
            // Menue_standart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menue_standart";
            this.Text = "Menue_standart";
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBBescheinigung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKrank;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.NumericUpDown numKrankentage;
        private System.Windows.Forms.Button btnZeiten;
        private System.Windows.Forms.Button btnGehen;
        private System.Windows.Forms.Button btnAnwesend;
        private System.Windows.Forms.Button btnBescheinigung;
        private System.Windows.Forms.PictureBox pcBBescheinigung;
        private System.Windows.Forms.ListBox lBoxAnzeige;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbAbteilung;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbHobby;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbGeburtstag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInhaber;
        private System.Windows.Forms.PictureBox pcBProfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}