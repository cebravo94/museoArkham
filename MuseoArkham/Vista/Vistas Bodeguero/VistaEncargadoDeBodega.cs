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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
               
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VistaEncargadoDeBodega_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void VistaEncargadoDeBodega_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

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

        private void dataGridViewObjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void dataGridViewRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonVerDetalles_Click(object sender, EventArgs e)
        {
            this.controlador.VerDetallesSolicitudes();
        }

        private void buttonVerDetallesObjetos_Click(object sender, EventArgs e)
        {
            this.controlador.VerDetallesObjetos();
        }

        private void buttonFiltrarObjetos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.controlador.aplicarFiltroObjetos();
        }

        private void button3_Click(object sender, EventArgs e) {
            this.controlador.CargarDatosTabla(0);
            this.buttonAplicarFiltroObjetos.Enabled = true;
            this.buttonCancelarFiltroObjetos.Enabled = false;
            this.comboBoxObjetos.Enabled = true;
        }
    }
}
