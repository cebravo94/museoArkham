using MuseoArkham.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorCrearSala
    {
        private VistaCrearSala ventana;

        public ControladorCrearSala(VistaCrearSala ventana)
        {
            this.ventana = ventana;
        }

        /**
         * <sumary>Este metodo se encarga de crear una nueva sala en el sistema segun los datos que ingrese la secretaria
         * para que posteriormente estos sean almacenado en la base de datos. Basicamente controla el evento del boton
         * aceptar de la ventana crear sala.
         * </sumary>
         * 
         * <param name="nombre">Nombre de la sala.</param>
         * <param name="area">cantidad de metros cuadrados que posee la sala.</param>
         * <param name="descripcion">Descripcion asociada a la sala que puede contener cualquier caracteristica de esta.</param>
        **/
        public void crearSala(string nombre, int area, string descripcion)
        {

        }
    }
}
