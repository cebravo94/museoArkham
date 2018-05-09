using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;

namespace MuseoArkham.Controlador
{
    class ControladorLogIn : Controlador
    {
        public void botonAceptar(string usuario, string contrasenna) {
            string tipo = this.verificarUsuario(usuario, contrasenna);
            if (tipo != null) {
                Form form = null;
                switch (tipo){
                    case "Secretaria":
                        form = new VistaSecretaria();
                        break;
                    case "Bodega":
                        form = new VistaEncargadoDeBodega();
                        break;
                    case "Director":
                        form = new VistaDirector();
                        break;
                    case "Gerente":
                        form = new VistaGerente();
                        break;
                    case "Administrador":
                        form = new VistaAdministrador();
                        break;
                }
                if (form!=null) this.abrirVentana(form);
            }
        }

        public string verificarUsuario(string usuario, string contrasenna) {
            string consulta = "select * from usuario where usuario.id_usuario = " + usuario;
            MySqlDataReader reader = this.realizarConsulta(consulta);

            if (reader != null) {
                reader.Read();
                if (reader["contrasenna"].ToString().Equals(contrasenna)) {
                    String tipo = reader["tipo"].ToString();
                    this.cerrarConexion();
                    return tipo;
                }
            }
            return null;
        }
    }
}
