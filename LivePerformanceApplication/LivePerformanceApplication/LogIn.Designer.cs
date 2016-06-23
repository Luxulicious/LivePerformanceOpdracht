namespace LivePerformanceApplication
{
    partial class LogIn
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRegularLogIn = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxWachtwoord = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(45, 94);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 37);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log-in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnRegularLogIn
            // 
            this.btnRegularLogIn.Location = new System.Drawing.Point(126, 94);
            this.btnRegularLogIn.Name = "btnRegularLogIn";
            this.btnRegularLogIn.Size = new System.Drawing.Size(159, 37);
            this.btnRegularLogIn.TabIndex = 1;
            this.btnRegularLogIn.Text = "Reguliere Gebruiker";
            this.btnRegularLogIn.UseVisualStyleBackColor = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(139, 24);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(146, 22);
            this.tbxEmail.TabIndex = 2;
            // 
            // tbxWachtwoord
            // 
            this.tbxWachtwoord.Location = new System.Drawing.Point(138, 52);
            this.tbxWachtwoord.Name = "tbxWachtwoord";
            this.tbxWachtwoord.Size = new System.Drawing.Size(147, 22);
            this.tbxWachtwoord.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(42, 24);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail adres:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(42, 52);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lblWachtwoord.TabIndex = 5;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 143);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxWachtwoord);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnRegularLogIn);
            this.Controls.Add(this.btnLogIn);
            this.Name = "LogIn";
            this.Text = "Log-In";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnRegularLogIn;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxWachtwoord;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWachtwoord;
    }
}

