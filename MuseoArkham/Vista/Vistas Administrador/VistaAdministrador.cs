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
            this.controlador = new ControladorAdministrador(this, usuario);
            InitializeComponent();
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
    }
}
