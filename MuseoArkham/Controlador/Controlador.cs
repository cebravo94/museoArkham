using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Controlador
{
    class Controlador
    {
        Conector_BD conector;

        public Controlador() {
            this.conector = new Conector_BD();
        }

        protected MySqlDataReader realizarConsulta(string consulta) {
            return this.conector.realizarConsulta(consulta);
        }

        protected void abrirVentana(Form form) {
            form.ShowDialog();
        }
        
        protected void cerrarConexion() {
            this.conector.cerrarConexion();
        }
    }
}
