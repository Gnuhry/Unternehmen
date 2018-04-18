namespace Unternehmen
{
    partial class Login
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
            this.txBbenutzername = new System.Windows.Forms.TextBox();
            this.txBpasswort = new System.Windows.Forms.TextBox();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txBbenutzername
            // 
            this.txBbenutzername.Location = new System.Drawing.Point(346, 139);
            this.txBbenutzername.Name = "txBbenutzername";
            this.txBbenutzername.Size = new System.Drawing.Size(116, 21);
            this.txBbenutzername.TabIndex = 0;
            // 
            // txBpasswort
            // 
            this.txBpasswort.Location = new System.Drawing.Point(346, 165);
            this.txBpasswort.Name = "txBpasswort";
            this.txBpasswort.Size = new System.Drawing.Size(116, 21);
            this.txBpasswort.TabIndex = 1;
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.Location = new System.Drawing.Point(311, 204);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(87, 23);
            this.btnRegistrieren.TabIndex = 2;
            this.btnRegistrieren.Text = "button1";
            this.btnRegistrieren.UseVisualStyleBackColor = true;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegistrieren_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(434, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "button2";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 498);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistrieren);
            this.Controls.Add(this.txBpasswort);
            this.Controls.Add(this.txBbenutzername);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBbenutzername;
        private System.Windows.Forms.TextBox txBpasswort;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.Button btnLogin;
    }
}