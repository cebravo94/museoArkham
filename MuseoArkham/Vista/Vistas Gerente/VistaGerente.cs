using MuseoArkham.Controlador.Controlador_Gerente;
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
    public partial class VistaGerente : Form
    {
        private ControladorGerente controlador;
        public VistaGerente()
        {
            this.controlador = new ControladorGerente(this);
            InitializeComponent();
        }

        private void VistaGerente_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }
    }
}
