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
        public class MarcaDA
        {

            public static int AgregarMarca(MarcaNE mNE)
            {
                IDbConnection con = CapaDA.DBComun.Conexion();
                con.Open();
                try
                {
                    SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT IDMarca FROM Marca WHERE IDMarca = @IDMarca) INSERT INTO Marca (IDMarca, NombreMarca) VALUES (@IDMarca, @NombreMarca) ", con as SqlConnection);
                    Comand.Parameters.Add(new SqlParameter("@IDMarca", mNE.IDMarca));
                    Comand.Parameters.Add(new SqlParameter("@NombreMarca", mNE.NombreMarca));

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


            public List<MarcaNE> MostrarMarca()
            {
                IDbConnection con = DBComun.Conexion();
                con.Open();
                SqlCommand _Command = new SqlCommand("SELECT * From Marca", con as SqlConnection);
                IDataReader reader = _Command.ExecuteReader();
                List<MarcaNE> Lista = new List<MarcaNE>();
                while (reader.Read())
                {
                    MarcaNE ObjetoMarcaNE = new MarcaNE();
                    ObjetoMarcaNE.IDMarca = reader.GetInt32(0);
                    ObjetoMarcaNE.NombreMarca = reader.GetString(1);

                    Lista.Add(ObjetoMarcaNE);
                }
                con.Close();
                return Lista;
            }

            public List<MarcaNE> LlenarComboMarca()
            {
                IDbConnection con = DBComun.Conexion();
                con.Open();
                SqlCommand _Command = new SqlCommand("SELECT NombreMarca From Marca", con as SqlConnection);
                IDataReader reader = _Command.ExecuteReader();
                List<MarcaNE> Lista = new List<MarcaNE>();
                while (reader.Read())
                {
                    MarcaNE ObjetoMarcaNE = new MarcaNE();
                    ObjetoMarcaNE.IDMarca = reader.GetInt32(0);
                    ObjetoMarcaNE.NombreMarca = reader.GetString(1);

                    Lista.Add(ObjetoMarcaNE);
                }
                con.Close();
                return Lista;
            }

            public static int ModificarMarca(MarcaNE mNE)
            {
                IDbConnection con = CapaDA.DBComun.Conexion();
                con.Open();
                SqlCommand Comand = new SqlCommand("UPDATE Marca SET NombreMarca= @NombreMarca WHERE IDMarca=@IDMarca", con as SqlConnection);
                Comand.Parameters.Add(new SqlParameter("@NombreMarca", mNE.NombreMarca));
                Comand.Parameters.Add(new SqlParameter("@IDMarca", mNE.IDMarca));

                int Resultado = Comand.ExecuteNonQuery();
                con.Close();
                return Resultado;
            }

            public static int EliminarMarca(MarcaNE mNE)
            {
                IDbConnection con = CapaDA.DBComun.Conexion();
                con.Open();
                SqlCommand Comand = new SqlCommand("Delete Marca WHERE IDMarca=@IDMarca", con as SqlConnection);
                Comand.Parameters.Add(new SqlParameter("@NombreMarca", mNE.NombreMarca));
                Comand.Parameters.Add(new SqlParameter("@IDMarca", mNE.IDMarca));

                int Resultado = Comand.ExecuteNonQuery();
                con.Close();
                return Resultado;
            }
        }
    }

