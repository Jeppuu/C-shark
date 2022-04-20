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
using MySql.Data.MySqlClient;   //käytetään eramake ja mysql kirjastoja

namespace encryptDecrypt
{
    public partial class Form1 : Form
    {
        YHDISTA yhteys = new YHDISTA(); //luodaan ilmentymä YHDISTÄ luokasta

        public Form1()
        {
            InitializeComponent();
        }

        private void cryptaaBtn_Click(object sender, EventArgs e)
        {
            
            String salattu = eCryptography.Encrypt(salasanaTbx.Text);   //kryptataan syötetty salasana käyttäen eramakea
            MySqlCommand cmd = new MySqlCommand();
            String lisakysely = "INSERT INTO salasana(salasana) VALUES (@ssa);";    //luodaan sql komento joka lisää
            cmd.CommandText = lisakysely;                                           //salasanan tietokantaan
            cmd.Connection = yhteys.OtaYhteys();
            cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;        //@ssa saa arvon salattu

            yhteys.AvaaYhteys();   //avataan yhteys, lisätään salasana ja suljetaan yhteys
            if (cmd.ExecuteNonQuery() == 1 && salasanaTbx.Text != "")
            {
                yhteys.SuljeYhteys();
                vastausLbl.Text = "Salasanasi on cryptattu ja viety tietokantaan.";
                salasanaTbx.Text = "";
                vastausLbl.Visible = true;
            }
            else if (salasanaTbx.Text == "")    //jos salasanaa ei syötetty, annetaan viesti
            {
                vastausLbl.Visible = true;
                vastausLbl.Text = "Syötä salasana!";
            }
            else
            {
                yhteys.SuljeYhteys();
            }

            CryptattuCbx.DataSource = HaeSalasanat(salattu);
        }

        private void naytaSalasanaBtn_Click(object sender, EventArgs e)
        {
            String salasana = eCryptography.Decrypt(CryptattuCbx.Text); //decryptataan cryptattu salasana
            
            if (CryptattuCbx.SelectedIndex != 0)
            {
                vastausLbl.Text = "Salasanasi oli: " + salasana;            //ja näytetään se vastauskentässä
                vastausLbl.Visible = true;                                  //jos comboboxista on valittu jotain
                CryptattuCbx.SelectedIndex = 0;
            }
            else
            {
                vastausLbl.Text = "Valitse cryptattu salasana!";
            }
            
        }

        //haetaan comboboxiin cryptatut salasanat
        public DataTable HaeSalasanat(String salasana)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT salasana FROM salasana", yhteys.OtaYhteys());
            DataTable dt = new DataTable();     // uusi data-adapteri hakee salasanan tietokannasta
            da.Fill(dt);                        //ja vie tiedot datatableen
            CryptattuCbx.DataSource = dt;
            CryptattuCbx.DisplayMember = "salasana";    //comboboc näyttää cryptatun salasanan
            CryptattuCbx.ValueMember = "salasana";
            return dt;
        }

        //tyhjennetään vastaus, kun textboxia klikataan
        private void TyhjennaVastaus(object sender, MouseEventArgs e)
        {
            vastausLbl.Text = "";
        }
        //tehdään sama comboboxille
        private void CryptattuCbx_MouseDown(object sender, MouseEventArgs e)
        {
            vastausLbl.Text = "";
        }
    }
}
