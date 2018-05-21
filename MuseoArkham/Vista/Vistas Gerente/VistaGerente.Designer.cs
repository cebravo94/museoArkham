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
            this.buttonRechazarSolicitud = new System.Windows.Forms.Button();
            this.buttonAceptarSolicitud = new System.Windows.Forms.Button();
            this.buttonVerDetalleSolicitudTraslado = new System.Windows.Forms.Button();
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
            this.groupBox3.Controls.Add(this.buttonVerDetalleSolicitudTraslado);
            this.groupBox3.Controls.Add(this.buttonRechazarSolicitud);
            this.groupBox3.Controls.Add(this.buttonAceptarSolicitud);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(133, 273);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonRechazarSolicitud
            // 
            this.buttonRechazarSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRechazarSolicitud.Location = new System.Drawing.Point(5, 48);
            this.buttonRechazarSolicitud.Name = "buttonRechazarSolicitud";
            this.buttonRechazarSolicitud.Size = new System.Drawing.Size(123, 30);
            this.buttonRechazarSolicitud.TabIndex = 1;
            this.buttonRechazarSolicitud.Text = "Rechazar solicitud";
            this.buttonRechazarSolicitud.UseVisualStyleBackColor = true;
            this.buttonRechazarSolicitud.Click += new System.EventHandler(this.buttonRechazarSolicitud_Click);
            // 
            // buttonAceptarSolicitud
            // 
            this.buttonAceptarSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAceptarSolicitud.Location = new System.Drawing.Point(5, 18);
            this.buttonAceptarSolicitud.Name = "buttonAceptarSolicitud";
            this.buttonAceptarSolicitud.Size = new System.Drawing.Size(123, 30);
            this.buttonAceptarSolicitud.TabIndex = 0;
            this.buttonAceptarSolicitud.Text = "Aceptar solicitud";
            this.buttonAceptarSolicitud.UseVisualStyleBackColor = true;
            this.buttonAceptarSolicitud.Click += new System.EventHandler(this.buttonAceptarSolicitud_Click);
            // 
            // buttonVerDetalleSolicitudTraslado
            // 
            this.buttonVerDetalleSolicitudTraslado.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVerDetalleSolicitudTraslado.Location = new System.Drawing.Point(5, 78);
            this.buttonVerDetalleSolicitudTraslado.Name = "buttonVerDetalleSolicitudTraslado";
            this.buttonVerDetalleSolicitudTraslado.Size = new System.Drawing.Size(123, 30);
            this.buttonVerDetalleSolicitudTraslado.TabIndex = 2;
            this.buttonVerDetalleSolicitudTraslado.Text = "Ver detalle";
            this.buttonVerDetalleSolicitudTraslado.UseVisualStyleBackColor = true;
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
        public System.Windows.Forms.Button buttonRechazarSolicitud;
        public System.Windows.Forms.Button buttonAceptarSolicitud;
        private System.Windows.Forms.Button buttonVerDetalleSolicitudTraslado;
    }
}