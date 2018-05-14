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

        /**
         * <summary>
         * Metodo que recibe los tipos de reportes que se haran y el filtro correspondiente
         * 
         * </summary>
         * 
         * <param name="comboTipoReporte"> Recibe desde la ventana el tipo de reporte que se hará</param>
         * <param name="comboFiltro"> Recibe desde la ventana el tipo de reporte que se hará</param>
         */
        public void botonGenerar(String comboTipoReporte, String comboFiltro)
        {

        }
    }
}
