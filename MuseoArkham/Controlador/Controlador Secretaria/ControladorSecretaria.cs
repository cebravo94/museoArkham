using MuseoArkham.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorSecretaria : Controlador
    {
        private VistaSecretaria ventana;

        public ControladorSecretaria(VistaSecretaria ventana) {
            this.ventana = ventana;
        }

        /**
         * <summary>
         * Metodo para manejar la eliminacion de departamentos
         * </summary>
         * 
         * <param name="depto"> El departamento seleccionado para eliminar.</param>
         * 
         */
        public void botonEliminar(Departamento depto)
        {

        }

        /**
         * <summary>
         * Metodo para agregar administrador al departamento
         * </summary>
         * 
         * <param name="depto"> El departamento seleccionado para agregarle administrador.</param>
         * 
         */
        public void botonAsignarAdministrador(Departamento depto)
        {

        }

        /**
         * <summary>
         * Metoddo que agrega salas a los departamentos
         * </summary>
         * 
         * <param name="depto"> Departamento para asignarle salas.</param>
         * 
         */
        public void botonAsignarSala(Departamento depto)
        {

        }
        /**
         * <summary>
         * Deshabilita al usuario seleccionado del museo
         * </summary>
         * 
         * <param name="usuario"> Usuario que se deshabilitara.</param>
         * 
         */
        public void botonDeshabilitarUsuario(Usuario usuario)
        {
        }
    }
}
