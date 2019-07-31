using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNE;
using CapaDA;

namespace CapaLN
{
    public class TipoLN
    {
        TipoDA ObjetoTipoDA = new TipoDA();

        public int AgregarTipo(TipoNE tip)
        {
            return CapaDA.TipoDA.AgregarTipo(tip);
        }

        public List<TipoNE> MostrarTipo()
        {
            return ObjetoTipoDA.MostrarTipo();
        }

        public List<TipoNE> LlenarTipo()
        {
            return ObjetoTipoDA.LlenarComboTipo();      
        }

        public int ModificarTipo(TipoNE tip)
        {
            return TipoDA.ModificarTipo(tip);
        }

        public int EliminarTipo(TipoNE tip)
        {
            return TipoDA.EliminarTipo(tip);
        }
    }
}
