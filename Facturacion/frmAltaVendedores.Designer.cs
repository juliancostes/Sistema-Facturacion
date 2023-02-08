namespace Facturacion
{
    partial class frmAltaVendedores
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
            this.btnRemoveVendedor = new System.Windows.Forms.Button();
            this.btnAddVendedor = new System.Windows.Forms.Button();
            this.listVendedores = new System.Windows.Forms.ListBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveVendedor
            // 
            this.btnRemoveVendedor.Location = new System.Drawing.Point(151, 275);
            this.btnRemoveVendedor.Name = "btnRemoveVendedor";
            this.btnRemoveVendedor.Size = new System.Drawing.Size(97, 57);
            this.btnRemoveVendedor.TabIndex = 0;
            this.btnRemoveVendedor.Text = "Eliminar";
            this.btnRemoveVendedor.UseVisualStyleBackColor = true;
            this.btnRemoveVendedor.Click += new System.EventHandler(this.btnRemoveVendedor_Click);
            // 
            // btnAddVendedor
            // 
            this.btnAddVendedor.Location = new System.Drawing.Point(33, 275);
            this.btnAddVendedor.Name = "btnAddVendedor";
            this.btnAddVendedor.Size = new System.Drawing.Size(96, 57);
            this.btnAddVendedor.TabIndex = 1;
            this.btnAddVendedor.Text = "Agregar";
            this.btnAddVendedor.UseVisualStyleBackColor = true;
            this.btnAddVendedor.Click += new System.EventHandler(this.btnAddVendedor_Click);
            // 
            // listVendedores
            // 
            this.listVendedores.FormattingEnabled = true;
            this.listVendedores.Location = new System.Drawing.Point(21, 87);
            this.listVendedores.Name = "listVendedores";
            this.listVendedores.Size = new System.Drawing.Size(355, 134);
            this.listVendedores.TabIndex = 2;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(135, 24);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(206, 20);
            this.txtVendedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Vendedor";
            // 
            // frmAltaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(432, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.listVendedores);
            this.Controls.Add(this.btnAddVendedor);
            this.Controls.Add(this.btnRemoveVendedor);
            this.Name = "frmAltaVendedores";
            this.Text = "Alta Vendedores";
            this.Load += new System.EventHandler(this.formAltaVendedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveVendedor;
        private System.Windows.Forms.Button btnAddVendedor;
        private System.Windows.Forms.ListBox listVendedores;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label2;
    }
}
