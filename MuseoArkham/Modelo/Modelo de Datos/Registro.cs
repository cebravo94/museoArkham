﻿using System;
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
        public int IdSalaOrigen { get; }
        public int IdSalaDestino { get; }
        public DateTime FechaIngreso { get; set; } //(anno/mes/dia)
        public ArrayList Items;

        public Registro(int idRegistro, int idDpto, int idItem, int idAdmin, int idSalaOrigen, int idSalaDestino, DateTime fechaIngreso)
        {
            IdRegistro = idRegistro;
            IdDpto = idDpto;
            IdItem = idItem;
            IdAdmin = idAdmin;
            IdSalaOrigen = idSalaOrigen;
            IdSalaDestino = idSalaDestino;
            FechaIngreso = fechaIngreso;
            Items = new ArrayList();
        }

    }
}