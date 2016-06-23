namespace LivePerformanceApplication
{
    partial class Huren
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
            this.tbxNaam = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.dtpVan = new System.Windows.Forms.DateTimePicker();
            this.dtpTot = new System.Windows.Forms.DateTimePicker();
            this.clbxBoten = new System.Windows.Forms.CheckedListBox();
            this.clbxMeren = new System.Windows.Forms.CheckedListBox();
            this.clbxArtikelen = new System.Windows.Forms.CheckedListBox();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.cbxNoordzee = new System.Windows.Forms.CheckBox();
            this.cbxIjsselmeer = new System.Windows.Forms.CheckBox();
            this.btnBerekenMeren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNaam
            // 
            this.tbxNaam.Location = new System.Drawing.Point(30, 13);
            this.tbxNaam.Name = "tbxNaam";
            this.tbxNaam.Size = new System.Drawing.Size(100, 22);
            this.tbxNaam.TabIndex = 0;
            this.tbxNaam.Text = "Naam";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(30, 41);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 22);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.Text = "Email";
            // 
            // dtpVan
            // 
            this.dtpVan.Location = new System.Drawing.Point(30, 80);
            this.dtpVan.Name = "dtpVan";
            this.dtpVan.Size = new System.Drawing.Size(200, 22);
            this.dtpVan.TabIndex = 2;
            // 
            // dtpTot
            // 
            this.dtpTot.Location = new System.Drawing.Point(246, 80);
            this.dtpTot.Name = "dtpTot";
            this.dtpTot.Size = new System.Drawing.Size(200, 22);
            this.dtpTot.TabIndex = 3;
            // 
            // clbxBoten
            // 
            this.clbxBoten.FormattingEnabled = true;
            this.clbxBoten.Location = new System.Drawing.Point(464, 13);
            this.clbxBoten.Name = "clbxBoten";
            this.clbxBoten.Size = new System.Drawing.Size(120, 89);
            this.clbxBoten.TabIndex = 4;
            // 
            // clbxMeren
            // 
            this.clbxMeren.FormattingEnabled = true;
            this.clbxMeren.Location = new System.Drawing.Point(751, 12);
            this.clbxMeren.Name = "clbxMeren";
            this.clbxMeren.Size = new System.Drawing.Size(120, 89);
            this.clbxMeren.TabIndex = 5;
            // 
            // clbxArtikelen
            // 
            this.clbxArtikelen.FormattingEnabled = true;
            this.clbxArtikelen.Location = new System.Drawing.Point(614, 13);
            this.clbxArtikelen.Name = "clbxArtikelen";
            this.clbxArtikelen.Size = new System.Drawing.Size(120, 89);
            this.clbxArtikelen.TabIndex = 6;
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(21, 388);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(139, 48);
            this.btnBevestigen.TabIndex = 7;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // nudBudget
            // 
            this.nudBudget.Location = new System.Drawing.Point(751, 269);
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(120, 22);
            this.nudBudget.TabIndex = 8;
            // 
            // cbxNoordzee
            // 
            this.cbxNoordzee.AutoSize = true;
            this.cbxNoordzee.Location = new System.Drawing.Point(751, 297);
            this.cbxNoordzee.Name = "cbxNoordzee";
            this.cbxNoordzee.Size = new System.Drawing.Size(92, 21);
            this.cbxNoordzee.TabIndex = 9;
            this.cbxNoordzee.Text = "Noordzee";
            this.cbxNoordzee.UseVisualStyleBackColor = true;
            // 
            // cbxIjsselmeer
            // 
            this.cbxIjsselmeer.AutoSize = true;
            this.cbxIjsselmeer.Location = new System.Drawing.Point(751, 340);
            this.cbxIjsselmeer.Name = "cbxIjsselmeer";
            this.cbxIjsselmeer.Size = new System.Drawing.Size(93, 21);
            this.cbxIjsselmeer.TabIndex = 10;
            this.cbxIjsselmeer.Text = "Ijsselmeer";
            this.cbxIjsselmeer.UseVisualStyleBackColor = true;
            // 
            // btnBerekenMeren
            // 
            this.btnBerekenMeren.Location = new System.Drawing.Point(751, 388);
            this.btnBerekenMeren.Name = "btnBerekenMeren";
            this.btnBerekenMeren.Size = new System.Drawing.Size(139, 48);
            this.btnBerekenMeren.TabIndex = 11;
            this.btnBerekenMeren.Text = "Bereken aantal meren";
            this.btnBerekenMeren.UseVisualStyleBackColor = true;
            // 
            // Huren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 448);
            this.Controls.Add(this.btnBerekenMeren);
            this.Controls.Add(this.cbxIjsselmeer);
            this.Controls.Add(this.cbxNoordzee);
            this.Controls.Add(this.nudBudget);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.clbxArtikelen);
            this.Controls.Add(this.clbxMeren);
            this.Controls.Add(this.clbxBoten);
            this.Controls.Add(this.dtpTot);
            this.Controls.Add(this.dtpVan);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxNaam);
            this.Name = "Huren";
            this.Text = "Huren";
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNaam;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.DateTimePicker dtpVan;
        private System.Windows.Forms.DateTimePicker dtpTot;
        private System.Windows.Forms.CheckedListBox clbxBoten;
        private System.Windows.Forms.CheckedListBox clbxMeren;
        private System.Windows.Forms.CheckedListBox clbxArtikelen;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.CheckBox cbxNoordzee;
        private System.Windows.Forms.CheckBox cbxIjsselmeer;
        private System.Windows.Forms.Button btnBerekenMeren;
    }
}