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

namespace SuositutNimet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelVastaus.Text = "";
            labelVastaus.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Users/Okehittaja/source/repos/C-shark/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/Okehittaja/source/repos/C-shark/tytot.txt");
            string nimi = textBoxNimi.Text;
            int ip = 1; //laskuri pojille
            int it = 1; //laskuri tytöille

            //käydään läpi kaikki poikien nimet tiedostossa, kasvattaen laskuria
            foreach (string poika in pojat)
            {
                if (nimi == poika) //jos löytyy match
                {
                    labelVastaus.Text = "Nimesi oli " + ip + ". suosituin poikien nimi vuonna 2020!";
                    labelVastaus.Visible = true;
                }
                ip++;
            }

            //sama tytöille
            foreach(string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    labelVastaus.Text = "Nimesi oli " + it + ". suosituin tyttöjen nimi vuonna 2020!";
                    labelVastaus.Visible = true;
                }
                it++;
            }

            //jos nimeä ei löytynyt kummastakaan listasta
            if(labelVastaus.Visible == false)
            {
                labelVastaus.Text = "Nimesi ei ollut yksi suosituimmista vuonna 2020.";
                labelVastaus.Visible = true;
            }
        }
        //kun textboxia klikkaa, vastaus tyhjenee
        private void tyhjennaVastaus(object sender, MouseEventArgs e)
        {
            labelVastaus.Text = "";
        }
    }
}
