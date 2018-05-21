using MuseoArkham.Controlador.ControladorDirector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Vista
{
    public partial class VistaDirector : Form
    {
        private ControladorDirector controlador;
        public VistaDirector()
        {
            this.controlador = new ControladorDirector(this);
            InitializeComponent();
        }
        

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaDirector_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void GenerarReporte(object sender, EventArgs e)
        {
            switch (comboBoxReporte.Text) {
                case "General de inventario":
                    this.controlador.ReporteInventario(this.tablaDirector);
                    break;
                case "Departamento":
                    Console.WriteLine("aaa");
                    this.controlador.ReporteDepartamento(comboBoxFiltro.Text,this.tablaDirector);
                    break;
                case "Colección":
                    this.controlador.ReporteColeccion(comboBoxFiltro.Text, this.tablaDirector);
                    break;
                case "Autor":
                    this.controlador.ReporteAutor(comboBoxFiltro.Text, this.tablaDirector);
                    break;
                case "Estilo artistico":
                    this.controlador.ReporteEstilo(comboBoxFiltro.Text, this.tablaDirector);
                    break;
                case "Marca":
                    this.controlador.ReporteMarca(comboBoxFiltro.Text, this.tablaDirector);
                    break;
                case "Año de origen de objeto":
                    this.controlador.ReporteAnno(comboBoxFiltro.Text, this.tablaDirector);
                    break;
            }

        }
        
        private void comboBoxReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReporte.Text == "General de inventario")
            {
                this.comboBoxFiltro.Enabled = false;

            }

            if (comboBoxReporte.Text != "General de inventario" && comboBoxReporte.Text != "Seleccionar tipo reporte" )
            {
                this.comboBoxFiltro.Enabled = true;
                this.comboBoxFiltro.Text = "Seleccionar dato";
                this.controlador.LlenarComboBox(comboBoxReporte.Text,comboBoxFiltro);
            }

            
        }

        private void BotonPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
