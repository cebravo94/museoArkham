﻿namespace MuseoArkham.Vista
{
    partial class VistaAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAgregarUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCrearUsuario = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelRunUsuario = new System.Windows.Forms.Label();
            this.labelCorreoElectronicoUsuario = new System.Windows.Forms.Label();
            this.labelTipoUsuario = new System.Windows.Forms.Label();
            this.labelContraseñaUsuario = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxRunUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCorreoElectronicoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox1.Size = new System.Drawing.Size(565, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 459);
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
            this.tableLayoutPanel2.Controls.Add(this.buttonCrearUsuario, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancelar, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 417);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(531, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonCrearUsuario
            // 
            this.buttonCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCrearUsuario.Location = new System.Drawing.Point(322, 4);
            this.buttonCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrearUsuario.Name = "buttonCrearUsuario";
            this.buttonCrearUsuario.Size = new System.Drawing.Size(98, 30);
            this.buttonCrearUsuario.TabIndex = 0;
            this.buttonCrearUsuario.Text = "Crear";
            this.buttonCrearUsuario.UseVisualStyleBackColor = true;
            this.buttonCrearUsuario.Click += new System.EventHandler(this.buttonCrearUsuario_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancelar.Location = new System.Drawing.Point(428, 4);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(99, 30);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelNombreUsuario, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelRunUsuario, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelCorreoElectronicoUsuario, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelTipoUsuario, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelContraseñaUsuario, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNombreUsuario, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxRunUsuario, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCorreoElectronicoUsuario, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxContraseñaUsuario, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxTipoUsuario, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(531, 405);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNombreUsuario.Location = new System.Drawing.Point(4, 0);
            this.labelNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(125, 81);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre";
            // 
            // labelRunUsuario
            // 
            this.labelRunUsuario.AutoSize = true;
            this.labelRunUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRunUsuario.Location = new System.Drawing.Point(4, 81);
            this.labelRunUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRunUsuario.Name = "labelRunUsuario";
            this.labelRunUsuario.Size = new System.Drawing.Size(125, 81);
            this.labelRunUsuario.TabIndex = 1;
            this.labelRunUsuario.Text = "R.U.N";
            // 
            // labelCorreoElectronicoUsuario
            // 
            this.labelCorreoElectronicoUsuario.AutoSize = true;
            this.labelCorreoElectronicoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCorreoElectronicoUsuario.Location = new System.Drawing.Point(4, 162);
            this.labelCorreoElectronicoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreoElectronicoUsuario.Name = "labelCorreoElectronicoUsuario";
            this.labelCorreoElectronicoUsuario.Size = new System.Drawing.Size(125, 81);
            this.labelCorreoElectronicoUsuario.TabIndex = 2;
            this.labelCorreoElectronicoUsuario.Text = "Correo electrónico";
            // 
            // labelTipoUsuario
            // 
            this.labelTipoUsuario.AutoSize = true;
            this.labelTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTipoUsuario.Location = new System.Drawing.Point(4, 243);
            this.labelTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoUsuario.Name = "labelTipoUsuario";
            this.labelTipoUsuario.Size = new System.Drawing.Size(125, 81);
            this.labelTipoUsuario.TabIndex = 3;
            this.labelTipoUsuario.Text = "Tipo usuario";
            // 
            // labelContraseñaUsuario
            // 
            this.labelContraseñaUsuario.AutoSize = true;
            this.labelContraseñaUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContraseñaUsuario.Location = new System.Drawing.Point(4, 324);
            this.labelContraseñaUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseñaUsuario.Name = "labelContraseñaUsuario";
            this.labelContraseñaUsuario.Size = new System.Drawing.Size(125, 81);
            this.labelContraseñaUsuario.TabIndex = 4;
            this.labelContraseñaUsuario.Text = "Contraseña";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(137, 4);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(390, 22);
            this.textBoxNombreUsuario.TabIndex = 5;
            // 
            // textBoxRunUsuario
            // 
            this.textBoxRunUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRunUsuario.Location = new System.Drawing.Point(137, 85);
            this.textBoxRunUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRunUsuario.Name = "textBoxRunUsuario";
            this.textBoxRunUsuario.Size = new System.Drawing.Size(390, 22);
            this.textBoxRunUsuario.TabIndex = 6;
            // 
            // textBoxCorreoElectronicoUsuario
            // 
            this.textBoxCorreoElectronicoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCorreoElectronicoUsuario.Location = new System.Drawing.Point(137, 166);
            this.textBoxCorreoElectronicoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCorreoElectronicoUsuario.Name = "textBoxCorreoElectronicoUsuario";
            this.textBoxCorreoElectronicoUsuario.Size = new System.Drawing.Size(390, 22);
            this.textBoxCorreoElectronicoUsuario.TabIndex = 7;
            // 
            // textBoxContraseñaUsuario
            // 
            this.textBoxContraseñaUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContraseñaUsuario.Location = new System.Drawing.Point(137, 328);
            this.textBoxContraseñaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            this.textBoxContraseñaUsuario.Size = new System.Drawing.Size(390, 22);
            this.textBoxContraseñaUsuario.TabIndex = 9;
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Bodega",
            "Gerente"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(137, 247);
            this.comboBoxTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(390, 24);
            this.comboBoxTipoUsuario.TabIndex = 10;
            // 
            // VistaAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 506);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(589, 543);
            this.Name = "VistaAgregarUsuario";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Museo Arkham";
            this.Load += new System.EventHandler(this.VistaAgregarUsuario_Load);
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
        private System.Windows.Forms.Button buttonCrearUsuario;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelRunUsuario;
        private System.Windows.Forms.Label labelCorreoElectronicoUsuario;
        private System.Windows.Forms.Label labelTipoUsuario;
        private System.Windows.Forms.Label labelContraseñaUsuario;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxRunUsuario;
        private System.Windows.Forms.TextBox textBoxCorreoElectronicoUsuario;
        private System.Windows.Forms.TextBox textBoxContraseñaUsuario;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
    }
}