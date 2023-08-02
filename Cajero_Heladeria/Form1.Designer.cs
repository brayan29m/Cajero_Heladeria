
namespace Cajero_Heladeria
{
    partial class wfPortada
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPortada));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimizarPortada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarPortada = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.SeaShell;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.DimGray;
            this.btnIngresar.Image = global::Cajero_Heladeria.Properties.Resources.Cajero;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(285, 240);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(210, 70);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(140, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heladería \"Las Primicias\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Informal Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(250, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sistema de Cajero";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnMinimizarPortada);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCerrarPortada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 30);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(36, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "HELADERIA \"LAS PRIMICIAS\"";
            // 
            // btnMinimizarPortada
            // 
            this.btnMinimizarPortada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPortada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizarPortada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinimizarPortada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimizarPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarPortada.Image = global::Cajero_Heladeria.Properties.Resources.Mini;
            this.btnMinimizarPortada.Location = new System.Drawing.Point(690, 0);
            this.btnMinimizarPortada.Name = "btnMinimizarPortada";
            this.btnMinimizarPortada.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizarPortada.TabIndex = 5;
            this.btnMinimizarPortada.UseVisualStyleBackColor = true;
            this.btnMinimizarPortada.Click += new System.EventHandler(this.btnMinimizarPortada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox1.Image = global::Cajero_Heladeria.Properties.Resources.HeladoIcono;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarPortada
            // 
            this.btnCerrarPortada.BackgroundImage = global::Cajero_Heladeria.Properties.Resources.Cerrar;
            this.btnCerrarPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarPortada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPortada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarPortada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrarPortada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrarPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPortada.Image = global::Cajero_Heladeria.Properties.Resources.Cerrar;
            this.btnCerrarPortada.Location = new System.Drawing.Point(720, 0);
            this.btnCerrarPortada.Name = "btnCerrarPortada";
            this.btnCerrarPortada.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarPortada.TabIndex = 4;
            this.btnCerrarPortada.UseVisualStyleBackColor = true;
            this.btnCerrarPortada.Click += new System.EventHandler(this.btnCerrarPortada_Click);
            // 
            // wfPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Cajero_Heladeria.Properties.Resources.PortadaH;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wfPortada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELADERÍA \"LAS PRIMICIAS\"";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarPortada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimizarPortada;
        private System.Windows.Forms.Label label3;
    }
}

