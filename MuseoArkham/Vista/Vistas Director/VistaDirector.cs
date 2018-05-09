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
    public partial class VistaDirector : Form
    {
        public VistaDirector()
        {
            InitializeComponent();
        }
        
        private void comboReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReporte.Text == "Reporte detallado de un departamento") {
                comboDepartamento.Visible = true;
                comboDepartamento.BringToFront();
            }

            if (comboReporte.Text == "Reporte detallado de una colección") {
                combColeccion.Visible = true;
                combColeccion.BringToFront();
            }

            if (comboReporte.Text == "Reporte por autor") {
                combautor.Visible = true;
                combautor.BringToFront();
            }

            if (comboReporte.Text == "Reporte por marca") {
                comboMarca.Visible = true;
                comboMarca.BringToFront();
            }

            if (comboReporte.Text == "Reporte por estilo artistico")
            {
                combestilo.Visible = true;
                combestilo.BringToFront();
            }

            if (comboReporte.Text == "Reporte por año de origen de objeto")
            {
                comboOrigen.Visible = true;
                comboOrigen.BringToFront();
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
