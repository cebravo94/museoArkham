using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using MuseoArkham.Modelo;
using System.Diagnostics;
using MuseoArkham.Vista.Vistas_Administrador;
using MuseoArkham.Vista.VistasItem;
using System.Collections;
using MuseoArkham.Vista.VistasCompartidas;

namespace MuseoArkham.Controlador.Controlador_Bodeguero
{
    class ControladorBodeguero : Controlador
    {
        private VistaEncargadoDeBodega ventana;
        private Usuario usuario;
        public Departamento departamento { get; }

        public ControladorBodeguero(VistaEncargadoDeBodega ventana, Usuario usuario) {
            this.ventana = ventana;
            this.usuario = usuario;
            this.departamento = this.CargarDepartamento();
            this.llenarComboBoxObjetos(this.ventana.comboBoxObjetos);

        }

        /**
         * <sumary>
         * Este metodo se encarga de obtener un objeto en particular y una vez obtenido debe desincorporar el objeto del inventario
         * de la bodega del museo. (Este objeto no se elimina de la base de datos).
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void DesincorporarObjeto() {
            if (this.ventana.dataGridViewObjetos.RowCount > 0)
            {
                int index = this.ventana.dataGridViewObjetos.CurrentCell.RowIndex;
                DataGridViewRow data = this.ventana.dataGridViewObjetos.Rows[index];
                int id_item = Int32.Parse(data.Cells[0].Value.ToString());
                String estado = data.Cells[6].Value.ToString();
                //Console.WriteLine(id_item);
                if (estado != "En Restauracion")
                {
                    DialogResult result = MessageBox.Show(this.ventana, "¿Esta seguro que desea desincorporar el objeto?", "Advertencia",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET estado = 'Deshabilitado' where id_item =" + id_item);
                        this.CerrarConexion();
                    }
                }
                else
                {
                    MessageBox.Show(this.ventana, "No se puede desincorporar el objeto si esta en Restauracion", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Console.WriteLine(index);
            }
        }

        /**
         * <sumary>
         * Este metodo se encarga de obtener un objeto (Item) en particular que se haya seleccionado previamente y cambia el estado
         * de este a "En Restauracion". Tambien debe cambiar la ubicacion actual del objeto a uno por defecto que señale que se
         * encuentra en restauracion.
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void EnviarARestauracion() {
            if (this.ventana.dataGridViewObjetos.RowCount > 0)
            {
                int index = this.ventana.dataGridViewObjetos.CurrentCell.RowIndex;
                DataGridViewRow data = this.ventana.dataGridViewObjetos.Rows[index];
                String estado = data.Cells[6].Value.ToString();
                int id_item = Int32.Parse(data.Cells[0].Value.ToString());
                if (estado == "En Restauracion")
                {
                    MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET estado = 'En Bodega' where id_item =" + id_item);
                    this.CerrarConexion();
                    MessageBox.Show(this.ventana, "Objeto incorporado con exito", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET estado = 'En Restauracion' where id_item =" + id_item);
                    this.CerrarConexion();
                    MessageBox.Show(this.ventana, "Objeto enviado a Restauracion con exito", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void VerDetallesObjetos() {
            if (this.ventana.dataGridViewObjetos.RowCount > 0) {
                int index = this.ObtenerIdItem();
                VistaItem vista = new VistaItem(index);
                vista.ShowDialog(this.ventana);
            }
        }

        private String FormatearFecha(DateTime fecha) {
            String dia = fecha.Day.ToString();
            String mes = fecha.Month.ToString();
            String anno = fecha.Year.ToString();
            String fechaFormateada = anno + "-" + mes + "-" + dia;

            return fechaFormateada;
        }

        private void ConsultaActualizarEstadoSolicitud(int id_Solicitud) {
            MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.solicitud SET estado ='Despachada' WHERE solicitud.id_solicitud= " + id_Solicitud);
            this.CerrarConexion();
        }

        private void ConsultaActualizarUbicacionItemABodega(int id_item) {
            MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET id_dpto=2 WHERE id_item=" + id_item);
            this.CerrarConexion();
            MySqlDataReader reader2 = this.RealizarConsulta("UPDATE museo.item SET id_sala=1 WHERE id_item=" + id_item);
            this.CerrarConexion();
            MySqlDataReader reader3 = this.RealizarConsulta("UPDATE museo.item SET estado='En Bodega' WHERE id_item=" + id_item);
            this.CerrarConexion();
        }

        private void ConsultaActualizarUbicacionItemAExhibicion(int id_item, int id_departamento, int id_sala) {
            MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET id_dpto=" + id_departamento + " WHERE id_item=" + id_item);
            this.CerrarConexion();
            MySqlDataReader reader2 = this.RealizarConsulta("UPDATE museo.item SET id_sala=" + id_sala + " WHERE id_item=" + id_item);
            this.CerrarConexion();
            MySqlDataReader reader3 = this.RealizarConsulta("UPDATE museo.item SET estado='En Exhibicion' WHERE id_item=" + id_item);
            this.CerrarConexion();
        }

        private void ConsultaInsertarRegistro(String consulta) {
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.CerrarConexion();
        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud de traslado pendiente y una vez que el encargado de bodega la completa
         * de forma presencial el metodo le debe permitir registrar la solicutd en el sistema quedando en la base de datos del
         * museo.
         * En la pestaña "Solicitudes"
        **/
        public void RegistrarSolicitud() {
            if (this.ventana.dataGridViewSolicitudesTraslado.RowCount > 0)
            {
                ArrayList consultas = new ArrayList();
                ArrayList idItems1 = new ArrayList();
                ArrayList idItems2 = new ArrayList();
                int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
                DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
                int id_Solicitud = Int32.Parse(data.Cells[0].Value.ToString());
                String consulta0 = "SELECT * FROM museo.solicitud WHERE solicitud.id_solicitud=" + id_Solicitud + ";";
                MySqlDataReader reader0 = this.RealizarConsulta(consulta0);
                reader0.Read();
                Solicitud solicitud = new Solicitud(reader0);
                this.CerrarConexion();
                DateTime fechaIngreso = DateTime.Today;

                MySqlDataReader reader = this.RealizarConsulta("SELECT itemsolicitado.id_item FROM museo.itemsolicitado WHERE id_solicitud = " + id_Solicitud);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        int id_item = reader.GetInt32(0);
                        if (solicitud.IdSalaDestino == 1)
                        {
                            idItems1.Add(id_item);
                        }
                        else
                        {
                            idItems2.Add(id_item);
                        }
                        Registro registro = new Registro(0, solicitud.IdDpto, id_item, solicitud.IdAdministrador, 4, solicitud.IdSalaOrigen, solicitud.IdSalaDestino, fechaIngreso);
                        String consulta = "INSERT INTO registro (id_dpto,id_item,id_admin,id_gerente,id_sala_origen,id_sala_destino,fecha_ingreso) " +
                            "VALUES (" + registro.IdDpto + "," + registro.IdItem + "," + registro.IdAdmin + "," + registro.IdGerente +
                            "," + registro.IdSalaOrigen + "," + registro.IdSalaDestino + ",'" + this.FormatearFecha(registro.FechaIngreso) + "'); ";
                        consultas.Add(consulta);
                    }
                }
                this.CerrarConexion();
                foreach (String consulta in consultas)
                {
                    this.ConsultaInsertarRegistro(consulta);
                }
                foreach (int id in idItems1)
                {
                    this.ConsultaActualizarUbicacionItemABodega(id);
                }
                foreach (int id in idItems2)
                {
                    this.ConsultaActualizarUbicacionItemAExhibicion(id, solicitud.IdDpto, solicitud.IdSalaDestino);
                }
                this.ConsultaActualizarEstadoSolicitud(id_Solicitud);

