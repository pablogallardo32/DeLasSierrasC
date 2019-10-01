using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using CapaNE;

namespace CapaDA
{
    public class DBComun
    {
        private static string Conn = @"Data Source=PABLO\SQLEXPRESS;Initial Catalog=DeLasSierrasC;Integrated Security=True";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }

        public static IDbCommand ObtenerComando(string pComando, IDbConnection pCnn)
        {
            return new SqlCommand(pComando, pCnn as SqlConnection);
        }


            public DataTable LlenarComboRubro()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlDataAdapter Command = new SqlDataAdapter("SELECT NombreRubro From Rubro", con as SqlConnection);

            DataTable dt = new DataTable();
            Command.Fill(dt);
            return dt;
        }
            public DataTable LlenarComboTipo()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlDataAdapter Command = new SqlDataAdapter("SELECT NombreTipo From Tipo", con as SqlConnection);

                DataTable dt = new DataTable();
                Command.Fill(dt);
                return dt;
        }

            public DataTable LlenarComboMarca()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlDataAdapter Command = new SqlDataAdapter("SELECT NombreMarca From Marca", con as SqlConnection);

            DataTable dt = new DataTable();
            Command.Fill(dt);
            return dt;
        }

            public DataTable LlenarComboDetalle()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlDataAdapter Command = new SqlDataAdapter("SELECT NombreDetalle From Detalle", con as SqlConnection);

            DataTable dt = new DataTable();
            Command.Fill(dt);
            return dt;
        }

            public DataTable LlenarComboSabor()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlDataAdapter Command = new SqlDataAdapter("SELECT NombreSabor From Sabor", con as SqlConnection);

            DataTable dt = new DataTable();
            Command.Fill(dt);
            return dt;
        }

            public DataTable LlenarComboEnvase()
        {
            IDbConnection con = DBComun.Conexion();
            con.Open();
            SqlDataAdapter Command = new SqlDataAdapter("SELECT NombreEnvase From Envase", con as SqlConnection);

            DataTable dt = new DataTable();
            Command.Fill(dt);
            return dt;
        }

            public DataTable LlenarComboProveedor()
            {
                IDbConnection con = DBComun.Conexion();
                con.Open();
                SqlDataAdapter Command = new SqlDataAdapter("SELECT NombreEmpresa From Proveedor", con as SqlConnection);

                DataTable dt = new DataTable();
                Command.Fill(dt);
                return dt;
            }


            public DataTable LlenarComboIDProducto()
            {
                IDbConnection con = DBComun.Conexion();
                con.Open();
                SqlDataAdapter Command = new SqlDataAdapter("SELECT IDProducto, (Tipo + ' ' +  Marca + ' ' + Detalle + ' ' + Sabor + ' ' + Envase + ' ' + Tamaño + ' ' + Medicion) As DetalleProducto From Producto", con as SqlConnection);

                DataTable dt = new DataTable();
                Command.Fill(dt);
                return dt;
            }

            public DataTable LlenarComboNumeroProveedor()
            {
                IDbConnection con = DBComun.Conexion();
                con.Open();
                SqlDataAdapter Command = new SqlDataAdapter("SELECT * From Proveedor", con as SqlConnection);

                DataTable dt = new DataTable();
                Command.Fill(dt);
                return dt;
            }

        
    }
}
