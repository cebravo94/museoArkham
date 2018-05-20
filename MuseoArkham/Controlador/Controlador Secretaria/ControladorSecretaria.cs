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
        private Departamento Departamento { get; set; }

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

        /**
         * <summary>
         *  Carga los datos dependiendo de la pestaña que nos encontremos
         * </summary>
         */
        public void CargarDatos(int index)
        {
            switch (index)
            {
                case 0:
                    this.cargarDepartamentos();
                    break;
                case 1:
                    
                    break;
            }
        }

        /**
        * <summary>
        *  Realiza los metodos necesarios para cargar los datos de departamentos
        * </summary>
        */
        public void cargarDepartamentos()
        {
            string consulta = "SELECT  departamento.id_dpto AS ID,departamento.nombre AS Departamento, usuario.nombre AS Administrador" + 
                               " FROM departamento,usuario" +
                               " WHERE departamento.id_usuario = usuario.id_usuario";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(ventana.dataGridViewDepartamento, reader);
            this.CerrarConexion();
                 
        }
    }
}
