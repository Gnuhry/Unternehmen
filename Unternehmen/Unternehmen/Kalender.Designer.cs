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
            this.btnMonatvor = new System.Windows.Forms.Button();
            this.btnMonatzuruck = new System.Windows.Forms.Button();
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
            this.tLpKalender.Location = new System.Drawing.Point(175, 169);
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
            this.btnBeantragen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBeantragen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeantragen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeantragen.ForeColor = System.Drawing.Color.White;
            this.btnBeantragen.Location = new System.Drawing.Point(670, 429);
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
            this.cBoxMonat.Location = new System.Drawing.Point(175, 142);
            this.cBoxMonat.Name = "cBoxMonat";
            this.cBoxMonat.Size = new System.Drawing.Size(121, 21);
            this.cBoxMonat.TabIndex = 5;
            this.cBoxMonat.SelectedIndexChanged += new System.EventHandler(this.cBoxMonat_SelectedIndexChanged);
            // 
            // cBoxJahr
            // 
            this.cBoxJahr.FormattingEnabled = true;
            this.cBoxJahr.Location = new System.Drawing.Point(513, 142);
            this.cBoxJahr.Name = "cBoxJahr";
            this.cBoxJahr.Size = new System.Drawing.Size(121, 21);
            this.cBoxJahr.TabIndex = 6;
            this.cBoxJahr.SelectedIndexChanged += new System.EventHandler(this.cBoxJahr_SelectedIndexChanged);
            // 
            // btnMonatvor
            // 
            this.btnMonatvor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMonatvor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonatvor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonatvor.ForeColor = System.Drawing.Color.White;
            this.btnMonatvor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonatvor.Image")));
            this.btnMonatvor.Location = new System.Drawing.Point(588, 102);
            this.btnMonatvor.Name = "btnMonatvor";
            this.btnMonatvor.Size = new System.Drawing.Size(46, 34);
            this.btnMonatvor.TabIndex = 2;
            this.btnMonatvor.UseVisualStyleBackColor = false;
            this.btnMonatvor.Click += new System.EventHandler(this.btnMonatvor_Click);
            // 
            // btnMonatzuruck
            // 
            this.btnMonatzuruck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMonatzuruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonatzuruck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonatzuruck.ForeColor = System.Drawing.Color.White;
            this.btnMonatzuruck.Image = ((System.Drawing.Image)(resources.GetObject("btnMonatzuruck.Image")));
            this.btnMonatzuruck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonatzuruck.Location = new System.Drawing.Point(175, 102);
            this.btnMonatzuruck.Name = "btnMonatzuruck";
            this.btnMonatzuruck.Size = new System.Drawing.Size(46, 34);
            this.btnMonatzuruck.TabIndex = 1;
            this.btnMonatzuruck.UseVisualStyleBackColor = false;
            this.btnMonatzuruck.Click += new System.EventHandler(this.btnMonatzuruck_Click);
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

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLpKalender;
        private System.Windows.Forms.Button btnMonatzuruck;
        private System.Windows.Forms.Button btnMonatvor;
        private System.Windows.Forms.Button btnBeantragen;
        private System.Windows.Forms.ComboBox cBoxMonat;
        private System.Windows.Forms.ComboBox cBoxJahr;
    }
}