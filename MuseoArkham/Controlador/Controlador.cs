using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador
{
    abstract class Controlador
    {
        protected MySqlDataReader realizarConsulta(string consulta) {
            return (new Conector_BD()).realizarConsulta(consulta);
        }
    }
}
