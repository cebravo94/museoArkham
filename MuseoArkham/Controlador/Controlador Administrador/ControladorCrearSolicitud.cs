using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoArkham.Vista;
using MuseoArkham.Modelo;

namespace MuseoArkham.Controlador.Controlador_Administrador
{
    class ControladorCrearSolicitud : Controlador
    {
        private VistaCrearSolicitud ventana;
        Solicitud SolicitudNueva { get; set; }

        public ControladorCrearSolicitud(VistaCrearSolicitud ventana)
        {
            this.ventana = ventana;
        }

        /**
         * <summary>
         * Este metodo realiza las acciones correspondientes al boton aceptar
         * </summary>
         * <param name="consulta"> Es la consulta SQL</param>
         * 
         * <returns></returns>
         */
        public void botonCrear()
        {

        }

        /**
         * <summary>
         * Verifica que todos los campos necesarios esten con valores correctos
         * </summary>
         * <param name=> </param>
         * 
         * <returns></returns>
         */
        public void verificarDatos()
        {

        }


        /**
         * <summary>
         * refresca la tabla de la ventana padre.
         * </summary>
         * <param name=> </param>
         * 
         * <returns></returns>
         */
        public void refrescarTabla()
        {

        }
    }
}

