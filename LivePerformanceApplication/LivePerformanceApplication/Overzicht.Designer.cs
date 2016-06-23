namespace LivePerformanceApplication
{
    partial class Overzicht
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
            this.lbxVaargebieden = new System.Windows.Forms.ListBox();
            this.lbxHuurcontracten = new System.Windows.Forms.ListBox();
            this.btnAddMeer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxNaam = new System.Windows.Forms.TextBox();
            this.nudPrijs = new System.Windows.Forms.NumericUpDown();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblVerboden = new System.Windows.Forms.Label();
            this.clbxBoten = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrijs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxVaargebieden
            // 
            this.lbxVaargebieden.FormattingEnabled = true;
            this.lbxVaargebieden.ItemHeight = 16;
            this.lbxVaargebieden.Location = new System.Drawing.Point(12, 12);
            this.lbxVaargebieden.Name = "lbxVaargebieden";
            this.lbxVaargebieden.Size = new System.Drawing.Size(120, 292);
            this.lbxVaargebieden.TabIndex = 0;
            // 
            // lbxHuurcontracten
            // 
            this.lbxHuurcontracten.FormattingEnabled = true;
            this.lbxHuurcontracten.ItemHeight = 16;
            this.lbxHuurcontracten.Location = new System.Drawing.Point(138, 12);
            this.lbxHuurcontracten.Name = "lbxHuurcontracten";
            this.lbxHuurcontracten.Size = new System.Drawing.Size(120, 292);
            this.lbxHuurcontracten.TabIndex = 1;
            // 
            // btnAddMeer
            // 
            this.btnAddMeer.Location = new System.Drawing.Point(12, 324);
            this.btnAddMeer.Name = "btnAddMeer";
            this.btnAddMeer.Size = new System.Drawing.Size(119, 54);
            this.btnAddMeer.TabIndex = 3;
            this.btnAddMeer.Text = "Vaargebied toevoegen";
            this.btnAddMeer.UseVisualStyleBackColor = true;
            this.btnAddMeer.Click += new System.EventHandler(this.btnAddMeer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbxNaam
            // 
            this.tbxNaam.Location = new System.Drawing.Point(475, 12);
            this.tbxNaam.Name = "tbxNaam";
            this.tbxNaam.Size = new System.Drawing.Size(227, 22);
            this.tbxNaam.TabIndex = 7;
            // 
            // nudPrijs
            // 
            this.nudPrijs.Location = new System.Drawing.Point(475, 43);
            this.nudPrijs.Name = "nudPrijs";
            this.nudPrijs.Size = new System.Drawing.Size(227, 22);
            this.nudPrijs.TabIndex = 8;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(406, 15);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 9;
            this.lblNaam.Text = "Naam:";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(406, 45);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(43, 17);
            this.lblPrijs.TabIndex = 10;
            this.lblPrijs.Text = "Prijs: ";
            // 
            // lblVerboden
            // 
            this.lblVerboden.AutoSize = true;
            this.lblVerboden.Location = new System.Drawing.Point(406, 79);
            this.lblVerboden.Name = "lblVerboden";
            this.lblVerboden.Size = new System.Drawing.Size(296, 17);
            this.lblVerboden.TabIndex = 11;
            this.lblVerboden.Text = "Vergeet niet uw verboden boten te selecteren";
            // 
            // clbxBoten
            // 
            this.clbxBoten.FormattingEnabled = true;
            this.clbxBoten.Location = new System.Drawing.Point(265, 12);
            this.clbxBoten.Name = "clbxBoten";
            this.clbxBoten.Size = new System.Drawing.Size(120, 293);
            this.clbxBoten.TabIndex = 12;
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 390);
            this.Controls.Add(this.clbxBoten);
            this.Controls.Add(this.lblVerboden);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.nudPrijs);
            this.Controls.Add(this.tbxNaam);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddMeer);
            this.Controls.Add(this.lbxHuurcontracten);
            this.Controls.Add(this.lbxVaargebieden);
            this.Name = "Overzicht";
            this.Text = "Overzicht";
            this.Load += new System.EventHandler(this.Overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrijs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxVaargebieden;
        private System.Windows.Forms.ListBox lbxHuurcontracten;
        private System.Windows.Forms.Button btnAddMeer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxNaam;
        private System.Windows.Forms.NumericUpDown nudPrijs;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblVerboden;
        private System.Windows.Forms.CheckedListBox clbxBoten;
    }
}