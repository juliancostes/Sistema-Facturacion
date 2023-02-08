namespace Facturacion
{
    partial class frmAltaProducto
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNomProduct = new System.Windows.Forms.TextBox();
            this.textCostProduct = new System.Windows.Forms.TextBox();
            this.dgvTableProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(132, 302);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(90, 43);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "$";
            // 
            // textNomProduct
            // 
            this.textNomProduct.Location = new System.Drawing.Point(148, 17);
            this.textNomProduct.Name = "textNomProduct";
            this.textNomProduct.Size = new System.Drawing.Size(200, 20);
            this.textNomProduct.TabIndex = 5;
            // 
            // textCostProduct
            // 
            this.textCostProduct.Location = new System.Drawing.Point(148, 48);
            this.textCostProduct.Name = "textCostProduct";
            this.textCostProduct.Size = new System.Drawing.Size(200, 20);
            this.textCostProduct.TabIndex = 6;
            // 
            // dgvTableProduct
            // 
            this.dgvTableProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableProduct.Location = new System.Drawing.Point(11, 86);
            this.dgvTableProduct.Name = "dgvTableProduct";
            this.dgvTableProduct.Size = new System.Drawing.Size(337, 174);
            this.dgvTableProduct.TabIndex = 7;
            // 
            // frmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(360, 389);
            this.Controls.Add(this.dgvTableProduct);
            this.Controls.Add(this.textCostProduct);
            this.Controls.Add(this.textNomProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddProduct);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmAltaProducto";
            this.Text = "Alta Producto";
            this.Load += new System.EventHandler(this.formAltaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNomProduct;
        private System.Windows.Forms.TextBox textCostProduct;
        private System.Windows.Forms.DataGridView dgvTableProduct;
    }
}