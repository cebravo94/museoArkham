﻿using System;
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
        public Vehiculo(int idItem, int idDpto, int idSala, DateTime fechaIngreso, string descripcion, string coleccion, string estado, string nombre, string tipoItem, int anno, bool era, string marca, string modelo) : base(idItem, idDpto, idSala, fechaIngreso, descripcion, coleccion, estado, nombre, tipoItem, anno, era)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}
