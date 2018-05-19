using MuseoArkham.Controlador.Controlador_Administrador;
using MuseoArkham.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Vista
{
    public partial class VistaCrearSolicitud : Form
    {
        private ControladorCrearSolicitud controlador;

        public VistaCrearSolicitud(Departamento departamento)
        {
            InitializeComponent();
            this.controlador = new ControladorCrearSolicitud(this, departamento);
            this.controlador.llenarSalas();
        }

        private void CrearSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.controlador.crearSolicitud();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBoxCrearSolicitud_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridViewSeleccionObjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSalaOrigen_SelectionChangeCommitted(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            this.controlador.cargarObjetosSala(cb.Text);
            this.controlador.ajustarSalaDestino(cb.Text);
        }

        private void buttonCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
