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
        DataGridView dataGrid;
        public VistaAsignarSala(DataGridView data)
        {
            this.controlador = new ControladorAsignarSala(this);
            this.dataGrid = data;
            InitializeComponent();

            this.controlador.RellenarComboBox(comboBoxSala);
        }

        private void buttonAsignarSala_Click(object sender, EventArgs e)
        {
            string nombreSala = comboBoxSala.GetItemText(comboBoxSala.SelectedItem);
            int index = this.dataGrid.CurrentCell.RowIndex;
            DataGridViewRow data = this.dataGrid.Rows[index];
            string id = data.Cells[0].Value.ToString();
            this.controlador.AsignarSala(id,nombreSala);
            this.Close();
        }
    }
}
