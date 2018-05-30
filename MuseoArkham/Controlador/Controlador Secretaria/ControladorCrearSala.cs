using MuseoArkham.Vista;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorCrearSala : Controlador
    {
        private VistaCrearSala ventana;

        public ControladorCrearSala(VistaCrearSala ventana)
        {
            this.ventana = ventana;
        }



        public void validarArea(int area)
        {
            if (area < 5)
            {
                MessageBox.Show("El area de la sala debe ser mayor o igual a 5", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        public void validarNomber(string nombre)
        {
            if (nombre.Length == 0)
            {
                MessageBox.Show("El nombre de la sala es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        public void ValidarSala(string nombre, string areaString, string descripcion)
        {
            if (VerificarSala(nombre) == true)
            {
                int area = Int32.Parse(areaString);
                int departamento = 1;
                string estado;
                if (departamento == 1)
                {
                    estado = "Disponible";
                }
                else
                {
                    estado = "En uso";
                }
                this.crearSala(departamento, nombre, area, descripcion, estado);
            }
            else
            {
                MessageBox.Show("Ya existe una sala con este nombre. Los nombres de las salas deben " +
                    "de ser unicos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean VerificarSala(string nombre)
        {
            if (nombre.Length > 0)
            {
                string consulta = "select sala.id_sala from sala where sala.nombre = '" + nombre + "'";
                
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

        /**
         * <sumary>Este metodo se encarga de crear una nueva sala en el sistema segun los datos que ingrese la secretaria
         * para que posteriormente estos sean almacenado en la base de datos. Basicamente controla el evento del boton
         * aceptar de la ventana crear sala.
         * </sumary>
         * <param name="departamento">ID del departamento donde se asiganra la sala.</param>
         * <param name="nombre">Nombre de la sala.</param>
         * <param name="area">cantidad de metros cuadrados que posee la sala.</param>
         * <param name="descripcion">Descripcion asociada a la sala que puede contener cualquier caracteristica de esta.</param>
         * <param name="estado">Estado de la sala.</param>
        **/
        public void crearSala(int departamento,string nombre, int area, string descripcion, string estado)
        {
            validarNomber(nombre);
            validarArea(area);
            if (nombre.Length>0 && area >4) {

                string valores = "VALUES ( '" +departamento + "'  ,      '" + nombre + "'  ,    '" + descripcion + "' ,'" + area + "', 'Disponible' )";
                string consulta = "INSERT INTO sala (id_dpto,nombre,descripcion,area,estado) " + valores;
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.CerrarConexion();
                this.refrescarTablaPadre();
                this.ventana.Close();

            }
         
            
        }

        public void refrescarTablaPadre()
        {
            ((VistaSecretaria)(this.ventana.Owner)).refrescarTabla(1);
        }

       
    }
}
