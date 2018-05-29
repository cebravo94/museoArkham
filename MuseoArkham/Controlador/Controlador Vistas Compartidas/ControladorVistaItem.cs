using MuseoArkham.Modelo;
using MuseoArkham.Vista.VistasItem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador
{

    class ControladorVistaItem : Controlador
    {
        private VistaItem ventana;
        private Item item;

        public ControladorVistaItem(VistaItem ventana) {
            this.ventana = ventana;
        }

        public void cargarInfoItem(int idItem) {
            string consulta = "SELECT * FROM item WHERE item.id_item = " + idItem;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            this.item = new Item(reader);
            this.CerrarConexion();
            this.cargarTextBoxesItem();
            this.CerrarConexion();
            this.cargarTextBoxesDetalle();
            this.CerrarConexion();
        }

        private void cargarTextBoxesItem() {
            string consulta;
            consulta = "SELECT departamento.nombre AS nombre FROM item, departamento WHERE departamento.id_dpto = item.id_dpto AND item.id_item = " + item.IdItem;
            Debug.WriteLine("hola"+consulta);
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            ventana.textBox1.Text = reader["nombre"].ToString();
            this.CerrarConexion();
            consulta = "SELECT sala.nombre AS nombre FROM item, sala WHERE sala.id_sala = item.id_sala AND item.id_item = " + item.IdItem;
            reader = this.RealizarConsulta(consulta);
            reader.Read();
            ventana.textBox2.Text = reader["nombre"].ToString();
            this.CerrarConexion();
            this.ventana.textBox3.Text = item.Nombre.ToString();
            this.ventana.textBox4.Text = item.FechaIngreso.ToString("d");//La d es para solo mostrar la fecha sin la hora.
            this.ventana.textBox5.Text = item.Coleccion.ToString();
            this.ventana.textBox6.Text = item.Estado.ToString();
            this.ventana.textBox7.Text = item.Anno.ToString();
            this.ventana.textBox8.Text = item.Era.ToString();
            this.ventana.textBox9.Text = item.TipoItem.ToString();
            this.ventana.textBox10.Text = item.Descripcion.ToString();
        }

        private void cargarTextBoxesDetalle() {
            switch (item.TipoItem) {
                case "Documento":
                    this.cargarDocumento();
                    break;
                case "Vehiculo":
                    this.cargarVehiculo();
                    break;
                case "Pieza":
                    this.cargarPieza();
                    break;
                case "Obra":
                    this.cargarObra();
                    break;
            }
        }

        private void cargarDocumento() {
            string consulta;
            consulta = "SELECT documento.* FROM item, documento WHERE item.id_item = documento.id_item and item.id_item = "+item.IdItem;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            Documento documento= new Documento(item, reader);
            this.ventana.label11.Text = "Autor";
            this.ventana.textBox11.Text = documento.Autor;
            this.ventana.label12.Text = "Tipo";
            this.ventana.textBox12.Text = documento.Tipo;
        }

        private void cargarObra() {
            string consulta;
            consulta = "SELECT obra.* FROM item, obra WHERE item.id_item = obra.id_item and item.id_item = " + item.IdItem;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            Obra obra = new Obra(item, reader);
            this.ventana.label11.Text = "Autor";
            this.ventana.textBox11.Text = obra.Autor;
            this.ventana.label12.Text = "Tipo";
            this.ventana.textBox12.Text = obra.TipoObra;
            this.ventana.label13.Text = "Material";
            this.ventana.textBox13.Text = obra.Material;
            this.ventana.label13.Visible = true;
            this.ventana.textBox13.Visible = true;
            this.ventana.label14.Text = "Estilo";
            this.ventana.textBox14.Text = obra.Estilo;
            this.ventana.label14.Visible = true;
            this.ventana.textBox14.Visible = true;

        }

        private void cargarVehiculo() {
            string consulta;
            consulta = "SELECT vehiculo.* FROM item, vehiculo WHERE item.id_item = vehiculo.id_item and item.id_item = " + item.IdItem;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            Vehiculo vehiculo = new Vehiculo(item, reader);
            this.ventana.label11.Text = "Marca";
            this.ventana.textBox11.Text = vehiculo.Marca;
            this.ventana.label12.Text = "Modelo";
            this.ventana.textBox12.Text = vehiculo.Modelo;
        }

        private void cargarPieza() {
            string consulta;
            consulta = "SELECT pieza.* FROM item, pieza WHERE item.id_item = pieza.id_item and item.id_item = " + item.IdItem;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            Pieza pieza = new Pieza(item, reader);
            this.ventana.label11.Text = "Tipo";
            this.ventana.textBox11.Text = pieza.TipoPieza;
            this.ventana.label12.Text = "Periodo";
            this.ventana.textBox12.Text = pieza.Periodo;
        }


    }
}
