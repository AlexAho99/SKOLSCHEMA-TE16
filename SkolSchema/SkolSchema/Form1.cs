using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SkolSchema
{
    public partial class Skolschema : Form
    {
        public Skolschema()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.schoolsoft.se/");
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Måndag_Click(object sender, EventArgs e)
        {

        }

        private void Tisdag_Click(object sender, EventArgs e)
        {

        }

        private void Onsdag_Click(object sender, EventArgs e)
        {

        }

        private void Torsdag_Click(object sender, EventArgs e)
        {

        }

        private void Fredag_Click(object sender, EventArgs e)
        {

        }

        private void Spara_Click(object sender, EventArgs e)
        {

        }

        private void Ladda_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            //Close program
            Application.Exit();
        }

        private void Skolschema_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
