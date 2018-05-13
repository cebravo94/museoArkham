using MuseoArkham.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador.ControladorDirector
{
    class ControladorDirector : Controlador
    {
        private VistaDirector ventana;
        public ControladorDirector(VistaDirector ventana) {
            this.ventana = ventana;
        }
    }
}
