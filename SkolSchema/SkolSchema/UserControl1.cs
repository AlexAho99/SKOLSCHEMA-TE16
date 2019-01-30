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
        List<Text> text;
        List<Text1> text1;

        public UserControl1()
        {
            InitializeComponent();
            time = new List<Time>();
            text = new List<Text>();
            text1 = new List<Text1>();
        }

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

        private void LäggtillknappStarttid_Click(object sender, EventArgs e)
        {
            Time tmp = new Time(double.Parse(StarttidtxtBox.Text), double.Parse(LektionlängdtxtBox.Text));

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

        private void PrintTimeList()
        {
            foreach (Time time in time)
            {
                Starttid.Text = time.Starttid + "\t";
                LektionLängd.Text = time.LektionLängd + "\t";
            }
        }

        private void PrintTextList()
        {
            foreach (Text text in text)
            {
                Förnamn.Text = text.Förnamn + "\t";
                Efternamn.Text = text.Efternamn + "\t";
            }
        }

        private void PrintText1List()
        {
            foreach (Text1 text1 in text1)
            {
                KursNamnTxtBox.Text = text1.KursNamnTxtBox + "\t";
                SalNrTxtBox.Text = text1.SalNrTxtBox + "\t";
            }
        }

        private void NameKnapp_Click(object sender, EventArgs e)
        {
            Text tmp1 = new Text(Förnamn.Text, Efternamn.Text);
            text.Add(tmp1);
            PrintTextList();
        }

        private void KursButton_Click(object sender, EventArgs e)
        {
            Text1 tmp2 = new Text1(KursNamnTxtBox.Text, SalNrTxtBox.Text);
            text1.Add(tmp2);
            PrintText1List();
        }

        private void FörnamnES_Click(object sender, EventArgs e)
        {

        }

        private void EfternamnES_Click(object sender, EventArgs e)
        {

        }

        private void Efternamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Förnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void KursNamnTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
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

    class Text
    {
        public string FörnamnES;
        public string EfternamnES;

        public Text(string FörnamnES, string EfternamnES)
        {
            this.FörnamnES = FörnamnES;
            this.EfternamnES = EfternamnES;
        }

        public string Förnamn { get => FörnamnES; set => FörnamnES = value; }
        public string Efternamn { get => EfternamnES; set => EfternamnES = value; }
    }

    class Text1
    {
        public string KursNamnES;
        public string SalNrES;

        public Text1(string KursNamnES, string SalNrES)
        {
            this.KursNamnES = KursNamnES;
            this.SalNrES = SalNrES;
        }

        public string KursNamnTxtBox { get => KursNamnES; set => KursNamnES = value; }
        public string SalNrTxtBox { get => SalNrES; set => SalNrES = value; }
    }
}
