using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Controlador;
using MuseoArkham.Controlador.Controlador_Administrador;

namespace MuseoArkham.Vista
{
    public partial class VistaCrearSolicitud : Form
    {
        private ControladorCrearSolicitud controlador;
        public VistaCrearSolicitud()
        {
            this.controlador = new ControladorCrearSolicitud(this);
            InitializeComponent();
        }

        private void CrearSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.controlador.botonCrear();
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
    }
}

