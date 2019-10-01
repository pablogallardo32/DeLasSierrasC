using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNE
{
    public class ItemFacturaNE
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCosto { get; set; }
        public double Monto { get; set; }
        public int NumeroFactura { get; set; }

    }
}
