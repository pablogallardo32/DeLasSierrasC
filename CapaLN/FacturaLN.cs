using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaNE;
using System.Data;

namespace CapaLN
{
    public  class FacturaLN
    {
        FacturaNE ObjetoFacturaNE= new FacturaNE();
        DBComun ObjetoFacturaDB = new DBComun();
        FacturaDA ObjetoFacturaDA = new FacturaDA();

     

        public int AgregarFactura(FacturaNE fac)
        {
            return CapaDA.FacturaDA.AgregarFactura(fac);
        }

        public List<FacturaNE> MostrarFactura()
        {
            return ObjetoFacturaDA.MostrarFactura();
        }

        public DataTable LlenarComboProveedor()
        {
            return ObjetoFacturaDB.LlenarComboProveedor();
        }

        public DataTable LlenarComboIDProducto()
        {
            return ObjetoFacturaDB.LlenarComboIDProducto();
        }

        public DataTable LlenarComboNombreProducto(int IDProducto)
        {
            return ObjetoFacturaDA.LlenarComboNombreProducto(IDProducto);
        }

        public DataTable LlenarComboBoxPrecioCosto(int IDProducto)
        {
            return ObjetoFacturaDA.LlenarComboBoxPrecioCosto(IDProducto);
        }

        public DataTable LlenarComboNumeroProveedor()
        {
            return ObjetoFacturaDB.LlenarComboNumeroProveedor();
        }

        public DataTable LlenarComboNombreProveedor(int NumeroProveedor)
        {
            return ObjetoFacturaDA.LlenarComboNombreProveedor(NumeroProveedor);
        }

        public int EliminarFactura(FacturaNE fac)
        {
            return FacturaDA.EliminarFactura(fac);
        }

        public int ModificarFactura(FacturaNE fac)
        {
            return FacturaDA.ModificarFactura(fac);
        }

        public List<FacturaNE> TraerUltimoNumeroFactura()
        {
            return ObjetoFacturaDA.TraerUltimoNumeroFactura();
        }
    }
}
