namespace Unternehmen
{
    partial class Menue
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
            this.btnKalender = new System.Windows.Forms.Button();
            this.btnMessenger = new System.Windows.Forms.Button();
            this.btnAnwesend = new System.Windows.Forms.Button();
            this.btnGehen = new System.Windows.Forms.Button();
            this.btnZeiten = new System.Windows.Forms.Button();
            this.numKrankentage = new System.Windows.Forms.NumericUpDown();
            this.btnKrankentage = new System.Windows.Forms.Button();
            this.btnWebsite = new System.Windows.Forms.Button();
            this.btnAndern = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKalender
            // 
            this.btnKalender.Location = new System.Drawing.Point(617, 113);
            this.btnKalender.Name = "btnKalender";
            this.btnKalender.Size = new System.Drawing.Size(75, 23);
            this.btnKalender.TabIndex = 0;
            this.btnKalender.Text = "button1";
            this.btnKalender.UseVisualStyleBackColor = true;
            this.btnKalender.Click += new System.EventHandler(this.btnKalender_Click);
            // 
            // btnMessenger
            // 
            this.btnMessenger.Location = new System.Drawing.Point(617, 151);
            this.btnMessenger.Name = "btnMessenger";
            this.btnMessenger.Size = new System.Drawing.Size(64, 21);
            this.btnMessenger.TabIndex = 1;
            this.btnMessenger.Text = "button1";
            this.btnMessenger.UseVisualStyleBackColor = true;
            this.btnMessenger.Click += new System.EventHandler(this.btnMessenger_Click);
            // 
            // btnAnwesend
            // 
            this.btnAnwesend.Location = new System.Drawing.Point(70, 78);
            this.btnAnwesend.Name = "btnAnwesend";
            this.btnAnwesend.Size = new System.Drawing.Size(129, 23);
            this.btnAnwesend.TabIndex = 2;
            this.btnAnwesend.Text = "Anwesend";
            this.btnAnwesend.UseVisualStyleBackColor = true;
            this.btnAnwesend.Click += new System.EventHandler(this.btnAnwesend_Click);
            // 
            // btnGehen
            // 
            this.btnGehen.Location = new System.Drawing.Point(70, 107);
            this.btnGehen.Name = "btnGehen";
            this.btnGehen.Size = new System.Drawing.Size(129, 23);
            this.btnGehen.TabIndex = 3;
            this.btnGehen.Text = "Gehen";
            this.btnGehen.UseVisualStyleBackColor = true;
            this.btnGehen.Click += new System.EventHandler(this.btnGehen_Click);
            // 
            // btnZeiten
            // 
            this.btnZeiten.Location = new System.Drawing.Point(70, 137);
            this.btnZeiten.Name = "btnZeiten";
            this.btnZeiten.Size = new System.Drawing.Size(128, 23);
            this.btnZeiten.TabIndex = 4;
            this.btnZeiten.Text = "Zeiten einsehen";
            this.btnZeiten.UseVisualStyleBackColor = true;
            this.btnZeiten.Click += new System.EventHandler(this.btnZeiten_Click);
            // 
            // numKrankentage
            // 
            this.numKrankentage.Location = new System.Drawing.Point(70, 166);
            this.numKrankentage.Name = "numKrankentage";
            this.numKrankentage.Size = new System.Drawing.Size(46, 20);
            this.numKrankentage.TabIndex = 5;
            // 
            // btnKrankentage
            // 
            this.btnKrankentage.Location = new System.Drawing.Point(123, 167);
            this.btnKrankentage.Name = "btnKrankentage";
            this.btnKrankentage.Size = new System.Drawing.Size(75, 23);
            this.btnKrankentage.TabIndex = 6;
            this.btnKrankentage.Text = "button2";
            this.btnKrankentage.UseVisualStyleBackColor = true;
            this.btnKrankentage.Click += new System.EventHandler(this.btnKrankentage_Click);
            // 
            // btnWebsite
            // 
            this.btnWebsite.Location = new System.Drawing.Point(70, 236);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Size = new System.Drawing.Size(128, 23);
            this.btnWebsite.TabIndex = 8;
            this.btnWebsite.Text = "Website";
            this.btnWebsite.UseVisualStyleBackColor = true;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // btnAndern
            // 
            this.btnAndern.Location = new System.Drawing.Point(70, 266);
            this.btnAndern.Name = "btnAndern";
            this.btnAndern.Size = new System.Drawing.Size(128, 23);
            this.btnAndern.TabIndex = 9;
            this.btnAndern.Text = "Daten ändern";
            this.btnAndern.UseVisualStyleBackColor = true;
            this.btnAndern.Click += new System.EventHandler(this.btnAndern_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(81, 62);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "label1";
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnAndern);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.btnKrankentage);
            this.Controls.Add(this.numKrankentage);
            this.Controls.Add(this.btnZeiten);
            this.Controls.Add(this.btnGehen);
            this.Controls.Add(this.btnAnwesend);
            this.Controls.Add(this.btnMessenger);
            this.Controls.Add(this.btnKalender);
            this.Name = "Menue";
            this.Text = "Menue";
            ((System.ComponentModel.ISupportInitialize)(this.numKrankentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKalender;
        private System.Windows.Forms.Button btnMessenger;
        private System.Windows.Forms.Button btnAnwesend;
        private System.Windows.Forms.Button btnGehen;
        private System.Windows.Forms.Button btnZeiten;
        private System.Windows.Forms.NumericUpDown numKrankentage;
        private System.Windows.Forms.Button btnKrankentage;
        private System.Windows.Forms.Button btnWebsite;
        private System.Windows.Forms.Button btnAndern;
        private System.Windows.Forms.Label lbStatus;
    }
}