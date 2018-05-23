using MuseoArkham.Modelo;
using MuseoArkham.Vista.Vistas_Administrador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador.Controlador_Administrador
{
    class ControladorVerSolicitud : Controlador
    {
        private VistaVerSolicitud ventana;

        public ControladorVerSolicitud(VistaVerSolicitud ventana) {
            this.ventana = ventana;
        }

        public void cargarSolicitud(int indexSolicitud) {
            string consulta = "SELECT * FROM solicitud WHERE solicitud.id_solicitud = " + indexSolicitud;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            Solicitud solicitud = new Solicitud(reader);
            this.CerrarConexion();
            this.cargarTextBoxes(reader, solicitud);
            this.cargarItemsSolicitud(reader, solicitud);
        }

        private void cargarItemsSolicitud(MySqlDataReader reader, Solicitud solicitud) {
            string consulta;
            consulta = "SELECT item.id_item AS ID, item.nombre AS Nombre," +
                    " item.estado AS Estado, item.tipo AS Tipo, item.descripcion AS Descripción" +
                    " FROM item, solicitud, itemsolicitado" +
                    " WHERE item.id_item = itemsolicitado.id_item" +
                    " AND solicitud.id_solicitud = itemsolicitado.id_solicitud" +
                    " AND solicitud.id_solicitud = " + solicitud.Id;
            reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(this.ventana.dataGridViewItems, reader);
            this.CerrarConexion();
        }

        private void cargarTextBoxes(MySqlDataReader reader, Solicitud solicitud) {
            string consulta;
            consulta = "SELECT usuario.nombre AS nombre FROM solicitud, usuario WHERE solicitud.id_administrador = usuario.id_usuario AND solicitud.id_solicitud = " + solicitud.Id;
            reader = this.RealizarConsulta(consulta);
            reader.Read();
            ventana.textBoxAdministrador.Text = reader["nombre"].ToString();
            this.CerrarConexion();
            consulta = "SELECT sala.nombre AS nombre FROM solicitud, sala WHERE solicitud.id_sala_origen = sala.id_sala AND solicitud.id_solicitud = " + solicitud.Id;
            reader = this.RealizarConsulta(consulta);
            reader.Read();
            ventana.textBoxSalaOrigen.Text = reader["nombre"].ToString();
            this.CerrarConexion();
            consulta = "SELECT sala.nombre AS nombre FROM solicitud, sala WHERE solicitud.id_sala_destino = sala.id_sala AND solicitud.id_solicitud = " + solicitud.Id;
            reader = this.RealizarConsulta(consulta);
            reader.Read();
            ventana.textBoxSalaDestino.Text = reader["nombre"].ToString();
            this.CerrarConexion();
            this.ventana.textBoxComentarios.Text = solicitud.Comentario;
            this.ventana.textBoxEstado.Text = solicitud.Estado;
        }
    }
}
