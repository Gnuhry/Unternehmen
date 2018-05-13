namespace Unternehmen
{
    partial class Termin
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
            this.dTpBis = new System.Windows.Forms.DateTimePicker();
            this.dTPVon = new System.Windows.Forms.DateTimePicker();
            this.btnLoschen = new System.Windows.Forms.Button();
            this.btnFestlegen = new System.Windows.Forms.Button();
            this.txBBeschreibung = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cBoxVonHour = new System.Windows.Forms.ComboBox();
            this.cBoxVonMin = new System.Windows.Forms.ComboBox();
            this.cBoxBisMin = new System.Windows.Forms.ComboBox();
            this.cBoxBisHour = new System.Windows.Forms.ComboBox();
            this.chBMo = new System.Windows.Forms.CheckBox();
            this.chBDienstag = new System.Windows.Forms.CheckBox();
            this.chBDonnerstag = new System.Windows.Forms.CheckBox();
            this.chBMittwoch = new System.Windows.Forms.CheckBox();
            this.chBFreitag = new System.Windows.Forms.CheckBox();
            this.chBSamstag = new System.Windows.Forms.CheckBox();
            this.chBSonntag = new System.Windows.Forms.CheckBox();
            this.chBMonatlich = new System.Windows.Forms.CheckBox();
            this.chBJahrlich = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dTpBis
            // 
            this.dTpBis.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTpBis.Location = new System.Drawing.Point(72, 39);
            this.dTpBis.Name = "dTpBis";
            this.dTpBis.Size = new System.Drawing.Size(200, 21);
            this.dTpBis.TabIndex = 2;
            this.dTpBis.Value = new System.DateTime(2018, 4, 19, 0, 0, 0, 0);
            // 
            // dTPVon
            // 
            this.dTPVon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPVon.Location = new System.Drawing.Point(72, 12);
            this.dTPVon.Name = "dTPVon";
            this.dTPVon.Size = new System.Drawing.Size(200, 21);
            this.dTPVon.TabIndex = 1;
            this.dTPVon.Value = new System.DateTime(2018, 4, 19, 0, 0, 0, 0);
            this.dTPVon.ValueChanged += new System.EventHandler(this.dTPVon_ValueChanged);
            // 
            // btnLoschen
            // 
            this.btnLoschen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnLoschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoschen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoschen.ForeColor = System.Drawing.Color.White;
            this.btnLoschen.Location = new System.Drawing.Point(227, 209);
            this.btnLoschen.Name = "btnLoschen";
            this.btnLoschen.Size = new System.Drawing.Size(172, 34);
            this.btnLoschen.TabIndex = 7;
            this.btnLoschen.Text = "Löschen";
            this.btnLoschen.UseVisualStyleBackColor = false;
            this.btnLoschen.Visible = false;
            this.btnLoschen.Click += new System.EventHandler(this.btnLoschen_Click);
            // 
            // btnFestlegen
            // 
            this.btnFestlegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnFestlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFestlegen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFestlegen.ForeColor = System.Drawing.Color.White;
            this.btnFestlegen.Location = new System.Drawing.Point(36, 209);
            this.btnFestlegen.Name = "btnFestlegen";
            this.btnFestlegen.Size = new System.Drawing.Size(172, 34);
            this.btnFestlegen.TabIndex = 8;
            this.btnFestlegen.Text = "Festlegen";
            this.btnFestlegen.UseVisualStyleBackColor = false;
            this.btnFestlegen.Click += new System.EventHandler(this.btnFestlegen_Click);
            // 
            // txBBeschreibung
            // 
            this.txBBeschreibung.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBeschreibung.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBeschreibung.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txBBeschreibung.BorderThickness = 3;
            this.txBBeschreibung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txBBeschreibung.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txBBeschreibung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txBBeschreibung.isPassword = false;
            this.txBBeschreibung.Location = new System.Drawing.Point(99, 169);
            this.txBBeschreibung.Margin = new System.Windows.Forms.Padding(4);
            this.txBBeschreibung.Name = "txBBeschreibung";
            this.txBBeschreibung.Size = new System.Drawing.Size(256, 33);
            this.txBBeschreibung.TabIndex = 9;
            this.txBBeschreibung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 5);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 257);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(421, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 257);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 5);
            this.panel4.TabIndex = 13;
            // 
            // cBoxVonHour
            // 
            this.cBoxVonHour.FormattingEnabled = true;
            this.cBoxVonHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBoxVonHour.Location = new System.Drawing.Point(287, 12);
            this.cBoxVonHour.Name = "cBoxVonHour";
            this.cBoxVonHour.Size = new System.Drawing.Size(42, 21);
            this.cBoxVonHour.TabIndex = 14;
            // 
            // cBoxVonMin
            // 
            this.cBoxVonMin.FormattingEnabled = true;
            this.cBoxVonMin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBoxVonMin.Location = new System.Drawing.Point(335, 12);
            this.cBoxVonMin.Name = "cBoxVonMin";
            this.cBoxVonMin.Size = new System.Drawing.Size(42, 21);
            this.cBoxVonMin.TabIndex = 15;
            // 
            // cBoxBisMin
            // 
            this.cBoxBisMin.FormattingEnabled = true;
            this.cBoxBisMin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBoxBisMin.Location = new System.Drawing.Point(335, 41);
            this.cBoxBisMin.Name = "cBoxBisMin";
            this.cBoxBisMin.Size = new System.Drawing.Size(42, 21);
            this.cBoxBisMin.TabIndex = 17;
            // 
            // cBoxBisHour
            // 
            this.cBoxBisHour.FormattingEnabled = true;
            this.cBoxBisHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBoxBisHour.Location = new System.Drawing.Point(287, 41);
            this.cBoxBisHour.Name = "cBoxBisHour";
            this.cBoxBisHour.Size = new System.Drawing.Size(44, 21);
            this.cBoxBisHour.TabIndex = 16;
            // 
            // chBMo
            // 
            this.chBMo.AutoSize = true;
            this.chBMo.Location = new System.Drawing.Point(35, 75);
            this.chBMo.Name = "chBMo";
            this.chBMo.Size = new System.Drawing.Size(64, 17);
            this.chBMo.TabIndex = 18;
            this.chBMo.Text = "Monday";
            this.chBMo.UseVisualStyleBackColor = true;
            this.chBMo.CheckedChanged += new System.EventHandler(this.CheckedChangedWochentag);
            // 
            // chBDienstag
            // 
            this.chBDienstag.AutoSize = true;
            this.chBDienstag.Location = new System.Drawing.Point(99, 75);
            this.chBDienstag.Name = "chBDienstag";
            this.chBDienstag.Size = new System.Drawing.Size(67, 17);
            this.chBDienstag.TabIndex = 19;
            this.chBDienstag.Text = "Tuesday";
            this.chBDienstag.UseVisualStyleBackColor = true;
            this.chBDienstag.CheckedChanged += new System.EventHandler(this.CheckedChangedWochentag);
            // 
            // chBDonnerstag
            // 
            this.chBDonnerstag.AutoSize = true;
            this.chBDonnerstag.Location = new System.Drawing.Point(261, 75);
            this.chBDonnerstag.Name = "chBDonnerstag";
            this.chBDonnerstag.Size = new System.Drawing.Size(70, 17);
            this.chBDonnerstag.TabIndex = 20;
            this.chBDonnerstag.Text = "Thursday";
            this.chBDonnerstag.UseVisualStyleBackColor = true;
            this.chBDonnerstag.CheckedChanged += new System.EventHandler(this.CheckedChangedWochentag);
            // 
            // chBMittwoch
            // 
            this.chBMittwoch.AutoSize = true;
            this.chBMittwoch.Location = new System.Drawing.Point(172, 75);
            this.chBMittwoch.Name = "chBMittwoch";
            this.chBMittwoch.Size = new System.Drawing.Size(83, 17);
            this.chBMittwoch.TabIndex = 20;
            this.chBMittwoch.Text = "Wednesday";
            this.chBMittwoch.UseVisualStyleBackColor = true;
            this.chBMittwoch.CheckedChanged += new System.EventHandler(this.CheckedChangedWochentag);
            // 
            // chBFreitag
            // 
            this.chBFreitag.AutoSize = true;
            this.chBFreitag.Location = new System.Drawing.Point(35, 98);
            this.chBFreitag.Name = "chBFreitag";
            this.chBFreitag.Size = new System.Drawing.Size(54, 17);
            this.chBFreitag.TabIndex = 21;
            this.chBFreitag.Text = "Friday";
            this.chBFreitag.UseVisualStyleBackColor = true;
            this.chBFreitag.CheckedChanged += new System.EventHandler(this.CheckedChangedWochentag);
            // 
            // chBSamstag
            // 
            this.chBSamstag.AutoSize = true;
            this.chBSamstag.Location = new System.Drawing.Point(98, 98);
            this.chBSamstag.Name = "chBSamstag";
            this.chBSamstag.Size = new System.Drawing.Size(68, 17);
            this.chBSamstag.TabIndex = 22;
            this.chBSamstag.Text = "Saturday";
            this.chBSamstag.UseVisualStyleBackColor = true;
            this.chBSamstag.CheckedChanged += new System.EventHandler(this.CheckedChangedWochentag);
            // 
            // chBSonntag
            // 
            this.chBSonntag.AutoSize = true;
            this.chBSonntag.Location = new System.Drawing.Point(172, 98);
            this.chBSonntag.Name = "chBSonntag";
            this.chBSonntag.Size = new System.Drawing.Size(62, 17);
            this.chBSonntag.TabIndex = 23;
            this.chBSonntag.Text = "Sunday";
            this.chBSonntag.UseVisualStyleBackColor = true;
            this.chBSonntag.CheckedChanged += new System.EventHandler(this.CheckedChangedWochentag);
            // 
            // chBMonatlich
            // 
            this.chBMonatlich.AutoSize = true;
            this.chBMonatlich.Location = new System.Drawing.Point(72, 140);
            this.chBMonatlich.Name = "chBMonatlich";
            this.chBMonatlich.Size = new System.Drawing.Size(63, 17);
            this.chBMonatlich.TabIndex = 24;
            this.chBMonatlich.Text = "Monthly";
            this.chBMonatlich.UseVisualStyleBackColor = true;
            this.chBMonatlich.CheckedChanged += new System.EventHandler(this.chBMonatlich_CheckedChanged);
            // 
            // chBJahrlich
            // 
            this.chBJahrlich.AutoSize = true;
            this.chBJahrlich.Location = new System.Drawing.Point(217, 140);
            this.chBJahrlich.Name = "chBJahrlich";
            this.chBJahrlich.Size = new System.Drawing.Size(55, 17);
            this.chBJahrlich.TabIndex = 25;
            this.chBJahrlich.Text = "Yearly";
            this.chBJahrlich.UseVisualStyleBackColor = true;
            this.chBJahrlich.CheckedChanged += new System.EventHandler(this.chBJahrlich_CheckedChanged);
            // 
            // Termin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(426, 262);
            this.ControlBox = false;
            this.Controls.Add(this.chBJahrlich);
            this.Controls.Add(this.chBMonatlich);
            this.Controls.Add(this.chBSonntag);
            this.Controls.Add(this.chBSamstag);
            this.Controls.Add(this.chBFreitag);
            this.Controls.Add(this.chBMittwoch);
            this.Controls.Add(this.chBDonnerstag);
            this.Controls.Add(this.chBDienstag);
            this.Controls.Add(this.chBMo);
            this.Controls.Add(this.cBoxBisMin);
            this.Controls.Add(this.cBoxBisHour);
            this.Controls.Add(this.cBoxVonMin);
            this.Controls.Add(this.cBoxVonHour);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txBBeschreibung);
            this.Controls.Add(this.btnFestlegen);
            this.Controls.Add(this.btnLoschen);
            this.Controls.Add(this.dTpBis);
            this.Controls.Add(this.dTPVon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Termin";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dTpBis;
        private System.Windows.Forms.DateTimePicker dTPVon;
        private System.Windows.Forms.Button btnLoschen;
        private System.Windows.Forms.Button btnFestlegen;
        private Bunifu.Framework.UI.BunifuMetroTextbox txBBeschreibung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cBoxVonHour;
        private System.Windows.Forms.ComboBox cBoxVonMin;
        private System.Windows.Forms.ComboBox cBoxBisMin;
        private System.Windows.Forms.ComboBox cBoxBisHour;
        private System.Windows.Forms.CheckBox chBMo;
        private System.Windows.Forms.CheckBox chBDienstag;
        private System.Windows.Forms.CheckBox chBDonnerstag;
        private System.Windows.Forms.CheckBox chBMittwoch;
        private System.Windows.Forms.CheckBox chBFreitag;
        private System.Windows.Forms.CheckBox chBSamstag;
        private System.Windows.Forms.CheckBox chBSonntag;
        private System.Windows.Forms.CheckBox chBMonatlich;
        private System.Windows.Forms.CheckBox chBJahrlich;
    }
}