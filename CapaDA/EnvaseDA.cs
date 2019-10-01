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
    public class EnvaseDA
    {
        public static int AgregarEnvase(EnvaseNE eNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            try{
                SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT IDEnvase FROM Envase WHERE IDEnvase = @IDEnvase) INSERT INTO Envase (IDEnvase, NombreEnvase) VALUES (@IDEnvase, @NombreEnvase)", con as SqlConnection);
                Comand.Parameters.Add(new SqlParameter("@IDEnvase", eNE.IDEnvase));
                Comand.Parameters.Add(new SqlParameter("@NombreEnvase", eNE.NombreEnvase));
                
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


        public List<EnvaseNE> MostrarEnvase()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Envase", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<EnvaseNE> Lista = new List<EnvaseNE>();
            while (reader.Read())
            {
                EnvaseNE ObjetoEnvaseNE = new EnvaseNE();
                ObjetoEnvaseNE.IDEnvase = reader.GetInt32(0);
                ObjetoEnvaseNE.NombreEnvase = reader.GetString(1);

                Lista.Add(ObjetoEnvaseNE);
            }
            con.Close();
            return Lista;
        }

        public List<EnvaseNE> LlenarComboEnvase()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT NombreEnvase From Envase", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<EnvaseNE> Lista = new List<EnvaseNE>();
            while (reader.Read())
            {
                EnvaseNE ObjetoEnvaseNE = new EnvaseNE();
                ObjetoEnvaseNE.IDEnvase = reader.GetInt32(0);
                ObjetoEnvaseNE.NombreEnvase = reader.GetString(1);

                Lista.Add(ObjetoEnvaseNE);
            }
            con.Close();
            return Lista;
        }

        public static int ModificarEnvase(EnvaseNE eNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("UPDATE Envase SET NombreEnvase= @NombreEnvase WHERE IDEnvase=@IDEnvase", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreEnvase", eNE.NombreEnvase));
            Comand.Parameters.Add(new SqlParameter("@IDEnvase", eNE.IDEnvase));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public static int EliminarEnvase(EnvaseNE eNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("Delete Envase WHERE IDEnvase=@IDEnvase", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreEnvase", eNE.NombreEnvase));
            Comand.Parameters.Add(new SqlParameter("@IDEnvase", eNE.IDEnvase));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

        public List<EnvaseNE> TraerUltimoIDEnvase()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT( max(IDEnvase)+1) from Envase", con as SqlConnection);
            // _Command.CommandType = CommandType.StoredProcedure;
            IDataReader reader = _Command.ExecuteReader();
            List<EnvaseNE> Lista = new List<EnvaseNE>();
            while (reader.Read())
            {
                EnvaseNE ObjetoEnvaseNE = new EnvaseNE();

                ObjetoEnvaseNE.IDEnvase = reader.GetInt32(0);

                Lista.Add(ObjetoEnvaseNE);
            }
            con.Close();
            return Lista;
        }
    }
}
