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
        public void botonEliminar(string depto)
        {
            string cambiarAdmin = "UPDATE departamento SET departamento.id_usuario = 1 WHERE departamento.id_dpto = +'"+ depto + "'";
            Console.WriteLine(cambiarAdmin);
            this.RealizarConsultaNoQuery(cambiarAdmin);
            this.CerrarConexion();

            string cambiarEstado = "UPDATE sala SET sala.estado = 'Disponible' WHERE sala.id_dpto ='"+depto+"'";
            this.RealizarConsultaNoQuery(cambiarEstado);
            this.CerrarConexion();

            string cambiarDepto = "UPDATE sala SET sala.id_dpto = 1 WHERE sala.id_dpto = '" + depto + "'";
            this.RealizarConsultaNoQuery(cambiarDepto);
            this.CerrarConexion();

            string eliminarDepto = "DELETE FROM departamento WHERE departamento.id_dpto ='" + depto + "'";
            this.RealizarConsultaNoQuery(eliminarDepto);
            this.CerrarConexion();

            this.ventana.refrescarTabla(0);
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
                    this.cargarSalas();
                    break;
                case 2:
                    this.cargarUsuarios();
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
            
        }

        public void botonDeshabilitarUsuario()
        {
            if(DeshabilitarUsuario() == true)
            {
                string s = "Usuario deshabilitado con exito.";
                MessageBox.Show(s, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form.ActiveForm.Close();
            }
            else
            {
                string s = "Error en deshabilitar usuario. Los usuarios de tipo Director y Secretaria no pueden ser deshabilitados.";
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
                    this.cargarSalas();
                    break;
                case 2:
                    this.cargarUsuarios();
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

        public void cargarSalas()
        {
            string consulta = "SELECT sala.id_sala AS ID,departamento.nombre AS Departamento," +
                                " sala.nombre AS Nombre, sala.estado AS Estado," +
                                " sala.descripcion as Descripcion" +
                                " FROM departamento ,sala " +
                                " WHERE  departamento.id_dpto = sala.id_dpto";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(ventana.dataGridViewSalas, reader);
            this.CerrarConexion();
        }

        public void cargarUsuarios()
        {
            string consulta = "SELECT usuario.id_usuario AS ID,usuario.nombre AS Nombre," +
                               " usuario.rut as Rut, usuario.correo as Correo, usuario.tipo as Cargo" +
                               " FROM usuario";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(ventana.dataGridViewUsuarios, reader);
            this.CerrarConexion();
        }

        
    }
}
