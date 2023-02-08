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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void formInformes_Load(object sender, EventArgs e)
        {
            dgvResultado.RowHeadersVisible = false;
        }


        private void btnXVendedor_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Total por Vendedor";
   
            clsListasInformes.CalculoInformes.Clear();

            for (int i = 0; i < clsListasInformes.DatosVentas.Count; i++)
            {
                string nombre = clsListasInformes.DatosVentas[i].vendedor;
                double total = clsListasInformes.DatosVentas[i].total;

                acumular(nombre, total);
            }
            dgvResultado.DataSource = null;

            dgvResultado.DataSource = clsListasInformes.CalculoInformes;
        }


        private void btnXCliente_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Total por Cliente";

            clsListasInformes.CalculoInformes.Clear();

            for (int i = 0; i < clsListasInformes.DatosVentas.Count; i++)
            {
                string nombre = clsListasInformes.DatosVentas[i].cliente;
                double total = clsListasInformes.DatosVentas[i].total;

                acumular(nombre, total);
            }
            
            dgvResultado.DataSource = null;
            dgvResultado.DataSource = clsListasInformes.CalculoInformes;
        }

        private void btnXProducto_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Total por Producto";

            clsListasInformes.CalculoInformes.Clear();

            for (int i = 0; i < clsListasInformes.DatosProdVentas.Count; i++)
            {
                string nombre = clsListasInformes.DatosProdVentas[i].Nombre_del_Producto;
                double total = clsListasInformes.DatosProdVentas[i].Valor_de_Venta;
   
                acumular(nombre, total);
            }
            dgvResultado.DataSource = null;

            dgvResultado.DataSource = clsListasInformes.CalculoInformes;
        }


        private static void acumular(string nombre, double total)
        {
 
            bool encontrado = false;

            int lista = clsListasInformes.CalculoInformes.Count;
            for(int i = 0; i < lista; i++)
            {
                if (clsListasInformes.CalculoInformes[i].Nombre.Contains(nombre))
                { 
                    encontrado = true;
                    clsListasInformes.CalculoInformes[i].Total += total;
                }
            }
            if (encontrado == false)
            { 
                clsListasInformes.CalculoInformes.Add(new clsCalculoInformes() { Nombre = nombre, Total = total });
            }
        }


    }
}
