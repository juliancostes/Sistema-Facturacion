namespace Facturacion
{
    partial class frmFacturacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addVendedor = new System.Windows.Forms.Button();
            this.addCliente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.textIVA = new System.Windows.Forms.TextBox();
            this.textGanancia = new System.Windows.Forms.TextBox();
            this.IVAchek = new System.Windows.Forms.CheckBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDetVenta = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textCant = new System.Windows.Forms.NumericUpDown();
            this.textNomProduct = new System.Windows.Forms.TextBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCant)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ganancia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total";
            // 
            // addVendedor
            // 
            this.addVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVendedor.Location = new System.Drawing.Point(329, 15);
            this.addVendedor.Name = "addVendedor";
            this.addVendedor.Size = new System.Drawing.Size(77, 41);
            this.addVendedor.TabIndex = 11;
            this.addVendedor.Text = "Agregar Vendedor";
            this.addVendedor.UseVisualStyleBackColor = true;
            this.addVendedor.Click += new System.EventHandler(this.addVendedor_Click);
            // 
            // addCliente
            // 
            this.addCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addCliente.Location = new System.Drawing.Point(418, 16);
            this.addCliente.Name = "addCliente";
            this.addCliente.Size = new System.Drawing.Size(80, 40);
            this.addCliente.TabIndex = 12;
            this.addCliente.Text = "Agregar Cliente";
            this.addCliente.UseVisualStyleBackColor = true;
            this.addCliente.Click += new System.EventHandler(this.addCliente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(487, 451);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 62);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Location = new System.Drawing.Point(87, 49);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(226, 21);
            this.cbxVendedor.TabIndex = 14;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(87, 85);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(228, 21);
            this.cbxCliente.TabIndex = 15;
            // 
            // textIVA
            // 
            this.textIVA.Location = new System.Drawing.Point(113, 454);
            this.textIVA.Name = "textIVA";
            this.textIVA.Size = new System.Drawing.Size(64, 20);
            this.textIVA.TabIndex = 18;
            // 
            // textGanancia
            // 
            this.textGanancia.Location = new System.Drawing.Point(113, 484);
            this.textGanancia.Name = "textGanancia";
            this.textGanancia.Size = new System.Drawing.Size(64, 20);
            this.textGanancia.TabIndex = 19;
            // 
            // IVAchek
            // 
            this.IVAchek.AutoSize = true;
            this.IVAchek.Location = new System.Drawing.Point(39, 455);
            this.IVAchek.Name = "IVAchek";
            this.IVAchek.Size = new System.Drawing.Size(43, 17);
            this.IVAchek.TabIndex = 20;
            this.IVAchek.Text = "IVA";
            this.IVAchek.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubtotal.Location = new System.Drawing.Point(402, 448);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(13, 13);
            this.lblSubtotal.TabIndex = 22;
            this.lblSubtotal.Text = "0";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(402, 476);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(13, 13);
            this.lblIVA.TabIndex = 23;
            this.lblIVA.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(402, 503);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "SubTotal";
            // 
            // dgvDetVenta
            // 
            this.dgvDetVenta.AllowUserToDeleteRows = false;
            this.dgvDetVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetVenta.Location = new System.Drawing.Point(33, 205);
            this.dgvDetVenta.Name = "dgvDetVenta";
            this.dgvDetVenta.ReadOnly = true;
            this.dgvDetVenta.Size = new System.Drawing.Size(478, 219);
            this.dgvDetVenta.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // textCant
            // 
            this.textCant.Location = new System.Drawing.Point(87, 123);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(58, 20);
            this.textCant.TabIndex = 27;
            // 
            // textNomProduct
            // 
            this.textNomProduct.Location = new System.Drawing.Point(236, 123);
            this.textNomProduct.Name = "textNomProduct";
            this.textNomProduct.Size = new System.Drawing.Size(194, 20);
            this.textNomProduct.TabIndex = 28;
            this.textNomProduct.TextChanged += new System.EventHandler(this.textNomProduct_TextChanged);
            // 
            // btnAddList
            // 
            this.btnAddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddList.Location = new System.Drawing.Point(70, 166);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(396, 28);
            this.btnAddList.TabIndex = 29;
            this.btnAddList.Text = "Agregar";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "%";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(265, 166);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(0, 13);
            this.lblCosto.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 41);
            this.button1.TabIndex = 36;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(610, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.textNomProduct);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvDetVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.IVAchek);
            this.Controls.Add(this.textGanancia);
            this.Controls.Add(this.textIVA);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.addCliente);
            this.Controls.Add(this.addVendedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmFacturacion";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.formFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addVendedor;
        private System.Windows.Forms.Button addCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox textIVA;
        private System.Windows.Forms.TextBox textGanancia;
        private System.Windows.Forms.CheckBox IVAchek;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDetVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown textCant;
        private System.Windows.Forms.TextBox textNomProduct;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button button1;
    }
}