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
            this.cargarDepartamentos();
            this.cargarSalas();
            this.cargarUsuarios();
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

        public void botonDeshabilitarUsuario()
        {
            if(DeshabilitarUsuario() == true)
            {
                string s = "Usuario deshabilitado con exito.";
                MessageBox.Show(s, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string s = "Error en deshabilitar usuario. Los usuarios que poseen el cargo de Director o Secretaria no pueden ser deshabilitados.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean DeshabilitarUsuario()
        {
            int index = this.ventana.dataGridViewUsuarios.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewUsuarios.Rows[index];
            String idUsuario = data.Cells[0].Value.ToString();
            if(this.ValidacionUsuario(idUsuario) == true)
            {
                string consulta = "UPDATE usuario SET usuario.tipo = 'Deshabilitado' WHERE usuario.id_usuario = " + idUsuario + ";";
                this.RealizarConsultaNoQuery(consulta);
                this.ventana.refrescarTabla(2);
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean ValidacionUsuario(string idUsuario)
        {
            string consulta = "select usuario.tipo from usuario where usuario.id_usuario = " + idUsuario;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null)
            {
                reader.Read();
                String tipoUsuario;
                tipoUsuario = reader.GetValue(0).ToString();
                Console.WriteLine(tipoUsuario);
                if (tipoUsuario.Equals("Director") || tipoUsuario.Equals("Secretaria"))
                {
                    this.CerrarConexion();
                    return false;
                }
                this.CerrarConexion();
                return true;
            }
            this.CerrarConexion();
            return false;
        }
  
    }
}
