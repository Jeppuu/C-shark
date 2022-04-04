using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_kysymysta
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = new string[] { "", "B", "A", "B", "C", "D", "A", "C", "B", "D", "A" };
        int laskuri = 0;
        int oikein = 0;

        public Form1()
        {
            InitializeComponent();
            radioButtonA.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            radioButtonB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            radioButtonC.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            radioButtonD.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                labelVastaus.Text = "Vastaus " + (laskuri) + ". kysymykseen:";
                laskuri++;
            }
            else
            {
                labelVastaus.Text = "";
                radioButtonA.Enabled = false;
                radioButtonB.Enabled = false;
                radioButtonC.Enabled = false;
                radioButtonD.Enabled = false;

                for(int j = 1;j <= 10; j++)
                {
                    if(vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                labelOikein.Text = "Oikeita vastauksia oli: " + oikein;
                labelOikein.Visible = true;

            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if(radioButtonA.Checked == true)
            {
                radioButtonA.Checked = false;
                laskuri--;
            }
            if (radioButtonB.Checked == true)
            {
                radioButtonB.Checked = false;
                laskuri--;
            }
            if (radioButtonC.Checked == true)
            {
                radioButtonC.Checked = false;
                laskuri--;
            }
            if (radioButtonD.Checked == true)
            {
                radioButtonD.Checked = false;
                laskuri--;
            }

        }
    }
}
