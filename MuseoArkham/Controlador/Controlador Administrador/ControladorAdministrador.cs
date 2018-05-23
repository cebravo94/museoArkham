using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using System.Data;
using MuseoArkham.Modelo;
using System.Diagnostics;
using MuseoArkham.Vista.Vistas_Administrador;
using MuseoArkham.Vista.VistasItem;

namespace MuseoArkham.Controlador.Controlador_Administrador
{
    class ControladorAdministrador : Controlador
    {
        private VistaAdministrador ventana;
        private Usuario usuario;
        public Departamento departamento { get; }

        public ControladorAdministrador(VistaAdministrador ventana, Usuario usuario) {
            this.ventana = ventana;
            this.usuario = usuario;
            this.departamento = this.cargarDepartamento();
        }

        /**
         * <summary>
         *Realiza la consulta SQL que se hará al apretar el botón "CancelarSolicitud"
         * En la pestaña "Solicitudes de Traslado"
         * </summary>
         */
        public void botonCancelarSolicitud() {
            if (this.ventana.dataGridViewSolicitudesTraslado.RowCount>0) {
                int idSolicitud = this.obtenerIdSolicitud();
                string consulta1 = "DELETE FROM itemsolicitado WHERE itemsolicitado.id_solicitud = " + idSolicitud;
                this.RealizarConsultaNoQuery(consulta1);
                this.CerrarConexion();
                string consulta2 = "DELETE FROM solicitud WHERE solicitud.id_solicitud = " + idSolicitud;
                this.RealizarConsultaNoQuery(consulta2);
                this.CerrarConexion();
                string contador = "SELECT COUNT(solicitud.id_solicitud) AS cantidad" +
                    " FROM solicitud" +
                    " WHERE solicitud.id_administrador = " + this.usuario.Id;
                MySqlDataReader reader = this.RealizarConsulta(contador);
                reader.Read();
                int cantidad = Int32.Parse(reader["cantidad"].ToString());
                this.CerrarConexion();
                this.cargarDatosTabla(0);
                if (cantidad == 0) this.ventana.dataGridViewSolicitudesTraslado.DataSource = null;
            }
        }

        public void botonVerSolicitud() {
            if (this.ventana.dataGridViewSolicitudesTraslado.RowCount > 0) {
                int index = this.obtenerIdSolicitud();
                VistaVerSolicitud vista = new VistaVerSolicitud(index);
                vista.ShowDialog(this.ventana);
            }
        }

        public void botonVerDetalle() {
            if (this.ventana.dataGridViewObjetos.RowCount > 0) {
                int index = this.obtenerIdItem();
                VistaItem vista = new VistaItem(index);
                vista.ShowDialog(this.ventana);
            }
        }

        private int obtenerIdItem() {
            int index = this.ventana.dataGridViewObjetos.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewObjetos.Rows[index];
            int idItem = Int32.Parse(data.Cells[0].Value.ToString());
            return idItem;
        }

        private int obtenerIdSolicitud() {
            int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
            int idSolicitud = Int32.Parse(data.Cells[0].Value.ToString());
            return idSolicitud;
        }

        /**
         * <summary>
         * Ejecuta SQL para filtrar los objetos.
         * </summary>
         */
        public void botonFiltrarSolicitudes() {
        }

        private Departamento cargarDepartamento() {
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null) {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                return departamento;
            }
            return null;
        }

        public void cargarDatosTabla(int index) {
            switch (index) {
                case 0:
                    this.cargarSolicitudes();
                    break;
                case 1:
                    this.cargarItems();
                    break;
                case 2:
                    this.cargarRegistros();
                    break;
            }
        }

        private void cargarSolicitudes() {
            if (this.departamento != null) {
                string consulta = "SELECT solicitud.id_solicitud AS ID, usuario.nombre, sala.nombre as Origen," +
                    " N.salaDestino as Destino, solicitud.estado AS Estado," +
                    " solicitud.comentario as Comentario FROM usuario, solicitud, sala ," +
                        " (SELECT sala.nombre AS salaDestino, solicitud.id_solicitud AS iD" +
                        " FROM sala, solicitud" +
                        " WHERE solicitud.id_sala_destino = sala.id_sala" +
                        " AND solicitud.id_dpto = " + departamento.Id + ") AS N " +
                    " WHERE solicitud.id_sala_origen = sala.id_sala" +
                    " AND solicitud.id_administrador = usuario.id_usuario" +
                    " AND N.iD = solicitud.id_solicitud" +
                    " AND solicitud.id_dpto = " + departamento.Id;
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewSolicitudesTraslado, reader);
                this.CerrarConexion();
            }
        }

        private void cargarItems() {
            if (this.departamento != null) {
                string consulta = "SELECT item.id_item AS ID, item.nombre AS Nombre, sala.nombre AS Ubicación," +
                    " item.estado AS Estado, item.tipo AS Tipo, item.descripcion AS Descripción" +
                    " FROM item, departamento, sala" +
                    " WHERE item.id_dpto = departamento.id_dpto" +
                    " AND sala.id_sala = item.id_sala" +
                    " AND NOT item.estado = 'Deshabilitado'" +
                    " AND departamento.id_dpto = " + departamento.Id;
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
                this.CerrarConexion();
            }
        }

        private void cargarRegistros() {
            if (this.departamento != null) {
                string consulta = "SELECT registro.id_registro AS ID, item.nombre AS Nombre, sala.nombre AS Destino," +
                    " registro.fecha_ingreso AS Fecha" +
                    " FROM item, departamento, sala, registro, usuario" +
                    " WHERE registro.id_dpto = departamento.id_dpto" +
                    " AND registro.id_sala_destino = sala.id_sala" +
                    " AND registro.id_admin = usuario.id_usuario" +
                    " AND registro.id_item = item.id_item" +
                    " AND departamento.id_dpto = " + departamento.Id;
                Debug.WriteLine(consulta);
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewRegistros, reader);
                this.CerrarConexion();
            }
        }
    }
}
