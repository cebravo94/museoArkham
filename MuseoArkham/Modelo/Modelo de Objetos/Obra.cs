using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Obra : Item
    {
        public String Material { get; set; }
        public String Estilo { get; set; }
        public String Tipo { get; set; }
        public String Autor { get; set; }

        public Obra(int idItem, int idDpto, int idSala, DateTime fechaIngreso, string descripcion, string coleccion, string estado, string nombre, int anno, bool era, string material, string estilo, string tipo, string autor) : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, anno, era)
        {
            Material = material;
            Estilo = estilo;
            Tipo = tipo;
            Autor = autor;
        }
    }
}
