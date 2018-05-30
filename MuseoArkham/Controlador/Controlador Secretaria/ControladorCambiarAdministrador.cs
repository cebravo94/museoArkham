using MuseoArkham.Vista;
using MuseoArkham.Vista.Vistas_Secretaria;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorCambiarAdministrador : Controlador
    {

        VistaCambiarAdministrador ventana;

        public ControladorCambiarAdministrador(VistaCambiarAdministrador ventana)
        {
            this.ventana = ventana;
        }

        public void RellenarComboBox(DataGridView dataGrid,ComboBox combo)
        {
            string tipoUsuario = this.obtenerTipo(dataGrid);

            string subconsulta = "SELECT  departamento.id_usuario AS ID" +
                              " FROM departamento,usuario" +
                              " WHERE departamento.id_usuario = usuario.id_usuario AND usuario.tipo = '"+tipoUsuario+"'";
            string consulta = "SELECT usuario.nombre FROM usuario " +
                             " WHERE usuario.tipo = '" + tipoUsuario + "' AND id_usuario NOT IN(" + subconsulta + ")";
            Console.WriteLine(consulta);
            MySqlDataReader reader = this.RealizarConsulta(consulta);

            DataTable dataTable = new DataTable();
            if (reader != null)
            {
                dataTable.Load(reader);
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string text = dataTable.Rows[i]["nombre"].ToString();
                combo.Items.Add(text);
            }
            this.CerrarConexion();
        }

        public void CambiarAdministrador(DataGridView dataGrid, string nombreAdmin)
        {
            string valor = this.obtenerAdministrador(nombreAdmin);
            string id = obtenerIdDepto(dataGrid);
            string consulta = "UPDATE departamento SET departamento.id_usuario =" + valor + " WHERE departamento.id_dpto = " + id;
            this.RealizarConsultaNoQuery(consulta);
            this.CerrarConexion();

            this.refrescarTablaPadre();
        }

        private string obtenerTipo(DataGridView dataGrid)
        {
            string id = obtenerIdDepto(dataGrid);
            string consulta = "SELECT nombre AS nombre FROM departamento WHERE departamento.id_dpto =" + id;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            string nombre = reader["nombre"].ToString();
            this.CerrarConexion();
            if (nombre.Equals("Bodega"))
            {
                return "Bodega";
            }
            else
            {
                return "Administrador";
            }

            return "";
        }
        private string obtenerIdDepto(DataGridView dataGrid)
        {
            int index = dataGrid.CurrentCell.RowIndex;
            DataGridViewRow data = dataGrid.Rows[index];
            string id = data.Cells[0].Value.ToString();

            return id;
        }
        private string obtenerAdministrador(string admin)
        {
            string consulta = "SELECT usuario.id_usuario FROM usuario WHERE usuario.nombre = '" + admin + "'";

            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            string valor = reader.GetString(0);
            this.CerrarConexion();
            return valor;
        }

        public void refrescarTablaPadre()
        {
            ((VistaSecretaria)(this.ventana.Owner)).refrescarTabla(0);
        }
    }
}
