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

namespace MuseoArkham.Vista.VistasItem
{
    public partial class VistaItem : Form
    {
        private ControladorVistaItem controlador;

        public VistaItem(int idItem) {
            InitializeComponent();
            this.controlador = new ControladorVistaItem(this);
            this.cargarInfoItem(idItem);
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cargarInfoItem(int idItem) {
            this.controlador.cargarInfoItem(idItem);
        }
    }
}
