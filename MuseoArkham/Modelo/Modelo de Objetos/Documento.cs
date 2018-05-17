using MySql.Data.MySqlClient;
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

        public Documento(int idItem, int idDpto, int idSala, DateTime fechaIngreso,
            string descripcion, string coleccion, string estado, string nombre,
            string tipoItem, int anno, string era, string tipo, string autor)
            : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, tipoItem, anno, era) 
        {
            Tipo = tipo;
            Autor = autor;
        }

        public Documento(Item item, MySqlDataReader reader) 
            : base(item.IdItem, item.IdDpto, item.IdSala, item.FechaIngreso, 
                  item.Descripcion, item.Coleccion, item.Estado, item.Nombre, 
                  item.TipoItem, item.Anno, item.Era) 
        {
            Tipo = reader["tipo"].ToString();
            Autor = reader["autor"].ToString();
        }
    }
}
