namespace Facturacion
{
    partial class main
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
            this.btnAltaVendedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaVendedor
            // 
            this.btnAltaVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaVendedor.Location = new System.Drawing.Point(121, 102);
            this.btnAltaVendedor.Name = "btnAltaVendedor";
            this.btnAltaVendedor.Size = new System.Drawing.Size(127, 99);
            this.btnAltaVendedor.TabIndex = 0;
            this.btnAltaVendedor.Text = "Alta Vendedor";
            this.btnAltaVendedor.UseVisualStyleBackColor = true;
            this.btnAltaVendedor.Click += new System.EventHandler(this.btnAltaVendedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.Location = new System.Drawing.Point(121, 256);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(127, 93);
            this.btnAltaProducto.TabIndex = 2;
            this.btnAltaProducto.Text = "Alta Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.Location = new System.Drawing.Point(327, 102);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(126, 99);
            this.btnAltaCliente.TabIndex = 3;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(327, 256);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(126, 93);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Location = new System.Drawing.Point(530, 102);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(119, 99);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.btnAltaProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltaVendedor);
            this.Name = "main";
            this.Text = "Sistema de Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaVendedor;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnInformes;
    }
}

