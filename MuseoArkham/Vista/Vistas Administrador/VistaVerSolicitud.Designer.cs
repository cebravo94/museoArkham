namespace MuseoArkham.Vista.Vistas_Administrador
{
    partial class VistaVerSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaVerSolicitud));
            this.groupBoxVerSolicitud = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSalaOrigen = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.textBoxComentarios = new System.Windows.Forms.TextBox();
            this.labelSalaDestino = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSolicitar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewObjetosEnBodega = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSalaOrigen = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxVerSolicitud.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetosEnBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVerSolicitud
            // 
            this.groupBoxVerSolicitud.AutoSize = true;
            this.groupBoxVerSolicitud.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxVerSolicitud.Location = new System.Drawing.Point(3, 1);
            this.groupBoxVerSolicitud.Name = "groupBoxVerSolicitud";
            this.groupBoxVerSolicitud.Size = new System.Drawing.Size(429, 410);
            this.groupBoxVerSolicitud.TabIndex = 0;
            this.groupBoxVerSolicitud.TabStop = false;
            this.groupBoxVerSolicitud.Text = "Ver Solicitud";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(423, 391);
            this.tableLayoutPanel5.TabIndex = 13;
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
            this.tableLayoutPanel1.Controls.Add(this.textBoxComentarios, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSalaDestino, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSalaOrigen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 72);
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
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelComentario.Location = new System.Drawing.Point(3, 27);
            this.labelComentario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(70, 40);
            this.labelComentario.TabIndex = 8;
            this.labelComentario.Text = "Comentarios";
            // 
            // textBoxComentarios
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxComentarios, 3);
            this.textBoxComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxComentarios.Location = new System.Drawing.Point(79, 27);
            this.textBoxComentarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.textBoxComentarios.Multiline = true;
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.ReadOnly = true;
            this.textBoxComentarios.Size = new System.Drawing.Size(335, 37);
            this.textBoxComentarios.TabIndex = 11;
            // 
            // labelSalaDestino
            // 
            this.labelSalaDestino.AutoSize = true;
            this.labelSalaDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSalaDestino.Location = new System.Drawing.Point(211, 0);
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
            this.tableLayoutPanel4.Controls.Add(this.buttonSolicitar, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonCancelar, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(417, 34);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // buttonSolicitar
            // 
            this.buttonSolicitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSolicitar.Location = new System.Drawing.Point(252, 3);
            this.buttonSolicitar.Name = "buttonSolicitar";
            this.buttonSolicitar.Size = new System.Drawing.Size(77, 28);
            this.buttonSolicitar.TabIndex = 0;
            this.buttonSolicitar.Text = "Solicitar";
            this.buttonSolicitar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancelar.Location = new System.Drawing.Point(335, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 28);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 267);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewObjetosEnBodega);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 246);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewObjetosEnBodega
            // 
            this.dataGridViewObjetosEnBodega.AllowUserToAddRows = false;
            this.dataGridViewObjetosEnBodega.AllowUserToDeleteRows = false;
            this.dataGridViewObjetosEnBodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewObjetosEnBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjetosEnBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewObjetosEnBodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewObjetosEnBodega.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewObjetosEnBodega.Name = "dataGridViewObjetosEnBodega";
            this.dataGridViewObjetosEnBodega.Size = new System.Drawing.Size(411, 246);
            this.dataGridViewObjetosEnBodega.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selección";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Objetos";
            // 
            // textBoxSalaOrigen
            // 
            this.textBoxSalaOrigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSalaOrigen.Location = new System.Drawing.Point(79, 3);
            this.textBoxSalaOrigen.Name = "textBoxSalaOrigen";
            this.textBoxSalaOrigen.ReadOnly = true;
            this.textBoxSalaOrigen.Size = new System.Drawing.Size(126, 20);
            this.textBoxSalaOrigen.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(287, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 13;
            // 
            // VistaVerSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.groupBoxVerSolicitud);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaVerSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Solicitud";
            this.groupBoxVerSolicitud.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjetosEnBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVerSolicitud;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSalaOrigen;
        private System.Windows.Forms.Label labelComentario;
        public System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.Label labelSalaDestino;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonSolicitar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridViewObjetosEnBodega;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxSalaOrigen;
        public System.Windows.Forms.TextBox textBox1;
    }
}