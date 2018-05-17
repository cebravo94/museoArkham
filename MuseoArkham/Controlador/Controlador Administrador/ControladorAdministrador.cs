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

        public ControladorAdministrador(VistaAdministrador ventana, Usuario usuario) {
            this.ventana = ventana;
            this.usuario = usuario;
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
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null) {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                String consulta = "select * from solicitud, departamento" +
                                  " where solicitud.id_dpto=departamento.id_dpto" +
                                  " and departamento.id_dpto=" + departamento.Id;
                Debug.WriteLine(consulta);
                reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            }
            this.CerrarConexion();
        }

        private void cargarItems() {
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null) {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                String consulta = "select * from item, departamento" +
                                  " where item.id_dpto=departamento.id_dpto" +
                                  " and departamento.id_dpto=" + departamento.Id;
                Debug.WriteLine(consulta);
                reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            }
            this.CerrarConexion();
        }
    }
}
