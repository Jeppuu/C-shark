using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class yllapitoForm : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public yllapitoForm()
        {
            InitializeComponent();
        }

        private void yllapitoForm_Load(object sender, EventArgs e)
        {
            tietotauluDgv.DataSource = opiskelija.HaeOpiskelijat();
            tietotauluDgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
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
                Boolean lisaaOpiskelija = opiskelija.LisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if(lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti!", "Opiskelija lisätty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uuden opiskelijan lisääminen epäonnistui!", "Opiskelijaa ei lisätty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDgv.DataSource = opiskelija.HaeOpiskelijat();
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
                Boolean lisaaOpiskelija = opiskelija.MuokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaOpiskelija)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti!", "Opiskelija päivitetty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijan päivittäminen epäonnistui!", "Opiskelijaa ei päivitetty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDgv.DataSource = opiskelija.HaeOpiskelijat();
        }

        private void tietotauluDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enimiTxb.Text = tietotauluDgv.CurrentRow.Cells[1].Value.ToString();
            snimiTxb.Text = tietotauluDgv.CurrentRow.Cells[2].Value.ToString();
            puhelinTxb.Text = tietotauluDgv.CurrentRow.Cells[3].Value.ToString();
            emailTxb.Text = tietotauluDgv.CurrentRow.Cells[4].Value.ToString();
            opiskelijanroTxb.Text = tietotauluDgv.CurrentRow.Cells[5].Value.ToString();
            idTxb.Text = tietotauluDgv.CurrentRow.Cells[0].Value.ToString();
        }

        private void poistaBtn_Click(object sender, EventArgs e)
        {
            int ktunnus = Int32.Parse(idTxb.Text);
            if (opiskelija.PoistaOpiskelija(ktunnus.ToString()))
            {
                tietotauluDgv.DataSource = opiskelija.HaeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti!", "Opiskelija poistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijan poisto epäonnistui!", "Opiskelijaa ei poistettu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBtn.PerformClick();
        }
    }
}
