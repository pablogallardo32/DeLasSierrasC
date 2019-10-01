using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNE
{
    public class FacturaNE
    {

        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public double TotalImporte { get; set; }
    }
}
