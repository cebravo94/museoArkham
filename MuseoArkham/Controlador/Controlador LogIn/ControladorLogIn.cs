using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using MuseoArkham.Modelo;

namespace MuseoArkham.Controlador
{
    class ControladorLogIn : Controlador
    {
        private VistaLogIn ventana;

        public ControladorLogIn(VistaLogIn ventana) {
            this.ventana = ventana;
        }
        
        /**
         * <summary>
         * Acción que se activa mediante el botón aceptar. Verifica los datos
         * ingresados y de ser correctos abrirá la ventana correspondiente.
         * Si los datos son erroneos tirará un mensaje de error.
         * </summary>
         */
        public void botonAceptar() {
            Usuario personal = this.verificarUsuario(this.ventana.textBoxIdentificador.Text, this.ventana.textBoxContrasenna.Text);
            if (personal != null) {
                Form nuevaVentana = null;
                switch (personal.Tipo) {
                    case "Secretaria":
                        nuevaVentana = new VistaSecretaria();
                        break;
                    case "Bodega":
                        nuevaVentana = new VistaEncargadoDeBodega();
                        break;
                    case "Director":
                        nuevaVentana = new VistaDirector();
                        break;
                    case "Gerente":
                        nuevaVentana = new VistaGerente();
                        break;
                    case "Administrador":
                        nuevaVentana = new VistaAdministrador(personal);
                        break;
                }
                if (nuevaVentana != null) {
                    this.ventana.textBoxContrasenna.Text = "";
                    this.ventana.textBoxIdentificador.Text = "";
                    this.AbrirVentana(nuevaVentana, this.ventana);
                }
            }
            else {
                string s = "No se ha podido validar el ingreso.\nRevise su usuario y contraseña.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * <summary>
         * Este metodo verifica que el usuario y la contraseña sean correctos
         * Si es el caso, retornará un string con el tipo de usuario que es.
         * Sino, retornará null.
         * </summary>
         * <param name="usuario"> El rut del usuario</param>
         * <param name="contrasenna"> La contraseña del usuario</param>
         * 
         * <returns>Tipo de usuario</returns>
         */
        private Usuario verificarUsuario(string usuario, string contrasenna) {
            string consulta = "select * from usuario where usuario.id_usuario = " + usuario;
            MySqlDataReader reader = this.RealizarConsulta(consulta);

            if (reader != null) {
                reader.Read();
                Usuario personal;
                personal = new Usuario(Int32.Parse(reader["id_usuario"].ToString()),reader["contrasenna"].ToString(),
                    reader["nombre"].ToString(),reader["rut"].ToString(), DateTime.Parse(reader["fechaIngreso"].ToString()),
                    reader["correo"].ToString(),reader["tipo"].ToString());
                if (personal.Contrasenna.Equals(contrasenna)) {
                    this.CerrarConexion();
                    return personal;
                }
            }
            return null;
        }
    }
}
