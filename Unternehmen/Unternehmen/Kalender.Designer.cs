namespace Unternehmen
{
    partial class Kalender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalender));
            this.tLpKalender = new System.Windows.Forms.TableLayoutPanel();
            this.btnBeantragen = new System.Windows.Forms.Button();
            this.cBoxMonat = new System.Windows.Forms.ComboBox();
            this.cBoxJahr = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMonatvor = new System.Windows.Forms.Button();
            this.btnMonatzuruck = new System.Windows.Forms.Button();
            this.lBoxTage = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbUrlaubstageC = new System.Windows.Forms.Label();
            this.txBBeschreibung = new System.Windows.Forms.TextBox();
            this.cBoxTagFeiertag = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tLpKalender
            // 
            this.tLpKalender.ColumnCount = 7;
            this.tLpKalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tLpKalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tLpKalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tLpKalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tLpKalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tLpKalender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tLpKalender.Location = new System.Drawing.Point(76, 145);
            this.tLpKalender.Name = "tLpKalender";
            this.tLpKalender.RowCount = 7;
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.Size = new System.Drawing.Size(459, 329);
            this.tLpKalender.TabIndex = 0;
            this.tLpKalender.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tLpKalender_MouseDown);
            this.tLpKalender.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tLpKalender_MouseMove);
            this.tLpKalender.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tLpKalender_MouseUp);
            // 
            // btnBeantragen
            // 
            this.btnBeantragen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnBeantragen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeantragen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeantragen.ForeColor = System.Drawing.Color.White;
            this.btnBeantragen.Location = new System.Drawing.Point(670, 434);
            this.btnBeantragen.Name = "btnBeantragen";
            this.btnBeantragen.Size = new System.Drawing.Size(125, 40);
            this.btnBeantragen.TabIndex = 4;
            this.btnBeantragen.Text = "Apply";
            this.btnBeantragen.UseVisualStyleBackColor = false;
            this.btnBeantragen.Click += new System.EventHandler(this.btnBeantragen_Click);
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
            this.cBoxMonat.Location = new System.Drawing.Point(76, 118);
            this.cBoxMonat.Name = "cBoxMonat";
            this.cBoxMonat.Size = new System.Drawing.Size(121, 21);
            this.cBoxMonat.TabIndex = 5;
            this.cBoxMonat.SelectedIndexChanged += new System.EventHandler(this.cBoxMonat_SelectedIndexChanged);
            // 
            // cBoxJahr
            // 
            this.cBoxJahr.FormattingEnabled = true;
            this.cBoxJahr.Location = new System.Drawing.Point(414, 118);
            this.cBoxJahr.Name = "cBoxJahr";
            this.cBoxJahr.Size = new System.Drawing.Size(121, 21);
            this.cBoxJahr.TabIndex = 6;
            this.cBoxJahr.SelectedIndexChanged += new System.EventHandler(this.cBoxJahr_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 57);
            this.panel1.TabIndex = 7;
            // 
            // btnMonatvor
            // 
            this.btnMonatvor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnMonatvor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonatvor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonatvor.ForeColor = System.Drawing.Color.White;
            this.btnMonatvor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonatvor.Image")));
            this.btnMonatvor.Location = new System.Drawing.Point(489, 78);
            this.btnMonatvor.Name = "btnMonatvor";
            this.btnMonatvor.Size = new System.Drawing.Size(46, 34);
            this.btnMonatvor.TabIndex = 2;
            this.btnMonatvor.UseVisualStyleBackColor = false;
            this.btnMonatvor.Click += new System.EventHandler(this.btnMonatvor_Click);
            // 
            // btnMonatzuruck
            // 
            this.btnMonatzuruck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.btnMonatzuruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonatzuruck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonatzuruck.ForeColor = System.Drawing.Color.White;
            this.btnMonatzuruck.Image = ((System.Drawing.Image)(resources.GetObject("btnMonatzuruck.Image")));
            this.btnMonatzuruck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonatzuruck.Location = new System.Drawing.Point(76, 78);
            this.btnMonatzuruck.Name = "btnMonatzuruck";
            this.btnMonatzuruck.Size = new System.Drawing.Size(46, 34);
            this.btnMonatzuruck.TabIndex = 1;
            this.btnMonatzuruck.UseVisualStyleBackColor = false;
            this.btnMonatzuruck.Click += new System.EventHandler(this.btnMonatzuruck_Click);
            // 
            // lBoxTage
            // 
            this.lBoxTage.FormattingEnabled = true;
            this.lBoxTage.Location = new System.Drawing.Point(541, 327);
            this.lBoxTage.Name = "lBoxTage";
            this.lBoxTage.Size = new System.Drawing.Size(120, 147);
            this.lBoxTage.TabIndex = 8;
            this.lBoxTage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lBoxTage_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(541, 292);
            this.dateTimePicker1.MaxDate = new System.DateTime(1753, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(1753, 12, 31, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(738, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(590, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 147);
            this.listBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(711, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Remove";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(667, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Remove";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbUrlaubstageC
            // 
            this.lbUrlaubstageC.AutoSize = true;
            this.lbUrlaubstageC.Location = new System.Drawing.Point(587, 69);
            this.lbUrlaubstageC.Name = "lbUrlaubstageC";
            this.lbUrlaubstageC.Size = new System.Drawing.Size(35, 13);
            this.lbUrlaubstageC.TabIndex = 14;
            this.lbUrlaubstageC.Text = "label1";
            // 
            // txBBeschreibung
            // 
            this.txBBeschreibung.Location = new System.Drawing.Point(695, 318);
            this.txBBeschreibung.Name = "txBBeschreibung";
            this.txBBeschreibung.Size = new System.Drawing.Size(100, 20);
            this.txBBeschreibung.TabIndex = 15;
            this.txBBeschreibung.Visible = false;
            // 
            // cBoxTagFeiertag
            // 
            this.cBoxTagFeiertag.FormattingEnabled = true;
            this.cBoxTagFeiertag.Location = new System.Drawing.Point(590, 91);
            this.cBoxTagFeiertag.Name = "cBoxTagFeiertag";
            this.cBoxTagFeiertag.Size = new System.Drawing.Size(115, 21);
            this.cBoxTagFeiertag.TabIndex = 16;
            this.cBoxTagFeiertag.Visible = false;
            this.cBoxTagFeiertag.SelectedIndexChanged += new System.EventHandler(this.cBoxTagFeiertag_SelectedIndexChanged);
            // 
            // Kalender
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(807, 585);
            this.ControlBox = false;
            this.Controls.Add(this.cBoxTagFeiertag);
            this.Controls.Add(this.txBBeschreibung);
            this.Controls.Add(this.lbUrlaubstageC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lBoxTage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cBoxJahr);
            this.Controls.Add(this.cBoxMonat);
            this.Controls.Add(this.btnBeantragen);
            this.Controls.Add(this.btnMonatvor);
            this.Controls.Add(this.btnMonatzuruck);
            this.Controls.Add(this.tLpKalender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kalender";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kalender_FormClosing);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tLpKalender_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLpKalender;
        private System.Windows.Forms.Button btnMonatzuruck;
        private System.Windows.Forms.Button btnMonatvor;
        private System.Windows.Forms.Button btnBeantragen;
        private System.Windows.Forms.ComboBox cBoxMonat;
        private System.Windows.Forms.ComboBox cBoxJahr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lBoxTage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbUrlaubstageC;
        private System.Windows.Forms.TextBox txBBeschreibung;
        private System.Windows.Forms.ComboBox cBoxTagFeiertag;
    }
}