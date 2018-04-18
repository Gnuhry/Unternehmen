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
            this.lbMonat = new System.Windows.Forms.Label();
            this.lbJahr = new System.Windows.Forms.Label();
            this.btnBeantragen = new System.Windows.Forms.Button();
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
            this.tLpKalender.Location = new System.Drawing.Point(355, 97);
            this.tLpKalender.Name = "tLpKalender";
            this.tLpKalender.RowCount = 7;
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLpKalender.Size = new System.Drawing.Size(535, 329);
            this.tLpKalender.TabIndex = 0;
            // 
            // btnMonatzuruck
            // 
            this.btnMonatzuruck.Location = new System.Drawing.Point(355, 44);
            this.btnMonatzuruck.Name = "btnMonatzuruck";
            this.btnMonatzuruck.Size = new System.Drawing.Size(87, 23);
            this.btnMonatzuruck.TabIndex = 1;
            this.btnMonatzuruck.Text = "<-";
            this.btnMonatzuruck.UseVisualStyleBackColor = true;
            this.btnMonatzuruck.Click += new System.EventHandler(this.btnMonatzuruck_Click);
            // 
            // btnMonatvor
            // 
            this.btnMonatvor.Location = new System.Drawing.Point(801, 49);
            this.btnMonatvor.Name = "btnMonatvor";
            this.btnMonatvor.Size = new System.Drawing.Size(87, 23);
            this.btnMonatvor.TabIndex = 2;
            this.btnMonatvor.Text = "->";
            this.btnMonatvor.UseVisualStyleBackColor = true;
            this.btnMonatvor.Click += new System.EventHandler(this.btnMonatvor_Click);
            // 
            // lbMonat
            // 
            this.lbMonat.AutoSize = true;
            this.lbMonat.Location = new System.Drawing.Point(651, 54);
            this.lbMonat.Name = "lbMonat";
            this.lbMonat.Size = new System.Drawing.Size(44, 13);
            this.lbMonat.TabIndex = 0;
            this.lbMonat.Text = "Monat";
            // 
            // lbJahr
            // 
            this.lbJahr.AutoSize = true;
            this.lbJahr.Location = new System.Drawing.Point(603, 54);
            this.lbJahr.Name = "lbJahr";
            this.lbJahr.Size = new System.Drawing.Size(30, 13);
            this.lbJahr.TabIndex = 3;
            this.lbJahr.Text = "Jahr";
            // 
            // btnBeantragen
            // 
            this.btnBeantragen.Location = new System.Drawing.Point(499, 44);
            this.btnBeantragen.Name = "btnBeantragen";
            this.btnBeantragen.Size = new System.Drawing.Size(87, 23);
            this.btnBeantragen.TabIndex = 4;
            this.btnBeantragen.Text = "beantragen";
            this.btnBeantragen.UseVisualStyleBackColor = true;
            this.btnBeantragen.Click += new System.EventHandler(this.btnBeantragen_Click);
            // 
            // Kalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 473);
            this.Controls.Add(this.btnBeantragen);
            this.Controls.Add(this.lbJahr);
            this.Controls.Add(this.lbMonat);
            this.Controls.Add(this.btnMonatvor);
            this.Controls.Add(this.btnMonatzuruck);
            this.Controls.Add(this.tLpKalender);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Kalender";
            this.Text = "Kalender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLpKalender;
        private System.Windows.Forms.Button btnMonatzuruck;
        private System.Windows.Forms.Button btnMonatvor;
        private System.Windows.Forms.Label lbMonat;
        private System.Windows.Forms.Label lbJahr;
        private System.Windows.Forms.Button btnBeantragen;
    }
}