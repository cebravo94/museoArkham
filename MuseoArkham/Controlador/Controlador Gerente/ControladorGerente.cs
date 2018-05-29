using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using MuseoArkham.Modelo;
using System.Data;
using MuseoArkham.Vista.Vistas_Administrador;
using MuseoArkham.Vista.VistasItem;

namespace MuseoArkham.Controlador.Controlador_Gerente
{
    class ControladorGerente : Controlador
    {
        private VistaGerente ventana;
        private Usuario usuario;
        public Departamento departamento { get; }

        public ControladorGerente(VistaGerente ventana, Usuario usuario) {
            this.ventana = ventana;
            this.usuario = usuario;
            this.llenarComboBoxSolicitudes(this.ventana.comboBoxSolicitudes);
            this.llenarComboBoxObjetos(this.ventana.comboBoxObjetos);
            //this.departamento = this.cargarDepartamento();
        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud en particular previamente seleccionada y el estado de esta debe ser modifcada
         * a "Aceptada" y luego de eso se debe enviar a las solicitudes que puede visualizar el encargado de bodega y el administrador
         * que realizo dicha solicitud debe poder visualizar que su solicitud fue aceptada.
         * </sumary>
        **/
        public void aceptarSolicitud() {
            int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
            int id = int.Parse(data.Cells[0].Value.ToString());

            string consulta = "SELECT * FROM itemsolicitado,item, solicitud WHERE itemsolicitado.id_item = item.id_item AND solicitud.id_solicitud = itemsolicitado.id_solicitud AND itemsolicitado.id_solicitud=" + id;
            MySqlDataReader reader1 = this.RealizarConsulta(consulta);
            if (reader1 == null) {
                string s = "No hay objetos vinculados a la solicitud";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CerrarConexion();
                return;
            }
            DataTable tabla = new DataTable();
            tabla.Load(reader1);
            reader1.Close();
            this.CerrarConexion();
            if (objetosDisponibles(id, tabla)) {

                foreach (DataRow row in tabla.Rows) {

                    int idItem = int.Parse(row[0].ToString());
                    this.RealizarConsultaNoQuery("UPDATE item SET item.estado ='En Solicitud' WHERE item.id_item=" + idItem);

                }
                this.RealizarConsultaNoQuery("UPDATE solicitud SET solicitud.estado ='Aceptada' WHERE solicitud.id_solicitud=" + id);
                this.cargarDatosTabla(0);
            }

        }

        internal void verDetalleObjeto() {
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

        internal void verDetalleSolicitud() {
            if (this.ventana.dataGridViewSolicitudesTraslado.RowCount > 0) {
                int index = this.obtenerIdSolicitud();
                VistaVerSolicitud vista = new VistaVerSolicitud(index);
                vista.ShowDialog(this.ventana);
            }
        }

        private int obtenerIdSolicitud() {
            int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
            int idSolicitud = Int32.Parse(data.Cells[0].Value.ToString());
            return idSolicitud;
        }

        private bool objetosDisponibles(int id, DataTable tabla) {
            //Console.WriteLine("Estoy en comprobar objetos");
            foreach (DataRow row in tabla.Rows) {

                if (row[9].ToString().Equals("En Solicitud")) {
                    string s = "El objeto solicitado no se encuentra disponible";
                    MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                Console.WriteLine(row[16]);
                Console.WriteLine(row[4]);
                if (!row[16].ToString().Equals(row[4].ToString()))
                {
                    string s = "El objeto solicitado ya no se encuentra disponible";
                    MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


        internal void cambioDeSeleccion() {
            try {
                int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
                DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
                String estado = data.Cells[4].Value.ToString();
                if (estado.Equals("Aceptada") || estado.Equals("Rechazada")||estado.Equals("Despachada")) {
                    this.ventana.botonAceptarSolicitud.Enabled = false;
                    this.ventana.botonRechazarSolicitud.Enabled = false;

                }
                else {
                    this.ventana.botonAceptarSolicitud.Enabled = true;
                    this.ventana.botonRechazarSolicitud.Enabled = true;
                }
            }
            catch (Exception ex) {

                Console.WriteLine(ex.StackTrace);
            };
        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud en particular previamente seleccionada y el estado de esta debe ser modifcada
         * a "Rechazada" y el administrador que realizo dicha solicitud debe poder visualizar que su solicitud fue rechazada.
         * </sumary>
        **/
        public void rechazarSolicitud() {
            int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
            int id = int.Parse(data.Cells[0].Value.ToString());
            this.RealizarConsultaNoQuery("UPDATE solicitud SET solicitud.estado ='Rechazada' WHERE solicitud.id_solicitud=" + id);
            this.cargarDatosTabla(0);
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

        internal void cargarDatosTabla(int index) {
            switch (index) {
                case 0:
                    this.cargarSolicitudes();
                    break;

                case 1:
                    this.cargarObjetos();
                    break;

            }
        }

        private void cargarObjetos() {

            String consulta = "SELECT item.id_item AS ID, item.nombre AS Nombre, sala.nombre AS Ubicación," +
                   " item.estado AS Estado, item.tipo AS Tipo, item.descripcion AS Descripción" +
                   " FROM item, departamento, sala" +
                   " WHERE item.id_dpto = departamento.id_dpto" +
                   " AND sala.id_sala = item.id_sala" +
                   " AND NOT item.estado = 'Deshabilitado'";
            
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            this.CerrarConexion();
        }

        private void cargarSolicitudes() {

            string consulta = "SELECT solicitud.id_solicitud AS ID, usuario.nombre AS Nombre, sala.nombre as 'Sala origen'," +
                    " N.salaDestino as 'Sala destino', solicitud.estado AS Estado," +
                    " solicitud.comentario as Comentario FROM usuario, solicitud, sala ," +
                        " (SELECT sala.nombre AS salaDestino, solicitud.id_solicitud AS iD" +
                        " FROM sala, solicitud" +
                        " WHERE solicitud.id_sala_destino = sala.id_sala) AS N " +
                    " WHERE solicitud.id_sala_origen = sala.id_sala" +
                    " AND solicitud.id_administrador = usuario.id_usuario" +
                    " AND N.iD = solicitud.id_solicitud";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(ventana.dataGridViewSolicitudesTraslado, reader);
            this.CerrarConexion();

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
    }
}
