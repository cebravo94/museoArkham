using MuseoArkham.Controlador.Controlador_Secretaria;
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
    public partial class VistaAgregarUsuario : Form
    {
        ControladorAgregarUsuario controlador;
        public VistaAgregarUsuario()
        {         
            this.controlador = new ControladorAgregarUsuario(this);
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VistaAgregarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
