namespace MuseoArkham.Vista
{
    partial class VistaSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaSecretaria));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDepartamento = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDepartamento = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAsignarAdministrador = new System.Windows.Forms.Button();
            this.buttonAsignarSalas = new System.Windows.Forms.Button();
            this.buttonEliminarDepartamento = new System.Windows.Forms.Button();
            this.buttonCrearDepartamento = new System.Windows.Forms.Button();
            this.tabPageSalas = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSalas = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCrearSala = new System.Windows.Forms.Button();
            this.tabPageUsuario = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonDeshabilitarUsuario = new System.Windows.Forms.Button();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPageSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPageUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
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
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretaria";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDepartamento);
            this.tabControl1.Controls.Add(this.tabPageSalas);
            this.tabControl1.Controls.Add(this.tabPageUsuario);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 305);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageDepartamento
            // 
            this.tabPageDepartamento.Controls.Add(this.splitContainer2);
            this.tabPageDepartamento.Location = new System.Drawing.Point(4, 22);
            this.tabPageDepartamento.Name = "tabPageDepartamento";
            this.tabPageDepartamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartamento.Size = new System.Drawing.Size(818, 279);
            this.tabPageDepartamento.TabIndex = 0;
            this.tabPageDepartamento.Text = "Departamento";
            this.tabPageDepartamento.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.dataGridViewDepartamento);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(675, 273);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewDepartamento
            // 
            this.dataGridViewDepartamento.AllowUserToAddRows = false;
            this.dataGridViewDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDepartamento.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewDepartamento.Name = "dataGridViewDepartamento";
            this.dataGridViewDepartamento.Size = new System.Drawing.Size(665, 250);
            this.dataGridViewDepartamento.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAsignarAdministrador);
            this.groupBox3.Controls.Add(this.buttonAsignarSalas);
            this.groupBox3.Controls.Add(this.buttonEliminarDepartamento);
            this.groupBox3.Controls.Add(this.buttonCrearDepartamento);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(133, 273);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonAsignarAdministrador
            // 
            this.buttonAsignarAdministrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAsignarAdministrador.Location = new System.Drawing.Point(5, 108);
            this.buttonAsignarAdministrador.Name = "buttonAsignarAdministrador";
            this.buttonAsignarAdministrador.Size = new System.Drawing.Size(123, 30);
            this.buttonAsignarAdministrador.TabIndex = 3;
            this.buttonAsignarAdministrador.Text = "Asignar administrador";
            this.buttonAsignarAdministrador.UseVisualStyleBackColor = true;
            // 
            // buttonAsignarSalas
            // 
            this.buttonAsignarSalas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAsignarSalas.Location = new System.Drawing.Point(5, 78);
            this.buttonAsignarSalas.Name = "buttonAsignarSalas";
            this.buttonAsignarSalas.Size = new System.Drawing.Size(123, 30);
            this.buttonAsignarSalas.TabIndex = 2;
            this.buttonAsignarSalas.Text = "Asignar salas";
            this.buttonAsignarSalas.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarDepartamento
            // 
            this.buttonEliminarDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEliminarDepartamento.Location = new System.Drawing.Point(5, 48);
            this.buttonEliminarDepartamento.Name = "buttonEliminarDepartamento";
            this.buttonEliminarDepartamento.Size = new System.Drawing.Size(123, 30);
            this.buttonEliminarDepartamento.TabIndex = 1;
            this.buttonEliminarDepartamento.Text = "Eliminar departamento";
            this.buttonEliminarDepartamento.UseVisualStyleBackColor = true;
            // 
            // buttonCrearDepartamento
            // 
            this.buttonCrearDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCrearDepartamento.Location = new System.Drawing.Point(5, 18);
            this.buttonCrearDepartamento.Name = "buttonCrearDepartamento";
            this.buttonCrearDepartamento.Size = new System.Drawing.Size(123, 30);
            this.buttonCrearDepartamento.TabIndex = 0;
            this.buttonCrearDepartamento.Text = "Crear departamento";
            this.buttonCrearDepartamento.UseVisualStyleBackColor = true;
            this.buttonCrearDepartamento.Click += new System.EventHandler(this.buttonCrearDepartamento_Click);
            // 
            // tabPageSalas
            // 
            this.tabPageSalas.Controls.Add(this.splitContainer3);
            this.tabPageSalas.Location = new System.Drawing.Point(4, 22);
            this.tabPageSalas.Name = "tabPageSalas";
            this.tabPageSalas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSalas.Size = new System.Drawing.Size(818, 279);
            this.tabPageSalas.TabIndex = 1;
            this.tabPageSalas.Text = "Salas";
            this.tabPageSalas.UseVisualStyleBackColor = true;
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
            this.groupBox4.Controls.Add(this.dataGridViewSalas);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(675, 273);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // dataGridViewSalas
            // 
            this.dataGridViewSalas.AllowUserToAddRows = false;
            this.dataGridViewSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSalas.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewSalas.Name = "dataGridViewSalas";
            this.dataGridViewSalas.Size = new System.Drawing.Size(665, 250);
            this.dataGridViewSalas.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCrearSala);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(133, 273);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // buttonCrearSala
            // 
            this.buttonCrearSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCrearSala.Location = new System.Drawing.Point(5, 18);
            this.buttonCrearSala.Name = "buttonCrearSala";
            this.buttonCrearSala.Size = new System.Drawing.Size(123, 30);
            this.buttonCrearSala.TabIndex = 0;
            this.buttonCrearSala.Text = "Crear sala";
            this.buttonCrearSala.UseVisualStyleBackColor = true;
            this.buttonCrearSala.Click += new System.EventHandler(this.buttonCrearSala_Click);
            // 
            // tabPageUsuario
            // 
            this.tabPageUsuario.Controls.Add(this.splitContainer4);
            this.tabPageUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsuario.Name = "tabPageUsuario";
            this.tabPageUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuario.Size = new System.Drawing.Size(818, 279);
            this.tabPageUsuario.TabIndex = 2;
            this.tabPageUsuario.Text = "Usuarios";
            this.tabPageUsuario.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox6);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer4.Size = new System.Drawing.Size(812, 273);
            this.splitContainer4.SplitterDistance = 675;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewUsuarios);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(675, 273);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(665, 250);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonDeshabilitarUsuario);
            this.groupBox7.Controls.Add(this.buttonAgregarUsuario);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox7.Size = new System.Drawing.Size(133, 273);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // buttonDeshabilitarUsuario
            // 
            this.buttonDeshabilitarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeshabilitarUsuario.Location = new System.Drawing.Point(5, 48);
            this.buttonDeshabilitarUsuario.Name = "buttonDeshabilitarUsuario";
            this.buttonDeshabilitarUsuario.Size = new System.Drawing.Size(123, 30);
            this.buttonDeshabilitarUsuario.TabIndex = 1;
            this.buttonDeshabilitarUsuario.Text = "Deshabilitar usuario";
            this.buttonDeshabilitarUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(5, 18);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(123, 30);
            this.buttonAgregarUsuario.TabIndex = 0;
            this.buttonAgregarUsuario.Text = "Agregar usuario";
            this.buttonAgregarUsuario.UseVisualStyleBackColor = true;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // VistaSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(854, 480);
            this.Name = "VistaSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museo Arkham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaSecretaria_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDepartamento.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tabPageSalas.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tabPageUsuario.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDepartamento;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAsignarAdministrador;
        private System.Windows.Forms.Button buttonAsignarSalas;
        private System.Windows.Forms.Button buttonEliminarDepartamento;
        private System.Windows.Forms.Button buttonCrearDepartamento;
        private System.Windows.Forms.TabPage tabPageSalas;
        private System.Windows.Forms.TabPage tabPageUsuario;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCrearSala;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonDeshabilitarUsuario;
        private System.Windows.Forms.Button buttonAgregarUsuario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridViewDepartamento;
        public System.Windows.Forms.DataGridView dataGridViewSalas;
        public System.Windows.Forms.DataGridView dataGridViewUsuarios;
    }
}