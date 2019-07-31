using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaNE;

namespace CapaLN
{
    public class SaborLN
    {
        SaborDA ObjetoSaborDA = new SaborDA();

        public int AgregarSabor(SaborNE sab)
        {
            return CapaDA.SaborDA.AgregarSabor(sab);
        }

        public List<SaborNE> MostrarSabor()
        {
            return ObjetoSaborDA.MostrarSabor();
        }

        public List<SaborNE> LlenarComboSabor()
        {
            return ObjetoSaborDA.LlenarComboSabor();
        }

        public int ModificarSabor(SaborNE sab)
        {
            return SaborDA.ModificarSabor(sab);
        }

        public int EliminarSabor(SaborNE sab)
        {
            return SaborDA.EliminarSabor(sab);
        }
    }
}
