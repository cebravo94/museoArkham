using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Vista;
using MuseoArkham.Controlador.Controlador_Secretaria;
using MuseoArkham.Vista.Vistas_Secretaria;

namespace MuseoArkham.Vista
{
    public partial class VistaSecretaria : Form
    {
        private ControladorSecretaria controlador;
        public VistaSecretaria()
        {
            this.controlador = new ControladorSecretaria(this);
            
            InitializeComponent();
            this.controlador.CargarDatos(0);
        }



        private void VistaSecretaria_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void buttonCrearDepartamento_Click(object sender, EventArgs e)
        {
            VistaCrearDepartamento vcd = new VistaCrearDepartamento();
            vcd.ShowDialog(this);
        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            VistaCrearSala vcs = new VistaCrearSala();
            vcs.ShowDialog(this);
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            VistaAgregarUsuario vau = new VistaAgregarUsuario();
            vau.ShowDialog();
        }

    

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.controlador.CargarDatos((sender as TabControl).SelectedIndex);
        }

        public void refrescarTabla(int index)
        {
            this.controlador.CargarDatos(index);
        }

        private void buttonAsignarSalas_Click(object sender, EventArgs e)
        {
            
            int index = this.dataGridViewDepartamento.CurrentCell.RowIndex;
            DataGridViewRow data = this.dataGridViewDepartamento.Rows[index];
            string id = data.Cells[0].Value.ToString();
            
            
            VistaAsignarSala vas = new VistaAsignarSala(id);
            vas.ShowDialog(this);
            
            
            
        }

        private void buttonAsignarAdministrador_Click(object sender, EventArgs e)
        {
            int index = this.dataGridViewDepartamento.CurrentCell.RowIndex;
            DataGridViewRow data = this.dataGridViewDepartamento.Rows[index];
            string id = data.Cells[0].Value.ToString();
            string admin = data.Cells[2].Value.ToString();
            if (admin.Equals("default"))
            {
                VistaAsignarAdministrador vad = new VistaAsignarAdministrador(id);
                vad.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Departamento ya tiene administrador, eliga otro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonEliminarDepartamento_Click(object sender, EventArgs e)
        {
            int index = this.dataGridViewDepartamento.CurrentCell.RowIndex;
            DataGridViewRow data = this.dataGridViewDepartamento.Rows[index];
            string id = data.Cells[0].Value.ToString();
            this.controlador.botonEliminar(id);
            this.refrescarTabla(0);
        }
    }
}
