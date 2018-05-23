namespace MuseoArkham.Vista
{
    partial class VistaCrearSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCrearSala));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCrearSala = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombreSala = new System.Windows.Forms.Label();
            this.textBoxNombreSala = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionSala = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMetrosCuadrados = new System.Windows.Forms.Label();
            this.numericUpDownMetrosCuadrados = new System.Windows.Forms.NumericUpDown();
            this.labelDescripcionSala = new System.Windows.Forms.Label();
            this.labelAreaSala = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrosCuadrados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(424, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Sala";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 373);
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
            this.tableLayoutPanel2.Controls.Add(this.buttonCrearSala, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancelar, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 338);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonCrearSala
            // 
            this.buttonCrearSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCrearSala.Location = new System.Drawing.Point(240, 3);
            this.buttonCrearSala.Name = "buttonCrearSala";
            this.buttonCrearSala.Size = new System.Drawing.Size(73, 26);
            this.buttonCrearSala.TabIndex = 0;
            this.buttonCrearSala.Text = "Crear";
            this.buttonCrearSala.UseVisualStyleBackColor = true;
            this.buttonCrearSala.Click += new System.EventHandler(this.buttonCrearSala_Click);
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
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelNombreSala, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNombreSala, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxDescripcionSala, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelDescripcionSala, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelAreaSala, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 329);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelNombreSala
            // 
            this.labelNombreSala.AutoSize = true;
            this.labelNombreSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNombreSala.Location = new System.Drawing.Point(3, 0);
            this.labelNombreSala.Name = "labelNombreSala";
            this.labelNombreSala.Size = new System.Drawing.Size(94, 77);
            this.labelNombreSala.TabIndex = 0;
            this.labelNombreSala.Text = "Nombre";
            // 
            // textBoxNombreSala
            // 
            this.textBoxNombreSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNombreSala.Location = new System.Drawing.Point(103, 3);
            this.textBoxNombreSala.Name = "textBoxNombreSala";
            this.textBoxNombreSala.Size = new System.Drawing.Size(292, 20);
            this.textBoxNombreSala.TabIndex = 3;
            // 
            // textBoxDescripcionSala
            // 
            this.textBoxDescripcionSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescripcionSala.Location = new System.Drawing.Point(103, 234);
            this.textBoxDescripcionSala.Multiline = true;
            this.textBoxDescripcionSala.Name = "textBoxDescripcionSala";
            this.tableLayoutPanel3.SetRowSpan(this.textBoxDescripcionSala, 2);
            this.textBoxDescripcionSala.Size = new System.Drawing.Size(292, 92);
            this.textBoxDescripcionSala.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Controls.Add(this.labelMetrosCuadrados, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownMetrosCuadrados, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(103, 80);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(292, 71);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // labelMetrosCuadrados
            // 
            this.labelMetrosCuadrados.AutoSize = true;
            this.labelMetrosCuadrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMetrosCuadrados.Location = new System.Drawing.Point(265, 0);
            this.labelMetrosCuadrados.Name = "labelMetrosCuadrados";
            this.labelMetrosCuadrados.Size = new System.Drawing.Size(24, 71);
            this.labelMetrosCuadrados.TabIndex = 0;
            this.labelMetrosCuadrados.Text = "m2";
            this.labelMetrosCuadrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDownMetrosCuadrados
            // 
            this.numericUpDownMetrosCuadrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMetrosCuadrados.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownMetrosCuadrados.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownMetrosCuadrados.Name = "numericUpDownMetrosCuadrados";
            this.numericUpDownMetrosCuadrados.Size = new System.Drawing.Size(262, 20);
            this.numericUpDownMetrosCuadrados.TabIndex = 1;
            // 
            // labelDescripcionSala
            // 
            this.labelDescripcionSala.AutoSize = true;
            this.labelDescripcionSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescripcionSala.Location = new System.Drawing.Point(3, 231);
            this.labelDescripcionSala.Name = "labelDescripcionSala";
            this.labelDescripcionSala.Size = new System.Drawing.Size(94, 77);
            this.labelDescripcionSala.TabIndex = 2;
            this.labelDescripcionSala.Text = "Descripción";
            // 
            // labelAreaSala
            // 
            this.labelAreaSala.AutoSize = true;
            this.labelAreaSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAreaSala.Location = new System.Drawing.Point(3, 77);
            this.labelAreaSala.Name = "labelAreaSala";
            this.labelAreaSala.Size = new System.Drawing.Size(94, 77);
            this.labelAreaSala.TabIndex = 1;
            this.labelAreaSala.Text = "Área";
            // 
            // VistaCrearSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 412);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(446, 450);
            this.Name = "VistaCrearSala";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Museo Arkham";
            this.Load += new System.EventHandler(this.VistaCrearSala_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrosCuadrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonCrearSala;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelNombreSala;
        private System.Windows.Forms.Label labelAreaSala;
        private System.Windows.Forms.Label labelDescripcionSala;
        private System.Windows.Forms.TextBox textBoxNombreSala;
        private System.Windows.Forms.TextBox textBoxDescripcionSala;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelMetrosCuadrados;
        private System.Windows.Forms.NumericUpDown numericUpDownMetrosCuadrados;
    }
}