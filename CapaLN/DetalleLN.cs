using CapaDA;
using CapaNE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLN
{
    public class DetalleLN
    {
        DetalleDA ObjetoDetalleDA = new DetalleDA();

        public int AgregarDetalle(DetalleNE det)
        {
            return CapaDA.DetalleDA.AgregarDetalle(det);
        }

        public List<DetalleNE> MostrarDetalle()
        {
            return ObjetoDetalleDA.MostrarDetalle();
        }

        public List<DetalleNE> LlenarComboDetalle()
        {
            return ObjetoDetalleDA.LlenarComboDetalle();
        }

        public int ModificarDetalle(DetalleNE det)
        {
            return DetalleDA.ModificarDetalle(det);
        }

        public int EliminarDetalle(DetalleNE det)
        {
            return DetalleDA.EliminarDetalle(det);
        }

        public List<DetalleNE> TraerUltimoIDDetalle()
        {
            return ObjetoDetalleDA.TraerUltimoIDDetalle();
        }
    }
}
