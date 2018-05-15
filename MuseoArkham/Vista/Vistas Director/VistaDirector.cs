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

        private void VistaDirector_Load(object sender, EventArgs e)
        {

        }
    }
}
