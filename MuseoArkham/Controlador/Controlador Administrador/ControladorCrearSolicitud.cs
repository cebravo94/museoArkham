using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoArkham.Vista;
using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

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
         * Este metodo realiza las acciones correspondientes al boton aceptar
         * </summary>
         * <param name="consulta"> Es la consulta SQL</param>
         * 
         * <returns></returns>
         */
        public void botonCrear()
        {

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

