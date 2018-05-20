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

namespace MuseoArkham.Vista.Vistas_Administrador
{
    public partial class VistaVerSolicitud : Form
    {
        ControladorVerSolicitud controlador;
        public VistaVerSolicitud(int indexSolicitud) {
            InitializeComponent();
            this.controlador = new ControladorVerSolicitud(this);
            this.cargarDatos(indexSolicitud);

        }

        private void buttonSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cargarDatos(int indexSolicitud) {
            this.controlador.cargarSolicitud(indexSolicitud);
        }
    }
}
