using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using System.Data;
using CapaNE;

namespace CapaDA
{
    public class ProveedorDA
    {

        public static int AgregarProveedor(ProveedorNE pNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT NumeroProveedor FROM Proveedor WHERE NumeroProveedor = @NumeroProveedor) INSERT INTO Proveedor (NombreEmpresa, NumeroProveedor, Rubro, TelefonoVendedor, TelefonoRepartidor) VALUES (@NombreEmpresa, @NumeroProveedor, @Rubro, @TelVendedor, @TelRepartidor)", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NumeroProveedor", pNE.NumeroProveedor));
            Comand.Parameters.Add(new SqlParameter("@Rubro", pNE.Rubro));
            Comand.Parameters.Add(new SqlParameter("@TelVendedor", pNE.TelefonoVendedor));
            Comand.Parameters.Add(new SqlParameter("@TelRepartidor", pNE.TelefonoRepartidor));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public static int ModificarProveedor(ProveedorNE pNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("UPDATE Proveedor SET NombreEmpresa= @NombreEmpresa, NumeroProveedor=@NumeroProveedor,Rubro=@Rubro, TelefonoVendedor= @TelefonoVendedor, TelefonoRepartidor=@TelefonoRepartidor WHERE NumeroProveedor=@NumeroProveedor", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreEmpresa", pNE.NombreEmpresa));
            Comand.Parameters.Add(new SqlParameter("@NumeroProveedor", pNE.NumeroProveedor));
            Comand.Parameters.Add(new SqlParameter("@Rubro", pNE.Rubro));
            Comand.Parameters.Add(new SqlParameter("@TelefonoVendedor", pNE.TelefonoVendedor));
            Comand.Parameters.Add(new SqlParameter("@TelefonoRepartidor", pNE.TelefonoRepartidor));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }


        public static int EliminarProveedor(ProveedorNE pNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("DELETE FROM Proveedor  WHERE NumeroProveedor=@NumeroProveedor", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NumeroProveedor", pNE.NumeroProveedor));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }


        public List<ProveedorNE> MostrarProveedor()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Proveedor", con as SqlConnection);
            // _Command.CommandType = CommandType.StoredProcedure;
            IDataReader reader = _Command.ExecuteReader();
            List<ProveedorNE> Lista = new List<ProveedorNE>();
            while (reader.Read())
            {
                ProveedorNE ObjetoProveedorNE = new ProveedorNE();
                ObjetoProveedorNE.NombreEmpresa = reader.GetString(0);
                ObjetoProveedorNE.NumeroProveedor = reader.GetString(1);
                ObjetoProveedorNE.Rubro = reader.GetString(2);
                ObjetoProveedorNE.TelefonoVendedor = reader.GetInt32(3);
                ObjetoProveedorNE.TelefonoRepartidor = reader.GetInt32(4);
                Lista.Add(ObjetoProveedorNE);
            }
            con.Close();
            return Lista;
        }


    }
}