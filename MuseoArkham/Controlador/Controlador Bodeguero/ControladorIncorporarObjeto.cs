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
            int anno = Int32.Parse(ventana.textBoxAnnoDocumento.Text);
            String era = ventana.comboBoxEraDocumento.SelectedItem.ToString();
            String tipo = ventana.comboBoxTipoDocumento.SelectedItem.ToString();
            String autor = ventana.textBoxAutorDocumento.Text;
            String descripcion = ventana.textBoxDescripcionDocumento.Text;
            DateTime fechaIngreso = DateTime.Today;
            documentoNuevo = new Documento(0,2,1,fechaIngreso,descripcion,coleccionDocumento, "En Bodega", nombreDocumento,"documento",anno,era,tipo,autor);

            //Consulta sql para insertar
            this.InsertarDocumentoBD(documentoNuevo);
        }

        public void IncorporarObra()
        {
            String nombreObra = ventana.textBoxNombreObra.Text;
            String coleccionObra = ventana.textBoxColeccionObra.Text;
            int anno = Int32.Parse(ventana.textBoxAnnoObra.Text);
            String era = ventana.comboBoxEraObra.SelectedItem.ToString();
            String tipo = ventana.comboBoxTipoObra.SelectedItem.ToString();
            String autor = ventana.textBoxAutorObra.Text;
            String material = ventana.textBoxMaterialObra.Text;
            String estilo = ventana.textBoxEstiloObra.Text;
            String descripcion = ventana.textBoxDescripcionObra.Text;
            DateTime fechaIngreso = DateTime.Today;

            obraNueva = new Obra(0, 2, 1, fechaIngreso, descripcion, coleccionObra, "En Bodega", nombreObra, "obra", anno, era, material, estilo, tipo, autor);

            //Consulta sql para insertar
            this.InsertarObraBD(obraNueva);
        }

        public void IncorporarPieza()
        {
            String nombrePieza = ventana.textBoxNombrePieza.Text;
            String coleccionPieza = ventana.textBoxColeccionPieza.Text;
            int anno = Int32.Parse(ventana.textBoxAnnoPieza.Text);
            String era = ventana.comboBoxEraPieza.SelectedItem.ToString();
            String tipo = ventana.comboBoxTipoPieza.SelectedItem.ToString();
            String periodo = ventana.textBoxPeriodoPieza.Text;
            String descripcion = ventana.textBoxDescripcionPieza.Text;
            DateTime fechaIngreso = DateTime.Today;

            piezaNueva = new Pieza(0,2,1,fechaIngreso,descripcion,coleccionPieza, "En Bodega", nombrePieza,"pieza",anno,era,periodo,tipo);

            //Consulta sql para insertar
            this.InsertarPiezaBD(piezaNueva);
        }

        public void IncorporarVehiculo()
        {
            String nombreVehiculo = ventana.textBoxNombreVehiculo.Text;
            String coleccionVehiculo = ventana.textBoxColeccionVehiculo.Text;
            int anno = Int32.Parse(ventana.textBoxAnnoVehiculo.Text);
            String era = ventana.comboBoxEraVehiculo.SelectedItem.ToString();
            String marca = ventana.textBoxMarcaVehiculo.Text;
            String modelo = ventana.textBoxModeloVehiculo.Text;
            String descripcion = ventana.textBoxDescripcionVehiculo.Text;
            DateTime fechaIngreso = DateTime.Today;

            vehiculoNuevo = new Vehiculo(0,2,1,fechaIngreso,descripcion,coleccionVehiculo, "En Bodega",nombreVehiculo,"vehiculo",anno,era,marca,modelo);

            //Consulta sql para insertar
            this.InsertarVehiculoBD(vehiculoNuevo);
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
