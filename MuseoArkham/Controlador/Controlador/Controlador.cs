using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Controlador
{
    class Controlador {
        private Conector_BD conector;

        public Controlador() {
            this.conector = Conector_BD.Instance;
        }

        /**
         * <summary>
         * Este metodo recibe un String con la consulta en lenguaje SQL y
         * retorna un lector con la respuesta de la consulta o null si
         * es que no se pudo realizar.
         * </summary>
         * <param name="consulta"> Es la consulta SQL</param>
         * 
         * <returns>La tabla con la respuesta SQL</returns>
         */
        protected MySqlDataReader RealizarConsulta(string consulta) {
            return this.conector.RealizarConsulta(consulta);
        }

        protected void RealizarConsultaNoQuery(string consulta) {
            this.conector.RealizarConsultaNoQuery(consulta);
        }

        /**
         * <summary>
         * Este metodo recibe una ventana, oculta el padre y la muestra en pantalla
         * </summary>
         * 
         * <param name="form"> La ventana que se abrirá.</param>
         */
        public void AbrirVentana(Form nuevaVentana, Form ventanaPadre) {
            ventanaPadre.Hide();
            nuevaVentana.ShowDialog(ventanaPadre);
        }
        
        /**
         * <summary>
         * Este metodo recibe la ventana actual, muestra el padre y cierra la ventana
         * </summary>
         * 
         * <param name="form"> La ventana que se cerrará.</param>
         */
        public void CerrarVentana(Form form) {
            form.Owner.Show();
        }

        /**
         * <summary>
         * Cierra la conexión con la base de datos.
         * </summary>
         */
        public void CerrarConexion() {
            Conector_BD.CerrarConexion();
        }

        protected void PoblarTabla(DataGridView tabla, MySqlDataReader reader) {
            DataTable dataTable = new DataTable();
            if (reader != null) {
                dataTable.Load(reader);
                tabla.DataSource = true;
                tabla.DataSource = dataTable;
                tabla.Refresh();
            }
        }
    }
}
