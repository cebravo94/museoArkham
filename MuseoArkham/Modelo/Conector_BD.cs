using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MuseoArkham.Modelo
{
    class Conector_BD
    {
        MySqlConnection con;

        public Conector_BD() {
            string conS = "Server=localhost;Port=3306;Database=museo;Uid=root;password=password";
            this.con = new MySqlConnection(conS);
        }

        public MySqlDataReader realizarConsulta(String consulta) {
            MySqlCommand command = con.CreateCommand();
            command.CommandText = consulta;
            try {
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                con.Close();
                return reader;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                con.Close();
            }
            return null;
        }

    }
}
