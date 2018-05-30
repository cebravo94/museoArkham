using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Vista.Vistas_Secretaria;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;

namespace MuseoArkham.Controlador.Controlador_Secretaria
{
    class ControladorAsignarSala : Controlador
    {
        VistaAsignarSala ventana;
        
        public ControladorAsignarSala(VistaAsignarSala ventana)
        {
            
            this.ventana = ventana;
        }


        public void RellenarComboBox(ComboBox combo)
        {
            string consulta = "SELECT * FROM sala" +
                               " WHERE sala.estado = 'Disponible'";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            
            DataTable dataTable = new DataTable();
            if (reader != null)
            {
                dataTable.Load(reader);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string text = dataTable.Rows[i]["nombre"].ToString();
                combo.Items.Add(text);
            }
            combo.SelectedItem = 0;
            this.CerrarConexion();
        }

        public void AsignarSala(string id, string nombre,Boolean validar)
        {
            if (validar)
            {
                this.mostrarMensaje("No se puede asignar sala a la bodega");
            }
            else
            {
                string valor = this.ObtenerSala(nombre);

                string consulta = "UPDATE sala SET sala.estado = 'En Uso' WHERE sala.id_sala = '" + valor + "'";
                this.RealizarConsultaNoQuery(consulta);

                string consulta2 = "UPDATE sala SET sala.id_dpto = '" + id + "' WHERE sala.id_sala = '" + valor + "'";
                this.RealizarConsultaNoQuery(consulta2);

                this.refrescarTablaPadre();
            }

        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private string ObtenerSala(string nombre)
        {

            string consulta = "SELECT sala.id_sala FROM sala WHERE sala.nombre = '" + nombre + "'";
            Console.WriteLine(nombre);
            Console.WriteLine(consulta);
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            string valor = reader.GetString(0);
            this.CerrarConexion();
            return valor;

        }

        public void refrescarTablaPadre()
        {
            ((VistaSecretaria)(this.ventana.Owner)).refrescarTabla(1);
        }
    }


    
}
