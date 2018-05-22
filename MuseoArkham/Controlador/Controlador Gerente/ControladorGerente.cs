﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using MuseoArkham.Modelo;
using System.Data;

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
            //this.departamento = this.cargarDepartamento();
        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud en particular previamente seleccionada y el estado de esta debe ser modifcada
         * a "Aceptada" y luego de eso se debe enviar a las solicitudes que puede visualizar el encargado de bodega y el administrador
         * que realizo dicha solicitud debe poder visualizar que su solicitud fue aceptada.
         * </sumary>
        **/
        public void aceptarSolicitud()
        {
            int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
            int id = int.Parse(data.Cells[0].Value.ToString());
            string consulta = "SELECT * FROM itemsolicitado,item WHERE itemsolicitado.id_item = item.id_item AND itemsolicitado.id_solicitud=" + id;
            MySqlDataReader reader1 = this.RealizarConsulta(consulta);
            if (reader1 == null)
            {
                string s = "No hay objetos vinculados a la solicitud";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CerrarConexion();
                return;
            }
            DataTable tabla = new DataTable();
            tabla.Load(reader1);
            reader1.Close();
            this.CerrarConexion();
            if (objetosDisponibles(id, tabla))
            {

                foreach (DataRow row in tabla.Rows)
                {
                    
                    Console.WriteLine("dato: " + row[0].ToString());
                    int idItem = int.Parse(row[0].ToString());
                    this.RealizarConsultaNoQuery("UPDATE item SET item.estado ='En Solicitud' WHERE item.id_item=" + idItem);
                   
                }
                this.RealizarConsultaNoQuery("UPDATE solicitud SET solicitud.estado ='Aceptada' WHERE solicitud.id_solicitud=" + id);
                this.cargarDatosTabla(0);
            }

        }

        private bool objetosDisponibles(int id, DataTable tabla)
        {
            //Console.WriteLine("Estoy en comprobar objetos");
            foreach(DataRow row in tabla.Rows)
            {
                Console.WriteLine("hols" + row[9].ToString());
                if (row[9].ToString().Equals("En Solicitud")){
                    string s = "El objeto solicitado no se encuentra disponible";
                    MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


        internal void cambioDeSeleccion()
        {
            try
            {
                int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
                DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
                String estado = data.Cells[4].Value.ToString();
                if (estado.Equals("Aceptada") || estado.Equals("Rechazada")){
                    this.ventana.botonAceptarSolicitud.Enabled = false;
                    this.ventana.botonRechazarSolicitud.Enabled = false;

                }
                else
                {
                    this.ventana.botonAceptarSolicitud.Enabled = true;
                    this.ventana.botonRechazarSolicitud.Enabled = true;
                }
            }catch (Exception e) { };
        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud en particular previamente seleccionada y el estado de esta debe ser modifcada
         * a "Rechazada" y el administrador que realizo dicha solicitud debe poder visualizar que su solicitud fue rechazada.
         * </sumary>
        **/
        public void rechazarSolicitud()
        {
            int index = this.ventana.dataGridViewSolicitudesTraslado.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewSolicitudesTraslado.Rows[index];
            int id = int.Parse(data.Cells[0].Value.ToString());
            this.RealizarConsultaNoQuery("UPDATE solicitud SET solicitud.estado ='Rechazada' WHERE solicitud.id_solicitud=" + id);
            this.cargarDatosTabla(0);
        }

        private Departamento cargarDepartamento()
        {
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null)
            {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                return departamento;
            }
            return null;
        }

        internal void cargarDatosTabla(int index)
        {
            switch (index)
            {
                case 0:
                    this.cargarSolicitudes();
                    break;

                case 1:
                    this.cargarObjetos();
                    break;

            }
        }

        private void cargarObjetos()
        {
            string consulta = "SELECT item.id_item AS ID, item.nombre AS Nombre, sala.nombre AS Ubicación," +
                    " item.estado AS Estado, item.tipo AS Tipo, item.descripcion AS Descripción" +
                    " FROM item, departamento, sala" +
                    " WHERE item.id_dpto = departamento.id_dpto" +
                    " AND sala.id_sala = item.id_sala";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            this.CerrarConexion();
        }

        private void cargarSolicitudes()
        {

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
    }
}
