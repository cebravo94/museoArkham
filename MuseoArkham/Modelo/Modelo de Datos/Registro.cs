using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Registro
    {
        public int IdRegistro { get; }
        public int IdDpto { get; }
        public int IdItem { get; }
        public int IdAdmin { get; } //Deberia ser la id de gerente de exhibicion o se deberia agregar tambien
        public int IdGerente { get; }
        public int IdSalaOrigen { get; }
        public int IdSalaDestino { get; }
        public DateTime FechaIngreso { get; set; } //(anno/mes/dia)
        public ArrayList Items;

        public Registro(int idRegistro, int idDpto, int idItem, int idAdmin, int idGerente, int idSalaOrigen, int idSalaDestino, DateTime fechaIngreso)
        {
            IdRegistro = idRegistro;
            IdDpto = idDpto;
            IdItem = idItem;
            IdAdmin = idAdmin;
            IdGerente = idGerente;
            IdSalaOrigen = idSalaOrigen;
            IdSalaDestino = idSalaDestino;
            FechaIngreso = fechaIngreso;
            Items = new ArrayList();
        }

        public Registro(MySqlDataReader reader) {
            IdRegistro = Int32.Parse(reader["id_registro"].ToString());
            IdDpto = Int32.Parse(reader["id_dpto"].ToString());
            IdItem = Int32.Parse(reader["id_item"].ToString());
            IdAdmin = Int32.Parse(reader["id_admin"].ToString());
            IdGerente = Int32.Parse(reader["id_gerente"].ToString());
            IdSalaOrigen = Int32.Parse(reader["id_sala_origen"].ToString());
            IdSalaDestino = Int32.Parse(reader["id_sala_destino"].ToString());
            FechaIngreso = DateTime.Parse(reader["fecha_ingreso"].ToString());
        }

        public void AgregarItem(Item item)
        {
            this.Items.Add(item);
        }
    }
}
