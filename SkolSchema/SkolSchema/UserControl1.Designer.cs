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
            this.FörnamnES = new System.Windows.Forms.Label();
            this.Förnamn = new System.Windows.Forms.TextBox();
            this.KursNamnTxtBox = new System.Windows.Forms.TextBox();
            this.KursnamnES = new System.Windows.Forms.Label();
            this.SalNrES = new System.Windows.Forms.Label();
            this.SalNrTxtBox = new System.Windows.Forms.TextBox();
            this.Efternamn = new System.Windows.Forms.TextBox();
            this.NameKnapp = new System.Windows.Forms.Button();
            this.KursButton = new System.Windows.Forms.Button();
            this.EfternamnES = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StarttidtxtBox
            // 
            this.StarttidtxtBox.Location = new System.Drawing.Point(6, 139);
            this.StarttidtxtBox.Name = "StarttidtxtBox";
            this.StarttidtxtBox.Size = new System.Drawing.Size(100, 22);
            this.StarttidtxtBox.TabIndex = 0;
            this.StarttidtxtBox.TextChanged += new System.EventHandler(this.StarttidtxtBox_TextChanged);
            // 
            // Starttid
            // 
            this.Starttid.AutoSize = true;
            this.Starttid.Location = new System.Drawing.Point(3, 114);
            this.Starttid.Name = "Starttid";
            this.Starttid.Size = new System.Drawing.Size(58, 17);
            this.Starttid.TabIndex = 1;
            this.Starttid.Text = "TidStart";
            this.Starttid.Click += new System.EventHandler(this.Starttid_Click);
            // 
            // LektionlängdtxtBox
            // 
            this.LektionlängdtxtBox.Location = new System.Drawing.Point(113, 139);
            this.LektionlängdtxtBox.Name = "LektionlängdtxtBox";
            this.LektionlängdtxtBox.Size = new System.Drawing.Size(75, 22);
            this.LektionlängdtxtBox.TabIndex = 3;
            this.LektionlängdtxtBox.TextChanged += new System.EventHandler(this.LektionlängdtxtBox_TextChanged);
            // 
            // LäggtillknappStarttid
            // 
            this.LäggtillknappStarttid.Location = new System.Drawing.Point(194, 135);
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
            this.LärarNamn.Location = new System.Drawing.Point(3, 164);
            this.LärarNamn.Name = "LärarNamn";
            this.LärarNamn.Size = new System.Drawing.Size(104, 17);
            this.LärarNamn.TabIndex = 6;
            this.LärarNamn.Text = "Lärarens namn";
            this.LärarNamn.Click += new System.EventHandler(this.LärarNamn_Click);
            // 
            // SalNr
            // 
            this.SalNr.AutoSize = true;
            this.SalNr.Location = new System.Drawing.Point(109, 0);
            this.SalNr.Name = "SalNr";
            this.SalNr.Size = new System.Drawing.Size(85, 17);
            this.SalNr.TabIndex = 7;
            this.SalNr.Text = "Sal Nummer";
            this.SalNr.Click += new System.EventHandler(this.SalNr_Click);
            // 
            // LektionLängd
            // 
            this.LektionLängd.AutoSize = true;
            this.LektionLängd.Location = new System.Drawing.Point(110, 114);
            this.LektionLängd.Name = "LektionLängd";
            this.LektionLängd.Size = new System.Drawing.Size(68, 17);
            this.LektionLängd.TabIndex = 8;
            this.LektionLängd.Text = "TidLängd";
            this.LektionLängd.Click += new System.EventHandler(this.LektionLängd_Click);
            // 
            // TextBoxStarttid
            // 
            this.TextBoxStarttid.AutoSize = true;
            this.TextBoxStarttid.Location = new System.Drawing.Point(3, 96);
            this.TextBoxStarttid.Name = "TextBoxStarttid";
            this.TextBoxStarttid.Size = new System.Drawing.Size(46, 17);
            this.TextBoxStarttid.TabIndex = 9;
            this.TextBoxStarttid.Text = "Börjar";
            // 
            // TextBoxLektionLängd
            // 
            this.TextBoxLektionLängd.AutoSize = true;
            this.TextBoxLektionLängd.Location = new System.Drawing.Point(110, 96);
            this.TextBoxLektionLängd.Name = "TextBoxLektionLängd";
            this.TextBoxLektionLängd.Size = new System.Drawing.Size(45, 17);
            this.TextBoxLektionLängd.TabIndex = 10;
            this.TextBoxLektionLängd.Text = "Slutar";
            // 
            // FörnamnES
            // 
            this.FörnamnES.Location = new System.Drawing.Point(3, 193);
            this.FörnamnES.Name = "FörnamnES";
            this.FörnamnES.Size = new System.Drawing.Size(104, 17);
            this.FörnamnES.TabIndex = 11;
            this.FörnamnES.Text = "Förnamn";
            this.FörnamnES.Click += new System.EventHandler(this.FörnamnES_Click);
            // 
            // Förnamn
            // 
            this.Förnamn.Location = new System.Drawing.Point(6, 213);
            this.Förnamn.Name = "Förnamn";
            this.Förnamn.Size = new System.Drawing.Size(100, 22);
            this.Förnamn.TabIndex = 13;
            this.Förnamn.TextChanged += new System.EventHandler(this.Förnamn_TextChanged);
            // 
            // KursNamnTxtBox
            // 
            this.KursNamnTxtBox.Location = new System.Drawing.Point(6, 47);
            this.KursNamnTxtBox.Name = "KursNamnTxtBox";
            this.KursNamnTxtBox.Size = new System.Drawing.Size(100, 22);
            this.KursNamnTxtBox.TabIndex = 14;
            this.KursNamnTxtBox.TextChanged += new System.EventHandler(this.KursNamnTxtBox_TextChanged);
            // 
            // KursnamnES
            // 
            this.KursnamnES.AutoSize = true;
            this.KursnamnES.Location = new System.Drawing.Point(3, 27);
            this.KursnamnES.Name = "KursnamnES";
            this.KursnamnES.Size = new System.Drawing.Size(99, 17);
            this.KursnamnES.TabIndex = 15;
            this.KursnamnES.Text = "Kursens namn";
            // 
            // SalNrES
            // 
            this.SalNrES.AutoSize = true;
            this.SalNrES.Location = new System.Drawing.Point(109, 27);
            this.SalNrES.Name = "SalNrES";
            this.SalNrES.Size = new System.Drawing.Size(106, 17);
            this.SalNrES.TabIndex = 16;
            this.SalNrES.Text = "Salens nummer";
            // 
            // SalNRTxtBox
            // 
            this.SalNrTxtBox.Location = new System.Drawing.Point(112, 47);
            this.SalNrTxtBox.Name = "SalNRTxtBox";
            this.SalNrTxtBox.Size = new System.Drawing.Size(100, 22);
            this.SalNrTxtBox.TabIndex = 17;
            this.SalNrTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Efternamn
            // 
            this.Efternamn.Location = new System.Drawing.Point(112, 213);
            this.Efternamn.Name = "Efternamn";
            this.Efternamn.Size = new System.Drawing.Size(100, 22);
            this.Efternamn.TabIndex = 18;
            this.Efternamn.TextChanged += new System.EventHandler(this.Efternamn_TextChanged);
            // 
            // NameKnapp
            // 
            this.NameKnapp.Location = new System.Drawing.Point(218, 209);
            this.NameKnapp.Name = "NameKnapp";
            this.NameKnapp.Size = new System.Drawing.Size(75, 30);
            this.NameKnapp.TabIndex = 19;
            this.NameKnapp.Text = "Lägg Till";
            this.NameKnapp.UseVisualStyleBackColor = true;
            this.NameKnapp.Click += new System.EventHandler(this.NameKnapp_Click);
            // 
            // KursButton
            // 
            this.KursButton.Location = new System.Drawing.Point(218, 42);
            this.KursButton.Name = "KursButton";
            this.KursButton.Size = new System.Drawing.Size(75, 30);
            this.KursButton.TabIndex = 20;
            this.KursButton.Text = "Lägg Till";
            this.KursButton.UseVisualStyleBackColor = true;
            this.KursButton.Click += new System.EventHandler(this.KursButton_Click);
            // 
            // EfternamnES
            // 
            this.EfternamnES.Location = new System.Drawing.Point(109, 193);
            this.EfternamnES.Name = "EfternamnES";
            this.EfternamnES.Size = new System.Drawing.Size(104, 17);
            this.EfternamnES.TabIndex = 21;
            this.EfternamnES.Text = "Efternamn";
            this.EfternamnES.Click += new System.EventHandler(this.EfternamnES_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.EfternamnES);
            this.Controls.Add(this.KursButton);
            this.Controls.Add(this.NameKnapp);
            this.Controls.Add(this.Efternamn);
            this.Controls.Add(this.SalNrTxtBox);
            this.Controls.Add(this.SalNrES);
            this.Controls.Add(this.KursnamnES);
            this.Controls.Add(this.KursNamnTxtBox);
            this.Controls.Add(this.Förnamn);
            this.Controls.Add(this.FörnamnES);
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
            this.Size = new System.Drawing.Size(350, 250);
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
        private System.Windows.Forms.Label FörnamnES;
        private System.Windows.Forms.TextBox Förnamn;
        private System.Windows.Forms.TextBox KursNamnTxtBox;
        private System.Windows.Forms.Label KursnamnES;
        private System.Windows.Forms.Label SalNrES;
        private System.Windows.Forms.TextBox SalNrTxtBox;
        private System.Windows.Forms.TextBox Efternamn;
        private System.Windows.Forms.Button NameKnapp;
        private System.Windows.Forms.Button KursButton;
        private System.Windows.Forms.Label EfternamnES;
    }
}
