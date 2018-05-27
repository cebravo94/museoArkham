using MuseoArkham.Controlador.Controlador_Bodeguero;
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
    public partial class VistaEncargadoDeBodega : Form
    {
        private ControladorBodeguero controlador;
        public VistaEncargadoDeBodega(Usuario usuario)
        {
            InitializeComponent();
            this.controlador = new ControladorBodeguero(this, usuario);
            this.controlador.CargarDatosTabla(0);
        }
     
        private void VistaEncargadoDeBodega_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void buttonIncorporarObjeto_Click(object sender, EventArgs e)
        {
            Form ventanaIncorporarObjeto = new VistaIncorporarObjeto(this.controlador.departamento);
            ventanaIncorporarObjeto.ShowDialog();
            this.controlador.CargarDatosTabla(0);
        }

        private void buttonDesincorporarObjeto_Click(object sender, EventArgs e)
        {
            this.controlador.DesincorporarObjeto();
            this.controlador.CargarDatosTabla(0);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.controlador.CargarDatosTabla((sender as TabControl).SelectedIndex);
        }

        private void buttonEnviarRestauracion_Click(object sender, EventArgs e)
        {
            this.controlador.EnviarARestauracion();
            this.controlador.CargarDatosTabla(0);
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            this.controlador.RegistrarSolicitud();
            this.controlador.CargarDatosTabla(1);
        }

        private void buttonVerDetalles_Click(object sender, EventArgs e)
        {
            this.controlador.VerDetallesSolicitudes();
        }

        private void buttonVerDetallesObjetos_Click(object sender, EventArgs e)
        {
            this.controlador.VerDetallesObjetos();
        }

        private void buttonVerDetallesRegistro_Click(object sender, EventArgs e)
        {
            this.controlador.VerDetallesRegistros();
        }
    }
}
