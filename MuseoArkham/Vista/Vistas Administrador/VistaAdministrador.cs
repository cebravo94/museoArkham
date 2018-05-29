using MuseoArkham.Controlador.Controlador_Administrador;
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
    public partial class VistaAdministrador : Form
    {
        private ControladorAdministrador controlador;
        public VistaAdministrador(Usuario usuario)
        {
            InitializeComponent();
            this.controlador = new ControladorAdministrador(this, usuario);
            this.controlador.cargarDatosTabla(0);
        }


        private void VistaAdministrador_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void VistaAdministrador_Load(object sender, EventArgs e)
        {
                   }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCrearSolicitud_Click(object sender, EventArgs e)
        {
            Form ventanaCrearSolicitud = new VistaCrearSolicitud(this.controlador.departamento);
            ventanaCrearSolicitud.ShowDialog(this);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            this.controlador.cargarDatosTabla((sender as TabControl).SelectedIndex);
        }

        public void refrescarTabla(int index) {
            this.controlador.cargarDatosTabla(index);
        }

        private void buttonCancelarSolicitud_Click(object sender, EventArgs e) {
            this.controlador.botonCancelarSolicitud();
        }

        private void buttonVerSolicitud_Click(object sender, EventArgs e) {
            this.controlador.botonVerSolicitud();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.controlador.botonVerDetalle();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.controlador.aplicarFiltroSolicitudes();
        }

        private void button3_Click(object sender, EventArgs e) {
            this.controlador.cargarDatosTabla(0);
            this.buttonAplicarFiltroSolicitudes.Enabled = true;
            this.buttonCancelarFiltroSolicitudes.Enabled = false;
            this.comboBoxSolicitudes.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e) {
            this.controlador.aplicarFiltroObjetos();
        }

        private void button4_Click(object sender, EventArgs e) {
            this.controlador.cargarDatosTabla(1);
            this.buttonAplicarFiltroObjetos.Enabled = true;
            this.buttonQuitarFiltroObjetos.Enabled = false;
            this.comboBoxObjetos.Enabled = true;
        }
    }
}
