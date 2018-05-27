using MuseoArkham.Modelo;
using MuseoArkham.Vista.VistasCompartidas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoArkham.Controlador.Controlador_Vistas_Compartidas
{
    class ControladorVerRegistro : Controlador
    {
        private VistaVerRegistro ventana;
        private Registro registro;

        public ControladorVerRegistro(VistaVerRegistro ventana)
        {
            this.ventana = ventana;
        }

        public void CargarInfoRegistro(int idRegistro)
        {
            string consulta = "SELECT * FROM museo.registro WHERE registro.id_registro = " + idRegistro;
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            this.registro = new Registro(reader);
            this.CerrarConexion();
            this.CargarInfoTextBoxes();
            this.CerrarConexion();
        }

        private void CargarInfoTextBoxes()
        {
            string consulta = "SELECT registro.id_registro AS Registro, item.nombre AS Item, departamento.nombre AS NombreDpto, C2.Administrador, usuario.nombre AS Gerente, sala.nombre AS SalaOrigen, C1.SalaDestino, registro.fecha_ingreso AS Fecha " +
                "FROM museo.registro, museo.item, museo.usuario, museo.sala, museo.departamento, " +
                "(SELECT sala.nombre AS SalaDestino, sala.id_sala AS IDSala " +
                "FROM museo.registro, museo.sala " +
                "WHERE " + this.registro.IdSalaDestino + " = sala.id_sala " +
                "GROUP BY SalaDestino) AS C1, " +
                "(SELECT usuario.nombre AS Administrador, usuario.id_usuario AS IDAdmin " +
                "FROM museo.registro, museo.usuario " +
                "WHERE " + this.registro.IdAdmin + " = usuario.id_usuario " +
                "GROUP BY Administrador) AS C2 " +
                "WHERE " + this.registro.IdDpto + " = departamento.id_dpto AND " + this.registro.IdSalaOrigen + " = sala.id_sala AND " +
                "item.id_item = " + this.registro.IdItem + " AND " + this.registro.IdGerente + " = usuario.id_usuario AND " +
                "C1.IDSala = " + this.registro.IdSalaDestino + " AND C2.IDAdmin = " + this.registro.IdAdmin + ";";
            MySqlDataReader reader = this.RealizarConsulta(consulta);
            reader.Read();
            ventana.textBoxObjetoRegistro.Text = reader["Item"].ToString();
            ventana.textBoxDepartamentoRegistro.Text = reader["NombreDpto"].ToString();
            ventana.textBoxAdministradorRegistro.Text = reader["Administrador"].ToString();
            ventana.textBoxGerenteRegistro.Text = reader["Gerente"].ToString();
            ventana.textBoxFechaRegistro.Text = this.registro.FechaIngreso.ToString("d");
            ventana.textBoxSalaOrigenRegistro.Text = reader["SalaOrigen"].ToString();
            ventana.textBoxSalaDestinoRegistro.Text = reader["SalaDestino"].ToString();
            this.CerrarConexion();
        }
    }
}
