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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSalaOrigen = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.comboBoxSalaOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxSalaDestino = new System.Windows.Forms.ComboBox();
            this.textBoxComentarios = new System.Windows.Forms.TextBox();
            this.labelSalaDestino = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAgregarObjeto = new System.Windows.Forms.Button();
            this.buttonQuitarObjeto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewObjetosEnBodega = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSeleccionObjetos = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCrearSolicitud.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetosEnBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCrearSolicitud
            // 
            this.groupBoxCrearSolicitud.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxCrearSolicitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCrearSolicitud.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCrearSolicitud.Name = "groupBoxCrearSolicitud";
            this.groupBoxCrearSolicitud.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxCrearSolicitud.Size = new System.Drawing.Size(424, 405);
            this.groupBoxCrearSolicitud.TabIndex = 0;
            this.groupBoxCrearSolicitud.TabStop = false;
            this.groupBoxCrearSolicitud.Text = "Crear Solicitud";
            this.groupBoxCrearSolicitud.Enter += new System.EventHandler(this.groupBoxCrearSolicitud_Enter);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(404, 372);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelSalaOrigen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelComentario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSalaOrigen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSalaDestino, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxComentarios, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSalaDestino, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 68);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // labelSalaOrigen
            // 
            this.labelSalaOrigen.AutoSize = true;
            this.labelSalaOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSalaOrigen.Location = new System.Drawing.Point(3, 0);
            this.labelSalaOrigen.Name = "labelSalaOrigen";
            this.labelSalaOrigen.Size = new System.Drawing.Size(70, 22);
            this.labelSalaOrigen.TabIndex = 6;
            this.labelSalaOrigen.Text = "Sala origen";
            this.labelSalaOrigen.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelComentario.Location = new System.Drawing.Point(3, 22);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(70, 41);
            this.labelComentario.TabIndex = 8;
            this.labelComentario.Text = "Comentarios";
            this.labelComentario.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBoxSalaOrigen
            // 
            this.comboBoxSalaOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSalaOrigen.FormattingEnabled = true;
            this.comboBoxSalaOrigen.Location = new System.Drawing.Point(79, 3);
            this.comboBoxSalaOrigen.Name = "comboBoxSalaOrigen";
            this.comboBoxSalaOrigen.Size = new System.Drawing.Size(117, 21);
            this.comboBoxSalaOrigen.TabIndex = 9;
            // 
            // comboBoxSalaDestino
            // 
            this.comboBoxSalaDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSalaDestino.FormattingEnabled = true;
            this.comboBoxSalaDestino.Location = new System.Drawing.Point(278, 3);
            this.comboBoxSalaDestino.Name = "comboBoxSalaDestino";
            this.comboBoxSalaDestino.Size = new System.Drawing.Size(117, 21);
            this.comboBoxSalaDestino.TabIndex = 10;
            // 
            // textBoxComentarios
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxComentarios, 3);
            this.textBoxComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxComentarios.Location = new System.Drawing.Point(79, 25);
            this.textBoxComentarios.Multiline = true;
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.Size = new System.Drawing.Size(316, 35);
            this.textBoxComentarios.TabIndex = 11;
            // 
            // labelSalaDestino
            // 
            this.labelSalaDestino.AutoSize = true;
            this.labelSalaDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSalaDestino.Location = new System.Drawing.Point(202, 0);
            this.labelSalaDestino.Name = "labelSalaDestino";
            this.labelSalaDestino.Size = new System.Drawing.Size(70, 22);
            this.labelSalaDestino.TabIndex = 7;
            this.labelSalaDestino.Text = "Sala destino";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.buttonCrear, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonCancelar, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(398, 32);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCrear.Location = new System.Drawing.Point(240, 3);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(73, 26);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancelar.Location = new System.Drawing.Point(319, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(76, 26);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewSeleccionObjetos, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 254);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonAgregarObjeto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonQuitarObjeto, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 112);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(392, 29);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonAgregarObjeto
            // 
            this.buttonAgregarObjeto.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAgregarObjeto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarObjeto.Image")));
            this.buttonAgregarObjeto.Location = new System.Drawing.Point(118, 3);
            this.buttonAgregarObjeto.Name = "buttonAgregarObjeto";
            this.buttonAgregarObjeto.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarObjeto.TabIndex = 0;
            this.buttonAgregarObjeto.UseVisualStyleBackColor = true;
            // 
            // buttonQuitarObjeto
            // 
            this.buttonQuitarObjeto.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonQuitarObjeto.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuitarObjeto.Image")));
            this.buttonQuitarObjeto.Location = new System.Drawing.Point(199, 3);
            this.buttonQuitarObjeto.Name = "buttonQuitarObjeto";
            this.buttonQuitarObjeto.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitarObjeto.TabIndex = 1;
            this.buttonQuitarObjeto.UseMnemonic = false;
            this.buttonQuitarObjeto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewObjetosEnBodega);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 88);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewObjetosEnBodega
            // 
            this.dataGridViewObjetosEnBodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewObjetosEnBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjetosEnBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewObjetosEnBodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewObjetosEnBodega.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewObjetosEnBodega.Name = "dataGridViewObjetosEnBodega";
            this.dataGridViewObjetosEnBodega.Size = new System.Drawing.Size(392, 88);
            this.dataGridViewObjetosEnBodega.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewSeleccionObjetos
            // 
            this.dataGridViewSeleccionObjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSeleccionObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeleccionObjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewSeleccionObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeleccionObjetos.Location = new System.Drawing.Point(3, 162);
            this.dataGridViewSeleccionObjetos.Name = "dataGridViewSeleccionObjetos";
            this.dataGridViewSeleccionObjetos.Size = new System.Drawing.Size(392, 89);
            this.dataGridViewSeleccionObjetos.TabIndex = 1;
            this.dataGridViewSeleccionObjetos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeleccionObjetos_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Objetos disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Objetos agregados";
            // 
            // VistaCrearSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 411);
            this.Controls.Add(this.groupBoxCrearSolicitud);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(446, 450);
            this.Name = "VistaCrearSolicitud";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Solicitud";
            this.Load += new System.EventHandler(this.CrearSolicitud_Load);
            this.groupBoxCrearSolicitud.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetosEnBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionObjetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCrearSolicitud;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label labelSalaOrigen;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.Label labelSalaDestino;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxSalaOrigen;
        private System.Windows.Forms.ComboBox comboBoxSalaDestino;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewObjetosEnBodega;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGridViewSeleccionObjetos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonAgregarObjeto;
        private System.Windows.Forms.Button buttonQuitarObjeto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}