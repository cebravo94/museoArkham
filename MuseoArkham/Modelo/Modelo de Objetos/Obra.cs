using MySql.Data.MySqlClient;
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
        public String TipoObra { get; set; }
        public String Autor { get; set; }

        public Obra(int idItem, int idDpto, int idSala, DateTime fechaIngreso, 
            string descripcion, string coleccion, string estado, string nombre, 
            string tipoItem, int anno, string era, string material, string estilo, string tipoObra, string autor) 
            : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, tipoItem, anno, era)
        {
            Material = material;
            Estilo = estilo;
            TipoObra = tipoObra;
            Autor = autor;
        }

        public Obra(Item item, MySqlDataReader reader) 
            : base(item.IdItem, item.IdDpto, item.IdSala, item.FechaIngreso, 
                  item.Descripcion, item.Coleccion, item.Estado, item.Nombre, 
                  item.TipoItem, item.Anno, item.Era) 
        {
            Material = reader["material"].ToString();
            Estilo = reader["estilo"].ToString();
            TipoObra = reader["tipo"].ToString();
            Autor = reader["autor"].ToString();
        }
    }
}
