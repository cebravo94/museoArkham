using MuseoArkham.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{


    class ControladorCrearDepartamento : Controlador
    {
        private VistaCrearDepartamento ventana;

        public ControladorCrearDepartamento(VistaCrearDepartamento ventana)
        {
            this.ventana = ventana;
        }

        /**
         * <sumary>
         * Este metodo se encarga de crear un nuevo departamento segun los datos que ingrese la secretaria.
         * Basicamente controla el evento que realiza el boton aceptar de la ventana crear departamento.
         * </sumary>
         * 
         * <param name="nombre"> Nombre del departamento que se desea crear.</param>
         * <param name="descripcion"> Descripcion asociada al departamento que se desea crear.</param>
        **/
        public void crearDepartamento(string nombre, string descripcion)
        {

        }
    }
}
