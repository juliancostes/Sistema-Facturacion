using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    internal class clsDatosVentas
    {
        public string vendedor { get; set; }
        public string cliente { get; set; }
        public double subTotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
    }
}
