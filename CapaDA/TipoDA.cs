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
    public class TipoDA
    {
        public static int AgregarTipo(TipoNE tNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            try
            {
                SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT IDTipo FROM Tipo WHERE IDTipo = @IDTipo) INSERT INTO Tipo (IDTipo, NombreTipo) VALUES (@IDTipo, @NombreTipo)", con as SqlConnection);
                Comand.Parameters.Add(new SqlParameter("@IDTipo", tNE.IDTipo));
                Comand.Parameters.Add(new SqlParameter("@NombreTipo", tNE.NombreTipo));

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


        public List<TipoNE> MostrarTipo()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Tipo", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<TipoNE> Lista = new List<TipoNE>();
            while (reader.Read())
            {
                TipoNE ObjetoTipoNE = new TipoNE();
                ObjetoTipoNE.IDTipo = reader.GetInt32(0);
                ObjetoTipoNE.NombreTipo = reader.GetString(1);

                Lista.Add(ObjetoTipoNE);
            }
            con.Close();
            return Lista;
        }

        public List<TipoNE> LlenarComboTipo()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT NombreTipo From Tipo", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<TipoNE> Lista = new List<TipoNE>();
            while (reader.Read())
            {
                TipoNE ObjetoTipoNE = new TipoNE();
                ObjetoTipoNE.IDTipo = reader.GetInt32(0);
                ObjetoTipoNE.NombreTipo = reader.GetString(1);

                Lista.Add(ObjetoTipoNE);
            }
            con.Close();
            return Lista;
        }

        public static int ModificarTipo(TipoNE tNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("UPDATE Tipo SET NombreTipo= @NombreTipo WHERE IDTipo=@IDTipo", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreTipo", tNE.NombreTipo));
            Comand.Parameters.Add(new SqlParameter("@IDTipo", tNE.IDTipo));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public static int EliminarTipo(TipoNE tNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("Delete Tipo WHERE IDTipo=@IDTipo", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreTipo", tNE.NombreTipo));
            Comand.Parameters.Add(new SqlParameter("@IDTipo", tNE.IDTipo));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }
    }
}
