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
    public class DetalleDA
    {

        public static int AgregarDetalle(DetalleNE dNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            try
            {
                SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT IDDetalle FROM Detalle WHERE IDDetalle = @IDDetalle) INSERT INTO Detalle (IDDetalle, NombreDetalle) VALUES (@IDDetalle, @NombreDetalle)", con as SqlConnection);
                Comand.Parameters.Add(new SqlParameter("@IDDetalle", dNE.IDDetalle));
                Comand.Parameters.Add(new SqlParameter("@NombreDetalle", dNE.NombreDetalle));

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


        public List<DetalleNE> MostrarDetalle()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Detalle", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<DetalleNE> Lista = new List<DetalleNE>();
            while (reader.Read())
            {
                DetalleNE ObjetoDetalleNE = new DetalleNE();
                ObjetoDetalleNE.IDDetalle = reader.GetInt32(0);
                ObjetoDetalleNE.NombreDetalle = reader.GetString(1);

                Lista.Add(ObjetoDetalleNE);
            }
            con.Close();
            return Lista;
        }

        public List<DetalleNE> LlenarComboDetalle()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT NombreDetalle From Detalle", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<DetalleNE> Lista = new List<DetalleNE>();
            while (reader.Read())
            {
                DetalleNE ObjetoDetalleNE = new DetalleNE();
                ObjetoDetalleNE.IDDetalle = reader.GetInt32(0);
                ObjetoDetalleNE.NombreDetalle = reader.GetString(1);

                Lista.Add(ObjetoDetalleNE);
            }
            con.Close();
            return Lista;
        }

        public static int ModificarDetalle(DetalleNE dNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("UPDATE Detalle SET NombreDetalle= @NombreDetalle WHERE IDDetalle=@IDDetalle", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreDetalle", dNE.NombreDetalle));
            Comand.Parameters.Add(new SqlParameter("@IDDetalle", dNE.IDDetalle));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }


        public static int EliminarDetalle(DetalleNE dNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("Delete Detalle WHERE IDDetalle=@IDDetalle", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreDetalle", dNE.NombreDetalle));
            Comand.Parameters.Add(new SqlParameter("@IDDetalle", dNE.IDDetalle));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }
    }
}
