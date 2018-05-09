﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Modelo
{
    public class Usuario
    {
        public int Id { get; }
        public String Contrasenna { get; set; }
        public String Nombre { get; set; }
        public String Rut { get; set; }
        public DateTime FechaIngreso { get; set; }//(anno/mes/dia)
        public String Correo { get; set; }
        public String Tipo { get; set; }

        public Usuario(int id, string contrasenna, string nombre, string rut, DateTime fechaIngreso, string correo, string tipo)
        {
            Id = id;
            Contrasenna = contrasenna;
            Nombre = nombre;
            Rut = rut;
            FechaIngreso = fechaIngreso;
            Correo = correo;
            Tipo = tipo;
        }
    }
}
