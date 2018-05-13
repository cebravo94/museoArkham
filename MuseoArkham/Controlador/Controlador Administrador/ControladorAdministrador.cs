using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Administrador
{
    class ControladorAdministrador : Controlador
    {
        private VistaAdministrador ventana;

        public ControladorAdministrador(VistaAdministrador ventana) {
            this.ventana = ventana;
        }

    }
}
