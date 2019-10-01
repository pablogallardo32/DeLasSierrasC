using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using CapaNE;

namespace CapaDA
{
    public class ProductoDA
    {

        public static int AgregarProducto(ProductoNE pNE)
        {
               IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            try{
                SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT IDProducto FROM Producto WHERE IDProducto = @IDProducto) INSERT INTO Producto (IDProducto, Rubro, Tipo, Marca, Detalle, Sabor, Envase, Medicion, Tamaño, PrecioCosto, PrecioVenta, StockMinimo) VALUES (@IDProducto, @Rubro, @Tipo, @Marca, @Detalle, @Sabor, @Envase, @Medicion, @Tamaño, @PrecioCosto, @PrecioVenta, @StockMinimo)", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@IDProducto", pNE.IDProducto));
            Comand.Parameters.Add(new SqlParameter("@Rubro", pNE.Rubro));
            Comand.Parameters.Add(new SqlParameter("@Tipo", pNE.Tipo));
            Comand.Parameters.Add(new SqlParameter("@Marca", pNE.Marca));
            Comand.Parameters.Add(new SqlParameter("@Detalle", pNE.Detalle));
            Comand.Parameters.Add(new SqlParameter("@Sabor", pNE.Sabor));
            Comand.Parameters.Add(new SqlParameter("@Envase", pNE.Envase));
            Comand.Parameters.Add(new SqlParameter("@Medicion", pNE.Medicion));
            Comand.Parameters.Add(new SqlParameter("@Tamaño", pNE.Tamaño));
            Comand.Parameters.Add(new SqlParameter("@PrecioCosto", pNE.PrecioCosto));
            Comand.Parameters.Add(new SqlParameter("@PrecioVenta", pNE.PrecioVenta));
            Comand.Parameters.Add(new SqlParameter("@StockMinimo", pNE.StockMinimo));
                
            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
            }
            
            catch (Exception ex)
            { 
           Console.WriteLine("Error" + ex);
           return 1;
            }
        }

        public List<ProductoNE> MostrarProducto()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Producto", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<ProductoNE> Lista = new List<ProductoNE>();
            while (reader.Read())
            {
                ProductoNE ObjetoProductoNE = new ProductoNE();
                ObjetoProductoNE.IDProducto= reader.GetInt32(0);
                ObjetoProductoNE.Rubro = reader.GetString(1);
                ObjetoProductoNE.Tipo = reader.GetString(2);
                ObjetoProductoNE.Marca = reader.GetString(3);
                ObjetoProductoNE.Detalle = reader.GetString(4);
                ObjetoProductoNE.Sabor = reader.GetString(5);
                ObjetoProductoNE.Envase = reader.GetString(6);
                ObjetoProductoNE.Medicion = reader.GetString(7);
                ObjetoProductoNE.Tamaño = reader.GetString(8);
                ObjetoProductoNE.PrecioCosto =Convert.ToDouble(reader.GetDouble(9));
                ObjetoProductoNE.PrecioVenta = Convert.ToDouble(reader.GetDouble(10));
                ObjetoProductoNE.StockMinimo = reader.GetInt32(11);

                Lista.Add(ObjetoProductoNE);
            }
            con.Close();
            return Lista;
        }

        public static int ModificarProducto(ProductoNE pNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("UPDATE Producto SET Rubro= @Rubro, Tipo=@Tipo, Marca=@Marca, Detalle=@Detalle, Sabor=@Sabor, Envase=@Envase, Medicion=@Medicion, Tamaño=@Tamaño, PrecioCosto=@PrecioCosto, PrecioVenta=@PrecioVenta, StockMinimo=@StockMinimo  WHERE IDProducto=@IDProducto", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@IDProducto", pNE.IDProducto));
            Comand.Parameters.Add(new SqlParameter("@Rubro", pNE.Rubro));
            Comand.Parameters.Add(new SqlParameter("@Tipo", pNE.Tipo));
            Comand.Parameters.Add(new SqlParameter("@Marca", pNE.Marca));
            Comand.Parameters.Add(new SqlParameter("@Detalle", pNE.Detalle));
            Comand.Parameters.Add(new SqlParameter("@Sabor", pNE.Sabor));
            Comand.Parameters.Add(new SqlParameter("@Envase", pNE.Envase));
            Comand.Parameters.Add(new SqlParameter("@Medicion", pNE.Medicion));
            Comand.Parameters.Add(new SqlParameter("@Tamaño", pNE.Tamaño));
            Comand.Parameters.Add(new SqlParameter("@PrecioCosto", pNE.PrecioCosto));
            Comand.Parameters.Add(new SqlParameter("@PrecioVenta", pNE.PrecioVenta));
            Comand.Parameters.Add(new SqlParameter("@StockMinimo", pNE.StockMinimo));
                

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public static int EliminarProducto(ProductoNE pNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("Delete Producto WHERE IDProducto=@IDProducto", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@IDProducto", pNE.IDProducto));
            Comand.Parameters.Add(new SqlParameter("@Rubro", pNE.Rubro));
            Comand.Parameters.Add(new SqlParameter("@Tipo", pNE.Tipo));
            Comand.Parameters.Add(new SqlParameter("@Marca", pNE.Marca));
            Comand.Parameters.Add(new SqlParameter("@Detalle", pNE.Detalle));
            Comand.Parameters.Add(new SqlParameter("@Sabor", pNE.Sabor));
            Comand.Parameters.Add(new SqlParameter("@Envase", pNE.Envase));
            Comand.Parameters.Add(new SqlParameter("@Medicion", pNE.Medicion));
            Comand.Parameters.Add(new SqlParameter("@Tamaño", pNE.Tamaño));
            Comand.Parameters.Add(new SqlParameter("@PrecioCosto", pNE.PrecioCosto));
            Comand.Parameters.Add(new SqlParameter("@PrecioVenta", pNE.PrecioVenta));
            Comand.Parameters.Add(new SqlParameter("@StockMinimo", pNE.StockMinimo));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }


        
    }
}
