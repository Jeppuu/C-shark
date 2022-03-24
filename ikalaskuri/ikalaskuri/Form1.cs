using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikalaskuri
{
    public partial class Ikalaskuri : Form
    {
        public Ikalaskuri()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = synttaritDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays); //varsinainen ikä
            vuottaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            kuukauttaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            paivaaLB.Text = (erotus + " päivää");
            tuntiaLB.Text = (erotus * 24 + " tuntia");
            minuuttiaLB.Text = (erotus * 24 * 60 + " minuuttia");
            sekuntiaLB.Text = (erotus * 24 * 3600 + " sekuntia");
            vuottaLB.Visible = true;
            kuukauttaLB.Visible = true;
            paivaaLB.Visible = true;
            tuntiaLB.Visible = true;
            minuuttiaLB.Visible = true;
            sekuntiaLB.Visible = true;


        }
    }
}
