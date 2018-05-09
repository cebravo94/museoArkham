using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Sala
    {
        public int Id { get; }
        public int IdDpto { get; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public ArrayList Items;

        public Sala(int id, int idDpto, string nombre, string descripcion, bool estado)
        {
            Id = id;
            IdDpto = idDpto;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
            Items = new ArrayList();
        }
    }
}
