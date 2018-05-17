﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Solicitud
    {
        public int Id { get; }
        public int IdDpto { get; }
        public int IdAdministrador { get; }
        public int IdSalaOrigen { get; }
        public int IdSalaDestino { get; }
        public String Comentario { get; set; }
        public String Estado { get; set; }
        public ArrayList Items;

        public Solicitud(int id, int idDpto, int idAdministrador, int idSalaOrigen, int idSalaDestino, string comentario, string estado)
        {
            Id = id;
            IdDpto = idDpto;
            IdAdministrador = idAdministrador;
            IdSalaOrigen = idSalaOrigen;
            IdSalaDestino = idSalaDestino;
            Comentario = comentario;
            Estado = estado;
            Items = new ArrayList();
        }

        public Solicitud(MySqlDataReader reader) {
            Id = Int32.Parse(reader["id_solicitud"].ToString());
            IdDpto = Int32.Parse(reader["id_dpto"].ToString());
            IdAdministrador = Int32.Parse(reader["id_administrador"].ToString());
            IdSalaOrigen = Int32.Parse(reader["id_sala_origen"].ToString());
            IdSalaDestino = Int32.Parse(reader["id_sala_destino"].ToString());
            Comentario = reader["comentario"].ToString();
            Estado = reader["estado"].ToString();
            Items = new ArrayList();
        }

        public void AgregarItem(Item item)
        {
            this.Items.Add(item);
        }
    }
}
