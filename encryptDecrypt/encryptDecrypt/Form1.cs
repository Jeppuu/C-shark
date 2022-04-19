using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;
using MySql.Data.MySqlClient;

namespace encryptDecrypt
{
    public partial class Form1 : Form
    {
        YHDISTA yhteys = new YHDISTA();

        public Form1()
        {
            InitializeComponent();
        }

        private void cryptaaBtn_Click(object sender, EventArgs e)
        {
            
            String salattu = eCryptography.Encrypt(cryptattuTxb.Text);
            MySqlCommand cmd = new MySqlCommand();
            String lisakysely = "INSERT INTO salasana(salasana) VALUES (@ssa);";
            cmd.CommandText = lisakysely;
            cmd.Connection = yhteys.OtaYhteys();
            cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;

            yhteys.AvaaYhteys();
            if (cmd.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                vastausLbl.Text = "Salasanasi on cryptattu ja viety tietokantaan.";
                salasanaTbx.Text = "";
                vastausLbl.Visible = true;
            }
            else
            {
                yhteys.SuljeYhteys();
            }
        }

        private void naytaSalasanaBtn_Click(object sender, EventArgs e)
        {
            String salasana = eCryptography.Decrypt(cryptattuTxb.Text);
            vastausLbl.Text = "Salasanasi oli: " + salasana;
            vastausLbl.Visible = true;
            cryptattuTxb.Text = "";
        }
    }
}
