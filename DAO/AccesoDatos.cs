using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAO
{
	class AccesoDatos
	{


        public string LlenarConexion()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "Tortas"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = "root"; //Contraseña de usuario de acceso a MySQL


            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            return cadenaConexion;
        }

        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection cn = new MySqlConnection(LlenarConexion());
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private MySqlDataAdapter ObtenerAdaptador(String consultaSql, MySqlConnection cn)
        {
            MySqlDataAdapter adaptador;
            try
            {
                adaptador = new MySqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            MySqlConnection Conexion = ObtenerConexion();
            MySqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }
        public void RealizarConsulta(String Sql)
        {
            MySqlConnection Conexion = ObtenerConexion();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = Sql;
            command.Connection = Conexion;
            MySqlDataReader consultar = command.ExecuteReader();
            Conexion.Close();
        }
/*
        String rutaBDFinal =
	  "Data Source=localhost\\sqlexpress;Initial Catalog=AppTortas;Integrated Security=True";

		public SqlConnection ObtenerConexion()
		{
			SqlConnection cn = new SqlConnection(rutaBDFinal);
			try
			{
				cn.Open();
				return cn;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
		{
			SqlDataAdapter adaptador;
			try
			{
				adaptador = new SqlDataAdapter(consultaSql, cn);
				return adaptador;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public DataTable ObtenerTabla(String NombreTabla, String Sql)
		{
			DataSet ds = new DataSet();
			SqlConnection Conexion = ObtenerConexion();
			SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
			adp.Fill(ds, NombreTabla);
			Conexion.Close();
			return ds.Tables[NombreTabla];
		}

		public void EjecutarProcedimientoAlmacenado(ref SqlCommand Comando, String NombreSP)
		{

			SqlConnection Conexion = ObtenerConexion();
			//SqlCommand cmd = new SqlCommand();
			//cmd = Comando;
			Comando.Connection = Conexion;
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.CommandText = NombreSP;
			Comando.ExecuteNonQuery();
			Conexion.Close();
			//return FilasCambiadas;
		}*/
	}
}
