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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnAltaVendedor_Click(object sender, EventArgs e)
        {
            AltaVendedor();
        }
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            AltaCliente();
        }
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            facturacion();
        }

        private void AltaVendedor()

        {
            frmAltaVendedores frm = new frmAltaVendedores();
            frm.Show();
        }

        private void AltaCliente()

        {
            frmAltaCliente frm2 = new frmAltaCliente();
            frm2.Show();
        }

        private void facturacion()
        {
            frmFacturacion frm3 = new frmFacturacion();
            frm3.Show();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto frm4 = new frmAltaProducto();
            frm4.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes frm5 = new frmInformes();
            frm5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}