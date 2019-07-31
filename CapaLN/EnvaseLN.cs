using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaNE;

namespace CapaLN
{
   public class EnvaseLN
    {
        EnvaseDA ObjetoEnvaseDA = new EnvaseDA();

        public int AgregarEnvase(EnvaseNE env)
        {
            return CapaDA.EnvaseDA.AgregarEnvase(env);
        }

        public List<EnvaseNE> MostrarEnvase()
        {
            return ObjetoEnvaseDA.MostrarEnvase();
        }

        public List<EnvaseNE> LlenarComboEnvase()
        {
            return ObjetoEnvaseDA.LlenarComboEnvase();
        }

        public int ModificarEnvase(EnvaseNE env)
        {
            return EnvaseDA.ModificarEnvase(env);
        }

        public int EliminarEnvase(EnvaseNE env)
        {
            return EnvaseDA.EliminarEnvase(env);
        }
    }
}