using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD
{
    class Yhdista
    {
        public string Yhteyslause()
        {
            return "datasource=localhost;port=3306;username=root;password=;database=Opiskelijat";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Opiskelijat");

        //funktio yhteyttä varten
        public MySqlConnection OtaYhteys()
        {
            return yhteys;
        }

        //funktio yhteyden avaamiseen
        public void AvaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        //funktio yhteyden sulkemiseen
        public void SuljeYhteys() {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
