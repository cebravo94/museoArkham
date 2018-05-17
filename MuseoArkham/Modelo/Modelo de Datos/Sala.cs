using MySql.Data.MySqlClient;
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
        public String Estado { get; set; }
        public int Area { get; set; }
        public ArrayList Items;

        public Sala(int id, int idDpto, string nombre, string descripcion, String estado, int area)
        {
            Id = id;
            IdDpto = idDpto;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
            Area = area;
            Items = new ArrayList();
        }

        public Sala(MySqlDataReader reader) {
            Id = Int32.Parse(reader["id_sala"].ToString()); ;
            IdDpto = Int32.Parse(reader["id_dpto"].ToString());
            Nombre = reader["nombre"].ToString();
            Descripcion = reader["descripcion"].ToString();
            Estado = reader["estado"].ToString();
            Area = Int32.Parse(reader["area"].ToString());
            Items = new ArrayList();
        }

        public void AgregarItem(Item item)
        {
            this.Items.Add(item);
        }


    }
}
