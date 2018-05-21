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
            this.controlador = new ControladorGerente(this, usuario);  
            InitializeComponent();
            this.controlador.cargarDatosTabla(0);
        }

        private void VistaGerente_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Este metodo debe recibir u obtener una solicitud en particular que se haya selecionado para cambiar su estado a "Aceptada".
            this.controlador.aceptarSolicitud();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Este metodo debe recibir u obtener una solicitud en particular que se haya seleccionado para cambiar su estado a "Rechazada".
            this.controlador.rechazarSolicitud();
        }

        private void tabControlSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.controlador.cargarDatosTabla((sender as TabControl).SelectedIndex);
        }

        private void VistaGerente_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptarSolicitud_Click(object sender, EventArgs e)
        {
            this.controlador.aceptarSolicitud();
        }

        private void dataGridViewSolicitudesTraslado_SelectionChanged(object sender, EventArgs e)
        {
            this.controlador.cambioDeSeleccion();
        }

        private void buttonRechazarSolicitud_Click(object sender, EventArgs e)
        {
            this.controlador.rechazarSolicitud();
        }
    }
}
