using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaNE;

namespace CapaLN
{
   public class MarcaLN
    {
       MarcaDA ObjetoMarcaDA = new MarcaDA();

       public int AgregarMarca(MarcaNE mar)
        {
            return CapaDA.MarcaDA.AgregarMarca(mar);
        }

       public List<MarcaNE> MostrarMarca()
        {
            return ObjetoMarcaDA.MostrarMarca();
        }

       public List<MarcaNE> LlenarComboMarca()
        {
            return ObjetoMarcaDA.LlenarComboMarca();
        }

       public int ModificarMarca(MarcaNE mar)
        {
            return MarcaDA.ModificarMarca(mar);
        }

       public int EliminarMarca(MarcaNE mar)
        {
            return MarcaDA.EliminarMarca(mar);
        }
    }
}
