﻿using MuseoArkham.Controlador.Controlador_Secretaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MuseoArkham.Vista
{
    public partial class VistaCrearDepartamento : Form
    {
        private ControladorCrearDepartamento controlador;
        public VistaCrearDepartamento()
        {
            this.controlador = new ControladorCrearDepartamento(this);
            InitializeComponent();
        }


        private void VistaCrearDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCrearDepartamento_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string descripcion = textBox2.Text;
            this.controlador.crearDepartamento(nombre, descripcion);
            this.Close();
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
