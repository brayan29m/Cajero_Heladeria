
namespace Cajero_Heladeria
{
    partial class RegistroCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCajero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizarCajero = new System.Windows.Forms.Button();
            this.btnCerrarCajero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAdicional = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.mskServicios = new System.Windows.Forms.MaskedTextBox();
            this.cmbAderezo = new System.Windows.Forms.ComboBox();
            this.cmbSabor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMinimizarCajero);
            this.panel1.Controls.Add(this.btnCerrarCajero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(37, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "REGISTRO DE VENTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox1.Image = global::Cajero_Heladeria.Properties.Resources.HeladoIcono;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizarCajero
            // 
            this.btnMinimizarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarCajero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizarCajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinimizarCajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimizarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarCajero.Image = global::Cajero_Heladeria.Properties.Resources.Mini;
            this.btnMinimizarCajero.Location = new System.Drawing.Point(740, 0);
            this.btnMinimizarCajero.Name = "btnMinimizarCajero";
            this.btnMinimizarCajero.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizarCajero.TabIndex = 7;
            this.btnMinimizarCajero.UseVisualStyleBackColor = true;
            this.btnMinimizarCajero.Click += new System.EventHandler(this.btnMinimizarCajero_Click);
            // 
            // btnCerrarCajero
            // 
            this.btnCerrarCajero.BackgroundImage = global::Cajero_Heladeria.Properties.Resources.Cerrar;
            this.btnCerrarCajero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCajero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarCajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrarCajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCajero.Image = global::Cajero_Heladeria.Properties.Resources.Cerrar;
            this.btnCerrarCajero.Location = new System.Drawing.Point(770, 0);
            this.btnCerrarCajero.Name = "btnCerrarCajero";
            this.btnCerrarCajero.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarCajero.TabIndex = 6;
            this.btnCerrarCajero.UseVisualStyleBackColor = true;
            this.btnCerrarCajero.Click += new System.EventHandler(this.btnCerrarCajero_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTROL DE REGISTRO DE VENTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mskCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbAdicional);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.cmbTamanio);
            this.groupBox1.Controls.Add(this.mskServicios);
            this.groupBox1.Controls.Add(this.cmbAderezo);
            this.groupBox1.Controls.Add(this.cmbSabor);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(29, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar Pedido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(525, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Precio del producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(535, 115);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(150, 50);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "lblPrecio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(525, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Nombre del Cliente/a:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Seleccione el aderezo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Seleccione el sabor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Incluya los servicios:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Escoja algún adicional:";
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(15, 160);
            this.mskCantidad.Mask = "99";
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(150, 27);
            this.mskCantidad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Escoja el tamaño:";
            // 
            // cmbAdicional
            // 
            this.cmbAdicional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdicional.FormattingEnabled = true;
            this.cmbAdicional.Items.AddRange(new object[] {
            "(Seleccione)",
            "Chispitas",
            "Grageas",
            "Coco Rallado",
            "Queso",
            "Fruta Picada",
            "Barquillo",
            "Chicles"});
            this.cmbAdicional.Location = new System.Drawing.Point(285, 105);
            this.cmbAdicional.Name = "cmbAdicional";
            this.cmbAdicional.Size = new System.Drawing.Size(150, 27);
            this.cmbAdicional.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(530, 50);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(150, 27);
            this.txtCliente.TabIndex = 7;
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Items.AddRange(new object[] {
            "(Seleccione)",
            "Supremo",
            "Grande",
            "Mediano",
            "Pequeño",
            "Cono"});
            this.cmbTamanio.Location = new System.Drawing.Point(285, 50);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(150, 27);
            this.cmbTamanio.TabIndex = 4;
            this.cmbTamanio.SelectedIndexChanged += new System.EventHandler(this.cmbTamanio_SelectedIndexChanged);
            // 
            // mskServicios
            // 
            this.mskServicios.Location = new System.Drawing.Point(285, 160);
            this.mskServicios.Mask = "$9.99";
            this.mskServicios.Name = "mskServicios";
            this.mskServicios.Size = new System.Drawing.Size(150, 27);
            this.mskServicios.TabIndex = 6;
            // 
            // cmbAderezo
            // 
            this.cmbAderezo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAderezo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAderezo.FormattingEnabled = true;
            this.cmbAderezo.Items.AddRange(new object[] {
            "(Seleccione)",
            "Nutella",
            "Crema",
            "Leche Condensada",
            "Manjar de Leche",
            "Dulce de Mora",
            "Salsa de Maracuyá",
            "Chocolate Derretido"});
            this.cmbAderezo.Location = new System.Drawing.Point(15, 105);
            this.cmbAderezo.Name = "cmbAderezo";
            this.cmbAderezo.Size = new System.Drawing.Size(150, 27);
            this.cmbAderezo.TabIndex = 1;
            // 
            // cmbSabor
            // 
            this.cmbSabor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSabor.FormattingEnabled = true;
            this.cmbSabor.Items.AddRange(new object[] {
            "(Seleccione)",
            "Chocolate",
            "Vainilla",
            "Fresa",
            "Mora",
            "Chicle",
            "Taxo",
            "Guanábana",
            "Coco",
            "Ron Pasas",
            "Mango",
            "Menta",
            "Dulce de Leche",
            "Frutas",
            "Café",
            "Turrón"});
            this.cmbSabor.Location = new System.Drawing.Point(15, 50);
            this.cmbSabor.Name = "cmbSabor";
            this.cmbSabor.Size = new System.Drawing.Size(150, 27);
            this.cmbSabor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(482, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Actual:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(620, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 25);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "lblFecha";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Location = new System.Drawing.Point(252, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 60);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuscar.Location = new System.Drawing.Point(406, 321);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 60);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(29, 403);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(745, 185);
            this.dgvDatos.TabIndex = 7;
            // 
            // RegistroCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Cajero_Heladeria.Properties.Resources.Heladeria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Compras";
            this.Load += new System.EventHandler(this.RegistroCajero_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizarCajero;
        private System.Windows.Forms.Button btnCerrarCajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSabor;
        private System.Windows.Forms.ComboBox cmbAderezo;
        private System.Windows.Forms.MaskedTextBox mskServicios;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.MaskedTextBox mskCantidad;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAdicional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}