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
        public VistaCrearSala()
        {
            this.controlador = new ControladorCrearSala(this);
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.controlador.crearSala(textBoxNombreSala.Text, (int)numericArea.Value, textBoxDescripcionSala.Text);
        }
    }
}
