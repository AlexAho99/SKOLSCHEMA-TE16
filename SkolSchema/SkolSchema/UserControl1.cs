using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace ContainerUserControl
{
    public partial class UserControl1: UserControl
    {
        List<Time> time;
        //En sorterad lista.

        public UserControl1()
        {
            InitializeComponent();
            time = new List<Time>();
        }

        //Detta är UserControl.
        [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
        public class UserControl : System.Windows.Forms.UserControl
        {

        }

        private void Starttid_Click(object sender, EventArgs e)
        {

        }

        private void LektionLängd_Click(object sender, EventArgs e)
        {

        }

        private void StarttidtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LektionlängdtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Detta är knappen som lägger till tiden.
        private void LäggtillknappStarttid_Click(object sender, EventArgs e)
        {
            Time tmp = new Time(int.Parse(StarttidtxtBox.Text), int.Parse(LektionlängdtxtBox.Text));

            time.Add(tmp);
            PrintTimeList();
        }

        private void Kursnamn_Click(object sender, EventArgs e)
        {

        }

        private void SalNr_Click(object sender, EventArgs e)
        {

        }

        private void LärarNamn_Click(object sender, EventArgs e)
        {

        }

        //Detta låter oss printa ut tidenerna.
        private void PrintTimeList()
        {
            foreach (Time time in time)
            {
                Starttid.Text = time.Starttid + "\t";
                LektionLängd.Text = time.LektionLängd + "\t";
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }

    //En class som fungerar med listan Time.
    class Time
    {
        double starttid;
        double lektionLängd;

        public Time(double starttid, double lektionLängd)
        {
            this.starttid = starttid;
            this.lektionLängd = lektionLängd;
        }

        public double Starttid { get => starttid; set => starttid = value; }
        public double LektionLängd { get => lektionLängd; set => lektionLängd = value; }
    }

}
