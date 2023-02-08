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
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void formFacturacion_Load(object sender, EventArgs e)
        {
            textNomProduct.CharacterCasing = CharacterCasing.Upper;

            textIVA.Text = "21";
            textGanancia.Text = "30";

            cbxVendedor.DropDownStyle = ComboBoxStyle.DropDownList;

            ActualizarVendedores();


            cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            ActualizarCliente(); 

        }

        private void ActualizarVendedores()

        {

            cbxVendedor.Items.Clear(); 
            cbxVendedor.Items.AddRange(clsAltaVendedor.vendedores.ToArray());
            cbxVendedor.SelectedIndex = 0;
        }

        private void ActualizarCliente()

        {

            cbxCliente.Items.Clear(); 
            cbxCliente.Items.AddRange(clsAltaCliente.cliente.ToArray());
            cbxCliente.SelectedIndex = 0;
        }


        private void UpdateVendedores()

        {
            frmAltaVendedores AltVend = new frmAltaVendedores();
            AltVend.ShowDialog(); 
            cbxVendedor.Items.Clear();
            cbxVendedor.Items.AddRange(clsAltaVendedor.vendedores.ToArray());
            cbxVendedor.SelectedIndex = 0;
        }

        private void UpdateCliente()

        {
            frmAltaCliente AltVend = new frmAltaCliente();
            AltVend.ShowDialog(); 
            cbxCliente.Items.Clear(); 
            cbxCliente.Items.AddRange(clsAltaCliente.cliente.ToArray()); 
            cbxCliente.SelectedIndex = 0; 
        }

        private void BuscarProducto() {
            for (int i = 0; i < clsProducto.productos.Count; i++)
                  {
                    if (textNomProduct.Text == clsProducto.productos[i].Nombre) {
 
                        lblCosto.Text = Convert.ToString(clsProducto.productos[i].Costo);
  
                        break;

                    }
                    else
                    {

                        lblCosto.Text = "";
                    }
            }
        }

        private void ActualizarVentas()
        {

            dgvDetVenta.DataSource = null; 
            dgvDetVenta.DataSource = clsVenta.venta; 
        }

 
        private void textNomProduct_TextChanged(object sender, EventArgs e)

        {
            if (textNomProduct.Text.Length > 0)
 
              {
                    BuscarProducto();
                  
              }
              else
              {     
                  lblCosto.Text = "";

            }
        }



        private void addVendedor_Click(object sender, EventArgs e)
        {
            UpdateVendedores();
        }

        private void addCliente_Click(object sender, EventArgs e)
        {
            UpdateCliente();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAltaProducto AltVend = new frmAltaProducto();
            AltVend.ShowDialog(); 
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            clsVenta.venta.Add(new clsDetVenta()
            {
                Cantidad = Convert.ToInt32(textCant.Text),
                Nombre_del_Producto = Convert.ToString(textNomProduct.Text),
                Costo_Unitario = Convert.ToDouble(lblCosto.Text),
                Costo_Total = Convert.ToDouble(textCant.Text) * Convert.ToDouble(lblCosto.Text),
                Valor_de_Venta = (Convert.ToDouble(textCant.Text) * Convert.ToDouble(lblCosto.Text)) * (1+(Convert.ToDouble(textGanancia.Text)/100))
            });
            ActualizarVentas();
            textNomProduct.Text = ""; 


            double bTotal = 0;
            for (int i = 0; i < clsVenta.venta.Count; i++)
            {
                bTotal += clsVenta.venta[i].Valor_de_Venta;
            }

            lblSubtotal.Text = Convert.ToString(bTotal);

            if (IVAchek.Checked == true)

            {

                lblIVA.Text = Convert.ToString(bTotal * (Convert.ToDouble(textIVA.Text)/100));
            }
            else
            {   
                lblIVA.Text = "0";
            }

            lblTotal.Text = Convert.ToString(bTotal + Convert.ToDouble(lblIVA.Text));
        }

        public class CkeckboxModel
        {   
            public bool IVAchek { get; set; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            clsListasInformes.DatosVentas.Add(new clsDatosVentas()
            {
                vendedor = cbxVendedor.Text,
                cliente = cbxCliente.Text,
                subTotal = Convert.ToDouble(lblSubtotal.Text),
                iva = Convert.ToDouble(lblIVA.Text),
                total = Convert.ToDouble(lblTotal.Text)
            });

            lblSubtotal.Text = "0";
            lblIVA.Text = "0";
            lblTotal.Text = "0";


            for (int i = 0; i < clsVenta.venta.Count; i++)
            {
                clsListasInformes.DatosProdVentas.Add(new clsDatosProdVentas()
                {
                    Cantidad = clsVenta.venta[i].Cantidad,
                    Nombre_del_Producto = clsVenta.venta[i].Nombre_del_Producto,
                    Costo_Total = clsVenta.venta[i].Costo_Total,
                    Valor_de_Venta = clsVenta.venta[i].Valor_de_Venta
                });

            }

            clsVenta.venta.Clear();
            dgvDetVenta.DataSource = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaProducto frm4 = new frmAltaProducto();
            frm4.Show();
        }
    }
}