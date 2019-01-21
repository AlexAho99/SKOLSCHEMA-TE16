namespace ContainerUserControl
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StarttidtxtBox = new System.Windows.Forms.TextBox();
            this.Starttid = new System.Windows.Forms.Label();
            this.LektionlängdtxtBox = new System.Windows.Forms.TextBox();
            this.LäggtillknappStarttid = new System.Windows.Forms.Button();
            this.Kursnamn = new System.Windows.Forms.Label();
            this.LärarNamn = new System.Windows.Forms.Label();
            this.SalNr = new System.Windows.Forms.Label();
            this.LektionLängd = new System.Windows.Forms.Label();
            this.TextBoxStarttid = new System.Windows.Forms.Label();
            this.TextBoxLektionLängd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StarttidtxtBox
            // 
            this.StarttidtxtBox.Location = new System.Drawing.Point(3, 170);
            this.StarttidtxtBox.Name = "StarttidtxtBox";
            this.StarttidtxtBox.Size = new System.Drawing.Size(75, 22);
            this.StarttidtxtBox.TabIndex = 0;
            this.StarttidtxtBox.TextChanged += new System.EventHandler(this.StarttidtxtBox_TextChanged);
            // 
            // Starttid
            // 
            this.Starttid.AutoSize = true;
            this.Starttid.Location = new System.Drawing.Point(3, 150);
            this.Starttid.Name = "Starttid";
            this.Starttid.Size = new System.Drawing.Size(58, 17);
            this.Starttid.TabIndex = 1;
            this.Starttid.Text = "TidStart";
            this.Starttid.Click += new System.EventHandler(this.Starttid_Click);
            // 
            // LektionlängdtxtBox
            // 
            this.LektionlängdtxtBox.Location = new System.Drawing.Point(85, 170);
            this.LektionlängdtxtBox.Name = "LektionlängdtxtBox";
            this.LektionlängdtxtBox.Size = new System.Drawing.Size(75, 22);
            this.LektionlängdtxtBox.TabIndex = 3;
            this.LektionlängdtxtBox.TextChanged += new System.EventHandler(this.LektionlängdtxtBox_TextChanged);
            // 
            // LäggtillknappStarttid
            // 
            this.LäggtillknappStarttid.Location = new System.Drawing.Point(166, 166);
            this.LäggtillknappStarttid.Name = "LäggtillknappStarttid";
            this.LäggtillknappStarttid.Size = new System.Drawing.Size(75, 30);
            this.LäggtillknappStarttid.TabIndex = 4;
            this.LäggtillknappStarttid.Text = "Lägg Till";
            this.LäggtillknappStarttid.UseVisualStyleBackColor = true;
            this.LäggtillknappStarttid.Click += new System.EventHandler(this.LäggtillknappStarttid_Click);
            // 
            // Kursnamn
            // 
            this.Kursnamn.AutoSize = true;
            this.Kursnamn.Location = new System.Drawing.Point(3, 0);
            this.Kursnamn.Name = "Kursnamn";
            this.Kursnamn.Size = new System.Drawing.Size(72, 17);
            this.Kursnamn.TabIndex = 5;
            this.Kursnamn.Text = "Kursnamn";
            this.Kursnamn.Click += new System.EventHandler(this.Kursnamn_Click);
            // 
            // LärarNamn
            // 
            this.LärarNamn.AutoSize = true;
            this.LärarNamn.Location = new System.Drawing.Point(3, 80);
            this.LärarNamn.Name = "LärarNamn";
            this.LärarNamn.Size = new System.Drawing.Size(104, 17);
            this.LärarNamn.TabIndex = 6;
            this.LärarNamn.Text = "Lärarens namn";
            this.LärarNamn.Click += new System.EventHandler(this.LärarNamn_Click);
            // 
            // SalNr
            // 
            this.SalNr.AutoSize = true;
            this.SalNr.Location = new System.Drawing.Point(3, 40);
            this.SalNr.Name = "SalNr";
            this.SalNr.Size = new System.Drawing.Size(85, 17);
            this.SalNr.TabIndex = 7;
            this.SalNr.Text = "Sal Nummer";
            this.SalNr.Click += new System.EventHandler(this.SalNr_Click);
            // 
            // LektionLängd
            // 
            this.LektionLängd.AutoSize = true;
            this.LektionLängd.Location = new System.Drawing.Point(85, 150);
            this.LektionLängd.Name = "LektionLängd";
            this.LektionLängd.Size = new System.Drawing.Size(68, 17);
            this.LektionLängd.TabIndex = 8;
            this.LektionLängd.Text = "TidLängd";
            this.LektionLängd.Click += new System.EventHandler(this.LektionLängd_Click);
            // 
            // TextBoxStarttid
            // 
            this.TextBoxStarttid.AutoSize = true;
            this.TextBoxStarttid.Location = new System.Drawing.Point(3, 125);
            this.TextBoxStarttid.Name = "TextBoxStarttid";
            this.TextBoxStarttid.Size = new System.Drawing.Size(46, 17);
            this.TextBoxStarttid.TabIndex = 9;
            this.TextBoxStarttid.Text = "Börjar";
            // 
            // TextBoxLektionLängd
            // 
            this.TextBoxLektionLängd.AutoSize = true;
            this.TextBoxLektionLängd.Location = new System.Drawing.Point(85, 125);
            this.TextBoxLektionLängd.Name = "TextBoxLektionLängd";
            this.TextBoxLektionLängd.Size = new System.Drawing.Size(45, 17);
            this.TextBoxLektionLängd.TabIndex = 10;
            this.TextBoxLektionLängd.Text = "Slutar";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.TextBoxLektionLängd);
            this.Controls.Add(this.TextBoxStarttid);
            this.Controls.Add(this.LektionLängd);
            this.Controls.Add(this.SalNr);
            this.Controls.Add(this.LärarNamn);
            this.Controls.Add(this.Kursnamn);
            this.Controls.Add(this.LäggtillknappStarttid);
            this.Controls.Add(this.LektionlängdtxtBox);
            this.Controls.Add(this.Starttid);
            this.Controls.Add(this.StarttidtxtBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(350, 200);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StarttidtxtBox;
        private System.Windows.Forms.Label Starttid;
        private System.Windows.Forms.TextBox LektionlängdtxtBox;
        private System.Windows.Forms.Button LäggtillknappStarttid;
        private System.Windows.Forms.Label Kursnamn;
        private System.Windows.Forms.Label LärarNamn;
        private System.Windows.Forms.Label SalNr;
        private System.Windows.Forms.Label LektionLängd;
        private System.Windows.Forms.Label TextBoxStarttid;
        private System.Windows.Forms.Label TextBoxLektionLängd;
    }
}
