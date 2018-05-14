using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Administrador
{
    class ControladorAdministrador : Controlador
    {
        private VistaAdministrador ventana;

        public ControladorAdministrador(VistaAdministrador ventana) {
            this.ventana = ventana;
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
    }
}
