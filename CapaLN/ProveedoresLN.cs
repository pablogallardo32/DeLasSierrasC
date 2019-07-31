
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNE;
using CapaDA;

namespace CapaLN
{
    public class ProveedorLN
    {
        ProveedorDA ObjetoProveedorDA = new ProveedorDA();

        public int AgregarProveedor(ProveedorNE prov)
        {
            return CapaDA.ProveedorDA.AgregarProveedor(prov);
        }

        public List<ProveedorNE> MostrarProveedor()
        {
            return ObjetoProveedorDA.MostrarProveedor();
        }

      

        public int ModificarProveedor(ProveedorNE prov)
        {
            return ProveedorDA.ModificarProveedor(prov); 
        }

        public int EliminarProveedor(ProveedorNE prov)
        {
            return ProveedorDA.EliminarProveedor(prov);
        }
       
    }
}



