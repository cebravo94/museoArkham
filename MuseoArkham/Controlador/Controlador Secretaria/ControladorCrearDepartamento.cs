using MuseoArkham.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuseoArkham.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            if(VerificarTamanoNombre(nombre) == true)
            {
                MessageBox.Show("El nombre del departamento es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VerificarNombreDepartamentoUnico(nombre) == true)
                {
                    string valores = "VALUES (1,'" + nombre + "','" + descripcion + "' , 'Activo')";
                    string consulta = "INSERT INTO departamento (id_usuario,nombre,descripcion,estado) " + valores;
                    MySqlDataReader reader = this.RealizarConsulta(consulta);
                    this.CerrarConexion();
                    this.refrescarTablaPadre();
                }
                else
                {
                    MessageBox.Show("Ya existe un departamento con el mismo nombre.\nLos " +
                        "nombres de departamento deben de ser unicos.", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool VerificarTamanoNombre(string nombre)
        {
            if (nombre.Length == 0)
            {
                return true;
            }
            return false;
        }

        private bool VerificarNombreDepartamentoUnico(string nombre)
        {
            if (nombre.Length > 0)
            {
                nombre = nombre.Trim();
                string consulta = "select departamento.id_dpto from departamento where departamento.nombre = '" + nombre + "'";

                MySqlDataReader reader = this.RealizarConsulta(consulta);
                if (reader != null)
                {
                    this.CerrarConexion();
                    return false;
                }
            }
            this.CerrarConexion();
            return true;
        }

        public void refrescarTablaPadre()
        {
            ((VistaSecretaria)(this.ventana.Owner)).refrescarTabla(0);
        }
    }
}
