using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNE
{
    public class ProductoNE
    {
        public int IDProducto {get;set;}
        public string Rubro {get;set;}
        public string Tipo {get;set;}
        public string Marca {get;set;}
        public string Detalle {get;set;}
        public string Sabor {get;set;}
        public string Envase {get;set;}
        public string Medicion {get;set;}
        public string Tamaño {get;set;}
        public double PrecioCosto {get;set;}
        public double PrecioVenta {get;set;}
        public int StockMinimo {get;set;}
    }
}
