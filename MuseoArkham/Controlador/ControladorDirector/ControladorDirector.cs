using MuseoArkham.Vista;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Modelo;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace MuseoArkham.Controlador.ControladorDirector
{
    class ControladorDirector : Controlador
    {
        private VistaDirector ventana;
        private String consultaActual = "nada";

        public ControladorDirector(VistaDirector ventana) {
            this.ventana = ventana;
        }

        /**
         * <summary>
         * Metodo que recibe los tipos de reportes que se haran y el filtro correspondiente
         * 
         * </summary>
         * 
         * <param name="comboTipoReporte"> Recibe desde la ventana el tipo de reporte que se hará</param>
         * <param name="comboFiltro"> Recibe desde la ventana el tipo de reporte que se hará</param>
         */
        public void BotonGenerar(String reporte, String filtro, DataGridView tabla)
        {
            switch (reporte)
            {
                case "General de inventario":
                    this.ReporteInventario(tabla);
                    break;
                case "Departamento":
                    Console.WriteLine("aaa");
                    this.ReporteDepartamento(filtro,tabla);
                    break;
                case "Colección":
                    this.ReporteColeccion(filtro, tabla);
                    break;
                case "Autor":
                    this.ReporteAutor(filtro, tabla);
                    break;
                case "Estilo artistico":
                    this.ReporteEstilo(filtro, tabla);
                    break;
                case "Marca":
                    this.ReporteMarca(filtro, tabla);
                    break;
                case "Año de origen de objeto":
                    this.ReporteAnno(filtro, tabla);
                    break;
            }

        }
        

        public void LlenarComboBox(String tipo , ComboBox combob ) {

            MySqlDataReader reader;

            switch (tipo){
                case "Departamento":
                   combob.Items.Clear();
                   reader = this.RealizarConsulta("select * from departamento");
                    while (reader.Read()) {
                        String depa = reader["nombre"].ToString();
                        combob.Items.Add(depa);
                    }
                    this.CerrarConexion();
                    break;
                case "Colección":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item group by item.coleccion");
                    while (reader.Read())
                    {
                        String coleccion = reader["coleccion"].ToString();
                        combob.Items.Add(coleccion);
                    }
                    this.CerrarConexion();

                    break;
                case "Autor":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item , obra where item.id_item = obra.id_item");
                    while (reader.Read())
                    {
                        String autor = reader["autor"].ToString();
                        combob.Items.Add(autor);
                    }
                    this.CerrarConexion();

                    break;
                case "Marca":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item , vehiculo where item.id_item = vehiculo.id_item group by vehiculo.marca");
                    while (reader.Read())
                    {
                        String marca = reader["marca"].ToString();
                        combob.Items.Add(marca);
                    }
                    this.CerrarConexion();

                    break;

                case "Estilo artistico":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item , obra where item.id_item = obra.id_item  group by obra.estilo");
                    while (reader.Read())
                    {
                        String estilo = reader["estilo"].ToString();
                        combob.Items.Add(estilo);
                    }
                    this.CerrarConexion();

                    break;
                    
                case "Año de origen de objeto":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item group by item.anno");
                    while (reader.Read())
                    {
                        int anno = Int32.Parse(reader["anno"].ToString());
                        combob.Items.Add(anno);
                    }
                    this.CerrarConexion();

                    break;
                    
            }

        }
        public void ReporteDepartamento(string text,DataGridView tabla)
        {
            MySqlDataReader read;
            String consulta = "SELECT t2.nombre , t2.descripcion,t1.nombre as nombreItem , t4.nombre as nombreUsuario , t3.nombre as nombreSala FROM item as t1, departamento as t2, sala as t3 , usuario as t4 WHERE t2.nombre = '" + text + "' AND t2.id_dpto = t1.id_dpto AND t3.id_dpto = t2.id_dpto AND t4.id_usuario = t2.id_usuario";
            this.consultaActual = "Reporte general de departamento";
            read = this.RealizarConsulta(consulta);
            Console.WriteLine(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteInventario(DataGridView tabla) {
            MySqlDataReader read;
            this.consultaActual = "Reporte general de inventario";
            read = this.RealizarConsulta("select * from item");
            if (read != null){
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteColeccion(string text, DataGridView tabla)
        {
            Console.WriteLine("entro a crear el reporte de coleccion");
            MySqlDataReader read;

            String consulta = "SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.* FROM item as t1, departamento as t2, sala as t3 WHERE t1.coleccion = '" + text + "' AND t2.id_dpto = t1.id_dpto AND t3.id_dpto = t2.id_dpto";
            this.consultaActual = "Reporte a partir de una coleccion";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }
    

        public void ReporteAnno(string text, DataGridView tabla)
        {
            MySqlDataReader read;
          
            String consulta = "SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.* FROM item as t1, departamento as t2, sala as t3 WHERE t1.anno =" + text + " AND t2.id_dpto = t1.id_dpto AND t3.id_dpto = t2.id_dpto";
            this.consultaActual = "Reporte apartir de año de origen de un objeto";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteMarca(string text, DataGridView tabla)
        {
            MySqlDataReader read;

            String consulta = "SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.* FROM item as t1, departamento as t2, vehiculo as t4 ,sala as t3 WHERE t4.marca = '" + text + "' AND t2.id_dpto = t1.id_dpto  AND t4.id_item = t1.id_item and t1.id_sala = t3.id_sala";
            this.consultaActual = "Reporte a partir de una marca";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteEstilo(string text, DataGridView tabla)
        {
            MySqlDataReader read;

            String consulta = "SELECT t3.estilo , t1.* FROM item as t1,departamento as t2,obra as t3 WHERE t3.id_item = t1.id_item and t3.estilo = '"+ text +"' and t1.id_dpto = t2.id_dpto";
            this.consultaActual = "Reporte a partir de un estilo artistico";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteAutor(string text, DataGridView tabla)
        {
            MySqlDataReader read;

            String consulta = "SELECT t3.autor , t1.* FROM item as t1,departamento as t2,obra as t3 WHERE t3.id_item = t1.id_item and t3.autor = '" + text + "' and t1.id_dpto = t2.id_dpto";
            this.consultaActual = "Reporte a partir de un autor";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ExportarPdf(DataGridView tabla) {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }
            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
               
                string fecha = "Fecha: " + DateTime.Now.ToString();

                Chunk chunk = new Chunk(this.consultaActual + ".", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("Reporte efectuado por director del museo."));
                doc.Add(new Paragraph(fecha));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarTabla(doc,tabla);
                doc.AddCreationDate();
                doc.Close();
            }

        }
        private void GenerarTabla(Document document,DataGridView dataGridView1)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataGridView1);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                datatable.AddCell(dataGridView1.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        private float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] valor = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                valor[i] = (float)dg.Columns[i].Width;
            }
            return valor;

        }

        public String ObtenrConsultaActual() {
            return this.consultaActual;

        }
    }
  }

