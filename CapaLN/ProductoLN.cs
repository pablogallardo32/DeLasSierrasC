using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaNE;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace CapaLN
{
   public  class ProductoLN
    {
       ProductoDA ObjetoProductoDA = new ProductoDA();
       DBComun ObjetoRubroDA = new DBComun();
       DBComun ObjetoMarcaDA = new DBComun();
       DBComun ObjetoTipoDA = new DBComun();
       DBComun ObjetoDetalleDA = new DBComun();
       DBComun ObjetoSaborDA = new DBComun();
       DBComun ObjetoEnvaseDA = new DBComun();

       public int AgregarProducto(ProductoNE pro)
       {
           return CapaDA.ProductoDA.AgregarProducto(pro);
       }

       public List<ProductoNE> MostrarProducto()
       {
           return ObjetoProductoDA.MostrarProducto();
       }

       public int ModificarProducto(ProductoNE pro)
       {
           return CapaDA.ProductoDA.ModificarProducto(pro);
       }

       public int EliminarProducto(ProductoNE pro)
       {
           return CapaDA.ProductoDA.EliminarProducto(pro);
       }

       public DataTable LlenarComboRubro()
       {
           return ObjetoRubroDA.LlenarComboRubro();
       }

       public DataTable LlenarComboTipo()
       {
           return ObjetoTipoDA.LlenarComboTipo();
       }

       public DataTable LlenarComboMarca()
       {
           return ObjetoMarcaDA.LlenarComboMarca();
       }

       public DataTable LlenarComboDetalle()
       {
           return ObjetoDetalleDA.LlenarComboDetalle();
       }

       public DataTable LlenarComboSabor()
       {
           return ObjetoSaborDA.LlenarComboSabor();
       }

       public DataTable LlenarComboEnvase()
       {
           return ObjetoEnvaseDA.LlenarComboEnvase();
       }

       public List<ProductoNE> TraerUltimoNumeroProducto()
       {
           return ObjetoProductoDA.TraerUltimoNumeroProducto();
       }
    }
}
