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
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void formAltaProducto_Load(object sender, EventArgs e)
        {
            if (clsProducto.productos.Count > 0)
            {
                ActualizarTablaProd();
            }

            textNomProduct.CharacterCasing = CharacterCasing.Upper;
  
            ActualizarTablaProd();
            dgvTableProduct.RowHeadersVisible = false;
            dgvTableProduct.DataSource = clsProducto.productos;
            LimpiarControles();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            clsProducto.productos.Add(new clsDetProducto()
            {
                Nombre = textNomProduct.Text,
                Costo = Convert.ToDouble(textCostProduct.Text),
            });
            ActualizarTablaProd();
            textNomProduct.Text = "";
            textCostProduct.Text = "";
        }

        private void ActualizarTablaProd()
        {
            dgvTableProduct.DataSource = null;
            dgvTableProduct.DataSource = clsProducto.productos;
        }

        private void LimpiarControles()
        {
            textNomProduct.Clear();
            textCostProduct.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
