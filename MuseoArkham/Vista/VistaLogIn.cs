using MuseoArkham.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham
{
    public partial class VistaLogIn : Form
    {
        private ControladorLogIn controlador;
        public VistaLogIn() {
            this.controlador = new ControladorLogIn();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            controlador.botonAceptar(this.textBoxIdentificador.Text, this.textBoxContrasenna.Text);
        }
    }
}
