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
        DataGridView dataGrid;
        public VistaAsignarAdministrador(DataGridView data)
        {
            this.controlador = new ControladorAsignarAdministrador(this);
            this.dataGrid = data;
            InitializeComponent();
            this.controlador.RellenarComboBox(comboBoxAdministrador);
        }

        private void buttonAsignarAdministrador_Click(object sender, EventArgs e)
        {
            string nombreAdmin = comboBoxAdministrador.GetItemText(comboBoxAdministrador.SelectedItem);
            
            this.controlador.AsignarAdministrador(this.dataGrid,nombreAdmin);
            this.Close();
        }
    }
}
