using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Item
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
        public String Era { get; } //Antes de Cristo = True - Despues de Cristo = False

        public Item(int idItem, int idDpto, int idSala, DateTime fechaIngreso, string descripcion, string coleccion, string estado, string nombre, string tipoItem, int anno, String era)
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

        public Item(MySqlDataReader reader) {
            IdItem = Int32.Parse(reader["id_item"].ToString());
            IdDpto = Int32.Parse(reader["id_dpto"].ToString());
            IdSala = Int32.Parse(reader["id_sala"].ToString());
            FechaIngreso = DateTime.Parse(reader["id_registro"].ToString());
            Descripcion = reader["descripcion"].ToString();
            Coleccion = reader["coleccion"].ToString();
            Estado = reader["estado"].ToString();
            Nombre = reader["nombre"].ToString();
            TipoItem = reader["tipo"].ToString();
            Anno = Int32.Parse(reader["descripcion"].ToString());
            Era = reader["era"].ToString();
        }
    }
}
