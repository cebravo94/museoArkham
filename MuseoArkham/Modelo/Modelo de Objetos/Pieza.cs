using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Pieza : Item
    {
        public String Periodo { get; set; }
        public String TipoPieza { get; set; }

        public Pieza(int idItem, int idDpto, int idSala, DateTime fechaIngreso, string descripcion, string coleccion, string estado, string nombre, string tipoItem, int anno, bool era, string periodo, string tipoPieza) : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, tipoItem, anno, era)
        {
            Periodo = periodo;
            TipoPieza = tipoPieza;
        }
    }
}
