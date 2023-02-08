namespace Facturacion
{
    partial class frmInformes
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnXVendedor = new System.Windows.Forms.Button();
            this.btnXCliente = new System.Windows.Forms.Button();
            this.btnXProducto = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultados de";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(425, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(16, 18);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "0";
            // 
            // btnXVendedor
            // 
            this.btnXVendedor.Location = new System.Drawing.Point(72, 381);
            this.btnXVendedor.Name = "btnXVendedor";
            this.btnXVendedor.Size = new System.Drawing.Size(122, 48);
            this.btnXVendedor.TabIndex = 3;
            this.btnXVendedor.Text = "Total por Vendedor";
            this.btnXVendedor.UseVisualStyleBackColor = true;
            this.btnXVendedor.Click += new System.EventHandler(this.btnXVendedor_Click);
            // 
            // btnXCliente
            // 
            this.btnXCliente.Location = new System.Drawing.Point(308, 381);
            this.btnXCliente.Name = "btnXCliente";
            this.btnXCliente.Size = new System.Drawing.Size(122, 48);
            this.btnXCliente.TabIndex = 4;
            this.btnXCliente.Text = "Total por Cliente";
            this.btnXCliente.UseVisualStyleBackColor = true;
            this.btnXCliente.Click += new System.EventHandler(this.btnXCliente_Click);
            // 
            // btnXProducto
            // 
            this.btnXProducto.Location = new System.Drawing.Point(547, 381);
            this.btnXProducto.Name = "btnXProducto";
            this.btnXProducto.Size = new System.Drawing.Size(122, 48);
            this.btnXProducto.TabIndex = 5;
            this.btnXProducto.Text = "Total por producto";
            this.btnXProducto.UseVisualStyleBackColor = true;
            this.btnXProducto.Click += new System.EventHandler(this.btnXProducto_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(72, 47);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(607, 271);
            this.dgvResultado.TabIndex = 6;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnXProducto);
            this.Controls.Add(this.btnXCliente);
            this.Controls.Add(this.btnXVendedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label2);
            this.Name = "frmInformes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.formInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnXVendedor;
        private System.Windows.Forms.Button btnXCliente;
        private System.Windows.Forms.Button btnXProducto;
        private System.Windows.Forms.DataGridView dgvResultado;
    }
}