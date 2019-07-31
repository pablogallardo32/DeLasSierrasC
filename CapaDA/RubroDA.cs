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
    public class RubroDA
    {

        public static int AgregarRubro(RubroNE rNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            try{
            SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT IDRubro FROM Rubro WHERE IDRubro = @IDRubro) INSERT INTO Rubro (IDRubro, NombreRubro) VALUES (@IDRubro, @NombreRubro)", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@IDRubro", rNE.IDRubro));
            Comand.Parameters.Add(new SqlParameter("@NombreRubro", rNE.NombreRubro));
                
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


        public List<RubroNE> MostrarRubro()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Rubro", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<RubroNE> Lista = new List<RubroNE>();
            while (reader.Read())
            {
                RubroNE ObjetoRubroNE = new RubroNE();
                ObjetoRubroNE.IDRubro = reader.GetInt32(0);
                ObjetoRubroNE.NombreRubro = reader.GetString(1);
               
                Lista.Add(ObjetoRubroNE);
            }
            con.Close();
            return Lista;
        }

        public List<RubroNE> LlenarComboRubro()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT NombreRubro From Rubro", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<RubroNE> Lista = new List<RubroNE>();
            while (reader.Read())
            {
                RubroNE ObjetoRubroNE = new RubroNE();
                ObjetoRubroNE.IDRubro = reader.GetInt32(0);
                ObjetoRubroNE.NombreRubro = reader.GetString(1);

                Lista.Add(ObjetoRubroNE);
            }
            con.Close();
            return Lista;
        }

        public static int ModificarRubro(RubroNE rNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("UPDATE Rubro SET NombreRubro= @NombreRubro WHERE IDRubro=@IDRubro", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreRubro", rNE.NombreRubro));
            Comand.Parameters.Add(new SqlParameter("@IDRubro", rNE.IDRubro));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public static int EliminarRubro(RubroNE rNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("Delete Rubro WHERE IDRubro=@IDRubro", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreRubro", rNE.NombreRubro));
            Comand.Parameters.Add(new SqlParameter("@IDRubro", rNE.IDRubro));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }
    }
}
