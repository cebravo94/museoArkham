using MuseoArkham.Controlador.Controlador_Bodeguero;
using MuseoArkham.Modelo;
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
    public partial class VistaIncorporarObjeto : Form
    {

        ControladorIncorporarObjeto controlador;

        public VistaIncorporarObjeto(Departamento departamento)
        {
            InitializeComponent();
            this.controlador = new ControladorIncorporarObjeto(this, departamento);
            
        }

        private void VistaAgregarObjeto_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        //Metodos para llamar a los controladores para agregar items
        private void buttonIncorporarDocumento_Click(object sender, EventArgs e)
        {
            this.controlador.IncorporarDocumento();
            this.Close();
        }

        private void buttonIncorporarObra_Click(object sender, EventArgs e)
        {
            this.controlador.IncorporarObra();
            this.Close();
        }

        private void buttonIncorporarPieza_Click(object sender, EventArgs e)
        {
            this.controlador.IncorporarPieza();
            this.Close();
        }

        private void buttonIncorporarVehiculo_Click(object sender, EventArgs e)
        {
            this.controlador.IncorporarVehiculo();
            this.Close();
        }

        private void comboBoxEraDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Botones de Cancelar
        private void button1Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
