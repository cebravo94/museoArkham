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
    public partial class VistaAsignarAdministrador : Form
    {
        private ControladorAsignarAdministrador controlador;
        string id;
        public VistaAsignarAdministrador(string id)
        {
            this.controlador = new ControladorAsignarAdministrador(this);
            this.id = id;
            InitializeComponent();
            this.controlador.RellenarComboBox(comboBoxAdministrador);
        }

        private void buttonAsignarAdministrador_Click(object sender, EventArgs e)
        {
            string nombreAdmin = comboBoxAdministrador.GetItemText(comboBoxAdministrador.SelectedItem);
            this.controlador.AsignarAdministrador(id,nombreAdmin);
            this.Close();
        }
    }
}
