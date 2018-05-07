﻿namespace MuseoArkham.Vista
{
    partial class VistaDirector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaDirector));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGenerar = new System.Windows.Forms.Button();
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.combestilo = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.combautor = new System.Windows.Forms.ComboBox();
            this.combColeccion = new System.Windows.Forms.ComboBox();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.comboReporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.41344F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.58656F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(799, 455);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 86);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonCancelar);
            this.groupBox2.Controls.Add(this.botonGenerar);
            this.groupBox2.Controls.Add(this.comboOrigen);
            this.groupBox2.Controls.Add(this.combestilo);
            this.groupBox2.Controls.Add(this.comboMarca);
            this.groupBox2.Controls.Add(this.combautor);
            this.groupBox2.Controls.Add(this.combColeccion);
            this.groupBox2.Controls.Add(this.comboDepartamento);
            this.groupBox2.Controls.Add(this.comboReporte);
            this.groupBox2.Location = new System.Drawing.Point(3, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Director";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(321, 288);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(137, 40);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGenerar
            // 
            this.botonGenerar.Location = new System.Drawing.Point(321, 229);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(137, 40);
            this.botonGenerar.TabIndex = 7;
            this.botonGenerar.Text = "Generar";
            this.botonGenerar.UseVisualStyleBackColor = true;
            // 
            // comboOrigen
            // 
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Location = new System.Drawing.Point(282, 122);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(218, 21);
            this.comboOrigen.TabIndex = 6;
            this.comboOrigen.Text = "Seleccionar año de origen";
            this.comboOrigen.Visible = false;
            // 
            // combestilo
            // 
            this.combestilo.FormattingEnabled = true;
            this.combestilo.Location = new System.Drawing.Point(283, 122);
            this.combestilo.Name = "combestilo";
            this.combestilo.Size = new System.Drawing.Size(218, 21);
            this.combestilo.TabIndex = 5;
            this.combestilo.Text = "Seleccionar estilo artistico";
            this.combestilo.Visible = false;
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(282, 122);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(218, 21);
            this.comboMarca.TabIndex = 4;
            this.comboMarca.Text = "Seleccionar Marca";
            this.comboMarca.Visible = false;
            // 
            // combautor
            // 
            this.combautor.FormattingEnabled = true;
            this.combautor.Location = new System.Drawing.Point(282, 122);
            this.combautor.Name = "combautor";
            this.combautor.Size = new System.Drawing.Size(218, 21);
            this.combautor.TabIndex = 3;
            this.combautor.Text = "Seleccionar autor";
            this.combautor.Visible = false;
            // 
            // combColeccion
            // 
            this.combColeccion.FormattingEnabled = true;
            this.combColeccion.Location = new System.Drawing.Point(282, 122);
            this.combColeccion.Name = "combColeccion";
            this.combColeccion.Size = new System.Drawing.Size(218, 21);
            this.combColeccion.TabIndex = 2;
            this.combColeccion.Text = "Seleccionar coleccion";
            this.combColeccion.Visible = false;
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(282, 122);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(218, 21);
            this.comboDepartamento.TabIndex = 1;
            this.comboDepartamento.Text = "Seleccionar Departamento";
            this.comboDepartamento.Visible = false;
            // 
            // comboReporte
            // 
            this.comboReporte.FormattingEnabled = true;
            this.comboReporte.Items.AddRange(new object[] {
            "Reporte general de inventario",
            "Reporte detallado de un departamento",
            "Reporte detallado de una colección",
            "Reporte por autor",
            "Reporte por marca",
            "Reporte por estilo artistico",
            "Reporte por año de origen de objeto"});
            this.comboReporte.Location = new System.Drawing.Point(282, 66);
            this.comboReporte.Name = "comboReporte";
            this.comboReporte.Size = new System.Drawing.Size(219, 21);
            this.comboReporte.TabIndex = 0;
            this.comboReporte.Text = "Seleccionar tipo de reporte";
            this.comboReporte.SelectedIndexChanged += new System.EventHandler(this.comboReporte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARKHAM";
            // 
            // VistaDirector
            // 
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaDirector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museo Arkham";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.ComboBox combestilo;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox combautor;
        private System.Windows.Forms.ComboBox combColeccion;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.ComboBox comboReporte;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label label1;
    }
}