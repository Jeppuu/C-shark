using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIlaskuri
{
    public partial class BMIlaskuri : Form
    {
        public BMIlaskuri()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double pituus, paino,bmi;   //määritetään muuttujat

            try
            {
                vastausLB.Text = "";
                vastausLB.Visible = false;
                
                pituus = double.Parse(pituusTB.Text);   //muunnetaan arvot doubleiksi
                paino = double.Parse(painoTB.Text);

                bmi = Math.Round(paino / ((pituus/100.0) * (pituus/100.0)),2); //lasketaan bmi
                
                //määritetään painoindeksi
                if (bmi <= 18.5) {
                    vastausLB.Text = "Painoindeksisi on " + bmi + "\nAlipaino";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = Color.AliceBlue;
                } else if (bmi <= 24.9) {
                    vastausLB.Text = "Painoindeksisi on " + bmi + "\nNormaalipaino";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = Color.YellowGreen;
                } else if (bmi < 39.9)
                {
                    vastausLB.Text = "Painoindeksisi on " + bmi + "\nYlipaino";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = Color.Gold;
                } else
                {
                    vastausLB.Text = "Painoindeksisi on " + bmi + "\nHuomattava ylipaino";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = Color.OrangeRed;
                }
            }
            catch
            {
                vastausLB.Text = "Virhe! Syötäthän pelkkiä lukuja.";
                vastausLB.ForeColor= Color.OrangeRed;
                vastausLB.Visible = true;
            }
        }
    }
}
