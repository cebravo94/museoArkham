namespace MuseoArkham.Vista
{
    partial class VistaCrearSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCrearSolicitud));
            this.groupBoxCrearSolicitud = new System.Windows.Forms.GroupBox();
            this.labelDetalleObjetos = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.labelSalaDestino = new System.Windows.Forms.Label();
            this.labelSalaOrigen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.groupBoxCrearSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCrearSolicitud
            // 
            this.groupBoxCrearSolicitud.Controls.Add(this.labelDetalleObjetos);
            this.groupBoxCrearSolicitud.Controls.Add(this.labelComentario);
            this.groupBoxCrearSolicitud.Controls.Add(this.labelSalaDestino);
            this.groupBoxCrearSolicitud.Controls.Add(this.labelSalaOrigen);
            this.groupBoxCrearSolicitud.Controls.Add(this.dataGridView1);
            this.groupBoxCrearSolicitud.Controls.Add(this.textBox1);
            this.groupBoxCrearSolicitud.Controls.Add(this.comboBox2);
            this.groupBoxCrearSolicitud.Controls.Add(this.comboBox1);
            this.groupBoxCrearSolicitud.Controls.Add(this.buttonCancelar);
            this.groupBoxCrearSolicitud.Controls.Add(this.buttonCrear);
            this.groupBoxCrearSolicitud.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCrearSolicitud.Name = "groupBoxCrearSolicitud";
            this.groupBoxCrearSolicitud.Size = new System.Drawing.Size(306, 383);
            this.groupBoxCrearSolicitud.TabIndex = 0;
            this.groupBoxCrearSolicitud.TabStop = false;
            this.groupBoxCrearSolicitud.Text = "Crear Solicitud";
            // 
            // labelDetalleObjetos
            // 
            this.labelDetalleObjetos.AutoSize = true;
            this.labelDetalleObjetos.Location = new System.Drawing.Point(6, 140);
            this.labelDetalleObjetos.Name = "labelDetalleObjetos";
            this.labelDetalleObjetos.Size = new System.Drawing.Size(92, 13);
            this.labelDetalleObjetos.TabIndex = 9;
            this.labelDetalleObjetos.Text = "Detalle de objetos";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Location = new System.Drawing.Point(73, 74);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(65, 13);
            this.labelComentario.TabIndex = 8;
            this.labelComentario.Text = "Comentarios";
            this.labelComentario.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelSalaDestino
            // 
            this.labelSalaDestino.AutoSize = true;
            this.labelSalaDestino.Location = new System.Drawing.Point(73, 47);
            this.labelSalaDestino.Name = "labelSalaDestino";
            this.labelSalaDestino.Size = new System.Drawing.Size(65, 13);
            this.labelSalaDestino.TabIndex = 7;
            this.labelSalaDestino.Text = "Sala destino";
            // 
            // labelSalaOrigen
            // 
            this.labelSalaOrigen.AutoSize = true;
            this.labelSalaOrigen.Location = new System.Drawing.Point(78, 19);
            this.labelSalaOrigen.Name = "labelSalaOrigen";
            this.labelSalaOrigen.Size = new System.Drawing.Size(60, 13);
            this.labelSalaOrigen.TabIndex = 6;
            this.labelSalaOrigen.Text = "Sala origen";
            this.labelSalaOrigen.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObjeto,
            this.nombreObjeto,
            this.DescripcionObjeto});
            this.dataGridView1.Location = new System.Drawing.Point(6, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 183);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idObjeto
            // 
            this.idObjeto.HeaderText = "Id";
            this.idObjeto.Name = "idObjeto";
            this.idObjeto.ReadOnly = true;
            // 
            // nombreObjeto
            // 
            this.nombreObjeto.HeaderText = "Nombre";
            this.nombreObjeto.Name = "nombreObjeto";
            this.nombreObjeto.ReadOnly = true;
            this.nombreObjeto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DescripcionObjeto
            // 
            this.DescripcionObjeto.HeaderText = "Descripción";
            this.DescripcionObjeto.Name = "DescripcionObjeto";
            this.DescripcionObjeto.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 46);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(225, 354);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(144, 354);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaCrearSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 407);
            this.Controls.Add(this.groupBoxCrearSolicitud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaCrearSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Solicitud";
            this.Load += new System.EventHandler(this.CrearSolicitud_Load);
            this.groupBoxCrearSolicitud.ResumeLayout(false);
            this.groupBoxCrearSolicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCrearSolicitud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label labelSalaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionObjeto;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.Label labelSalaDestino;
        private System.Windows.Forms.Label labelDetalleObjetos;
    }
}