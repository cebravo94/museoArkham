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
    public partial class VistaCambiarAdministrador : Form
    {
        private ControladorCambiarAdministrador controlador;
        DataGridView dataGrid;

        public VistaCambiarAdministrador(DataGridView dataGrid)
        {
            this.controlador = new ControladorCambiarAdministrador(this);
            this.dataGrid = dataGrid;
            InitializeComponent();
            this.controlador.RellenarComboBox(comboBoxAdministrador);
        }

        private void buttonAsignarAdministrador_Click(object sender, EventArgs e)
        {
            string nombreAdmin = comboBoxAdministrador.GetItemText(comboBoxAdministrador.SelectedItem);

            this.controlador.CambiarAdministrador(this.dataGrid, nombreAdmin);
            this.Close();
        }
    }
}
