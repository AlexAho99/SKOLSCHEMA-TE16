namespace SkolSchema
{
    partial class Skolschema
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Spara = new System.Windows.Forms.Button();
            this.Ladda = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.userControl11 = new ContainerUserControl.UserControl1();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Länk till Schoolsoft";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Spara
            // 
            this.Spara.Location = new System.Drawing.Point(168, 269);
            this.Spara.Name = "Spara";
            this.Spara.Size = new System.Drawing.Size(141, 35);
            this.Spara.TabIndex = 13;
            this.Spara.Text = "Spara Schema";
            this.Spara.UseVisualStyleBackColor = true;
            this.Spara.Click += new System.EventHandler(this.Spara_Click);
            // 
            // Ladda
            // 
            this.Ladda.Location = new System.Drawing.Point(168, 310);
            this.Ladda.Name = "Ladda";
            this.Ladda.Size = new System.Drawing.Size(141, 35);
            this.Ladda.TabIndex = 14;
            this.Ladda.Text = "Ladda Schema";
            this.Ladda.UseVisualStyleBackColor = true;
            this.Ladda.Click += new System.EventHandler(this.Ladda_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(15, 269);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(147, 76);
            this.Close.TabIndex = 20;
            this.Close.Text = "Stäng Programmet";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(408, 50);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(350, 250);
            this.userControl11.TabIndex = 21;
            // 
            // Skolschema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Ladda);
            this.Controls.Add(this.Spara);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Skolschema";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Skolschema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Spara;
        private System.Windows.Forms.Button Ladda;
        private new System.Windows.Forms.Button Close;
        private ContainerUserControl.UserControl1 userControl11;
    }
}

