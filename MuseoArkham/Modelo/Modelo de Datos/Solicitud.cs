﻿using System;
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

        public void AgregarItem(Item item)
        {
            this.Items.Add(item);
        }
    }
}
