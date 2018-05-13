using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorSecretaria : Controlador
    {
        private VistaSecretaria ventana;

        public ControladorSecretaria(VistaSecretaria ventana) {
            this.ventana = ventana;
        }
    }
}
