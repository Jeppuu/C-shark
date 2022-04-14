using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace CRUD
{
    class OPISKELIJA
    {
        Yhdista yhteys = new Yhdista();
        
        //funktio lisäämään uuden oppilaan
        public bool LisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, email, opiskelijanumero) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono); ";
            komento.CommandText = lisakysely;
            komento.Connection = yhteys.OtaYhteys();

            //@ktu, @enm, @snm, @puh, @eml, @ono määrittely
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }
        //funktio kaikkien opiskelijoiden tietojen hakemiselle
        public DataTable HaeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, email, opiskelijanumero FROM yhteystiedot", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            //täytetään luotu taulu komennon tiedoilla (kaikki yhteystiedot)
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        //funktio opiskelijoiden tietojen muokkaamiseksi
        public bool MuokkaaOpiskelijaa(int oid, String enimi,String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `yhteystiedot` SET `Etunimi`=@enm," +
                "`Sukunimi`=@snm, `puhelin`=@puh,`email`=@eml,`opiskelijanumero`=@ono" +
                " WHERE oid = @oid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();

            //@ktu, @enm, @snm, @puh, @eml, @ono, @oid määrittely
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }

        //funktio tietojen poistamiseen
        public bool PoistaOpiskelija(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();

            //@ktu määrittely
            komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }
    }
}
