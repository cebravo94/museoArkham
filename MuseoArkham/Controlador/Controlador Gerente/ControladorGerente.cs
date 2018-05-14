using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Gerente
{
    class ControladorGerente : Controlador
    {
        private VistaGerente ventana;

        public ControladorGerente(VistaGerente ventana) {
            this.ventana = ventana;
        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud en particular previamente seleccionada y el estado de esta debe ser modifcada
         * a "Aceptada" y luego de eso se debe enviar a las solicitudes que puede visualizar el encargado de bodega y el administrador
         * que realizo dicha solicitud debe poder visualizar que su solicitud fue aceptada.
         * </sumary>
        **/
        public void aceptarSolicitud()
        {

        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud en particular previamente seleccionada y el estado de esta debe ser modifcada
         * a "Rechazada" y el administrador que realizo dicha solicitud debe poder visualizar que su solicitud fue rechazada.
         * </sumary>
        **/
        public void rechazarSolicitud()
        {

        }
    }
}
