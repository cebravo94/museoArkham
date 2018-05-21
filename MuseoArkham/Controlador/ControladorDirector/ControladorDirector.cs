using MuseoArkham.Vista;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoArkham.Modelo;
using System.Data;

namespace MuseoArkham.Controlador.ControladorDirector
{
    class ControladorDirector : Controlador
    {
        private VistaDirector ventana;

        public ControladorDirector(VistaDirector ventana) {
            this.ventana = ventana;
        }

        /**
         * <summary>
         * Metodo que recibe los tipos de reportes que se haran y el filtro correspondiente
         * 
         * </summary>
         * 
         * <param name="comboTipoReporte"> Recibe desde la ventana el tipo de reporte que se hará</param>
         * <param name="comboFiltro"> Recibe desde la ventana el tipo de reporte que se hará</param>
         */
        public void botonGenerar(String comboTipoReporte, String comboFiltro)
        {

        }
        

        public void LlenarComboBox(String tipo , ComboBox combob ) {

            MySqlDataReader reader;

            switch (tipo){
                case "Departamento":
                   combob.Items.Clear();
                   reader = this.RealizarConsulta("select * from departamento");
                    while (reader.Read()) {
                        String depa = reader["nombre"].ToString();
                        combob.Items.Add(depa);
                    }
                    this.CerrarConexion();
                    break;
                case "Colección":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item group by item.coleccion");
                    while (reader.Read())
                    {
                        String coleccion = reader["coleccion"].ToString();
                        combob.Items.Add(coleccion);
                    }
                    this.CerrarConexion();

                    break;
                case "Autor":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item , obra where item.id_item = obra.id_item");
                    while (reader.Read())
                    {
                        String autor = reader["autor"].ToString();
                        combob.Items.Add(autor);
                    }
                    this.CerrarConexion();

                    break;
                case "Marca":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item , vehiculo where item.id_item = vehiculo.id_item group by vehiculo.marca");
                    while (reader.Read())
                    {
                        String marca = reader["marca"].ToString();
                        combob.Items.Add(marca);
                    }
                    this.CerrarConexion();

                    break;

                case "Estilo artistico":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item , obra where item.id_item = obra.id_item  group by obra.estilo");
                    while (reader.Read())
                    {
                        String estilo = reader["estilo"].ToString();
                        combob.Items.Add(estilo);
                    }
                    this.CerrarConexion();

                    break;
                    
                case "Año de origen de objeto":
                    combob.Items.Clear();
                    reader = this.RealizarConsulta("select * from item group by item.anno");
                    while (reader.Read())
                    {
                        int anno = Int32.Parse(reader["anno"].ToString());
                        combob.Items.Add(anno);
                    }
                    this.CerrarConexion();

                    break;
                    
            }

        }
        //error de departamento: solo muestra una fila
        public void ReporteDepartamento(string text,DataGridView tabla)
        {
            MySqlDataReader read;
            String consulta = "SELECT t2.nombre , t2.descripcion,t1.nombre as nombreItem , t4.nombre as nombreUsuario , t3.nombre as nombreSala FROM item as t1, departamento as t2, sala as t3 , usuario as t4 WHERE t2.nombre = '" + text + "' AND t2.id_dpto = t1.id_dpto AND t3.id_dpto = t2.id_dpto AND t4.id_usuario = t2.id_usuario";

            read = this.RealizarConsulta(consulta);
            Console.WriteLine(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteInventario(DataGridView tabla) {
            MySqlDataReader read;
            read = this.RealizarConsulta("select * from item");
            if (read != null){
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteColeccion(string text, DataGridView tabla)
        {
            Console.WriteLine("entro a crear el reporte de coleccion");
            MySqlDataReader read;

            String consulta = "SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.* FROM item as t1, departamento as t2, sala as t3 WHERE t1.coleccion = '" + text + "' AND t2.id_dpto = t1.id_dpto AND t3.id_dpto = t2.id_dpto";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }
    

        public void ReporteAnno(string text, DataGridView tabla)
        {
            MySqlDataReader read;
          
            String consulta = "SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.* FROM item as t1, departamento as t2, sala as t3 WHERE t1.anno =" + text + " AND t2.id_dpto = t1.id_dpto AND t3.id_dpto = t2.id_dpto";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteMarca(string text, DataGridView tabla)
        {
            MySqlDataReader read;

            String consulta = "SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.* FROM item as t1, departamento as t2, vehiculo as t4 ,sala as t3 WHERE t4.marca = '" + text + "' AND t2.id_dpto = t1.id_dpto  AND t4.id_item = t1.id_item and t1.id_sala = t3.id_sala";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteEstilo(string text, DataGridView tabla)
        {
            MySqlDataReader read;

            String consulta = "SELECT t3.estilo , t1.* FROM item as t1,departamento as t2,obra as t3 WHERE t3.id_item = t1.id_item and t3.estilo = '"+ text +"' and t1.id_dpto = t2.id_dpto";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }

        public void ReporteAutor(string text, DataGridView tabla)
        {
            MySqlDataReader read;

            String consulta = "SELECT t3.autor , t1.* FROM item as t1,departamento as t2,obra as t3 WHERE t3.id_item = t1.id_item and t3.autor = '" + text + "' and t1.id_dpto = t2.id_dpto";
            Console.WriteLine("consulta: " + consulta);
            read = this.RealizarConsulta(consulta);
            if (read != null)
            {
                this.PoblarTabla(tabla, read);
            }
            this.CerrarConexion();
        }
    }
}
