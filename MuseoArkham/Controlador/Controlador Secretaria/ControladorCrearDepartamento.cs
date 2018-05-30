using MuseoArkham.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{


    class ControladorCrearDepartamento : Controlador
    {
        private VistaCrearDepartamento ventana;

        public ControladorCrearDepartamento(VistaCrearDepartamento ventana)
        {
            this.ventana = ventana;
        }

        /**
         * <sumary>
         * Este metodo se encarga de crear un nuevo departamento segun los datos que ingrese la secretaria.
         * Basicamente controla el evento que realiza el boton aceptar de la ventana crear departamento.
         * </sumary>
         * 
         * <param name="nombre"> Nombre del departamento que se desea crear.</param>
         * <param name="descripcion"> Descripcion asociada al departamento que se desea crear.</param>
        **/
        public void crearDepartamento(string nombre, string descripcion)
        {
            string valores = "VALUES (1,'" + nombre + "','" + descripcion + "' , 'Activo')";
            string consulta = "INSERT INTO departamento (id_usuario,nombre,descripcion,estado) " + valores;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            this.CerrarConexion();
            this.refrescarTablaPadre();
        }

        public void refrescarTablaPadre()
        {
            ((VistaSecretaria)(this.ventana.Owner)).refrescarTabla(0);
        }
    }
}