                string contador = "SELECT COUNT(solicitud.id_solicitud) AS cantidad" +
                        " FROM museo.solicitud" +
                        " WHERE estado = 'Aceptada' and " +
                        " (id_sala_destino=1 or id_sala_origen=1);";
                MySqlDataReader reader2 = this.RealizarConsulta(contador);
                reader2.Read();
                int cantidad = Int32.Parse(reader2["cantidad"].ToString());
                this.CerrarConexion();
                if (cantidad == 0)
                {
                    this.ventana.dataGridViewSolicitudesTraslado.DataSource = null;
                }
            }
        }

        /**
         * 
         * Este metodo recibe una solicitud en particular que se ha selecciona previamente y debe desplegar una ventana con los 
         * detalles de la solictud seleccionada.
         * En la pestaña "Solicitudes"
        **/
        public void VerDetallesSolicitudes() {
            if (this.ventana.dataGridViewSolicitudesTraslado.RowCount > 0) {
                int index = this.ObtenerIdSolicitud();
                VistaVerSolicitud vista = new VistaVerSolicitud(index);
                vista.ShowDialog(this.ventana);
            }
        }

        /**
         * 
         * Este metodo recibe un registro en particular que se ha selecciona previamente y debe desplegar una ventana con los 
         * detalles del registro seleccionado.
         * En la pestaña "Registros"
        **/
        public void VerDetallesRegistros()
        {
            if (this.ventana.dataGridViewRegistros.RowCount > 0)
            {
                int index = this.ObtenerIdRegistro();
                VistaVerRegistro vista = new VistaVerRegistro(index);
                vista.ShowDialog(this.ventana);
            }
        }

        private int ObtenerIdSolicitud()
        {
            int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
            int idSolicitud = Int32.Parse(data.Cells[0].Value.ToString());
            return idSolicitud;
        }

        private int ObtenerIdItem() {
            int index = this.ventana.dataGridViewObjetos.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewObjetos.Rows[index];
            int idItem = Int32.Parse(data.Cells[0].Value.ToString());
            return idItem;
        }

        private int ObtenerIdRegistro()
        {
            int index = this.ventana.dataGridViewRegistros.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewRegistros.Rows[index];
            int idRegistro = Int32.Parse(data.Cells[0].Value.ToString());
            return idRegistro;
        }

        private Departamento CargarDepartamento()
        {
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null) {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                return departamento;
            }
            return null;
        }

        public void CargarDatosTabla(int index) {
            switch (index) {
                case 0:
                    this.CargarItems();
                    this.recargarFiltros();
                    break;
                case 1:
                    this.CargarSolicitudes();
                    break;
                case 2:
                    this.CargarRegistros();
                    break;
            }
        }

        public void recargarFiltros() {
            ventana.comboBoxObjetos.Enabled = true;
            ventana.buttonAplicarFiltroObjetos.Enabled = true;
            ventana.buttonCancelarFiltroObjetos.Enabled = false;
        }

        private void CargarItems() {
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null) {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                String consulta = "select id_item AS ID,item.nombre AS Nombre, departamento.nombre AS NombreDpto," +
                                  " fecha_ingreso AS Fecha_Ingreso, item.tipo AS Tipo," +
                                  " coleccion AS Colección,item.estado AS Estado, anno AS Año, item.descripcion AS Descripción" +
                                  " from museo.item, museo.departamento" +
                                  " where item.id_dpto=departamento.id_dpto" +
                                  " and departamento.id_dpto=" + departamento.Id +
                                  " and item.estado != 'Deshabilitado';";
                Console.WriteLine(consulta);
                reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            }
            this.CerrarConexion();

            string contador = "SELECT COUNT(item.id_item) AS cantidad" +
                    " FROM museo.item" +
                    " WHERE estado = 'En Bodega' or estado = 'En Restauracion';";
            MySqlDataReader reader2 = this.RealizarConsulta(contador);
            reader2.Read();
            int cantidad = Int32.Parse(reader2["cantidad"].ToString());
            this.CerrarConexion();
            if (cantidad == 0) {
                this.ventana.dataGridViewObjetos.DataSource = null;
            }
        }

        private void CargarSolicitudes()
        {
            string consulta = "SELECT solicitud.id_solicitud AS ID, usuario.nombre, sala.nombre as Origen," +
                    " N.salaDestino as Destino, solicitud.estado AS Estado," +
                    " solicitud.comentario as Comentario FROM usuario, solicitud, sala ," +
                        " (SELECT sala.nombre AS salaDestino, solicitud.id_solicitud AS iD" +
                        " FROM sala, solicitud" +
                        " WHERE solicitud.id_sala_destino = sala.id_sala) AS N " +
                    " WHERE solicitud.id_sala_origen = sala.id_sala" +
                    " AND solicitud.id_administrador = usuario.id_usuario" +
                    " AND N.iD = solicitud.id_solicitud" +
                    " AND solicitud.estado ='Aceptada' AND (solicitud.id_sala_destino=1 or solicitud.id_sala_origen=1);";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(ventana.dataGridViewSolicitudesTraslado, reader);
            this.CerrarConexion();
        }

        private void CargarRegistros()
        {
            MySqlDataReader reader = this.RealizarConsulta("SELECT registro.id_registro AS Registro, item.nombre AS Item, departamento.nombre AS NombreDpto, sala.nombre AS SalaOrigen, C1.SalaDestino " +
                "FROM museo.registro, museo.item, museo.usuario, museo.sala, museo.departamento, " +
                "(SELECT sala.nombre AS SalaDestino, sala.id_sala AS IDSala " +
                "FROM museo.registro, museo.sala " +
                "WHERE registro.id_sala_destino = sala.id_sala " +
                "GROUP BY SalaDestino) AS C1, " +
                "(SELECT usuario.nombre AS Administrador, usuario.id_usuario AS IDAdmin " +
                "FROM museo.registro, museo.usuario " +
                "WHERE registro.id_admin = usuario.id_usuario " +
                "GROUP BY Administrador) AS C2 " +
                "WHERE registro.id_dpto = departamento.id_dpto AND registro.id_sala_origen = sala.id_sala AND " +
                "item.id_item = registro.id_item AND registro.id_gerente = usuario.id_usuario AND " +
                "C1.IDSala = registro.id_sala_destino AND C2.IDAdmin = registro.id_admin;");
            this.PoblarTabla(ventana.dataGridViewRegistros, reader);
            this.CerrarConexion();
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
            this.ventana.buttonCancelarFiltroObjetos.Enabled = true;

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