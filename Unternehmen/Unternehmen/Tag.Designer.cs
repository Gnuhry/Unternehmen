namespace Unternehmen
{
    partial class Tag
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
            this.label5 = new System.Windows.Forms.Label();
            this.txBGNtz = new System.Windows.Forms.TextBox();
            this.lbFeiertag = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZuruck = new System.Windows.Forms.Button();
            this.btnVor = new System.Windows.Forms.Button();
            this.lbGeburtstag = new System.Windows.Forms.Label();
            this.txBNotizen = new System.Windows.Forms.TextBox();
            this.lbUrlaub = new System.Windows.Forms.Label();
            this.lbKrank = new System.Windows.Forms.Label();
            this.lbWochentag = new System.Windows.Forms.Label();
            this.chBLUrlaub = new System.Windows.Forms.CheckedListBox();
            this.chBeFeiertag = new System.Windows.Forms.CheckBox();
            this.txBeFeiertag = new System.Windows.Forms.TextBox();
            this.LBTagesplan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Globale Notizen:";
            // 
            // txBGNtz
            // 
            this.txBGNtz.Location = new System.Drawing.Point(241, 274);
            this.txBGNtz.Multiline = true;
            this.txBGNtz.Name = "txBGNtz";
            this.txBGNtz.Size = new System.Drawing.Size(100, 70);
            this.txBGNtz.TabIndex = 29;
            // 
            // lbFeiertag
            // 
            this.lbFeiertag.AutoSize = true;
            this.lbFeiertag.Location = new System.Drawing.Point(202, 108);
            this.lbFeiertag.Name = "lbFeiertag";
            this.lbFeiertag.Size = new System.Drawing.Size(44, 13);
            this.lbFeiertag.TabIndex = 28;
            this.lbFeiertag.Text = "Neujahr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Notizen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Geburtstag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Urlaub:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Krank:";
            // 
            // btnZuruck
            // 
            this.btnZuruck.Location = new System.Drawing.Point(105, 80);
            this.btnZuruck.Name = "btnZuruck";
            this.btnZuruck.Size = new System.Drawing.Size(25, 23);
            this.btnZuruck.TabIndex = 23;
            this.btnZuruck.Text = "<";
            this.btnZuruck.UseVisualStyleBackColor = true;
            this.btnZuruck.Click += new System.EventHandler(this.btnZuruck_Click);
            // 
            // btnVor
            // 
            this.btnVor.Location = new System.Drawing.Point(345, 80);
            this.btnVor.Name = "btnVor";
            this.btnVor.Size = new System.Drawing.Size(28, 23);
            this.btnVor.TabIndex = 22;
            this.btnVor.Text = ">";
            this.btnVor.UseVisualStyleBackColor = true;
            this.btnVor.Click += new System.EventHandler(this.btnVor_Click);
            // 
            // lbGeburtstag
            // 
            this.lbGeburtstag.AutoSize = true;
            this.lbGeburtstag.Location = new System.Drawing.Point(112, 331);
            this.lbGeburtstag.Name = "lbGeburtstag";
            this.lbGeburtstag.Size = new System.Drawing.Size(67, 26);
            this.lbGeburtstag.TabIndex = 21;
            this.lbGeburtstag.Text = "Lennard (18)\r\nLukas (19)\r\n";
            // 
            // txBNotizen
            // 
            this.txBNotizen.Location = new System.Drawing.Point(243, 152);
            this.txBNotizen.Multiline = true;
            this.txBNotizen.Name = "txBNotizen";
            this.txBNotizen.Size = new System.Drawing.Size(100, 100);
            this.txBNotizen.TabIndex = 20;
            // 
            // lbUrlaub
            // 
            this.lbUrlaub.AutoSize = true;
            this.lbUrlaub.Location = new System.Drawing.Point(126, 255);
            this.lbUrlaub.Name = "lbUrlaub";
            this.lbUrlaub.Size = new System.Drawing.Size(36, 39);
            this.lbUrlaub.TabIndex = 19;
            this.lbUrlaub.Text = "Timon\r\nJonas\r\nFelix\r\n";
            // 
            // lbKrank
            // 
            this.lbKrank.AutoSize = true;
            this.lbKrank.Location = new System.Drawing.Point(114, 148);
            this.lbKrank.Name = "lbKrank";
            this.lbKrank.Size = new System.Drawing.Size(42, 65);
            this.lbKrank.TabIndex = 18;
            this.lbKrank.Text = "Günter\r\nHerbert\r\nKlaus\r\nMickey\r\nMax K.";
            // 
            // lbWochentag
            // 
            this.lbWochentag.AutoSize = true;
            this.lbWochentag.Location = new System.Drawing.Point(179, 80);
            this.lbWochentag.Name = "lbWochentag";
            this.lbWochentag.Size = new System.Drawing.Size(114, 13);
            this.lbWochentag.TabIndex = 17;
            this.lbWochentag.Text = "Montag 1.Januar 2000";
            // 
            // chBLUrlaub
            // 
            this.chBLUrlaub.FormattingEnabled = true;
            this.chBLUrlaub.Location = new System.Drawing.Point(105, 251);
            this.chBLUrlaub.Name = "chBLUrlaub";
            this.chBLUrlaub.Size = new System.Drawing.Size(68, 49);
            this.chBLUrlaub.TabIndex = 31;
            this.chBLUrlaub.Visible = false;
            this.chBLUrlaub.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chBLUrlaub_ItemCheck);
            // 
            // chBeFeiertag
            // 
            this.chBeFeiertag.AutoSize = true;
            this.chBeFeiertag.Location = new System.Drawing.Point(129, 36);
            this.chBeFeiertag.Name = "chBeFeiertag";
            this.chBeFeiertag.Size = new System.Drawing.Size(80, 17);
            this.chBeFeiertag.TabIndex = 32;
            this.chBeFeiertag.Text = "checkBox1";
            this.chBeFeiertag.UseVisualStyleBackColor = true;
            this.chBeFeiertag.Visible = false;
            this.chBeFeiertag.CheckedChanged += new System.EventHandler(this.chBeFeiertag_CheckedChanged);
            // 
            // txBeFeiertag
            // 
            this.txBeFeiertag.Location = new System.Drawing.Point(216, 36);
            this.txBeFeiertag.Name = "txBeFeiertag";
            this.txBeFeiertag.Size = new System.Drawing.Size(100, 20);
            this.txBeFeiertag.TabIndex = 33;
            this.txBeFeiertag.Visible = false;
            this.txBeFeiertag.TextChanged += new System.EventHandler(this.txBeFeiertag_TextChanged);
            // 
            // LBTagesplan
            // 
            this.LBTagesplan.FormattingEnabled = true;
            this.LBTagesplan.Location = new System.Drawing.Point(403, 148);
            this.LBTagesplan.Name = "LBTagesplan";
            this.LBTagesplan.Size = new System.Drawing.Size(218, 95);
            this.LBTagesplan.TabIndex = 34;
            this.LBTagesplan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBTagesplan_MouseDoubleClick);
            // 
            // Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBTagesplan);
            this.Controls.Add(this.txBeFeiertag);
            this.Controls.Add(this.chBeFeiertag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txBGNtz);
            this.Controls.Add(this.lbFeiertag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZuruck);
            this.Controls.Add(this.btnVor);
            this.Controls.Add(this.lbGeburtstag);
            this.Controls.Add(this.txBNotizen);
            this.Controls.Add(this.lbUrlaub);
            this.Controls.Add(this.lbKrank);
            this.Controls.Add(this.lbWochentag);
            this.Controls.Add(this.chBLUrlaub);
            this.Name = "Tag";
            this.Text = "Tag";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tag_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBGNtz;
        private System.Windows.Forms.Label lbFeiertag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZuruck;
        private System.Windows.Forms.Button btnVor;
        private System.Windows.Forms.Label lbGeburtstag;
        private System.Windows.Forms.TextBox txBNotizen;
        private System.Windows.Forms.Label lbUrlaub;
        private System.Windows.Forms.Label lbKrank;
        private System.Windows.Forms.Label lbWochentag;
        private System.Windows.Forms.CheckedListBox chBLUrlaub;
        private System.Windows.Forms.CheckBox chBeFeiertag;
        private System.Windows.Forms.TextBox txBeFeiertag;
        private System.Windows.Forms.ListBox LBTagesplan;
    }
}