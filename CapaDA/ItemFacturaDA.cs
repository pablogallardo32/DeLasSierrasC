using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNE;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDA
{
    public class ItemFacturaDA
    {
        public static int AgregarItemFactura(ItemFacturaNE iNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();

            SqlCommand Comand = new SqlCommand("INSERT INTO ItemFactura ( IdProducto, NombreProducto , Cantidad, PrecioCosto, Monto, NumeroFactura) VALUES ( @IdProducto, @NombreProducto , @Cantidad, @PrecioCosto, @Monto, @NumeroFactura)", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@IdProducto", iNE.IdProducto));
            Comand.Parameters.Add(new SqlParameter("@NombreProducto", iNE.NombreProducto));
            Comand.Parameters.Add(new SqlParameter("@Cantidad", iNE.Cantidad));
            Comand.Parameters.Add(new SqlParameter("@PrecioCosto", iNE.PrecioCosto));
            Comand.Parameters.Add(new SqlParameter("@Monto", iNE.Monto));
            Comand.Parameters.Add(new SqlParameter("@NumeroFactura", iNE.NumeroFactura));


            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public List<ItemFacturaNE> MostrarItemFactura(int NumeroFactura)
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * From ItemFactura where NumeroFactura=@NumeroFactura", con as SqlConnection);
            Command.Parameters.Add(new SqlParameter("@NumeroFactura", NumeroFactura));
            IDataReader reader = Command.ExecuteReader();
            List<ItemFacturaNE> Lista = new List<ItemFacturaNE>();
            while (reader.Read())
            {
                ItemFacturaNE ObjetoFacturaItemNE = new ItemFacturaNE();
                ObjetoFacturaItemNE.IdProducto = reader.GetInt32(0);
                ObjetoFacturaItemNE.NombreProducto = reader.GetString(1);
                ObjetoFacturaItemNE.Cantidad = reader.GetInt32(2);
                ObjetoFacturaItemNE.PrecioCosto = reader.GetInt32(3);
                ObjetoFacturaItemNE.Monto = reader.GetInt32(4);
                ObjetoFacturaItemNE.NumeroFactura = reader.GetInt32(5);

                Lista.Add(ObjetoFacturaItemNE);
            }
            con.Close();
            return Lista;
        }


        public static int EliminarItemFactura(int NumeroFactura)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("DELETE from ItemFactura WHERE NumeroFactura=@NumeroFactura", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NumeroFactura", NumeroFactura));
            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }
    }
}
