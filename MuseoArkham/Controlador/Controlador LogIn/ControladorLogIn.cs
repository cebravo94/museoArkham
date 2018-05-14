﻿using System;
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
            string tipo = this.verificarUsuario(this.ventana.textBoxIdentificador.Text, this.ventana.textBoxContrasenna.Text);
            if (tipo != null) {
                Form nuevaVentana = null;
                switch (tipo) {
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
                        nuevaVentana = new VistaAdministrador();
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
        private string verificarUsuario(string usuario, string contrasenna) {
            string consulta = "select * from usuario where usuario.id_usuario = " + usuario;
            MySqlDataReader reader = this.RealizarConsulta(consulta);

            if (reader != null) {
                reader.Read();
                if (reader["contrasenna"].ToString().Equals(contrasenna)) {
                    String tipo = reader["tipo"].ToString();
                    this.CerrarConexion();
                    return tipo;
                }
            }
            return null;
        }
    }
}