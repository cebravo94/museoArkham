using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Vista;
using MuseoArkham.Controlador.Controlador_Secretaria;

namespace MuseoArkham.Vista
{
    public partial class VistaSecretaria : Form
    {
        private ControladorSecretaria controlador;
        public VistaSecretaria()
        {
            this.controlador = new ControladorSecretaria(this);
            InitializeComponent();
        }



        private void VistaSecretaria_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void buttonCrearDepartamento_Click(object sender, EventArgs e)
        {
            VistaCrearDepartamento vcd = new VistaCrearDepartamento();
            vcd.ShowDialog();
        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            VistaCrearSala vcs = new VistaCrearSala();
            vcs.ShowDialog();
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            VistaAgregarUsuario vau = new VistaAgregarUsuario();
            vau.ShowDialog();
        }
    }
}
