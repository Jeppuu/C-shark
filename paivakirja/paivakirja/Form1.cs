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

namespace paivakirja
{
    public partial class paivakirjaForm : Form
    {
        public paivakirjaForm()
        {
            InitializeComponent();
            //yhdistetään päiväkirja tiedosto ja lisätään sen sisältö textboxiin
            string teksti = File.ReadAllText("C:/Users/Okehittaja/source/repos/C-shark/paivakirja.txt");
            textBox1.Text = teksti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //luodaan muuttuja johon yhdistetään kirjoitettu teksti, päivämäärä ja enter
            string teksti = "";
            teksti += textBox1.Text;
            teksti += "\t" + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n\n";
            
            //kirjataan muuttujan sisältö päiväkirjatiedostoon
            TextWriter text = new StreamWriter("C:/Users/Okehittaja/source/repos/C-shark/paivakirja.txt");
            text.Write(teksti);
            //suljetaan päiväkirja
            text.Close();
            Application.Exit();
        }
    }
}
