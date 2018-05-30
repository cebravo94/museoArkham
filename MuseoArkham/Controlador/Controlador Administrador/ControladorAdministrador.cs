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
using MuseoArkham.Vista.VistasCompartidas;

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
            this.llenarComboBoxSolicitudes(this.ventana.comboBoxSolicitudes);
            this.llenarComboBoxObjetos(this.ventana.comboBoxObjetos);
        }
        
        public void aplicarFiltroSolicitudes() {
            string opcion;
            DataGridView data = this.ventana.dataGridViewSolicitudesTraslado;
            switch (this.ventana.comboBoxSolicitudes.Text.ToString()) {
                case "Pendiente":
                    opcion = "Pendiente";
                    break;
                case "Aceptada":
                    opcion = "Aceptada";
                    break;
                case "Rechazada":
                    opcion = "Rechazada";
                    break;
                case "Despachada":
                    opcion = "Despachada";
                    break;
                default:
                    return;
            }
            data.MultiSelect = true;
            foreach (DataGridViewRow item in data.Rows) {
                if (item.Cells[4].Value.ToString() != opcion)
                    data.Rows[item.Index].Selected = true; ;
            }
            foreach (DataGridViewRow row in data.SelectedRows) {
                data.Rows.Remove(row);
            }
            data.MultiSelect = false;
            data.Update();
            this.ventana.dataGridViewSolicitudesTraslado.Refresh();
            this.ventana.comboBoxSolicitudes.Enabled = false;
            this.ventana.buttonAplicarFiltroSolicitudes.Enabled = false;
            this.ventana.buttonCancelarFiltroSolicitudes.Enabled = true;

        }

        public void aplicarFiltroObjetos() {
            string opcion;
            DataGridView data = this.ventana.dataGridViewObjetos;
            switch (this.ventana.comboBoxObjetos.Text.ToString()) {
                case "Documento":
                    opcion = "Documento";
                    break;
                case "Vehiculo":
                    opcion = "Vehiculo";
                    break;
                case "Obra":
                    opcion = "Obra";
                    break;
                case "Pieza":
                    opcion = "Pieza";
                    break;
                default:
                    return;
            }
            data.MultiSelect = true;
            foreach (DataGridViewRow item in data.Rows) {
                if (item.Cells[4].Value.ToString() != opcion)
                    data.Rows[item.Index].Selected = true; ;
            }
            foreach (DataGridViewRow row in data.SelectedRows) {
                data.Rows.Remove(row);
            }
            data.MultiSelect = false;
            data.Update();
            this.ventana.dataGridViewObjetos.Refresh();
            this.ventana.comboBoxObjetos.Enabled = false;
            this.ventana.buttonAplicarFiltroObjetos.Enabled = false;
            this.ventana.buttonQuitarFiltroObjetos.Enabled = true;

        }

        private void llenarComboBoxSolicitudes(ComboBox combo) {
            combo.Items.Add("Pendiente");
            combo.Items.Add("Aceptada");
            combo.Items.Add("Rechazada");
            combo.Items.Add("Despachada");
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void llenarComboBoxObjetos(ComboBox combo) {
            combo.Items.Add("Documento");
            combo.Items.Add("Vehiculo");
            combo.Items.Add("Pieza");
            combo.Items.Add("Obra");
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /**
         * <summary>
         *Realiza la consulta SQL que se hará al apretar el botón "CancelarSolicitud"
         * En la pestaña "Solicitudes de Traslado"
         * </summary>
         */
        public void botonCancelarSolicitud() {
            if (this.ventana.dataGridViewSolicitudesTraslado.RowCount>0) {
                int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
                DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
                string estado = data.Cells[4].Value.ToString();
                if (estado!="Pendiente") {
                    MessageBox.Show(this.ventana,"Solo se pueden Cancelar solicitudes con estado Pendiente","Error",MessageBoxButtons.OK);
                    return;
                }
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

        private int ObtenerIdRegistro()
        {
            int index = this.ventana.dataGridViewRegistros.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewRegistros.Rows[index];
            int idRegistro = Int32.Parse(data.Cells[0].Value.ToString());
            return idRegistro;
        }

        public void VerDetallesRegistros()
        {
            if (this.ventana.dataGridViewRegistros.RowCount > 0)
            {
                int index = this.ObtenerIdRegistro();
                VistaVerRegistro vista = new VistaVerRegistro(index);
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
                    this.recargarFiltroSolicitudes();
                    break;
                case 1:
                    this.cargarItems();
                    this.recargarFiltroObjetos();
                    break;
                case 2:
                    this.cargarRegistros();
                    break;
            }
        }


        public void recargarFiltroObjetos() {
            ventana.comboBoxObjetos.Enabled = true;
            ventana.buttonAplicarFiltroObjetos.Enabled = true;
            ventana.buttonQuitarFiltroObjetos.Enabled = false;
        }

        public void recargarFiltroSolicitudes() {
            ventana.comboBoxSolicitudes.Enabled = true;
            ventana.buttonAplicarFiltroSolicitudes.Enabled = true;
            ventana.buttonCancelarFiltroSolicitudes.Enabled = false;
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
