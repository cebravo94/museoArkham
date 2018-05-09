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

        public Departamento(int id, int idUsuario, string nombre, string descripcion)
        {
            Id = id;
            IdUsuario = idUsuario;
            Nombre = nombre;
            Descripcion = descripcion;
            Registros = new ArrayList();
            Solicitudes = new ArrayList();
        }
    }
}
