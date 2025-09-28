namespace prjChalimondRepuestos
{
    partial class frmRepuestos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMarcas_carga = new ComboBox();
            lstOrigen_carga = new ComboBox();
            numRepuesto_carga = new NumericUpDown();
            txtDesc_carga = new RichTextBox();
            numPrecio_carga = new NumericUpDown();
            groupBox1 = new GroupBox();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblRepuesto = new Label();
            btnCarga = new Button();
            lblOrigen = new Label();
            lblMarca = new Label();
            groupBox2 = new GroupBox();
            lastFiltrar_consulta = new ComboBox();
            lblFiltrar_consulta = new Label();
            lblOrigen_consulta = new Label();
            lblMarca_consulta = new Label();
            optImporta_consulta = new RadioButton();
            optNacional_consulta = new RadioButton();
            btnConsulta = new Button();
            lstMarca_consulta = new ComboBox();
            lastRepuestos_consulta = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numRepuesto_carga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio_carga).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lstMarcas_carga
            // 
            lstMarcas_carga.FormattingEnabled = true;
            lstMarcas_carga.Items.AddRange(new object[] { "Peugeot", "Fiat", "Renault" });
            lstMarcas_carga.Location = new Point(30, 37);
            lstMarcas_carga.Name = "lstMarcas_carga";
            lstMarcas_carga.Size = new Size(150, 23);
            lstMarcas_carga.TabIndex = 0;
            // 
            // lstOrigen_carga
            // 
            lstOrigen_carga.FormattingEnabled = true;
            lstOrigen_carga.Items.AddRange(new object[] { "Nacional", "Importado" });
            lstOrigen_carga.Location = new Point(198, 37);
            lstOrigen_carga.Name = "lstOrigen_carga";
            lstOrigen_carga.Size = new Size(150, 23);
            lstOrigen_carga.TabIndex = 1;
            // 
            // numRepuesto_carga
            // 
            numRepuesto_carga.Location = new Point(30, 80);
            numRepuesto_carga.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numRepuesto_carga.Name = "numRepuesto_carga";
            numRepuesto_carga.Size = new Size(150, 23);
            numRepuesto_carga.TabIndex = 2;
            // 
            // txtDesc_carga
            // 
            txtDesc_carga.Location = new Point(30, 121);
            txtDesc_carga.MaxLength = 50;
            txtDesc_carga.Name = "txtDesc_carga";
            txtDesc_carga.Size = new Size(318, 96);
            txtDesc_carga.TabIndex = 3;
            txtDesc_carga.Text = "";
            // 
            // numPrecio_carga
            // 
            numPrecio_carga.Location = new Point(198, 81);
            numPrecio_carga.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numPrecio_carga.Name = "numPrecio_carga";
            numPrecio_carga.Size = new Size(150, 23);
            numPrecio_carga.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDescripcion);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(lblRepuesto);
            groupBox1.Controls.Add(btnCarga);
            groupBox1.Controls.Add(lblOrigen);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(numPrecio_carga);
            groupBox1.Controls.Add(txtDesc_carga);
            groupBox1.Controls.Add(numRepuesto_carga);
            groupBox1.Controls.Add(lstOrigen_carga);
            groupBox1.Controls.Add(lstMarcas_carga);
            groupBox1.Location = new Point(28, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 247);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar datos";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(30, 106);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(198, 63);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // lblRepuesto
            // 
            lblRepuesto.AutoSize = true;
            lblRepuesto.Location = new Point(30, 62);
            lblRepuesto.Name = "lblRepuesto";
            lblRepuesto.Size = new Size(73, 15);
            lblRepuesto.TabIndex = 8;
            lblRepuesto.Text = "N° Repuesto";
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(28, 218);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(320, 23);
            btnCarga.TabIndex = 5;
            btnCarga.Text = "Cargar";
            btnCarga.UseVisualStyleBackColor = true;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(198, 19);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 7;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(30, 19);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lastRepuestos_consulta);
            groupBox2.Controls.Add(lastFiltrar_consulta);
            groupBox2.Controls.Add(lblFiltrar_consulta);
            groupBox2.Controls.Add(lblOrigen_consulta);
            groupBox2.Controls.Add(lblMarca_consulta);
            groupBox2.Controls.Add(optImporta_consulta);
            groupBox2.Controls.Add(optNacional_consulta);
            groupBox2.Controls.Add(btnConsulta);
            groupBox2.Controls.Add(lstMarca_consulta);
            groupBox2.Location = new Point(397, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 247);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consultar datos";
            // 
            // lastFiltrar_consulta
            // 
            lastFiltrar_consulta.FormattingEnabled = true;
            lastFiltrar_consulta.Location = new Point(19, 144);
            lastFiltrar_consulta.Name = "lastFiltrar_consulta";
            lastFiltrar_consulta.Size = new Size(150, 23);
            lastFiltrar_consulta.TabIndex = 14;
            // 
            // lblFiltrar_consulta
            // 
            lblFiltrar_consulta.AutoSize = true;
            lblFiltrar_consulta.Location = new Point(19, 126);
            lblFiltrar_consulta.Name = "lblFiltrar_consulta";
            lblFiltrar_consulta.Size = new Size(58, 15);
            lblFiltrar_consulta.TabIndex = 13;
            lblFiltrar_consulta.Text = "Filtrar por";
            // 
            // lblOrigen_consulta
            // 
            lblOrigen_consulta.AutoSize = true;
            lblOrigen_consulta.Location = new Point(19, 68);
            lblOrigen_consulta.Name = "lblOrigen_consulta";
            lblOrigen_consulta.Size = new Size(43, 15);
            lblOrigen_consulta.TabIndex = 12;
            lblOrigen_consulta.Text = "Origen";
            // 
            // lblMarca_consulta
            // 
            lblMarca_consulta.AutoSize = true;
            lblMarca_consulta.Location = new Point(19, 19);
            lblMarca_consulta.Name = "lblMarca_consulta";
            lblMarca_consulta.Size = new Size(40, 15);
            lblMarca_consulta.TabIndex = 11;
            lblMarca_consulta.Text = "Marca";
            // 
            // optImporta_consulta
            // 
            optImporta_consulta.AutoSize = true;
            optImporta_consulta.Location = new Point(19, 104);
            optImporta_consulta.Name = "optImporta_consulta";
            optImporta_consulta.Size = new Size(81, 19);
            optImporta_consulta.TabIndex = 8;
            optImporta_consulta.TabStop = true;
            optImporta_consulta.Text = "Importado";
            optImporta_consulta.UseVisualStyleBackColor = true;
            // 
            // optNacional_consulta
            // 
            optNacional_consulta.AutoSize = true;
            optNacional_consulta.Location = new Point(19, 86);
            optNacional_consulta.Name = "optNacional_consulta";
            optNacional_consulta.Size = new Size(72, 19);
            optNacional_consulta.TabIndex = 7;
            optNacional_consulta.TabStop = true;
            optNacional_consulta.Text = "Nacional";
            optNacional_consulta.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(19, 173);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(150, 63);
            btnConsulta.TabIndex = 6;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // lstMarca_consulta
            // 
            lstMarca_consulta.FormattingEnabled = true;
            lstMarca_consulta.Items.AddRange(new object[] { "Peugeot", "Fiat", "Renault" });
            lstMarca_consulta.Location = new Point(19, 37);
            lstMarca_consulta.Name = "lstMarca_consulta";
            lstMarca_consulta.Size = new Size(150, 23);
            lstMarca_consulta.TabIndex = 5;
            // 
            // lastRepuestos_consulta
            // 
            lastRepuestos_consulta.FormattingEnabled = true;
            lastRepuestos_consulta.ItemHeight = 15;
            lastRepuestos_consulta.Location = new Point(175, 37);
            lastRepuestos_consulta.Name = "lastRepuestos_consulta";
            lastRepuestos_consulta.Size = new Size(185, 199);
            lastRepuestos_consulta.TabIndex = 15;
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 279);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmRepuestos";
            Text = "Gestion de repuestos";
            ((System.ComponentModel.ISupportInitialize)numRepuesto_carga).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio_carga).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox lstMarcas_carga;
        private ComboBox lstOrigen_carga;
        private NumericUpDown numRepuesto_carga;
        private RichTextBox txtDesc_carga;
        private NumericUpDown numPrecio_carga;
        private GroupBox groupBox1;
        private Button btnCarga;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private TextBox textBox1;
        private RadioButton optImporta_consulta;
        private RadioButton optNacional_consulta;
        private Button btnConsulta;
        private ComboBox lstMarca_consulta;
        private Label lblPrecio;
        private Label lblRepuesto;
        private Label lblOrigen;
        private Label lblMarca;
        private Label lblDescripcion;
        private Label lblMarca_consulta;
        private Label lblFiltrar_consulta;
        private Label lblOrigen_consulta;
        private ComboBox lastFiltrar_consulta;
        private ListBox lastRepuestos_consulta;
    }
}
