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
            MySqlDataReader reader = this.RealizarConsulta("SELECT sala.nombre AS Sala FROM sala, departamento"+
                " WHERE sala.id_dpto = departamento.id_dpto AND departamento.id_dpto = "+this.departamento.Id);
            if (reader != null) {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                //dataTable.Rows[0]["nombre"].ToString();
                List<string> myList = new List<string>();
                foreach (DataRow row in dataTable.Rows) {
                    myList.Add(row[0].ToString());
                }
                ventana.comboBoxSalaOrigen.DataSource = myList;
            }
            this.CerrarConexion();
        }
    }
}

