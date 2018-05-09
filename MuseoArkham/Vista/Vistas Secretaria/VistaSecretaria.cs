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

namespace MuseoArkham.Vista
{
    public partial class VistaSecretaria : Form
    {
        public VistaSecretaria()
        {
            InitializeComponent();
        }

        private void botonAgregarUsuario_Click(object sender, EventArgs e)
        {
            VistaAgregarUsuario vau = new VistaAgregarUsuario();
            vau.ShowDialog();
        }

        private void botonCrearDepto_Click(object sender, EventArgs e)
        {
            VistaCrearDepartamento vcd = new VistaCrearDepartamento();
            vcd.ShowDialog();
        }

        private void botonCrearSala_Click(object sender, EventArgs e)
        {
            VistaCrearSala vcs = new VistaCrearSala();
            vcs.ShowDialog();
        }
    }
}
