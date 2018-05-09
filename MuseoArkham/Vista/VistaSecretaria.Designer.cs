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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonAsignarAdmin = new System.Windows.Forms.Button();
            this.botonAsignarSala = new System.Windows.Forms.Button();
            this.botonEliminarDepto = new System.Windows.Forms.Button();
            this.botonCrearDepto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablaDepartamento = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombreDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSalas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminGroupBox = new System.Windows.Forms.GroupBox();
            this.botonDeshabilitarUsuario = new System.Windows.Forms.Button();
            this.botonAgregarUsuario = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.columnaIdSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombreSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.botonCrearSala = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamento)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.adminGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.09957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.90044F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(316, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARKHAM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretaria";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 359);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Departamento";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.0733F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.9267F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 326);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.botonAsignarAdmin);
            this.groupBox3.Controls.Add(this.botonAsignarSala);
            this.groupBox3.Controls.Add(this.botonEliminarDepto);
            this.groupBox3.Controls.Add(this.botonCrearDepto);
            this.groupBox3.Location = new System.Drawing.Point(546, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 320);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administrar";
            // 
            // botonAsignarAdmin
            // 
            this.botonAsignarAdmin.Location = new System.Drawing.Point(54, 219);
            this.botonAsignarAdmin.Name = "botonAsignarAdmin";
            this.botonAsignarAdmin.Size = new System.Drawing.Size(108, 45);
            this.botonAsignarAdmin.TabIndex = 3;
            this.botonAsignarAdmin.Text = "Asignar Administrador";
            this.botonAsignarAdmin.UseVisualStyleBackColor = true;
            // 
            // botonAsignarSala
            // 
            this.botonAsignarSala.Location = new System.Drawing.Point(54, 164);
            this.botonAsignarSala.Name = "botonAsignarSala";
            this.botonAsignarSala.Size = new System.Drawing.Size(108, 45);
            this.botonAsignarSala.TabIndex = 2;
            this.botonAsignarSala.Text = "Asignar Salas";
            this.botonAsignarSala.UseVisualStyleBackColor = true;
            // 
            // botonEliminarDepto
            // 
            this.botonEliminarDepto.Location = new System.Drawing.Point(54, 109);
            this.botonEliminarDepto.Name = "botonEliminarDepto";
            this.botonEliminarDepto.Size = new System.Drawing.Size(108, 45);
            this.botonEliminarDepto.TabIndex = 1;
            this.botonEliminarDepto.Text = "Eliminar Departamento";
            this.botonEliminarDepto.UseVisualStyleBackColor = true;
            // 
            // botonCrearDepto
            // 
            this.botonCrearDepto.Location = new System.Drawing.Point(54, 52);
            this.botonCrearDepto.Name = "botonCrearDepto";
            this.botonCrearDepto.Size = new System.Drawing.Size(108, 47);
            this.botonCrearDepto.TabIndex = 0;
            this.botonCrearDepto.Text = "Crear Departamento";
            this.botonCrearDepto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tablaDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 320);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla";
            // 
            // tablaDepartamento
            // 
            this.tablaDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaNombreDepartamento,
            this.columnaSalas,
            this.columnaAdmin});
            this.tablaDepartamento.Location = new System.Drawing.Point(6, 14);
            this.tablaDepartamento.Name = "tablaDepartamento";
            this.tablaDepartamento.Size = new System.Drawing.Size(524, 300);
            this.tablaDepartamento.TabIndex = 2;
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "ID";
            this.columnaId.Name = "columnaId";
            // 
            // columnaNombreDepartamento
            // 
            this.columnaNombreDepartamento.HeaderText = "Nombre Departamento";
            this.columnaNombreDepartamento.Name = "columnaNombreDepartamento";
            // 
            // columnaSalas
            // 
            this.columnaSalas.HeaderText = "Salas";
            this.columnaSalas.Name = "columnaSalas";
            // 
            // columnaAdmin
            // 
            this.columnaAdmin.HeaderText = "Administrador";
            this.columnaAdmin.Name = "columnaAdmin";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuarios";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.94241F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.05759F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.adminGroupBox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(764, 313);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 307);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tabla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaIdUsuario,
            this.columnaNombre,
            this.columnaFecha});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // columnaIdUsuario
            // 
            this.columnaIdUsuario.HeaderText = "ID";
            this.columnaIdUsuario.Name = "columnaIdUsuario";
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre Usuario";
            this.columnaNombre.Name = "columnaNombre";
            // 
            // columnaFecha
            // 
            this.columnaFecha.HeaderText = "Fecha Ingreso";
            this.columnaFecha.Name = "columnaFecha";
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.botonDeshabilitarUsuario);
            this.adminGroupBox.Controls.Add(this.botonAgregarUsuario);
            this.adminGroupBox.Location = new System.Drawing.Point(545, 3);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Size = new System.Drawing.Size(216, 298);
            this.adminGroupBox.TabIndex = 1;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Administrar";
            // 
            // botonDeshabilitarUsuario
            // 
            this.botonDeshabilitarUsuario.Location = new System.Drawing.Point(54, 152);
            this.botonDeshabilitarUsuario.Name = "botonDeshabilitarUsuario";
            this.botonDeshabilitarUsuario.Size = new System.Drawing.Size(108, 47);
            this.botonDeshabilitarUsuario.TabIndex = 2;
            this.botonDeshabilitarUsuario.Text = "Deshabilitar Usuario";
            this.botonDeshabilitarUsuario.UseVisualStyleBackColor = true;
            // 
            // botonAgregarUsuario
            // 
            this.botonAgregarUsuario.Location = new System.Drawing.Point(54, 99);
            this.botonAgregarUsuario.Name = "botonAgregarUsuario";
            this.botonAgregarUsuario.Size = new System.Drawing.Size(108, 47);
            this.botonAgregarUsuario.TabIndex = 1;
            this.botonAgregarUsuario.Text = "Agregar Usuario";
            this.botonAgregarUsuario.UseVisualStyleBackColor = true;
            this.botonAgregarUsuario.Click += new System.EventHandler(this.botonAgregarUsuario_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(775, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Salas";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.94241F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.05759F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(764, 304);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(535, 298);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tabla";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaIdSala,
            this.columnaNombreSala});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 279);
            this.dataGridView2.TabIndex = 0;
            // 
            // columnaIdSala
            // 
            this.columnaIdSala.HeaderText = "ID";
            this.columnaIdSala.Name = "columnaIdSala";
            // 
            // columnaNombreSala
            // 
            this.columnaNombreSala.HeaderText = "Nombre";
            this.columnaNombreSala.Name = "columnaNombreSala";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.botonCrearSala);
            this.groupBox6.Location = new System.Drawing.Point(545, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 298);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Administrar";
            // 
            // botonCrearSala
            // 
            this.botonCrearSala.Location = new System.Drawing.Point(54, 126);
            this.botonCrearSala.Name = "botonCrearSala";
            this.botonCrearSala.Size = new System.Drawing.Size(108, 47);
            this.botonCrearSala.TabIndex = 2;
            this.botonCrearSala.Text = "Crear Sala";
            this.botonCrearSala.UseVisualStyleBackColor = true;
            // 
            // VistaSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museo Arkham";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamento)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.adminGroupBox.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button botonAsignarAdmin;
        private System.Windows.Forms.Button botonAsignarSala;
        private System.Windows.Forms.Button botonEliminarDepto;
        private System.Windows.Forms.Button botonCrearDepto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tablaDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombreDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaAdmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFecha;
        private System.Windows.Forms.GroupBox adminGroupBox;
        private System.Windows.Forms.Button botonDeshabilitarUsuario;
        private System.Windows.Forms.Button botonAgregarUsuario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaIdSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombreSala;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button botonCrearSala;
        private System.Windows.Forms.Label label1;
    }
}