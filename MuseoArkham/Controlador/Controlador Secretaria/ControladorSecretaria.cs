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
        public void botonEliminar(DataGridView data)
        {

            string depto = this.obtenerDepto(data);

            this.cambiarAdmin(depto);
            this.cambiarEstado(depto);
            this.cambiarDepto(depto);
            this.eliminarDepto(depto);
            this.ventana.refrescarTabla(0);
        }

       private string obtenerDepto(DataGridView dataGrid)
        {
            int index = dataGrid.CurrentCell.RowIndex;
            DataGridViewRow data = dataGrid.Rows[index];
            string depto = data.Cells[0].Value.ToString();

            return depto;
        }

        public Boolean validarVentana(DataGridView dataGrid)
        {
            int index = dataGrid.CurrentCell.RowIndex;
            DataGridViewRow data = dataGrid.Rows[index];
            string id = data.Cells[0].Value.ToString();
            string admin = data.Cells[2].Value.ToString();
            if (admin.Equals("default"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void cambiarAdmin(string depto)
        {
            string cambiarAdmin = "UPDATE departamento SET departamento.id_usuario = 1 WHERE departamento.id_dpto = +'" + depto + "'";
            this.RealizarConsultaNoQuery(cambiarAdmin);
            this.CerrarConexion();
        }
        private void cambiarEstado(string depto)
        {
            string cambiarEstado = "UPDATE sala SET sala.estado = 'Disponible' WHERE sala.id_dpto ='" + depto + "'";
            this.RealizarConsultaNoQuery(cambiarEstado);
            this.CerrarConexion();
        }

        private void cambiarDepto(string depto)
        {
            string cambiarDepto = "UPDATE sala SET sala.id_dpto = 1 WHERE sala.id_dpto = '" + depto + "'";
            this.RealizarConsultaNoQuery(cambiarDepto);
            this.CerrarConexion();
        }

        private void eliminarDepto(string depto)
        {
            string eliminarDepto = "DELETE FROM departamento WHERE departamento.id_dpto ='" + depto + "'";
            this.RealizarConsultaNoQuery(eliminarDepto);
            this.CerrarConexion();
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

        public void botonDeshabilitarUsuario()
        {
            int condicion = DeshabilitarUsuario();
            if (condicion == 0)
            {
                string s = "Usuario deshabilitado con exito.";
                MessageBox.Show(s, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(condicion == 1)
            {
                string s = "Error en deshabilitar usuario. El usuario es administrador de un departamento.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string s = "Error en deshabilitar usuario. Los usuarios que poseen el cargo de Director o Secretaria no pueden ser deshabilitados.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DeshabilitarUsuario()
        {
            int index = this.ventana.dataGridViewUsuarios.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewUsuarios.Rows[index];
            String idUsuario = data.Cells[0].Value.ToString();
            if(this.ValidacionUsuario(idUsuario) == true)
            {
                if(this.VerificacionAdministrador(idUsuario) == true)
                {
                    string consulta = "UPDATE usuario SET usuario.tipo = 'Deshabilitado' WHERE usuario.id_usuario = " + idUsuario + ";";
                    this.RealizarConsultaNoQuery(consulta);
                    this.ventana.refrescarTabla(2);
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 2;
            }
        }

        private bool VerificacionAdministrador(String idUsuario)
        {
            string consulta = "select departamento.id_dpto from departamento where departamento.id_usuario = " + idUsuario;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null)
            {   
                this.CerrarConexion();
                return false;
            }
            this.CerrarConexion();
            return true;
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
