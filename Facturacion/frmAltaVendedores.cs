using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class frmAltaVendedores : Micro_sistema_de_Ventas.Properties.ClsVendedores
    {
        public frmAltaVendedores()
        {
            InitializeComponent();
        }

        private void formAltaVendedores_Load(object sender, EventArgs e)
        {

            if (clsAltaVendedor.vendedores.Count > 0)
            {
                ActualizarListBox();
            }
            txtVendedor.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnAddVendedor_Click(object sender, EventArgs e)
        {
            if (txtVendedor.Text.Length > 0)
            {
                clsAltaVendedor.vendedores.Add(txtVendedor.Text);
                clsAltaVendedor.vendedores.Sort();

                ActualizarListBox();

                txtVendedor.Clear();
                txtVendedor.Focus();
            }
            else
            {
                MessageBox.Show("No se puede cargar un vendedor en blanco.",
                    "DATO INCORRECTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVendedor.Focus();
            }

        }


        private void ActualizarListBox()
        {
            listVendedores.DataSource = null;
            listVendedores.DataSource = clsAltaVendedor.vendedores;
        }

        private void btnRemoveVendedor_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Está seguro de eliminar el vendedor seleccionado?",
                                "ELIMINAR VENDEDOR",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.OK)
            {
                clsAltaVendedor.vendedores.Remove(listVendedores.SelectedValue.ToString());
                ActualizarListBox();
            }
           
        }

        private void txtVendedor_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (e.KeyChar == 13)
            {
                btnAddVendedor.PerformClick();
            }
        }

    }
}
