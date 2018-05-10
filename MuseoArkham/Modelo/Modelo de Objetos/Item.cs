using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public abstract class Item
    {
        public int IdItem { get; }
        public int IdDpto { get; }
        public int IdSala { get; }
        public DateTime FechaIngreso { get; set; }//(anno/mes/dia)
        public String Descripcion { get; set; }
        public String Coleccion { get; set; }
        public String Estado { get; set; }
        public String Nombre { get; set; }
        public String  TipoItem { get; set; }
        public int Anno { get; }
        public Boolean Era { get; } //Antes de Cristo = True - Despues de Cristo = False

        public Item(int idItem, int idDpto, int idSala, DateTime fechaIngreso, string descripcion, string coleccion, string estado, string nombre, string tipoItem, int anno, bool era)
        {
            IdItem = idItem;
            IdDpto = idDpto;
            IdSala = idSala;
            FechaIngreso = fechaIngreso;
            Descripcion = descripcion;
            Coleccion = coleccion;
            Estado = estado;
            Nombre = nombre;
            TipoItem = tipoItem;
            Anno = anno;
            Era = era;
        }
    }
}
