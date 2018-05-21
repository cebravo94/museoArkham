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
        //Esto es para que sea un Singleton
        private static readonly Lazy<Conector_BD> instance = new Lazy<Conector_BD>(() => new Conector_BD());

        private static MySqlConnection Con;

        private Conector_BD() {
            string conS = "Server=localhost;Port=3306;Database=museo;Uid=conexion;password=123456";
            Con = new MySqlConnection(conS);
        }

        public static Conector_BD Instance {
            get {
                return instance.Value;
            }
        }

        /**
         * Este metodo recibe un String con la consulta en lenguaje SQL y
         * retorna un lector con la respuesta de la consulta o null si
         * es que no se pudo realizar.
         * 
         * @param consulta - es la consulta SQL
         * 
         * @returns un objeto MySqlDataReader iterable con el cual se puede
         * leer el resultado de la consulta; null si no se pudo realizar la
         * consulta.
         * 
         */
        public MySqlDataReader RealizarConsulta(String consulta) {
            MySqlCommand command = Con.CreateCommand();
            command.CommandText = consulta;
            try {
                Con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) return reader;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Con.Close();
            }
            return null;
        }

        public void RealizarConsultaNoQuery(string consulta) {
            MySqlCommand command = Con.CreateCommand();
            command.CommandText = consulta;
            try {
                Con.Open();
                command.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Con.Close();
            }
        }

        //Cierra la conexión con la base de datos.
        public static void CerrarConexion() {
            Con.Close();
        }
    }
}
