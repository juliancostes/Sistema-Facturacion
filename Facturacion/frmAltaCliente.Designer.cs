namespace Facturacion
{
    partial class frmAltaCliente
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
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnRemoveCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(89, 213);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(91, 44);
            this.btnAddCliente.TabIndex = 0;
            this.btnAddCliente.Text = "Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnRemoveCliente
            // 
            this.btnRemoveCliente.Location = new System.Drawing.Point(212, 211);
            this.btnRemoveCliente.Name = "btnRemoveCliente";
            this.btnRemoveCliente.Size = new System.Drawing.Size(82, 46);
            this.btnRemoveCliente.TabIndex = 1;
            this.btnRemoveCliente.Text = "Eliminar";
            this.btnRemoveCliente.UseVisualStyleBackColor = true;
            this.btnRemoveCliente.Click += new System.EventHandler(this.btnRemoveCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razon Social del Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(29, 79);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(366, 108);
            this.listClientes.TabIndex = 4;
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(156, 28);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(198, 20);
            this.textCliente.TabIndex = 5;
            // 
            // frmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(505, 318);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Name = "frmAltaCliente";
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.formAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnRemoveCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.TextBox textCliente;
    }
}