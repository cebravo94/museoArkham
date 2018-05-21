using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Vista.Vistas_Secretaria;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorAsignarAdministrador : Controlador
    {
        VistaAsignarAdministrador ventana;
        public ControladorAsignarAdministrador(VistaAsignarAdministrador ventana)
        {
            this.ventana = ventana;
        }

        public void RellenarComboBox(ComboBox combo)
        {
            string subconsulta = "SELECT  departamento.id_usuario AS ID" +
                              " FROM departamento,usuario" +
                              " WHERE departamento.id_usuario = usuario.id_usuario AND usuario.tipo = 'Administrador'";

            string consulta = "SELECT usuario.nombre FROM usuario " +
                             " WHERE usuario.tipo = 'Administrador' AND id_usuario NOT IN(" + subconsulta + ")";
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

        public void AsignarAdministrador(string idDepto, string nombreAdmin)
        {
            string valor = this.obtenerAdministrador(nombreAdmin);

            string consulta = "UPDATE departamento SET departamento.id_usuario ="+valor+" WHERE departamento.id_dpto = " +idDepto;
            this.RealizarConsultaNoQuery(consulta);
            this.CerrarConexion();
            this.refrescarTablaPadre();
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
