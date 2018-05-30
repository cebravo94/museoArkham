using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using MuseoArkham.Modelo;
using System.Text.RegularExpressions;

namespace MuseoArkham.Controlador
{
    class ControladorLogIn : Controlador
    {
        private VistaLogIn ventana;

        public ControladorLogIn(VistaLogIn ventana)
        {
            this.ventana = ventana;
        }

        /**
         * <summary>
         * Acción que se activa mediante el botón aceptar. Verifica los datos
         * ingresados y de ser correctos abrirá la ventana correspondiente.
         * Si los datos son erroneos tirará un mensaje de error.
         * </summary>
         */
        public void botonAceptar()
        {
            Usuario personal = this.verificarUsuarioRut(this.ventana.textBoxIdentificador.Text, this.ventana.textBoxContrasenna.Text);
            if (personal != null)
            {
                Form nuevaVentana = null;
                switch (personal.Tipo)
                {
                    case "Secretaria":
                        nuevaVentana = new VistaSecretaria();
                        break;
                    case "Bodega":
                        if (VerificarUsuarioDepartamento(personal.Id) == true)
                        {
                            nuevaVentana = new VistaEncargadoDeBodega(personal);
                        }
                        else
                        {
                            string error = "El usuario no posee un departamento asignado.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Director":
                        nuevaVentana = new VistaDirector();
                        break;
                    case "Gerente":
                        nuevaVentana = new VistaGerente(personal);
                        break;
                    case "Administrador":
                        if (VerificarUsuarioDepartamento(personal.Id) == true)
                        {
                            nuevaVentana = new VistaAdministrador(personal);
                        }
                        else
                        {
                            string error = "El usuario no posee un departamento asignado.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Deshabilitado":
                        string s = "La cuenta del usuario se encuentra deshabilitada.";
                        MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (nuevaVentana != null)
                {
                    this.ventana.textBoxContrasenna.Text = "";
                    this.ventana.textBoxIdentificador.Text = "";
                    this.AbrirVentana(nuevaVentana, this.ventana);
                }
            }
            else
            {
                string s = "No se ha podido validar el ingreso.\nRevise su usuario y contraseña.";
                MessageBox.Show(s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarUsuarioDepartamento(int id) 
        {
            string consulta = "select * from departamento where departamento.id_usuario = '" + id + "'";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null)
            {
                this.CerrarConexion();
                return true;
            }
            this.CerrarConexion();
            return false;
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


        private Usuario verificarUsuario(string usuario, string contrasenna)
        {
            string consulta = "select * from usuario where usuario.id_usuario = " + usuario;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            if (reader != null)
            {
                reader.Read();
                Usuario personal;
                personal = new Usuario(reader);
                if (personal.Contrasenna.Equals(contrasenna))
                {
                    this.CerrarConexion();
                    return personal;
                }
            }
            this.CerrarConexion();
            return null;
        }


        private Usuario verificarUsuarioRut(string rut, string contrasenna)
        {

            if (ValidaRut(rut) == false)
            {
            
                return null;
            }

            rut = rut.Replace(".", "").ToUpper();
            const string carcter = "\"";
            rut = carcter + rut + carcter;
            Console.WriteLine(rut);
            string consulta = "select * from usuario where usuario.rut = " + rut;

            MySqlDataReader reader = this.RealizarConsulta(consulta);

            if (reader != null)
            {
                reader.Read();
                Usuario personal;
                personal = new Usuario(reader);
                if (personal.Contrasenna.Equals(contrasenna))
                {
                    this.CerrarConexion();
                    return personal;
                }
            }
            return null;
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
    }
}