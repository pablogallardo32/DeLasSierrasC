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
    public class EmpleadoDA
    {
        public static int AgregarEmpleado(EmpleadoNE eNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
       
            SqlCommand Comand = new SqlCommand("IF NOT EXISTS (SELECT DNI FROM Empleado WHERE DNI = @DNI)INSERT INTO Empleado ( Nombre, Apellido , DNI, FechaNacimiento, TelefonoCelular, TelefonoFijo, Mail, FechaIngreso, Seccion, Calle, Numero, Piso, Depto, Barrio, Localidad, Provincia, CodigoPostal) VALUES ( @Nombre, @Apellido , @DNI, @FechaNacimiento, @TelefonoCelular, @TelefonoFijo, @Mail, @FechaIngreso, @Seccion, @Calle, @Numero, @Piso, @Depto, @Barrio, @Localidad, @Provincia, @CodigoPostal)", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@Nombre", eNE.Nombre));
            Comand.Parameters.Add(new SqlParameter("@Apellido", eNE.Apellido));
            Comand.Parameters.Add(new SqlParameter("@Dni", eNE.DNI));
            Comand.Parameters.Add(new SqlParameter("@FechaNacimiento", eNE.FechaNacimiento));
            Comand.Parameters.Add(new SqlParameter("@TelefonoCelular", eNE.TelefonoCelular));
            Comand.Parameters.Add(new SqlParameter("@TelefonoFijo", eNE.TelefonoFijo));
            Comand.Parameters.Add(new SqlParameter("@Mail", eNE.Mail));
            Comand.Parameters.Add(new SqlParameter("@FechaIngreso", eNE.FechaIngreso));
            Comand.Parameters.Add(new SqlParameter("@Seccion", eNE.Seccion));
            Comand.Parameters.Add(new SqlParameter("@Calle", eNE.Calle));
            Comand.Parameters.Add(new SqlParameter("@Numero", eNE.Numero));
            Comand.Parameters.Add(new SqlParameter("@Piso", eNE.Piso));
            Comand.Parameters.Add(new SqlParameter("@Depto", eNE.Depto));
            Comand.Parameters.Add(new SqlParameter("@Barrio", eNE.Barrio));
            Comand.Parameters.Add(new SqlParameter("@Localidad", eNE.Localidad));
            Comand.Parameters.Add(new SqlParameter("@Provincia", eNE.Provincia));
            Comand.Parameters.Add(new SqlParameter("@CodigoPostal", eNE.CodigoPostal));

            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }


        public static int EliminarEmpleado(EmpleadoNE eNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand("DELETE from Empleado WHERE DNI=@DNI", con as SqlConnection);
            Comand.Parameters.Add(new SqlParameter("@DNI", eNE.DNI));
        //  //  Comand.Parameters.Add(new SqlParameter("@DNI", eNE.DNI));
        //    Comand.Parameters.Add(new SqlParameter("@Nombre", eNE.Nombre));
        //    Comand.Parameters.Add(new SqlParameter("@Apellido", eNE.Apellido));
        ////    Comand.Parameters.Add(new SqlParameter("@Dni", eNE.DNI));
        //    Comand.Parameters.Add(new SqlParameter("@FechaNacimiento", eNE.FechaNacimiento));
        //    Comand.Parameters.Add(new SqlParameter("@TelefonoCelular", eNE.TelefonoCelular));
        //    Comand.Parameters.Add(new SqlParameter("@TelefonoFijo", eNE.TelefonoFijo));
        //    Comand.Parameters.Add(new SqlParameter("@Mail", eNE.Mail));
        //    Comand.Parameters.Add(new SqlParameter("@FechaIngreso", eNE.FechaIngreso));
        //    Comand.Parameters.Add(new SqlParameter("@Seccion", eNE.Seccion));
        //    Comand.Parameters.Add(new SqlParameter("@Calle", eNE.Calle));
        //    Comand.Parameters.Add(new SqlParameter("@Numero", eNE.Numero));
        //    Comand.Parameters.Add(new SqlParameter("@Piso", eNE.Piso));
        //    Comand.Parameters.Add(new SqlParameter("@Depto", eNE.Depto));
        //    Comand.Parameters.Add(new SqlParameter("@Barrio", eNE.Barrio));
        //    Comand.Parameters.Add(new SqlParameter("@Localidad", eNE.Localidad));
        //    Comand.Parameters.Add(new SqlParameter("@Provincia", eNE.Provincia));
        //    Comand.Parameters.Add(new SqlParameter("@CodigoPostal", eNE.CodigoPostal));
            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }


        public List<EmpleadoNE> MostrarEmpleado()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlCommand _Command = new SqlCommand("SELECT * From Empleado", con as SqlConnection);
            IDataReader reader = _Command.ExecuteReader();
            List<EmpleadoNE> Lista = new List<EmpleadoNE>();
            while (reader.Read())
            {
                EmpleadoNE ObjetoEmpleadoNE = new EmpleadoNE();
                ObjetoEmpleadoNE.Nombre = reader.GetString(0);
                ObjetoEmpleadoNE.Apellido = reader.GetString(1);
                ObjetoEmpleadoNE.DNI = reader.GetInt32(2);
                ObjetoEmpleadoNE.FechaNacimiento =reader.GetDateTime(3);
                ObjetoEmpleadoNE.TelefonoCelular = reader.GetInt32(4);
                ObjetoEmpleadoNE.TelefonoFijo = reader.GetInt32(5);
                ObjetoEmpleadoNE.Mail = reader.GetString(6);
                ObjetoEmpleadoNE.FechaIngreso = reader.GetDateTime(7);
                ObjetoEmpleadoNE.Seccion = reader.GetString(8);
                ObjetoEmpleadoNE.Calle = reader.GetString(9);
                ObjetoEmpleadoNE.Numero = reader.GetInt32(10);
                ObjetoEmpleadoNE.Piso = reader.GetInt32(11);
                ObjetoEmpleadoNE.Depto = reader.GetString(12);
                ObjetoEmpleadoNE.Barrio = reader.GetString(13);
                ObjetoEmpleadoNE.Localidad = reader.GetString(14);
                ObjetoEmpleadoNE.Provincia = reader.GetString(15);
                ObjetoEmpleadoNE.CodigoPostal = reader.GetInt32(16);

                Lista.Add(ObjetoEmpleadoNE);
            }
            con.Close();
            return Lista;
        }

        public static int ModificarEmpleado(EmpleadoNE eNE)
        {
            IDbConnection con = CapaDA.DBComun.Conexion();
            con.Open();
            SqlCommand Comand = new SqlCommand(" UPDATE Empleado SET Nombre=@Nombre , Apellido=@Apellido , FechaNacimiento=@FechaNacimiento, TelefonoCelular=@TelefonoCelular, TelefonoFijo=@TelefonoFijo, Mail=@Mail , FechaIngreso=@FechaIngreso, Seccion=@Seccion , Calle=@Calle , Numero=@Numero, Piso=@Piso , Depto=@Depto , Barrio=@Barrio,  Localidad=@Localidad , Provincia=@Provincia , CodigoPostal=@CodigoPostal WHERE DNI=@DNI", con as SqlConnection);
           
            Comand.Parameters.Add(new SqlParameter("@Nombre", eNE.Nombre));
            Comand.Parameters.Add(new SqlParameter("@Apellido", eNE.Apellido));
            Comand.Parameters.Add(new SqlParameter("@DNI", eNE.DNI));
            Comand.Parameters.Add(new SqlParameter("@FechaNacimiento", eNE.FechaNacimiento));
            Comand.Parameters.Add(new SqlParameter("@TelefonoCelular", eNE.TelefonoCelular));
            Comand.Parameters.Add(new SqlParameter("@TelefonoFijo", eNE.TelefonoFijo));
            Comand.Parameters.Add(new SqlParameter("@Mail", eNE.Mail));
            Comand.Parameters.Add(new SqlParameter("@FechaIngreso", eNE.FechaIngreso));
            Comand.Parameters.Add(new SqlParameter("@Seccion", eNE.Seccion));
            Comand.Parameters.Add(new SqlParameter("@Calle", eNE.Calle));
            Comand.Parameters.Add(new SqlParameter("@Numero", eNE.Numero));
            Comand.Parameters.Add(new SqlParameter("@Piso", eNE.Piso));
            Comand.Parameters.Add(new SqlParameter("@Depto", eNE.Depto));
            Comand.Parameters.Add(new SqlParameter("@Barrio", eNE.Barrio));
            Comand.Parameters.Add(new SqlParameter("@Localidad", eNE.Localidad));
            Comand.Parameters.Add(new SqlParameter("@Provincia", eNE.Provincia));
            Comand.Parameters.Add(new SqlParameter("@CodigoPostal", eNE.CodigoPostal));


            int Resultado = Comand.ExecuteNonQuery();
            con.Close();
            return Resultado;
        }
    }
}
