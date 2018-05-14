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


        private void VistaAdministrador_FormClosing(object sender, FormClosingEventArgs e) {
            this.controlador.CerrarVentana(this);
        }

        private void VistaAdministrador_Load(object sender, EventArgs e)
        {
                   }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCrearSolicitud_Click(object sender, EventArgs e)
        {
            Form ventanaCrearSolicitud = new VistaCrearSolicitud();
            ventanaCrearSolicitud.ShowDialog();
        }
    }
}
