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
        public void botonCancelarSolicitud()
        {

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
            }
        }

        private void cargarSolicitudes() {
            if (this.departamento != null) {
                String consulta = "SELECT solicitud.id_solicitud AS Solicitud, item.nombre as Item, sala.nombre as Origen," +
                    " sala.nombre as Destino, solicitud.estado AS Estado, itemSolicitado.fecha_solicitud AS Fecha," +
                    " solicitud.comentario as Comentario FROM solicitud, sala, item, itemSolicitado" +
                    " WHERE solicitud.id_item = item.id_item" +
                    " AND solicitud.id_sala_origen = sala.id_sala" +
                    " AND solicitud.id_sala_destino = sala.id_sala" +
                    " AND itemSolicitado.id_solicitud = solicitud.id_solicitud" +
                    " AND solicitud.id_dpto = "+departamento.Id;
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
                this.CerrarConexion();
            }
        }

        private void cargarItems() {
            if (this.departamento != null) {
                String consulta = "SELECT item.id_item AS ID, item.nombre AS Nombre, sala.nombre AS Ubicación,"+
                    " item.estado AS Estado, item.tipo AS Tipo, item.descripcion AS Descripción" +
                    " FROM item, departamento, sala" +
                    " WHERE item.id_dpto = departamento.id_dpto" +
                    " AND sala.id_sala = item.id_sala"+
                    " AND departamento.id_dpto = " + departamento.Id;
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
                this.CerrarConexion();
            }
        }
    }
}
