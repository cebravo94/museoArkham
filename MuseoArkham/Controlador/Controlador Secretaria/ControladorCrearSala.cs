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
            
            if (nombre.Length>0) {

                string valores = "VALUES ( '" +departamento + "'  ,      '" + nombre + "'  ,    '" + descripcion + "' ,'" + area + "', 'Disponible' )";
                string consulta = "INSERT INTO sala (id_dpto,nombre,descripcion,area,estado) " + valores;
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.CerrarConexion();
                this.refrescarTablaPadre();

            }
            else
            {
                MessageBox.Show("El nombre de la sala es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                
            }
            
        }

        public void refrescarTablaPadre()
        {
            ((VistaSecretaria)(this.ventana.Owner)).refrescarTabla(1);
        }

       
    }
}
