﻿using MuseoArkham.Controlador.Controlador_Administrador;
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
    public partial class VistaAdministrador : Form
    {
        private ControladorAdministrador controlador;
        public VistaAdministrador()
        {
            this.controlador = new ControladorAdministrador(this);
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventanaCrearSolicitud = new VistaCrearSolicitud();
            ventanaCrearSolicitud.ShowDialog(this);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VistaAdministrador_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }
    }
}
