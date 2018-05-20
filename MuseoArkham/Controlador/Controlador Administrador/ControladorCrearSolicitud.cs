using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoArkham.Vista;
using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Administrador
{
    class ControladorCrearSolicitud : Controlador
    {
        private VistaCrearSolicitud ventana;
        private Departamento departamento;
        Solicitud SolicitudNueva { get; set; }

        public ControladorCrearSolicitud(VistaCrearSolicitud ventana, Departamento departamento)
        {
            this.ventana = ventana;
            this.departamento = departamento;
        }

        /**
         * <summary>
         * Este metodo realiza las acciones correspondientes al boton Solicitar
         * </summary>
         * 
         * <returns></returns>
         */
        public void crearSolicitud()
        {
            List<int> objetosSolicitud = new List<int>();
            foreach (DataGridViewRow r in this.ventana.dataGridViewObjetosEnBodega.Rows) {
                if (Convert.ToBoolean(r.Cells[0].Value)) {
                    objetosSolicitud.Add(Int32.Parse(r.Cells[1].Value.ToString()));
                }
            }
            if (objetosSolicitud.Count > 0) {
                int idSolicitud = this.obtenerIdSolicitud();
                List<string> stringsSolicitud = new List<string>();
                string consulta = "INSERT INTO itemsolicitado(id_item,id_solicitud) VALUES (";
                foreach (int idItem in objetosSolicitud) {
                    this.RealizarConsulta(consulta + idItem + "," + idSolicitud + ");");
                    this.CerrarConexion();
                }
                MessageBox.Show(this.ventana, "Se completó la solicitud","Completado",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.refrescarTabla();
                this.ventana.Close();
                return;
            }
            MessageBox.Show(this.ventana, "No se pudo crear la solicitud","Error",
                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private int obtenerIdSolicitud() {
            string generarConsulta = Solicitud.generarStringConsulta(this.departamento.Id, this.departamento.IdUsuario,
                    buscarIdSala(this.ventana.comboBoxSalaOrigen.Text), buscarIdSala(this.ventana.comboBoxSalaDestino.Text),
                    this.ventana.textBoxComentarios.Text, "Pendiente");
            generarConsulta += "SELECT LAST_INSERT_ID();";
            MySqlDataReader reader = this.RealizarConsulta(generarConsulta);
            reader.Read();
            int idSolicitud = Int32.Parse(reader["LAST_INSERT_ID()"].ToString());
            this.CerrarConexion();
            return idSolicitud;
        }

        private int buscarIdSala(string nombreSala) {
            MySqlDataReader reader = this.RealizarConsulta("SELECT sala.id_sala AS id_sala FROM sala WHERE sala.nombre = '"+nombreSala+"'");
            reader.Read();
            int idSala = Int32.Parse(reader["id_sala"].ToString());
            this.CerrarConexion();
            return idSala;
        }

        /**
         * <summary>
         * Verifica que todos los campos necesarios esten con valores correctos
         * </summary>
         * <param name=> </param>
         * 
         * <returns></returns>
         */
        public void verificarDatos()
        {

        }


        /**
         * <summary>
         * refresca la tabla de la ventana padre.
         * </summary>
         * <param name=> </param>
         * 
         * <returns></returns>
         */
        public void refrescarTabla()
        {
            ((VistaAdministrador)(this.ventana.Owner)).refrescarTabla(0);
        }

        public void llenarSalas() {
            string consulta = "SELECT sala.nombre AS Sala FROM sala, departamento"+
                " WHERE sala.id_dpto = departamento.id_dpto AND departamento.id_dpto = " + this.departamento.Id;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null) {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                List<string> listaOrigen = new List<string>();
                List<string> listaDestino = new List<string>();
                listaOrigen.Add("Bodega");
                foreach (DataRow row in dataTable.Rows) {
                    listaOrigen.Add(row[0].ToString());
                    listaDestino.Add(row[0].ToString());
                }
                ventana.comboBoxSalaOrigen.DataSource = listaOrigen;
                ventana.comboBoxSalaDestino.DataSource = listaDestino;
            }
            this.CerrarConexion();
        }

        public void ajustarSalaDestino(String salaOrigen) {
            string consulta = "SELECT sala.nombre AS Sala FROM sala, departamento" +
                " WHERE sala.id_dpto = departamento.id_dpto AND departamento.id_dpto = " + this.departamento.Id;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null) {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                List<string> listaDestino = new List<string>();
                if (salaOrigen!="Bodega") listaDestino.Add("Bodega");
                foreach (DataRow row in dataTable.Rows) {
                    if (row[0].ToString() != salaOrigen) listaDestino.Add(row[0].ToString());
                }
                ventana.comboBoxSalaDestino.DataSource = listaDestino;
            }
            this.CerrarConexion();
        }

        public void cargarObjetosSala(string nombreSala) {
            string consulta = "SELECT item.id_item AS ID, item.nombre AS Nombre," +
                    " item.tipo AS Tipo, item.descripcion AS Descripción" +
                    " FROM item, sala" +
                    " WHERE sala.id_sala = item.id_sala" +
                    " AND sala.nombre = '"+nombreSala+"'"+
                    " AND sala.id_dpto = "+this.departamento.Id;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null) {
                this.PoblarTabla(this.ventana.dataGridViewObjetosEnBodega, reader);
            }
            else {
                this.ventana.dataGridViewObjetosEnBodega.DataSource = null;
                this.ventana.dataGridViewObjetosEnBodega.Refresh();
            }
            this.CerrarConexion();
        }
    }
}

