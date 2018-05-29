namespace MuseoArkham.Vista.Vistas_Secretaria
{
    partial class VistaCambiarAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCambiarAdministrador));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAsignarAdministrador = new System.Windows.Forms.Button();
            this.buttonCancelarAsignarAdministrador = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAdministrador = new System.Windows.Forms.Label();
            this.comboBoxAdministrador = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(430, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar administrador";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 378);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAsignarAdministrador, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancelarAsignarAdministrador, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 343);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAsignarAdministrador
            // 
            this.buttonAsignarAdministrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAsignarAdministrador.Location = new System.Drawing.Point(243, 3);
            this.buttonAsignarAdministrador.Name = "buttonAsignarAdministrador";
            this.buttonAsignarAdministrador.Size = new System.Drawing.Size(74, 26);
            this.buttonAsignarAdministrador.TabIndex = 0;
            this.buttonAsignarAdministrador.Text = "Asignar";
            this.buttonAsignarAdministrador.UseVisualStyleBackColor = true;
            this.buttonAsignarAdministrador.Click += new System.EventHandler(this.buttonAsignarAdministrador_Click);
            // 
            // buttonCancelarAsignarAdministrador
            // 
            this.buttonCancelarAsignarAdministrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancelarAsignarAdministrador.Location = new System.Drawing.Point(323, 3);
            this.buttonCancelarAsignarAdministrador.Name = "buttonCancelarAsignarAdministrador";
            this.buttonCancelarAsignarAdministrador.Size = new System.Drawing.Size(78, 26);
            this.buttonCancelarAsignarAdministrador.TabIndex = 1;
            this.buttonCancelarAsignarAdministrador.Text = "Cancelar";
            this.buttonCancelarAsignarAdministrador.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelAdministrador, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxAdministrador, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(404, 334);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelAdministrador
            // 
            this.labelAdministrador.AutoSize = true;
            this.labelAdministrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdministrador.Location = new System.Drawing.Point(3, 0);
            this.labelAdministrador.Name = "labelAdministrador";
            this.labelAdministrador.Size = new System.Drawing.Size(94, 167);
            this.labelAdministrador.TabIndex = 0;
            this.labelAdministrador.Text = "Administrador";
            // 
            // comboBoxAdministrador
            // 
            this.comboBoxAdministrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdministrador.FormattingEnabled = true;
            this.comboBoxAdministrador.Location = new System.Drawing.Point(103, 3);
            this.comboBoxAdministrador.Name = "comboBoxAdministrador";
            this.comboBoxAdministrador.Size = new System.Drawing.Size(298, 21);
            this.comboBoxAdministrador.TabIndex = 1;
            // 
            // VistaCambiarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 411);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaCambiarAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar Administrador";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAsignarAdministrador;
        private System.Windows.Forms.Button buttonCancelarAsignarAdministrador;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelAdministrador;
        private System.Windows.Forms.ComboBox comboBoxAdministrador;
    }
}