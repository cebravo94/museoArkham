namespace MuseoArkham.Vista
{
    partial class VistaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAdministrador));
            this.banner = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAdministrador = new System.Windows.Forms.GroupBox();
            this.tabControl1Administrador = new System.Windows.Forms.TabControl();
            this.tabPageSolicitudesTraslado = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageObjetos = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigoObjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.banner.SuspendLayout();
            this.groupBoxAdministrador.SuspendLayout();
            this.tabControl1Administrador.SuspendLayout();
            this.tabPageSolicitudesTraslado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPageObjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.SystemColors.ControlText;
            this.banner.Controls.Add(this.label1);
            this.banner.Location = new System.Drawing.Point(2, 1);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(802, 70);
            this.banner.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(319, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARKHAM";
            // 
            // groupBoxAdministrador
            // 
            this.groupBoxAdministrador.Controls.Add(this.tabControl1Administrador);
            this.groupBoxAdministrador.Location = new System.Drawing.Point(2, 77);
            this.groupBoxAdministrador.Name = "groupBoxAdministrador";
            this.groupBoxAdministrador.Size = new System.Drawing.Size(802, 381);
            this.groupBoxAdministrador.TabIndex = 1;
            this.groupBoxAdministrador.TabStop = false;
            this.groupBoxAdministrador.Text = "Administrador";
            // 
            // tabControl1Administrador
            // 
            this.tabControl1Administrador.Controls.Add(this.tabPageSolicitudesTraslado);
            this.tabControl1Administrador.Controls.Add(this.tabPageObjetos);
            this.tabControl1Administrador.Location = new System.Drawing.Point(6, 19);
            this.tabControl1Administrador.Name = "tabControl1Administrador";
            this.tabControl1Administrador.SelectedIndex = 0;
            this.tabControl1Administrador.Size = new System.Drawing.Size(790, 362);
            this.tabControl1Administrador.TabIndex = 0;
            // 
            // tabPageSolicitudesTraslado
            // 
            this.tabPageSolicitudesTraslado.Controls.Add(this.splitContainer1);
            this.tabPageSolicitudesTraslado.Location = new System.Drawing.Point(4, 22);
            this.tabPageSolicitudesTraslado.Name = "tabPageSolicitudesTraslado";
            this.tabPageSolicitudesTraslado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolicitudesTraslado.Size = new System.Drawing.Size(782, 336);
            this.tabPageSolicitudesTraslado.TabIndex = 0;
            this.tabPageSolicitudesTraslado.Text = "Solicitudes de traslado";
            this.tabPageSolicitudesTraslado.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(776, 330);
            this.splitContainer1.SplitterDistance = 563;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.estado,
            this.usuario,
            this.departamento});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 323);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Solicitud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Filtrar Solicitudes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar Solicitud";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPageObjetos
            // 
            this.tabPageObjetos.Controls.Add(this.splitContainer2);
            this.tabPageObjetos.Location = new System.Drawing.Point(4, 22);
            this.tabPageObjetos.Name = "tabPageObjetos";
            this.tabPageObjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObjetos.Size = new System.Drawing.Size(782, 336);
            this.tabPageObjetos.TabIndex = 1;
            this.tabPageObjetos.Text = "Objetos";
            this.tabPageObjetos.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(776, 330);
            this.splitContainer2.SplitterDistance = 566;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 323);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoObjeto,
            this.descripcion,
            this.anno,
            this.sala});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(547, 298);
            this.dataGridView2.TabIndex = 0;
            // 
            // codigoObjeto
            // 
            this.codigoObjeto.HeaderText = "Código";
            this.codigoObjeto.Name = "codigoObjeto";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // anno
            // 
            this.anno.HeaderText = "Año";
            this.anno.Name = "anno";
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.Name = "sala";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonFiltrar);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 317);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Administrar";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(35, 50);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(120, 44);
            this.buttonFiltrar.TabIndex = 0;
            this.buttonFiltrar.Text = "Filtrar Objetos";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // VistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.groupBoxAdministrador);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museo Arkham";
            this.banner.ResumeLayout(false);
            this.banner.PerformLayout();
            this.groupBoxAdministrador.ResumeLayout(false);
            this.tabControl1Administrador.ResumeLayout(false);
            this.tabPageSolicitudesTraslado.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabPageObjetos.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel banner;
        private System.Windows.Forms.GroupBox groupBoxAdministrador;
        private System.Windows.Forms.TabControl tabControl1Administrador;
        private System.Windows.Forms.TabPage tabPageSolicitudesTraslado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPageObjetos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}