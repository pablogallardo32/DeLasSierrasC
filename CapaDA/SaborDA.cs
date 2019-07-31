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
   public class SaborDA
    {
       public static int AgregarSabor(SaborNE sNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            try
            {
                SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT IDSabor FROM Sabor WHERE IDSabor = @IDSabor) INSERT INTO Sabor (IDSabor, NombreSabor) VALUES (@IDSabor, @NombreSabor)", con as SqlConnection);
                Comand.Parameters.Add(new SqlParameter("@IDSabor", sNE.IDSabor));
                Comand.Parameters.Add(new SqlParameter("@NombreSabor", sNE.NombreSabor));

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


       public List<SaborNE> MostrarSabor()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Sabor", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<SaborNE> Lista = new List<SaborNE>();
            while (reader.Read())
            {
                SaborNE ObjetoSaborNE = new SaborNE();
                ObjetoSaborNE.IDSabor = reader.GetInt32(0);
                ObjetoSaborNE.NombreSabor = reader.GetString(1);

                Lista.Add(ObjetoSaborNE);
            }
            con.Close();
            return Lista;
        }

       public List<SaborNE> LlenarComboSabor()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT NombreSabor From Sabor", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<SaborNE> Lista = new List<SaborNE>();
            while (reader.Read())
            {
                SaborNE ObjetoSaborNE = new SaborNE();
                ObjetoSaborNE.IDSabor = reader.GetInt32(0);
                ObjetoSaborNE.NombreSabor = reader.GetString(1);

                Lista.Add(ObjetoSaborNE);
            }
            con.Close();
            return Lista;
        }

       public static int ModificarSabor(SaborNE sNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("UPDATE Sabor SET NombreSabor= @NombreSabor WHERE IDSabor=@IDSabor", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreSabor", sNE.NombreSabor));
            Comand.Parameters.Add(new SqlParameter("@IDSabor", sNE.IDSabor));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }

       public static int EliminarSabor(SaborNE sNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("Delete Sabor WHERE IDSabor=@IDSabor", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@NombreSabor", sNE.NombreSabor));
            Comand.Parameters.Add(new SqlParameter("@IDSabor", sNE.IDSabor));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }
    }
}
