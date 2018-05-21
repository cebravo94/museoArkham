using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MuseoArkham.Vista;
using System.Windows.Forms;
using MuseoArkham.Modelo;
using System.Diagnostics;

namespace MuseoArkham.Controlador.Controlador_Bodeguero
{
    class ControladorBodeguero : Controlador
    {
        private VistaEncargadoDeBodega ventana;
        private Usuario usuario;
        public Departamento departamento { get; }

        public ControladorBodeguero(VistaEncargadoDeBodega ventana, Usuario usuario) {
            this.ventana = ventana;
            this.usuario = usuario;
            this.departamento = this.cargarDepartamento();
            
        }

        /**
         * 
         * <sumary>
         * Este metodo se encarga de recibir un objeto creado por el encargado de bodega y lo agrega al inventario de la bodega
         * del museo.
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void IncorporarObjeto()
        {

        }

        /**
         * <sumary>
         * Este metodo se encarga de obtener un objeto en particular y una vez obtenido debe desincorporar el objeto del inventario
         * de la bodega del museo. (Este objeto no se elimina de la base de datos).
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void DesincorporarObjeto()
        {
            int index = this.ventana.dataGridViewObjetos.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewObjetos.Rows[index];
            int id_item = Int32.Parse(data.Cells[0].Value.ToString());
            Console.WriteLine(id_item);
            MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET estado = 'deshabilitado' where id_item ="+id_item);
            this.CerrarConexion();
            //Console.WriteLine(index);
        }

        /**
         * <sumary>
         * Este metodo se encarga de obtener un objeto (Item) en particular que se haya seleccionado previamente y cambia el estado
         * de este a "En Restauracion". Tambien debe cambiar la ubicacion actual del objeto a uno por defecto que señale que se
         * encuentra en restauracion.
         * En la pestaña "Objetos"
         * </sumary>
        **/
        public void EnviarARestauracion()
        {
            int index = this.ventana.dataGridViewObjetos.CurrentCell.RowIndex;
            DataGridViewRow data = this.ventana.dataGridViewObjetos.Rows[index];
            String estado = data.Cells[7].Value.ToString();
            int id_item = Int32.Parse(data.Cells[0].Value.ToString());
            if (estado == "en restauracion")
            {
                MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET estado = 'guardado' where id_item =" + id_item);
                this.CerrarConexion();
                
            }
            else
            {
                MySqlDataReader reader = this.RealizarConsulta("UPDATE museo.item SET estado = 'en restauracion' where id_item =" + id_item);
                this.CerrarConexion();
            }
                
        }

        /**
         * <sumary>
         * Este metodo se encarga de llamar las diferentes consultas que puede hacer el encargado de bodega sobre el inventario 
         * de la bodega y del museo. (Deberia deplegar las opciones de consulta de los objetos)
         *En la pestaña "Objetos" 
         * </sumary>
        **/
        public void ConsultaSobreObjetos()
        {

        }

        /**
         * <sumary>
         * Este metodo se encarga de recibir una solicitud de traslado aceptada y una vez que el encargado de bodega la completa
         * de forma presencial el metodo le debe permitir registrar la solicutd en el sistema quedando en la base de datos del
         * museo.
         * En la pestaña "Solicitudes"
        **/
        public void RegistrarSolicitud()
        {

        }

        /**
         * 
         * Este metodo recibe una solicitud en particular que se ha selecciona previamente y debe desplegar una ventana con los 
         * detalles de la solictud seleccionada.
         * En la pestaña "Solicitudes"
        **/
        public void VerDetallesSolicitudes()
        {

        }

        /**
         * 
         * Este metodo se encarga de llamar las diferentes consultas que puede hacer el encargado de bodega sobre las solicitudes
         * emitidas y aceptadas que son las que el visualiza. (Deberia deplegar las opciones de consulta de solicitudes)
         * En la pestaña "Solicitudes"
        **/
        public void ConsultaSolicitudes()
        {

        }

        /**
         * 
         * Este metodo recibe un registro en particular que se ha selecciona previamente y debe desplegar una ventana con los 
         * detalles del registro seleccionado.
         * En la pestaña "Registros"
        **/
        public void VerDetallesRegistros()
        {

        }

        private Departamento cargarDepartamento()
        {
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null)
            {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                return departamento;
            }
            return null;
        }

        public void CargarDatosTabla(int index)
        {
            switch (index)
            {
                case 0:
                    this.CargarItems();
                    break;
                case 1:
                    this.CargarSolicitudes();
                    break;
                case 2:
                    this.CargarRegistros();
                    break;
            }
        }

        private void CargarItems()
        {
            MySqlDataReader reader = this.RealizarConsulta("select * from departamento where id_usuario=" + this.usuario.Id);
            reader.Read();
            if (reader != null)
            {
                Departamento departamento = new Departamento(reader);
                this.CerrarConexion();
                Debug.WriteLine(departamento.Nombre);
                Debug.WriteLine(departamento.Id);
                String consulta = "select id_item,item.id_dpto,id_sala,item.nombre,fecha_ingreso,item.descripcion,coleccion,estado,anno,tipo,era" +
                                  " from museo.item, museo.departamento" +
                                  " where item.id_dpto=departamento.id_dpto" +
                                  " and departamento.id_dpto=" + departamento.Id+
                                  " and item.estado != 'deshabilitado';";
                Debug.WriteLine(consulta);
                reader = this.RealizarConsulta(consulta);
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            }
            this.CerrarConexion();
        }

        private void CargarSolicitudes()
        {
            MySqlDataReader reader = this.RealizarConsulta("SELECT * FROM museo.solicitud where estado ='aceptada';");
            //reader.Read();
            if (reader != null)
            {
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            }
            this.CerrarConexion();
        }

        private void CargarRegistros()
        {
            MySqlDataReader reader = this.RealizarConsulta("SELECT * FROM museo.registro");
            //reader.Read();
            if (reader != null)
            {
                this.PoblarTabla(ventana.dataGridViewObjetos, reader);
            }
            this.CerrarConexion();
        }
    }
}

