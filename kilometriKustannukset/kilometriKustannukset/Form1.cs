using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kilometriKustannukset
{
    public partial class kilometrikulut : Form
    {
        public kilometrikulut()
        {
            InitializeComponent();
        }

        private void kilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, muut, pesut, huollot, renkaat, kilometrit,kustannukset,kustannukset2;
            try
            {
                vastausLB.Text = "";
                vastausLB.Visible = false;
                vastausLB.ForeColor = Color.WhiteSmoke;
                laina = Convert.ToDouble(lainaTB.Text);
                nesteet = Convert.ToDouble(nesteetTB.Text);
                vakuutus = Convert.ToDouble(vakuutusTB.Text);
                muut = Convert.ToDouble(muutTB.Text);
                pesut = Convert.ToDouble(pesutTB.Text);
                huollot = Convert.ToDouble(huollotTB.Text);
                renkaat = Convert.ToDouble(renkaatTB.Text);
                kilometrit = Convert.ToDouble(kilometritCB.Text);

               kustannukset = (laina + nesteet + vakuutus + muut + pesut + huollot + renkaat) / (kilometrit / 12);
                kustannukset2 = Math.Round(kustannukset, 2);
                vastausLB.Text = "Kustannukset ovat yhteensä " + kustannukset2 + " euroa/kilometri.";
               vastausLB.Visible = true;
            }
            catch
            {
                vastausLB.Text = "Virhe! Syötä pelkkiä lukuja.";
                vastausLB.Visible = true;
                vastausLB.ForeColor = Color.Red;
            }
            

        }
    }
}
