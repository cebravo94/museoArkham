using MuseoArkham.Vista;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorAgregarUsuario : Controlador
    {
        private VistaAgregarUsuario ventana;

        public ControladorAgregarUsuario(VistaAgregarUsuario ventana) {
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
        public void botonAceptar(String nombre, String rut, String correo, String tipoUsuario, String contrasenna) {
            if (insertarUsuario(nombre, rut, correo, tipoUsuario, contrasenna) == true) {
                string s = "Usuario creado con exito.";
                MessageBox.Show(s, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form.ActiveForm.Close();
            }
            else {
                string s = "Error en crear usuario.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form owner = this.ventana.Owner;
            VistaSecretaria vs = (VistaSecretaria)owner;
            vs.refrescarTabla(2);
        }

        public void error() {
            string s = "Todos los campos deben de tener un valor.";
            MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void validarCampos(string nombre, string rut, string correo, string tipoUsuario, string contrasenna)
        {
            if (nombre.Length > 0 && rut.Length > 0 && correo.Length > 0 && tipoUsuario.Length > 0 && contrasenna.Length > 0)
            {
                rut = FormatearRut(rut);
                if (ValidaRut(rut) == true)
                {
                    Boolean rutVerificacion = verificarRutUsuario(rut);
                    Boolean correoVerificacion = verificarCorreoUsuario(correo);
                    if (rutVerificacion == true && correoVerificacion == true)
                    {
                        botonAceptar(nombre, rut, correo, tipoUsuario, contrasenna);
                    }
                    else if (rutVerificacion == false && correoVerificacion == true)
                    {
                        string s = "Ya existe un usuario con el rut que se ha ingresado. El rut debe de " +
                            "ser unico.";
                        MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rutVerificacion == true && correoVerificacion == false)
                    {
                        string s = "Ya existe un usuario con el correo que se ha ingresado. El correo debe de " +
                            "ser unico.";
                        MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string s = "Ya existe un usuario con el rut y el correo electronico" +
                            " que se ha ingresado. El rut y el correo electronico deben de " +
                            "ser unicos.";
                        MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    string s = "Rut no valido. Verifique que el Rut este escrito correctamente.\n" +
                        "Formato xxxxxxxx-x o xx.xxx.xxx-x.";
                    MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else {
                string s = "Todos los campos deben de tener un valor.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string FormatearRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            return rut;
        }

        public bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// método que calcula el digito verificador a partir
        /// de la mantisa del rut
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        private bool verificarCorreoUsuario(string correo)
        {
            string consulta = "select * from usuario where usuario.correo = '" + correo  + "'";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null)
            {
                this.CerrarConexion();
                return false;
            }
            this.CerrarConexion();
            return true;
        }

        private Boolean verificarRutUsuario(string rut)
        {
            string consulta = "select * from usuario where usuario.rut = '" + rut + "'";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null)
            {
                Console.WriteLine("is");
                this.CerrarConexion();
                return false;
            }
            this.CerrarConexion();
            return true;
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
            catch (Exception ex) {


                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
