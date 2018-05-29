using MuseoArkham.Controlador.Controlador_Gerente;
using MuseoArkham.Modelo;
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
    public partial class VistaGerente : Form
    {
        private ControladorGerente controlador;
        public VistaGerente(Usuario usuario)
        {
            InitializeComponent();
            this.controlador = new ControladorGerente(this, usuario);  
            this.controlador.cargarDatosTabla(0);
            this.comboBoxFiltrarEstado.SelectedIndex = 0;
        }

        private void VistaGerente_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }


        private void tabControlSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.controlador.cargarDatosTabla((sender as TabControl).SelectedIndex);
        }

        private void VistaGerente_Load(object sender, EventArgs e)
        {

        }

        private void botonAceptarSolicitud_Click(object sender, EventArgs e)
        {
            this.controlador.aceptarSolicitud();
        }

        private void dataGridViewSolicitudesTraslado_SelectionChanged(object sender, EventArgs e)
        {
            this.controlador.cambioDeSeleccion();
        }

        private void botonRechazarSolicitud_Click(object sender, EventArgs e)
        {
            this.controlador.rechazarSolicitud();
        }

        private void botonVerDetalleSolicitudTraslado_Click(object sender, EventArgs e)
        {
            this.controlador.verDetalleSolicitud();
        }

        private void botonVerDetallesObjeto_Click(object sender, EventArgs e)
        {
            this.controlador.verDetalleObjeto();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.controlador.aplicarFiltroObjetos();
        }

        private void button3_Click(object sender, EventArgs e) {
            this.controlador.cargarDatosTabla(1);
            this.buttonAplicarFiltroObjetos.Enabled = true;
            this.buttonQuitarFiltroObjetos.Enabled = false;
            this.comboBoxObjetos.Enabled = true;
        }

        private void buttonAplicarFiltroSolicitudes_Click(object sender, EventArgs e) {
            this.controlador.aplicarFiltroSolicitudes();
        }

        private void buttonCancelarFiltroSolicitudes_Click(object sender, EventArgs e) {
            this.controlador.cargarDatosTabla(0);
            this.buttonAplicarFiltroSolicitudes.Enabled = true;
            this.buttonCancelarFiltroSolicitudes.Enabled = false;
            this.comboBoxSolicitudes.Enabled = true;
        }
    }
}
