using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDA;
using CapaNE;
namespace CapaLN
{
    public class EmpleadoLN
    {
        EmpleadoDA ObjetoEmpleadoDA = new EmpleadoDA();

        public int AgregarEmpleado(EmpleadoNE emp)
        {
            return CapaDA.EmpleadoDA.AgregarEmpleado(emp);
        }

        public List<EmpleadoNE> MostrarEmpleado()
        {
            return ObjetoEmpleadoDA.MostrarEmpleado();
        }

        public int ModificarEmpleado(EmpleadoNE emp)
        {
            return EmpleadoDA.ModificarEmpleado(emp);
        }
        public int EliminarEmpleado(EmpleadoNE emp)
        {
            return EmpleadoDA.EliminarEmpleado(emp);
        }
    }
}
