using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace Ajastin
{
    public partial class ajastinForm : Form
    {
        public ajastinForm()
        {
            InitializeComponent();
        }

        private int kokonaisaika;

        private void Form1_Load(object sender, EventArgs e)
        {
            stopBtn.Enabled = false; //alkuun stop btn on pois käytöstä
            for (int i = 0; i < 60; i++)
            {
                minuutitCbx.Items.Add(i.ToString());    //lisätään minuutit
                sekunnitCbx.Items.Add(i.ToString());    //ja sekuntit
            }
            minuutitCbx.SelectedIndex = 3;  //oletus minuuttimäärä on kolme
            sekunnitCbx.SelectedIndex = 0;  //sekunteissa 0
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            stopBtn.Enabled = true; //vaihdetan niin päin, että stop on käytössä ja start ei

            int minuutit = int.Parse(minuutitCbx.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCbx.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTmr.Enabled = true;  //laitetaan ajastin päälle
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            stopBtn.Enabled = false;    //taas start käyttöön ja stop pois
            kokonaisaika = 0;           //nollataan kokonaisaika
            ajastinTmr.Enabled = false; // ajastin pois päältä
            timeLbl.Text = "00:00";     // taulu näyttää 00:00
        }

        private void ajastinTmr_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)   //ennenkuin ajastin osuu nollaan aka aika loppuu
            {
                kokonaisaika--;     //aika vähenee
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                timeLbl.Text = minuutit.ToString() + ":" + sekunnit.ToString(); //kellotaulu näyttää aikaa
            }
            else
            {   //kun aika loppuu
                ajastinTmr.Stop();  //ajastin pysähtyy
                SystemSounds.Exclamation.Play();    //hälytysääni soi
                MessageBox.Show("RING RING!!");     //ilmoitusviesti ilmestyy
                
            }
        }
    }
}
