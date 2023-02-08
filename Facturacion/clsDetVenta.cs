using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    public class clsDetVenta
    {
        public int Cantidad { get; set; }
        public string Nombre_del_Producto { get; set; }
        public double Costo_Unitario { get; set; }
        public double Costo_Total { get; set; }
        public double Valor_de_Venta { get; set; }
    }
}
