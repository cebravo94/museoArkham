using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Controlador.Controlador_Secretaria;

namespace MuseoArkham.Vista.Vistas_Secretaria
{
    public partial class VistaAsignarSala : Form
    {
        private ControladorAsignarSala controlador;
        string id;
        public VistaAsignarSala(string id)
        {
            this.controlador = new ControladorAsignarSala(this);
            this.id = id;
            InitializeComponent();

            this.controlador.RellenarComboBox(comboBoxSala);
        }

        private void buttonAsignarSala_Click(object sender, EventArgs e)
        {
            string nombreSala = comboBoxSala.GetItemText(comboBoxSala.SelectedItem);
            this.controlador.AsignarSala(id,nombreSala);
            this.Close();
        }
    }
}
