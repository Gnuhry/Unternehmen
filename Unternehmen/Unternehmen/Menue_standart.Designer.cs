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
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKrank
            // 
            this.btnKrank.Location = new System.Drawing.Point(98, 119);
            this.btnKrank.Name = "btnKrank";
            this.btnKrank.Size = new System.Drawing.Size(156, 23);
            this.btnKrank.TabIndex = 20;
            this.btnKrank.Text = "Krankentage bestätigen";
            this.btnKrank.UseVisualStyleBackColor = true;
            this.btnKrank.Click += new System.EventHandler(this.btnKrankentage_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(34, 17);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "label1";
            // 
            // numKrankentage
            // 
            this.numKrankentage.Location = new System.Drawing.Point(21, 121);
            this.numKrankentage.Name = "numKrankentage";
            this.numKrankentage.Size = new System.Drawing.Size(54, 20);
            this.numKrankentage.TabIndex = 18;
            // 
            // btnZeiten
            // 
            this.btnZeiten.Location = new System.Drawing.Point(21, 92);
            this.btnZeiten.Name = "btnZeiten";
            this.btnZeiten.Size = new System.Drawing.Size(149, 23);
            this.btnZeiten.TabIndex = 17;
            this.btnZeiten.Text = "Zeiten einsehen";
            this.btnZeiten.UseVisualStyleBackColor = true;
            this.btnZeiten.Click += new System.EventHandler(this.btnZeiten_Click);
            // 
            // btnGehen
            // 
            this.btnGehen.Location = new System.Drawing.Point(21, 62);
            this.btnGehen.Name = "btnGehen";
            this.btnGehen.Size = new System.Drawing.Size(150, 23);
            this.btnGehen.TabIndex = 16;
            this.btnGehen.Text = "Gehen";
            this.btnGehen.UseVisualStyleBackColor = true;
            this.btnGehen.Click += new System.EventHandler(this.btnGehen_Click);
            // 
            // btnAnwesend
            // 
            this.btnAnwesend.Location = new System.Drawing.Point(21, 33);
            this.btnAnwesend.Name = "btnAnwesend";
            this.btnAnwesend.Size = new System.Drawing.Size(150, 23);
            this.btnAnwesend.TabIndex = 15;
            this.btnAnwesend.Text = "Anwesend";
            this.btnAnwesend.UseVisualStyleBackColor = true;
            this.btnAnwesend.Click += new System.EventHandler(this.btnAnwesend_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(21, 147);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(150, 23);
            this.btnAdmin.TabIndex = 21;
            this.btnAdmin.Text = "Adminfenster";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Menue_standart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnKrank);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.numKrankentage);
            this.Controls.Add(this.btnZeiten);
            this.Controls.Add(this.btnGehen);
            this.Controls.Add(this.btnAnwesend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menue_standart";
            this.Text = "Menue_standart";
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKrank;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.NumericUpDown numKrankentage;
        private System.Windows.Forms.Button btnZeiten;
        private System.Windows.Forms.Button btnGehen;
        private System.Windows.Forms.Button btnAnwesend;
        private System.Windows.Forms.Button btnAdmin;
    }
}