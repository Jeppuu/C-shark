using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusFarenheitMuunnin
{
    public partial class CFMuunnin : Form
    {
        public CFMuunnin()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double vastaus, asteet;
            //varmistetaan että syötössä on double luku
            try
            {
                asteet = Convert.ToDouble(asteetTB.Text);
                vastausLB.Text = "";
                vastausLB.ForeColor = Color.Black;

                //tarkistetaan mihin suuntaan asteet halutaan muuttaa
                if (FtoC.Checked)
                {
                    vastaus = Math.Round( (asteet - 32) / 1.8, 1);
                    vastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celsius astetta.";
                    vastausLB.Visible = true;
                }
                if (CtoF.Checked)
                {
                    
                    vastaus = Math.Round( asteet * 1.8 + 32, 1);
                    vastausLB.Text = asteet + " Celsiusta on " + vastaus + " Fahrenheit astetta.";
                    vastausLB.Visible = true;
                }
            }
            //annetaan virhe jos syöttö ei ole double luku
            catch
            {
                vastausLB.Text = "Virhe! Syötä asteet lukuna.";
                vastausLB.Visible = true;
                vastausLB.ForeColor = Color.Red;
            }
           
        }
    }
}
