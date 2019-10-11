using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNE;
using CapaDA;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.ProviderBase;
using System.Globalization;
using System.Text.RegularExpressions;




namespace CapaLN
{ 
    public class ItemFacturaLN
    {
        

        ItemFacturaDA ObjetoItemFacturaDA= new ItemFacturaDA();

        public int AgregarItemFactura(ItemFacturaNE ObjetoItemFacturaNE)
        {

            return CapaDA.ItemFacturaDA.AgregarItemFactura(ObjetoItemFacturaNE);
        }

        public List<ItemFacturaNE> MostrarItemFactura(int NumeroFactura) 
        {
            return ObjetoItemFacturaDA.MostrarItemFactura(NumeroFactura);
        }

        public int EliminarItemFactura(int NumeroFactura)
        {
            return ItemFacturaDA.EliminarItemFactura(NumeroFactura);
        }

        public int ModificarItemFactura(ItemFacturaNE ifac)
        {
            return ItemFacturaDA.ModificarItemFactura(ifac);
        }

       
    }
}
