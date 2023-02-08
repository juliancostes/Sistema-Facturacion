using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void formAltaCliente_Load(object sender, EventArgs e)
        {

            if (clsAltaCliente.cliente.Count > 0)
            {
                ActualizarListBox();
            }
            textCliente.CharacterCasing = CharacterCasing.Upper;
        }


        private void ActualizarListBox() 
        {
            listClientes.DataSource = null;
            listClientes.DataSource = clsAltaCliente.cliente;
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            if (textCliente.Text.Length > 0)
            {
                clsAltaCliente.cliente.Add(textCliente.Text);
                clsAltaCliente.cliente.Sort();

                ActualizarListBox();

                textCliente.Clear();
                textCliente.Focus();
            }
            else
            {
                MessageBox.Show("No se puede cargar un cliente en blanco.",
                    "DATO INCORRECTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textCliente.Focus();
            }
        }

        private void btnRemoveCliente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro de eliminar el cliente seleccionado?",
                               "ELIMINAR CLIENTE",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.OK)
            {
                clsAltaCliente.cliente.Remove(listClientes.SelectedValue.ToString());
                ActualizarListBox();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
