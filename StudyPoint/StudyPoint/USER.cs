using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudyPoint
{
    class USER
    {
        YHDISTA yhteys = new YHDISTA();

        //
        // register a new user to MySql Database
        //
        public bool RegisterUser(String fname, String lname, String occupation, String mobile, String email, String password, String image)
        {
            MySqlCommand command = new MySqlCommand();
            String extra = "INSERT INTO register_user " +
                "(first_name, last_name, occupation, mobile, email, password, profile_picture) " +
                "VALUES (@fnm, @lnm, @ocp, @mbl, @eml, @psw, @pfp); ";
            command.CommandText = extra;
            command.Connection = yhteys.OtaYhteys();

            //Define values
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ocp", MySqlDbType.VarChar).Value = occupation;
            command.Parameters.Add("@mbl", MySqlDbType.VarChar).Value = mobile;
            command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@psw", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pfp", MySqlDbType.LongBlob).Value = image;

            yhteys.AvaaYhteys();
            if (command.ExecuteNonQuery() == 1)
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

        //
        // register a new post to Mysql database
        //
        public bool PostQuestion(String question, DateTime date)
        {
            MySqlCommand command = new MySqlCommand();
            String extra = "INSERT INTO questions " +
                "(question, question_date) " +
                "VALUES (@qst, @qdt); ";
            command.CommandText = extra;
            command.Connection = yhteys.OtaYhteys();

            //Define values
            command.Parameters.Add("@qst", MySqlDbType.VarChar).Value = question;
            command.Parameters.Add("@qdt", MySqlDbType.DateTime).Value = date;
            

            yhteys.AvaaYhteys();
            if (command.ExecuteNonQuery() == 1)
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

        //
        // fetch all questions for Mysql database
        //
        public DataTable FetchQuestions()
        {
            MySqlCommand komento = new MySqlCommand("SELECT question, question_date FROM questions", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            //fill the created table with the information from command
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
    }
}
