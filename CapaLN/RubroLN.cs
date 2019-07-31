using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaNE;
namespace CapaLN
{
    public class RubroLN
    {
        RubroDA ObjetoRubroDA = new RubroDA();

        public int AgregarRubro(RubroNE rub)
        {
            return CapaDA.RubroDA.AgregarRubro(rub);
        }

        public List<RubroNE> MostrarRubro()
        {
            return ObjetoRubroDA.MostrarRubro();
        }

        public List<RubroNE> LlenarComboRubro()
        {
            return ObjetoRubroDA.LlenarComboRubro();
        }

        public int ModificarRubro(RubroNE rub)
        {
            return RubroDA.ModificarRubro(rub);
        }

        public int EliminarRubro(RubroNE rub)
        {
            return RubroDA.EliminarRubro(rub);
        }
    }
}
