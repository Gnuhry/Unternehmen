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
            this.tLpKalender = new System.Windows.Forms.TableLayoutPanel();
            this.btnMonatzuruck = new System.Windows.Forms.Button();
            this.btnMonatvor = new System.Windows.Forms.Button();
            this.btnBeantragen = new System.Windows.Forms.Button();
            this.cBoxMonat = new System.Windows.Forms.ComboBox();
            this.cBoxJahr = new System.Windows.Forms.ComboBox();
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
            this.tLpKalender.Location = new System.Drawing.Point(69, 33);
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
            // 
            // btnMonatzuruck
            // 
            this.btnMonatzuruck.Location = new System.Drawing.Point(12, 4);
            this.btnMonatzuruck.Name = "btnMonatzuruck";
            this.btnMonatzuruck.Size = new System.Drawing.Size(75, 23);
            this.btnMonatzuruck.TabIndex = 1;
            this.btnMonatzuruck.Text = "button1";
            this.btnMonatzuruck.UseVisualStyleBackColor = true;
            this.btnMonatzuruck.Click += new System.EventHandler(this.btnMonatzuruck_Click);
            // 
            // btnMonatvor
            // 
            this.btnMonatvor.Location = new System.Drawing.Point(698, 12);
            this.btnMonatvor.Name = "btnMonatvor";
            this.btnMonatvor.Size = new System.Drawing.Size(75, 23);
            this.btnMonatvor.TabIndex = 2;
            this.btnMonatvor.Text = "button1";
            this.btnMonatvor.UseVisualStyleBackColor = true;
            this.btnMonatvor.Click += new System.EventHandler(this.btnMonatvor_Click);
            // 
            // btnBeantragen
            // 
            this.btnBeantragen.Location = new System.Drawing.Point(346, 401);
            this.btnBeantragen.Name = "btnBeantragen";
            this.btnBeantragen.Size = new System.Drawing.Size(75, 23);
            this.btnBeantragen.TabIndex = 4;
            this.btnBeantragen.Text = "button1";
            this.btnBeantragen.UseVisualStyleBackColor = true;
            this.btnBeantragen.Click += new System.EventHandler(this.btnBeantragen_Click);
            // 
            // cBoxMonat
            // 
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
            this.cBoxMonat.Location = new System.Drawing.Point(170, 6);
            this.cBoxMonat.Name = "cBoxMonat";
            this.cBoxMonat.Size = new System.Drawing.Size(121, 21);
            this.cBoxMonat.TabIndex = 5;
            this.cBoxMonat.SelectedIndexChanged += new System.EventHandler(this.cBoxMonat_SelectedIndexChanged);
            // 
            // cBoxJahr
            // 
            this.cBoxJahr.FormattingEnabled = true;
            this.cBoxJahr.Location = new System.Drawing.Point(346, 6);
            this.cBoxJahr.Name = "cBoxJahr";
            this.cBoxJahr.Size = new System.Drawing.Size(121, 21);
            this.cBoxJahr.TabIndex = 6;
            this.cBoxJahr.SelectedIndexChanged += new System.EventHandler(this.cBoxJahr_SelectedIndexChanged);
            // 
            // Kalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxJahr);
            this.Controls.Add(this.cBoxMonat);
            this.Controls.Add(this.btnBeantragen);
            this.Controls.Add(this.btnMonatvor);
            this.Controls.Add(this.btnMonatzuruck);
            this.Controls.Add(this.tLpKalender);
            this.Name = "Kalender";
            this.Text = "Kalender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kalender_FormClosing);
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