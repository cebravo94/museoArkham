using MuseoArkham.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorAgregarUsuario : Controlador
    {
        private VistaAgregarUsuario ventana;

        public ControladorAgregarUsuario(VistaAgregarUsuario ventana)
        {
            this.ventana = ventana;
        }

        /**
         * <summary>
         * Controla el evento que se realiza al apretar el boton de aceptar
         * </summary>
         * 
         * <param name="nombre"> El nombre completo del usuario a agregar.</param>
         * <param name="rut"> Rut del usuario que será agregado.</param>
         * <param name="correo"> Correo de contacto del usuario</param>
         * <param name="tipoUsuario"> Tipo de usuario que será.</param>
         * <param name="contrasenna"> Contraseña asignada al usuario.</param>
         */
        public void botonAceptar(String nombre,String rut, String correo, String tipoUsuario, String contrasenna)
        {

        }
    }
}
