﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Departamento
    {
        public int Id { get; }
        public int IdUsuario { get; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public ArrayList Registros;
        public ArrayList Solicitudes;
        public ArrayList Salas;

        public Departamento(int id, int idUsuario, string nombre, string descripcion)
        {
            Id = id;
            IdUsuario = idUsuario;
            Nombre = nombre;
            Descripcion = descripcion;
            Registros = new ArrayList();
            Solicitudes = new ArrayList();
            Salas = new ArrayList();
        }

        public Departamento(MySqlDataReader reader) {
            Id = Int32.Parse(reader["id_dpto"].ToString());
            IdUsuario = Int32.Parse(reader["id_usuario"].ToString());
            Nombre = reader["nombre"].ToString();
            Descripcion = reader["descripcion"].ToString();
            Registros = new ArrayList();
            Solicitudes = new ArrayList();
            Salas = new ArrayList();
        }

        public void AgregarRegistro(Registro registro)
        {
            this.Registros.Add(registro);
        }

        public void AgregarSolicitud(Solicitud solicitud)
        {
            this.Solicitudes.Add(solicitud);
        }

        public void AgregarSala(Sala sala)
        {
            this.Salas.Add(sala);
        }
    }
}
