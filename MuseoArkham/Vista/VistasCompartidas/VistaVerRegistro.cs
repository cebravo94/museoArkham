using MuseoArkham.Controlador.Controlador_Vistas_Compartidas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Vista.VistasCompartidas
{
    public partial class VistaVerRegistro : Form
    {
        private ControladorVerRegistro controlador;

        public VistaVerRegistro(int idRegistro)
        {
            InitializeComponent();
            this.controlador = new ControladorVerRegistro(this);
            this.cargarInfoRegistro(idRegistro);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarInfoRegistro(int idRegistro)
        {
            this.controlador.CargarInfoRegistro(idRegistro);
        }
    }
}
