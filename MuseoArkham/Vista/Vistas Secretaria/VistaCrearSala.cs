using MuseoArkham.Controlador.Controlador_Secretaria;
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
    public partial class VistaCrearSala : Form
    {
        private ControladorCrearSala controlador;

        public VistaCrearSala()
        {
            this.controlador = new ControladorCrearSala(this);
            InitializeComponent();
        }

        

        private void VistaCrearSala_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreSala.Text;
            int area = Int32.Parse(numericUpDownMetrosCuadrados.Value.ToString());
            string descripcion = textBoxDescripcionSala.Text;
            int departamento = 1;
            string estado;
            if (departamento == 1)
            {
                estado = "Disponible";
            }
            else
            {
                estado = "En uso";
            }
            
            this.controlador.crearSala(departamento,nombre, area, descripcion,estado);
            this.Close();
        }

       
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
