using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using System.Data;
using MuseoArkham.Modelo;

namespace MuseoArkham.Controlador.Controlador_Administrador
{
    class ControladorAdministrador : Controlador
    {
        private VistaAdministrador ventana;
        private Usuario usuario;

        public ControladorAdministrador(VistaAdministrador ventana, Usuario usuario) {
            this.ventana = ventana;
            this.usuario = usuario;
        }

        /**
         * <summary>
         *Realiza la consulta SQL que se hará al apretar el botón "CancelarSolicitud"
         * En la pestaña "Solicitudes de Traslado"
         * </summary>
         */
        public void botonCancelarSolicitud()
        {

        }

        /**
         * <summary>
         * Ejecuta SQL para filtrar los objetos.
         * </summary>
         */
        public void botonFiltrarSolicitudes() {
        }

        public void cargarDatosTabla(int index) {

        }

        public void llenarTablaObjetos() {
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            ds.Tables.Add(dataTable);
            ds.EnforceConstraints = false;
            dataTable.Load(this.RealizarConsulta(""));
            ventana.dataGridViewObjetos.DataSource(dataTable);
        }
    }
}
