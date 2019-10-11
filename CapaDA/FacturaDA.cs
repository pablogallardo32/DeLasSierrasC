using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNE;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace CapaDA
{
    public class FacturaDA
    {
        public  static int AgregarFactura(FacturaNE fNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();

            SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT NumeroFactura FROM Factura WHERE NumeroFactura = @NumeroFactura)INSERT INTO Factura ( NumeroFactura, Fecha , CuitProveedor, NombreProveedor, TotalImporte) VALUES ( @NumeroFactura, @Fecha , @CuitProveedor, @NombreProveedor, @TotalImporte)", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NumeroFactura", fNE.NumeroFactura));
            Comand.Parameters.Add(new SqlParameter("@Fecha", fNE.Fecha));
            Comand.Parameters.Add(new SqlParameter("@CuitProveedor", fNE.NumeroProveedor));
            Comand.Parameters.Add(new SqlParameter("@NombreProveedor", fNE.NombreProveedor));
            Comand.Parameters.Add(new SqlParameter("@TotalImporte", fNE.TotalImporte));


            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public static int EliminarFactura(FacturaNE fNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("DELETE from Factura WHERE NumeroFactura=@NumeroFactura", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NumeroFactura", fNE.NumeroFactura));
            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }



        public List<FacturaNE> MostrarFactura()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Factura", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<FacturaNE> Lista = new List<FacturaNE>();
            while (reader.Read())
            {
                FacturaNE ObjetoFacturaNE = new FacturaNE();
                ObjetoFacturaNE.NumeroFactura =reader.GetInt32(0);
                ObjetoFacturaNE.Fecha = reader.GetDateTime(1);
                ObjetoFacturaNE.NumeroProveedor = reader.GetInt32(2);
                ObjetoFacturaNE.NombreProveedor = reader.GetString(3);
                ObjetoFacturaNE.TotalImporte = reader.GetDouble(4);

                Lista.Add(ObjetoFacturaNE);
            }
            con.Close();
            return Lista;
        }

        public DataTable LlenarComboNombreProducto(int IDProducto)
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT IDProducto, (Tipo + ' ' +  Marca + ' ' + Detalle + ' ' + Sabor + ' ' + Envase + ' ' + Tamaño + ' ' + Medicion) As DetalleProducto From Producto Where IDProducto=@IDProducto", con as SqlConnection);
            Command.Parameters.Add(new SqlParameter("@IDProducto", IDProducto));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            return dt;
        }

        public DataTable LlenarComboBoxPrecioCosto(int IDProducto)
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT IDProducto, PrecioCosto From Producto Where IDProducto=@IDProducto", con as SqlConnection);
            Command.Parameters.Add(new SqlParameter("@IDProducto", IDProducto));

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            return dt;
        }

        public DataTable LlenarComboNombreProveedor(int NumeroProveedor)
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * From Proveedor Where NumeroProveedor=@NumeroProveedor", con as SqlConnection);
            Command.Parameters.Add(new SqlParameter("@NumeroProveedor", NumeroProveedor));
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(dt);
            return dt;
        }

        public List<FacturaNE> TraerUltimoNumeroFactura()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT( max(NumeroFactura)+1) from Factura", con as SqlConnection);
            // _Command.CommandType = CommandType.StoredProcedure;
            IDataReader reader = _Command.ExecuteReader();
            List<FacturaNE> Lista = new List<FacturaNE>();
            while (reader.Read())
            {
                FacturaNE ObjetoFacturaNE = new FacturaNE();

                ObjetoFacturaNE.NumeroFactura = reader.GetInt32(0);

                Lista.Add(ObjetoFacturaNE);
            }
            con.Close();
            return Lista;
        }


        public static int ModificarFactura(FacturaNE eNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();

            SqlCommand Comand = new SqlCommand(" UPDATE Factura SET Fecha=@Fecha , CuitProveedor=@CuitProveedor , NombreProveedor=@NombreProveedor, TotalImporte=@TotalImporte WHERE NumeroFactura = @NumeroFactura", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NumeroFactura", eNE.NumeroFactura));
            Comand.Parameters.Add(new SqlParameter("@Fecha", eNE.Fecha));
            Comand.Parameters.Add(new SqlParameter("@CuitProveedor", eNE.NumeroProveedor));
            Comand.Parameters.Add(new SqlParameter("@NombreProveedor", eNE.NombreProveedor));
            Comand.Parameters.Add(new SqlParameter("@TotalImporte", eNE.TotalImporte));
           

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }
    }
}
