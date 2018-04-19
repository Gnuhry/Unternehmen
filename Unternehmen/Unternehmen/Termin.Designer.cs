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
            this.txBBeschreibung = new System.Windows.Forms.TextBox();
            this.txBUhrzeitVon = new System.Windows.Forms.MaskedTextBox();
            this.dTpBis = new System.Windows.Forms.DateTimePicker();
            this.dTPVon = new System.Windows.Forms.DateTimePicker();
            this.txBUhrzeitBis = new System.Windows.Forms.MaskedTextBox();
            this.btnLoschen = new System.Windows.Forms.Button();
            this.btnFestlegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txBBeschreibung
            // 
            this.txBBeschreibung.Location = new System.Drawing.Point(69, 99);
            this.txBBeschreibung.Name = "txBBeschreibung";
            this.txBBeschreibung.Size = new System.Drawing.Size(100, 20);
            this.txBBeschreibung.TabIndex = 0;
            // 
            // txBUhrzeitVon
            // 
            this.txBUhrzeitVon.Location = new System.Drawing.Point(284, 37);
            this.txBUhrzeitVon.Mask = "90:00";
            this.txBUhrzeitVon.Name = "txBUhrzeitVon";
            this.txBUhrzeitVon.Size = new System.Drawing.Size(41, 20);
            this.txBUhrzeitVon.TabIndex = 4;
            this.txBUhrzeitVon.ValidatingType = typeof(System.DateTime);
            // 
            // dTpBis
            // 
            this.dTpBis.Location = new System.Drawing.Point(69, 64);
            this.dTpBis.Name = "dTpBis";
            this.dTpBis.Size = new System.Drawing.Size(200, 20);
            this.dTpBis.TabIndex = 2;
            this.dTpBis.Value = new System.DateTime(2018, 4, 19, 0, 0, 0, 0);
            // 
            // dTPVon
            // 
            this.dTPVon.Location = new System.Drawing.Point(69, 37);
            this.dTPVon.Name = "dTPVon";
            this.dTPVon.Size = new System.Drawing.Size(200, 20);
            this.dTPVon.TabIndex = 1;
            this.dTPVon.Value = new System.DateTime(2018, 4, 19, 0, 0, 0, 0);
            this.dTPVon.ValueChanged += new System.EventHandler(this.dTPVon_ValueChanged);
            // 
            // txBUhrzeitBis
            // 
            this.txBUhrzeitBis.Location = new System.Drawing.Point(284, 64);
            this.txBUhrzeitBis.Mask = "90:00";
            this.txBUhrzeitBis.Name = "txBUhrzeitBis";
            this.txBUhrzeitBis.Size = new System.Drawing.Size(41, 20);
            this.txBUhrzeitBis.TabIndex = 5;
            this.txBUhrzeitBis.ValidatingType = typeof(System.DateTime);
            // 
            // btnLoschen
            // 
            this.btnLoschen.Location = new System.Drawing.Point(44, 134);
            this.btnLoschen.Name = "btnLoschen";
            this.btnLoschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoschen.TabIndex = 7;
            this.btnLoschen.Text = "Löschen";
            this.btnLoschen.UseVisualStyleBackColor = true;
            this.btnLoschen.Visible = false;
            this.btnLoschen.Click += new System.EventHandler(this.btnLoschen_Click);
            // 
            // btnFestlegen
            // 
            this.btnFestlegen.Location = new System.Drawing.Point(142, 134);
            this.btnFestlegen.Name = "btnFestlegen";
            this.btnFestlegen.Size = new System.Drawing.Size(75, 23);
            this.btnFestlegen.TabIndex = 8;
            this.btnFestlegen.Text = "Festlegen";
            this.btnFestlegen.UseVisualStyleBackColor = true;
            this.btnFestlegen.Click += new System.EventHandler(this.btnFestlegen_Click);
            // 
            // Termin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFestlegen);
            this.Controls.Add(this.btnLoschen);
            this.Controls.Add(this.txBUhrzeitBis);
            this.Controls.Add(this.txBUhrzeitVon);
            this.Controls.Add(this.dTpBis);
            this.Controls.Add(this.dTPVon);
            this.Controls.Add(this.txBBeschreibung);
            this.Name = "Termin";
            this.Text = "Termin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBBeschreibung;
        private System.Windows.Forms.MaskedTextBox txBUhrzeitVon;
        private System.Windows.Forms.DateTimePicker dTpBis;
        private System.Windows.Forms.DateTimePicker dTPVon;
        private System.Windows.Forms.MaskedTextBox txBUhrzeitBis;
        private System.Windows.Forms.Button btnLoschen;
        private System.Windows.Forms.Button btnFestlegen;
    }
}