using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Vehiculo : Item
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public Vehiculo(int idItem, int idDpto, int idSala, DateTime fechaIngreso, 
            string descripcion, string coleccion, string estado, string nombre, 
            string tipoItem, int anno, string era, string marca, string modelo) 
            : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, tipoItem, anno, era)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public Vehiculo(Item item, MySqlDataReader reader) 
            : base(item.IdItem, item.IdDpto, item.IdSala, item.FechaIngreso, 
                  item.Descripcion, item.Coleccion, item.Estado, item.Nombre, 
                  item.TipoItem, item.Anno, item.Era) 
        {
            Marca = reader["marca"].ToString();
            Modelo = reader["modelo"].ToString();
        }
    }
}
