using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Bodeguero
{
    class ControladorBodeguero : Controlador
    {
        private VistaEncargadoDeBodega ventana;

        public ControladorBodeguero(VistaEncargadoDeBodega ventana) {
            this.ventana = ventana;
        }

        /**
         * 
         * <sumary>
         * Este metodo se encarga de recibir un objeto creado por el encargado de bodega y lo agrega al inventario de la bodega
         * del museo.
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void agregarObjeto()
        {

        }

        /**
         * <sumary>
         * Este metodo se encarga de obtener un objeto en particular y una vez obtenido debe desincorporar el objeto del inventario
         * de la bodega del museo. (Este objeto no se elimina de la base de datos).
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void desincorporarObjeto()
        {

        }

        /**
         * <sumary>
         * Este metodo se encarga de obtener un objeto (Item) en particular que se haya seleccionado previamente y cambia el estado
         * de este a "En Restauracion". Tambien debe cambiar la ubicacion actual del objeto a uno por defecto que señale que se
         * encuentra en restauracion.
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void enviarARestauracion()
        {

        }

        /**
         * <sumary>
         * Este metodo se encarga de llamar las diferentes consultas que puede hacer el encargado de bodega sobre el inventario 
         * de la bodega y del museo. (Deberia deplegar las opciones de consulta de los objetos)
         *En la pestaña "Objetos" 
         * </sumary>
        **/
        public void consultaSobreObjetos()
        {

        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud de traslado aceptada y una vez que el encargado de bodega la completa
         * de forma presencial el metodo le debe permitir registrar la solicutd en el sistema quedando en la base de datos del
         * museo.
         * En la pestaña "Solicitudes"
        **/
        public void registrarSolicitud()
        {

        }

        /**
         * 
         * Este metodo recibe una solicitud en particular que se ha selecciona previamente y debe desplegar una ventana con los 
         * detalles de la solictud seleccionada.
         * En la pestaña "Solicitudes"
        **/
        public void verDetallesSolicitudes()
        {

        }

        /**
         * 
         * Este metodo se encarga de llamar las diferentes consultas que puede hacer el encargado de bodega sobre las solicitudes
         * emitidas y aceptadas que son las que el visualiza. (Deberia deplegar las opciones de consulta de solicitudes)
         * En la pestaña "Solicitudes"
        **/
        public void consultaSolicitudes()
        {

        }

        /**
         * 
         * Este metodo recibe un registro en particular que se ha selecciona previamente y debe desplegar una ventana con los 
         * detalles del registro seleccionado.
         * En la pestaña "Registros"
        **/
        public void verDetallesRegistros()
        {

        }
    }
}

