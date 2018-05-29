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
            if (comboBoxReporte.Text == "Seleccionar tipo reporte" || comboBoxFiltro.Text == "Seleccionar dato")
            {
                MessageBox.Show("Llene los campos solicitados para generar el reporte.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                this.controlador.BotonGenerar(comboBoxReporte.Text,comboBoxFiltro.Text,this.tablaDirector);
                
            }

        }
        
        private void comboBoxReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReporte.Text == "General de inventario")
            {
                this.comboBoxFiltro.Enabled = false;
                this.comboBoxFiltro.Text = " ";

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
            if (this.controlador.ObtenrConsultaActual() == "nada")
            {
                MessageBox.Show("Genere un reporte para exportarlo a PDF.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.controlador.ExportarPdf(this.tablaDirector);
            }
        }
    }
}
