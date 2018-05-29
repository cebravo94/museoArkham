namespace MuseoArkham.Vista
{
    partial class VistaGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaGerente));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControlSolicitudes = new System.Windows.Forms.TabControl();
            this.tabPageSolicitudesTraslado = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSolicitudesTraslado = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonVerDetalleSolicitudTraslado = new System.Windows.Forms.Button();
            this.botonRechazarSolicitud = new System.Windows.Forms.Button();
            this.botonAceptarSolicitud = new System.Windows.Forms.Button();
            this.tabPageObjetos = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewObjetos = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCancelarFiltrarObjetos = new System.Windows.Forms.Button();
            this.botonFiltrarObjetos = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFiltrarEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVerDetallesObjeto = new System.Windows.Forms.Button();
            this.comboBoxEstadoSolicitud = new System.Windows.Forms.ComboBox();
            this.buttonFiltrarSolicitudes = new System.Windows.Forms.Button();
            this.buttonCancelarFiltrarSolicitud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControlSolicitudes.SuspendLayout();
            this.tabPageSolicitudesTraslado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudesTraslado)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPageObjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.splitContainer1.Size = new System.Drawing.Size(838, 441);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(838, 90);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControlSolicitudes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerente de exhibiciones";
            // 
            // tabControlSolicitudes
            // 
            this.tabControlSolicitudes.Controls.Add(this.tabPageSolicitudesTraslado);
            this.tabControlSolicitudes.Controls.Add(this.tabPageObjetos);
            this.tabControlSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSolicitudes.Location = new System.Drawing.Point(3, 16);
            this.tabControlSolicitudes.Name = "tabControlSolicitudes";
            this.tabControlSolicitudes.SelectedIndex = 0;
            this.tabControlSolicitudes.Size = new System.Drawing.Size(826, 305);
            this.tabControlSolicitudes.TabIndex = 0;
            this.tabControlSolicitudes.SelectedIndexChanged += new System.EventHandler(this.tabControlSolicitudes_SelectedIndexChanged);
            // 
            // tabPageSolicitudesTraslado
            // 
            this.tabPageSolicitudesTraslado.Controls.Add(this.splitContainer2);
            this.tabPageSolicitudesTraslado.Location = new System.Drawing.Point(4, 22);
            this.tabPageSolicitudesTraslado.Name = "tabPageSolicitudesTraslado";
            this.tabPageSolicitudesTraslado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolicitudesTraslado.Size = new System.Drawing.Size(818, 279);
            this.tabPageSolicitudesTraslado.TabIndex = 0;
            this.tabPageSolicitudesTraslado.Text = "Solicitudes de traslado";
            this.tabPageSolicitudesTraslado.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(812, 273);
            this.splitContainer2.SplitterDistance = 675;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSolicitudesTraslado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(675, 273);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewSolicitudesTraslado
            // 
            this.dataGridViewSolicitudesTraslado.AllowUserToAddRows = false;
            this.dataGridViewSolicitudesTraslado.AllowUserToDeleteRows = false;
            this.dataGridViewSolicitudesTraslado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewSolicitudesTraslado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudesTraslado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSolicitudesTraslado.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewSolicitudesTraslado.Name = "dataGridViewSolicitudesTraslado";
            this.dataGridViewSolicitudesTraslado.ReadOnly = true;
            this.dataGridViewSolicitudesTraslado.Size = new System.Drawing.Size(665, 250);
            this.dataGridViewSolicitudesTraslado.TabIndex = 0;
            this.dataGridViewSolicitudesTraslado.SelectionChanged += new System.EventHandler(this.dataGridViewSolicitudesTraslado_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCancelarFiltrarSolicitud);
            this.groupBox3.Controls.Add(this.buttonFiltrarSolicitudes);
            this.groupBox3.Controls.Add(this.comboBoxEstadoSolicitud);
            this.groupBox3.Controls.Add(this.botonVerDetalleSolicitudTraslado);
            this.groupBox3.Controls.Add(this.botonRechazarSolicitud);
            this.groupBox3.Controls.Add(this.botonAceptarSolicitud);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(133, 273);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // botonVerDetalleSolicitudTraslado
            // 
            this.botonVerDetalleSolicitudTraslado.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonVerDetalleSolicitudTraslado.Location = new System.Drawing.Point(5, 78);
            this.botonVerDetalleSolicitudTraslado.Name = "botonVerDetalleSolicitudTraslado";
            this.botonVerDetalleSolicitudTraslado.Size = new System.Drawing.Size(123, 30);
            this.botonVerDetalleSolicitudTraslado.TabIndex = 2;
            this.botonVerDetalleSolicitudTraslado.Text = "Ver detalle";
            this.botonVerDetalleSolicitudTraslado.UseVisualStyleBackColor = true;
            this.botonVerDetalleSolicitudTraslado.Click += new System.EventHandler(this.botonVerDetalleSolicitudTraslado_Click);
            // 
            // botonRechazarSolicitud
            // 
            this.botonRechazarSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRechazarSolicitud.Location = new System.Drawing.Point(5, 48);
            this.botonRechazarSolicitud.Name = "botonRechazarSolicitud";
            this.botonRechazarSolicitud.Size = new System.Drawing.Size(123, 30);
            this.botonRechazarSolicitud.TabIndex = 1;
            this.botonRechazarSolicitud.Text = "Rechazar solicitud";
            this.botonRechazarSolicitud.UseVisualStyleBackColor = true;
            this.botonRechazarSolicitud.Click += new System.EventHandler(this.botonRechazarSolicitud_Click);
            // 
            // botonAceptarSolicitud
            // 
            this.botonAceptarSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAceptarSolicitud.Location = new System.Drawing.Point(5, 18);
            this.botonAceptarSolicitud.Name = "botonAceptarSolicitud";
            this.botonAceptarSolicitud.Size = new System.Drawing.Size(123, 30);
            this.botonAceptarSolicitud.TabIndex = 0;
            this.botonAceptarSolicitud.Text = "Aceptar solicitud";
            this.botonAceptarSolicitud.UseVisualStyleBackColor = true;
            this.botonAceptarSolicitud.Click += new System.EventHandler(this.botonAceptarSolicitud_Click);
            // 
            // tabPageObjetos
            // 
            this.tabPageObjetos.Controls.Add(this.splitContainer3);
            this.tabPageObjetos.Location = new System.Drawing.Point(4, 22);
            this.tabPageObjetos.Name = "tabPageObjetos";
            this.tabPageObjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObjetos.Size = new System.Drawing.Size(818, 279);
            this.tabPageObjetos.TabIndex = 1;
            this.tabPageObjetos.Text = "Objetos";
            this.tabPageObjetos.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Size = new System.Drawing.Size(812, 273);
            this.splitContainer3.SplitterDistance = 675;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewObjetos);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(675, 273);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // dataGridViewObjetos
            // 
            this.dataGridViewObjetos.AllowUserToAddRows = false;
            this.dataGridViewObjetos.AllowUserToDeleteRows = false;
            this.dataGridViewObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewObjetos.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewObjetos.Name = "dataGridViewObjetos";
            this.dataGridViewObjetos.ReadOnly = true;
            this.dataGridViewObjetos.Size = new System.Drawing.Size(665, 250);
            this.dataGridViewObjetos.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCancelarFiltrarObjetos);
            this.groupBox5.Controls.Add(this.botonFiltrarObjetos);
            this.groupBox5.Controls.Add(this.comboBoxTipo);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.comboBoxFiltrarEstado);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.botonVerDetallesObjeto);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(133, 273);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // buttonCancelarFiltrarObjetos
            // 
            this.buttonCancelarFiltrarObjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCancelarFiltrarObjetos.Location = new System.Drawing.Point(5, 183);
            this.buttonCancelarFiltrarObjetos.Name = "buttonCancelarFiltrarObjetos";
            this.buttonCancelarFiltrarObjetos.Size = new System.Drawing.Size(123, 30);
            this.buttonCancelarFiltrarObjetos.TabIndex = 7;
            this.buttonCancelarFiltrarObjetos.Text = "Cancelar Filtros";
            this.buttonCancelarFiltrarObjetos.UseVisualStyleBackColor = true;
            this.buttonCancelarFiltrarObjetos.Click += new System.EventHandler(this.buttonCancelarFiltrarObjetos_Click);
            // 
            // botonFiltrarObjetos
            // 
            this.botonFiltrarObjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonFiltrarObjetos.Location = new System.Drawing.Point(5, 153);
            this.botonFiltrarObjetos.Name = "botonFiltrarObjetos";
            this.botonFiltrarObjetos.Size = new System.Drawing.Size(123, 30);
            this.botonFiltrarObjetos.TabIndex = 1;
            this.botonFiltrarObjetos.Text = "Filtrar";
            this.botonFiltrarObjetos.UseVisualStyleBackColor = true;
            this.botonFiltrarObjetos.Click += new System.EventHandler(this.botonFiltrarObjetos_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Todos",
            "Documento",
            "Vehículo",
            "Pieza",
            "Obra"});
            this.comboBoxTipo.Location = new System.Drawing.Point(5, 132);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(123, 21);
            this.comboBoxTipo.TabIndex = 4;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // comboBoxFiltrarEstado
            // 
            this.comboBoxFiltrarEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxFiltrarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrarEstado.FormattingEnabled = true;
            this.comboBoxFiltrarEstado.Items.AddRange(new object[] {
            "Todos",
            "En Exhibición",
            "En Solicitud",
            "En Restauración"});
            this.comboBoxFiltrarEstado.Location = new System.Drawing.Point(5, 92);
            this.comboBoxFiltrarEstado.Name = "comboBoxFiltrarEstado";
            this.comboBoxFiltrarEstado.Size = new System.Drawing.Size(123, 21);
            this.comboBoxFiltrarEstado.TabIndex = 3;
            this.comboBoxFiltrarEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrarEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.label1.Size = new System.Drawing.Size(34, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros";
            // 
            // botonVerDetallesObjeto
            // 
            this.botonVerDetallesObjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonVerDetallesObjeto.Location = new System.Drawing.Point(5, 18);
            this.botonVerDetallesObjeto.Name = "botonVerDetallesObjeto";
            this.botonVerDetallesObjeto.Size = new System.Drawing.Size(123, 30);
            this.botonVerDetallesObjeto.TabIndex = 0;
            this.botonVerDetallesObjeto.Text = "Ver detalles";
            this.botonVerDetallesObjeto.UseVisualStyleBackColor = true;
            this.botonVerDetallesObjeto.Click += new System.EventHandler(this.botonVerDetallesObjeto_Click);
            // 
            // comboBoxEstadoSolicitud
            // 
            this.comboBoxEstadoSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxEstadoSolicitud.FormattingEnabled = true;
            this.comboBoxEstadoSolicitud.Items.AddRange(new object[] {
            "Todos",
            "Pendiente",
            "Aceptada",
            "Rechazada",
            "Despachada"});
            this.comboBoxEstadoSolicitud.Location = new System.Drawing.Point(5, 108);
            this.comboBoxEstadoSolicitud.Name = "comboBoxEstadoSolicitud";
            this.comboBoxEstadoSolicitud.Size = new System.Drawing.Size(123, 21);
            this.comboBoxEstadoSolicitud.TabIndex = 3;
            // 
            // buttonFiltrarSolicitudes
            // 
            this.buttonFiltrarSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFiltrarSolicitudes.Location = new System.Drawing.Point(5, 129);
            this.buttonFiltrarSolicitudes.Name = "buttonFiltrarSolicitudes";
            this.buttonFiltrarSolicitudes.Size = new System.Drawing.Size(123, 30);
            this.buttonFiltrarSolicitudes.TabIndex = 4;
            this.buttonFiltrarSolicitudes.Text = "Filtrar";
            this.buttonFiltrarSolicitudes.UseVisualStyleBackColor = true;
            this.buttonFiltrarSolicitudes.Click += new System.EventHandler(this.buttonFiltrarSolicitudes_Click);
            // 
            // buttonCancelarFiltrarSolicitud
            // 
            this.buttonCancelarFiltrarSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCancelarFiltrarSolicitud.Location = new System.Drawing.Point(5, 159);
            this.buttonCancelarFiltrarSolicitud.Name = "buttonCancelarFiltrarSolicitud";
            this.buttonCancelarFiltrarSolicitud.Size = new System.Drawing.Size(123, 30);
            this.buttonCancelarFiltrarSolicitud.TabIndex = 5;
            this.buttonCancelarFiltrarSolicitud.Text = "Cancelar filtro";
            this.buttonCancelarFiltrarSolicitud.UseVisualStyleBackColor = true;
            this.buttonCancelarFiltrarSolicitud.Click += new System.EventHandler(this.buttonCancelarFiltrarSolicitud_Click);
            // 
            // VistaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(854, 480);
            this.Name = "VistaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museo Arkham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaGerente_FormClosing);
            this.Load += new System.EventHandler(this.VistaGerente_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControlSolicitudes.ResumeLayout(false);
            this.tabPageSolicitudesTraslado.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudesTraslado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabPageObjetos.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControlSolicitudes;
        private System.Windows.Forms.TabPage tabPageSolicitudesTraslado;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridViewSolicitudesTraslado;
        public System.Windows.Forms.Button botonRechazarSolicitud;
        public System.Windows.Forms.Button botonAceptarSolicitud;
        private System.Windows.Forms.Button botonVerDetalleSolicitudTraslado;
        private System.Windows.Forms.TabPage tabPageObjetos;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button botonFiltrarObjetos;
        private System.Windows.Forms.Button botonVerDetallesObjeto;
        public System.Windows.Forms.DataGridView dataGridViewObjetos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxFiltrarEstado;
        public System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button buttonCancelarFiltrarObjetos;
        private System.Windows.Forms.Button buttonCancelarFiltrarSolicitud;
        private System.Windows.Forms.Button buttonFiltrarSolicitudes;
        public System.Windows.Forms.ComboBox comboBoxEstadoSolicitud;
    }
}