﻿
using MuseoArkham.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Bodeguero
{
    class ControladorIncorporarObjeto : Controlador
    {
        private VistaIncorporarObjeto ventana;
        private Departamento departamento;
        Documento documentoNuevo { get; set; }
        Obra obraNueva { get; set; }
        Pieza piezaNueva { get; set; } 
        Vehiculo vehiculoNuevo { get; set; }

        public ControladorIncorporarObjeto(VistaIncorporarObjeto ventana, Departamento departamento)
        {
            this.ventana = ventana;
            this.departamento = departamento;
        }
        
        private DateTime obtenerFechaDeIngreso()
        {
            DateTime fecha = DateTime.Today;
            return fecha;
        }

        public void IncorporarDocumento()
        {
            String nombreDocumento = ventana.textBoxNombreDocumento.Text;
            String coleccionDocumento = ventana.textBoxColeccionDocumento.Text;
            int anno = -1;
            try
            {
                anno = Int32.Parse(ventana.textBoxAnnoDocumento.Text);
            }
            catch
            {
                MessageBox.Show(this.ventana, "No se puede Incorporar el objeto, el AÑO es invalido", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String era = null;
            try
            {
                era = ventana.comboBoxEraDocumento.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(this.ventana, "Debe seleccionar una Era", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String tipo = null;
            try
            {
                tipo = ventana.comboBoxTipoDocumento.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(this.ventana, "Debe seleccionar un Tipo", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            String autor = ventana.textBoxAutorDocumento.Text;
            String descripcion = ventana.textBoxDescripcionDocumento.Text;
            DateTime fechaIngreso = DateTime.Today;
            if (anno != -1 && (anno <= DateTime.Today.Year || ((anno > DateTime.Today.Year) && (era == "A.C."))) 
                && era != null && tipo != null && !string.IsNullOrEmpty(nombreDocumento) 
                && !string.IsNullOrEmpty(coleccionDocumento) && !string.IsNullOrEmpty(autor) 
                && !string.IsNullOrWhiteSpace(nombreDocumento)
                && !string.IsNullOrWhiteSpace(coleccionDocumento) && !string.IsNullOrWhiteSpace(autor))
            {
                documentoNuevo = new Documento(0, 2, 1, fechaIngreso, descripcion, coleccionDocumento, "En Bodega", nombreDocumento, "Documento", anno, era, tipo, autor);
                //Consulta sql para insertar
                this.InsertarDocumentoBD(documentoNuevo);
            }
            else
            {
                if ((anno > DateTime.Today.Year) && (era == "D.C."))
                {
                    MessageBox.Show(this.ventana, "El objeto no puede tener un AÑO mayor al actual", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this.ventana, "Los campos Nombre, Coleccion y Autor son obligatorios", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void IncorporarObra()
        {
            String nombreObra = ventana.textBoxNombreObra.Text;
            String coleccionObra = ventana.textBoxColeccionObra.Text;
            int anno = -1;
            try
            {
                anno = Int32.Parse(ventana.textBoxAnnoObra.Text);
            }
            catch
            {
                MessageBox.Show(this.ventana, "No se puede Incorporar el objeto, el AÑO es invalido", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            String era = null;
            try
            {
                era = ventana.comboBoxEraObra.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(this.ventana, "Debe seleccionar una Era", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String tipo = null;
            try
            {
                tipo = ventana.comboBoxTipoObra.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(this.ventana, "Debe seleccionar un Tipo", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            String autor = ventana.textBoxAutorObra.Text;
            String material = ventana.textBoxMaterialObra.Text;
            String estilo = ventana.textBoxEstiloObra.Text;
            String descripcion = ventana.textBoxDescripcionObra.Text;
            DateTime fechaIngreso = DateTime.Today;
            if (anno != -1 && (anno <= DateTime.Today.Year || ((anno > DateTime.Today.Year) && (era == "A.C."))) 
                && era != null && tipo != null && !string.IsNullOrEmpty(nombreObra) && !string.IsNullOrEmpty(coleccionObra) 
                && !string.IsNullOrEmpty(autor) && !string.IsNullOrEmpty(material) && !string.IsNullOrEmpty(estilo) 
                && !string.IsNullOrWhiteSpace(nombreObra) && !string.IsNullOrWhiteSpace(coleccionObra) 
                && !string.IsNullOrWhiteSpace(autor) && !string.IsNullOrWhiteSpace(material) && !string.IsNullOrWhiteSpace(estilo))
            {
                obraNueva = new Obra(0, 2, 1, fechaIngreso, descripcion, coleccionObra, "En Bodega", nombreObra, "Obra", anno, era, material, estilo, tipo, autor);
                //Consulta sql para insertar
                this.InsertarObraBD(obraNueva);
            }
            else
            {
                if ((anno > DateTime.Today.Year) && (era=="D.C."))
                {
                    MessageBox.Show(this.ventana, "El objeto no puede tener un AÑO mayor actual si la era es D.C.", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this.ventana, "Los campos Nombre, Coleccion, Autor, Material y Estilo son obligatorios", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void IncorporarPieza()
        {
            String nombrePieza = ventana.textBoxNombrePieza.Text;
            String coleccionPieza = ventana.textBoxColeccionPieza.Text;
            int anno = -1;
            try
            {
                anno = Int32.Parse(ventana.textBoxAnnoPieza.Text);
            }
            catch
            {
                MessageBox.Show(this.ventana, "No se puede Incorporar el objeto, el AÑO es invalido", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            String era = null;
            try
            {
                era = ventana.comboBoxEraPieza.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(this.ventana, "Debe seleccionar una Era", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            String tipo = null;
            try
            {
                tipo = ventana.comboBoxTipoPieza.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(this.ventana, "Debe seleccionar un tipo", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            String periodo = ventana.textBoxPeriodoPieza.Text;
            String descripcion = ventana.textBoxDescripcionPieza.Text;
            DateTime fechaIngreso = DateTime.Today;

            if (anno != -1 && (anno <= DateTime.Today.Year || ((anno > DateTime.Today.Year) && (era == "A.C."))) 
                && era != null && tipo != null && !string.IsNullOrEmpty(nombrePieza)
                && !string.IsNullOrEmpty(coleccionPieza) && !string.IsNullOrEmpty(periodo) && !string.IsNullOrWhiteSpace(nombrePieza)
                && !string.IsNullOrWhiteSpace(coleccionPieza) && !string.IsNullOrWhiteSpace(periodo))
            {
                piezaNueva = new Pieza(0, 2, 1, fechaIngreso, descripcion, coleccionPieza, "En Bodega", nombrePieza, "Pieza", anno, era, periodo, tipo);
                //Consulta sql para insertar
                this.InsertarPiezaBD(piezaNueva);
            }
            else
            {
                if ((anno > DateTime.Today.Year) && (era == "D.C."))
                {
                    MessageBox.Show(this.ventana, "El objeto no puede tener un AÑO mayor al actual", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this.ventana, "Los campos Nombre, Coleccion y Periodo son obligatorios", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void IncorporarVehiculo()
        {
            String nombreVehiculo = ventana.textBoxNombreVehiculo.Text;
            String coleccionVehiculo = ventana.textBoxColeccionVehiculo.Text;
            int anno = -1;
            try
            {
                anno = Int32.Parse(ventana.textBoxAnnoVehiculo.Text);
            }
            catch
            {
                MessageBox.Show(this.ventana, "No se puede Incorporar el objeto, el AÑO es invalido", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String era = null;
            try
            {
                era = ventana.comboBoxEraVehiculo.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(this.ventana, "Debe seleccionar una Era", "Accion Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            String marca = ventana.textBoxMarcaVehiculo.Text;
            String modelo = ventana.textBoxModeloVehiculo.Text;
            String descripcion = ventana.textBoxDescripcionVehiculo.Text;
            DateTime fechaIngreso = DateTime.Today;
            if (anno != -1 && (anno <= DateTime.Today.Year || ((anno > DateTime.Today.Year) && (era == "A.C."))) 
                && era != null && !string.IsNullOrEmpty(nombreVehiculo)
                && !string.IsNullOrEmpty(coleccionVehiculo) && !string.IsNullOrEmpty(marca) && !string.IsNullOrEmpty(modelo)
                && !string.IsNullOrWhiteSpace(nombreVehiculo) && !string.IsNullOrWhiteSpace(coleccionVehiculo)
                && !string.IsNullOrWhiteSpace(marca) && !string.IsNullOrWhiteSpace(modelo))
            {
                vehiculoNuevo = new Vehiculo(0, 2, 1, fechaIngreso, descripcion, coleccionVehiculo, "En Bodega", nombreVehiculo, "Vehiculo", anno, era, marca, modelo);
                //Consulta sql para insertar
                this.InsertarVehiculoBD(vehiculoNuevo);
            }
            else
            {
                if ((anno > DateTime.Today.Year) && (era=="D.C."))
                {
                    MessageBox.Show(this.ventana, "El objeto no puede tener un AÑO mayor al actual", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this.ventana, "Los campos Nombre, Coleccion, Marca y Modelo son obligatorios", "Accion Invalida",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private String FormatearFecha(DateTime fecha)
        {
            String dia = fecha.Day.ToString();
            String mes = fecha.Month.ToString();
            String anno = fecha.Year.ToString();
            String fechaFormateada = anno + "-" + mes + "-" + dia;

            return fechaFormateada;
        }

        private void InsertarDocumentoBD(Documento documento)
        {
            String consulta1 = "INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES" +
                " (" + documento.IdDpto + "," + documento.IdSala + ",'" + this.FormatearFecha(documento.FechaIngreso) + "','" + documento.Descripcion + "','" + documento.Coleccion + "','" +
                documento.Estado + "'," + documento.Anno + ",'" + documento.TipoItem + "','" + documento.Nombre + "','" + documento.Era + "');";
            MySqlDataReader reader = this.RealizarConsulta(consulta1);
            this.CerrarConexion();

            String consulta2 = "select id_item from museo.item;";
            Console.WriteLine(consulta2);
            reader = this.RealizarConsulta(consulta2);
            int mayor = 0;
            if (reader!=null)
            {
                
                while (reader.Read())
                {
                    int numero = reader.GetInt32(0);
                    if (mayor<numero)
                    {
                        mayor = numero;
                    }
                }
            }
            this.CerrarConexion();
            
            
            String consulta3 = "INSERT INTO documento (id_item,tipo,autor) VALUES ("+mayor+ ",'" +documento.Tipo + "','" +documento.Autor+"');";
            reader = this.RealizarConsulta(consulta3);
            this.CerrarConexion();
        }

        private void InsertarObraBD(Obra obra)
        {
            String consulta1 = "INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES" +
                " (" + obra.IdDpto + "," + obra.IdSala + ",'" + this.FormatearFecha(obra.FechaIngreso) + "','" + obra.Descripcion + "','" + obra.Coleccion + "','" +
                obra.Estado + "'," + obra.Anno + ",'" + obra.TipoItem + "','" + obra.Nombre + "','" + obra.Era + "');";
            MySqlDataReader reader = this.RealizarConsulta(consulta1);
            this.CerrarConexion();

            String consulta2 = "select id_item from museo.item;";
            Console.WriteLine(consulta2);
            reader = this.RealizarConsulta(consulta2);
            int mayor = 0;
            if (reader != null)
            {

                while (reader.Read())
                {
                    int numero = reader.GetInt32(0);
                    if (mayor < numero)
                    {
                        mayor = numero;
                    }
                }
            }
            this.CerrarConexion();


            String consulta3 = "INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (" + mayor + ",'" + obra.Material + "','" + obra.Estilo + "','"+
                obra.TipoObra+"','" + obra.Autor+"');";
            reader = this.RealizarConsulta(consulta3);
            this.CerrarConexion();
        }

        private void InsertarPiezaBD(Pieza pieza)
        {
            String consulta1 = "INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES" +
                " (" + pieza.IdDpto + "," + pieza.IdSala + ",'" + this.FormatearFecha(pieza.FechaIngreso) + "','" + pieza.Descripcion + "','" + pieza.Coleccion + "','" +
                pieza.Estado + "'," + pieza.Anno + ",'" + pieza.TipoItem + "','" + pieza.Nombre + "','" + pieza.Era + "');";
            MySqlDataReader reader = this.RealizarConsulta(consulta1);
            this.CerrarConexion();

            String consulta2 = "select id_item from museo.item;";
            Console.WriteLine(consulta2);
            reader = this.RealizarConsulta(consulta2);
            int mayor = 0;
            if (reader != null)
            {

                while (reader.Read())
                {
                    int numero = reader.GetInt32(0);
                    if (mayor < numero)
                    {
                        mayor = numero;
                    }
                }
            }
            this.CerrarConexion();


            String consulta3 = "INSERT INTO pieza (id_item,periodo,tipo) VALUES (" + mayor + ",'" + pieza.Periodo + "','" + pieza.TipoPieza + "');";
            reader = this.RealizarConsulta(consulta3);
            this.CerrarConexion();
        }

        private void InsertarVehiculoBD(Vehiculo vehiculo)
        {
            String consulta1 = "INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES" +
                " (" + vehiculo.IdDpto + "," + vehiculo.IdSala + ",'" + this.FormatearFecha(vehiculo.FechaIngreso) + "','" + vehiculo.Descripcion + "','" + vehiculo.Coleccion + "','" +
                vehiculo.Estado + "'," + vehiculo.Anno + ",'" + vehiculo.TipoItem + "','" + vehiculo.Nombre + "','" + vehiculo.Era + "');";
            MySqlDataReader reader = this.RealizarConsulta(consulta1);
            this.CerrarConexion();

            String consulta2 = "select id_item from museo.item;";
            Console.WriteLine(consulta2);
            reader = this.RealizarConsulta(consulta2);
            int mayor = 0;
            if (reader != null)
            {

                while (reader.Read())
                {
                    int numero = reader.GetInt32(0);
                    if (mayor < numero)
                    {
                        mayor = numero;
                    }
                }
            }
            this.CerrarConexion();


            String consulta3 = "INSERT INTO vehiculo (id_item,marca,modelo) VALUES (" + mayor + ",'" + vehiculo.Marca + "','" + vehiculo.Modelo + "');";
            reader = this.RealizarConsulta(consulta3);
            this.CerrarConexion();
        }
    }
}
