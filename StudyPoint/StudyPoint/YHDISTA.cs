using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace StudyPoint
{
    class YHDISTA
    {
        public string Yhteyslause()
        {
            return "datasource=localhost;port=3306;username=root;password=;database=studypoint";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=studypoint");

        //funktio yhteyttä varten
        public MySqlConnection OtaYhteys()
        {
            return yhteys;
        }

        //funktio yhteyden avaamiseen
        public void AvaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        //funktio yhteyden sulkemiseen
        public void SuljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
