using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MuseoArkham.Controlador
{
    class ControladorLogIn : Controlador
    {

        public bool verificarUsuario(string usuario, string contrasenna) {
            MySqlDataReader reader = this.realizarConsulta(usuario);
            if (reader != null) {
                reader.Read();
                if (reader["contrasenna"].ToString().Equals(contrasenna)) {
                    return true;
                }
            }
            return false;
        }
    }
}
