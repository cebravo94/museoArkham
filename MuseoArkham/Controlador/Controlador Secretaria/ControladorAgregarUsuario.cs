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
    class ControladorAgregarUsuario : Controlador
    {
        private VistaAgregarUsuario ventana;

        public ControladorAgregarUsuario(VistaAgregarUsuario ventana)
        {
            this.ventana = ventana;
        }

        /**
         * <summary>
         * Controla el evento que se realiza al apretar el boton de aceptar
         * </summary>
         * 
         * <param name="nombre"> El nombre completo del usuario a agregar.</param>
         * <param name="rut"> Rut del usuario que será agregado.</param>
         * <param name="correo"> Correo de contacto del usuario</param>
         * <param name="tipoUsuario"> Tipo de usuario que será.</param>
         * <param name="contrasenna"> Contraseña asignada al usuario.</param>
         */
        public void botonAceptar(String nombre,String rut, String correo, String tipoUsuario, String contrasenna)
        {
            if(validarCampos(nombre, rut, correo, tipoUsuario, contrasenna) == true)
            {
                if (insertarUsuario(nombre, rut, correo, tipoUsuario, contrasenna) == true)
                {
                    string s = "Usuario creado con exito.";
                    MessageBox.Show(s, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form.ActiveForm.Close();
                }
                else
                {
                    string s = "Error en crear usuario.";
                    MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string s = "Error en crear usuario.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos(string nombre, string rut, string correo, string tipoUsuario, string contrasenna)
        {
            if(nombre.Length > 0 && rut.Length > 0 && correo.Length > 0 && tipoUsuario.Length > 0 && contrasenna.Length > 0)
            {
                return true;
            }
            Console.WriteLine(tipoUsuario.Length);
            return false;
        }

        private Boolean insertarUsuario(String nombre, String rut, String correo, String tipoUsuario, String contrasenna)
        {
            try
            {
                string consulta = "INSERT INTO usuario (contrasenna,nombre,rut,correo,fecha_ingreso,tipo) " +
                    "VALUES ('" + contrasenna + "','" + nombre + "','" + rut + "','" + correo + "','" + DateTime.Today.ToString("yyyy/MM/dd") + "','" + tipoUsuario + "');";
                Console.WriteLine(consulta);
                MySqlDataReader reader = this.RealizarConsulta(consulta);
                this.CerrarConexion();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
