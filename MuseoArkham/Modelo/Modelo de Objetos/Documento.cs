using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Documento : Item
    {
        public String Tipo { get; set; }
        public String Autor { get; set; }

        public Documento(int idItem, int idDpto, int idSala, DateTime fechaIngreso, string descripcion, string coleccion, string estado, string nombre, int anno, bool era, string tipo, string autor) : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, anno, era)
        {
            Tipo = tipo;
            Autor = autor;
        }

    }
}
