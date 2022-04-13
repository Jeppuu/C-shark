using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class yllapitoForm : Form
    {
        public yllapitoForm()
        {
            InitializeComponent();
        }

        private void yllapitoForm_Load(object sender, EventArgs e)
        {
            tietotauluDgv.DataSource = OPISKELIJA.HaeOpiskelijat();
        }

        private void tyhjennaBtn_Click(object sender, EventArgs e)
        {
            idTxb.Text = "";
            enimiTxb.Text = "";
            snimiTxb.Text = "";
            puhelinTxb.Text = "";
            emailTxb.Text = "";
            opiskelijanroTxb.Text = "";
        }

        private void tallennaBtn_Click(object sender, EventArgs e)
        {
            String enimi = enimiTxb.Text;
            String snimi = snimiTxb.Text;
            String puhelin = puhelinTxb.Text;
            String email = emailTxb.Text;
            int oNro = Int32.Parse(opiskelijanroTxb.Text);

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE! Vaaditut kentät: Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaaOpiskelija = OPISKELIJA.LisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if(lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelija lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uuden opiskelijan lisääminen epäonnistui", "Opiskelijaa ei lisätty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDgv.DataSource = OPISKELIJA.HaeOpiskelijat();
        }

        private void paivitaBtn_Click(object sender, EventArgs e)
        {
            String enimi = enimiTxb.Text;
            String snimi = snimiTxb.Text;
            String puhelin = puhelinTxb.Text;
            String email = emailTxb.Text;
            int oNro = Int32.Parse(opiskelijanroTxb.Text);
            int oid = Int32.Parse(idTxb.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals("") )
            {
                MessageBox.Show("VIRHE! Vaaditut kentät: Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //JATKA TÄSTÄ -> POWERPOINT DIA toisiksi viimeinen
            }
        }
    }
}
