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
    public partial class VistaCrearSala : Form
    {
        private ControladorCrearSala controlador;

        public VistaCrearSala() {
            this.controlador = new ControladorCrearSala(this);
            InitializeComponent();
        }



        private void VistaCrearSala_Load(object sender, EventArgs e) {

        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            this.controlador.ValidarSala(textBoxNombreSala.Text, numericUpDownMetrosCuadrados.Value.ToString(), textBoxDescripcionSala.Text);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
