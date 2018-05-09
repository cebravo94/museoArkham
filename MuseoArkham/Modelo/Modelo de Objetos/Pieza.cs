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
        public String Tipo { get; set; }

        public Pieza(int idItem, int idDpto, int idSala, DateTime fechaIngreso, string descripcion, string coleccion, string estado, string nombre, int anno, bool era, string periodo, string tipo) : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, anno, era)
        {
            Periodo = periodo;
            Tipo = tipo;
        }
    }
}
