using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace DAO
{
    public class DaoCompras
    {
		AccesoDatos ds = new AccesoDatos();
		//	DaoDetalleCompra dc = new DaoDetalleCompra();



		public DataTable getTablaCompras()
		{
			List<Compras> lista = new List<Compras>();
			DataTable tabla = ds.ObtenerTabla("Compras", "select Nro_Compra as 'Numero de Compra',Total as 'Total de la Compra',Fecha as 'Fecha de Compra' from Compras where Estado = 1");
			return tabla;
		}

		public DataTable getTablaComprasFiltrada(string Consulta)
		{
			List<Compras> lista = new List<Compras>();
			DataTable tabla = ds.ObtenerTabla("Compras", Consulta);
			return tabla;
		}

		public void InsertarCompra(Compras com)
		{
			string Consulta = "insert into Compras(Total,Fecha,Estado)" +
				"values(" + com.getTotal() + ",'" + com.getFecha() + "',1)";

			ds.RealizarConsulta(Consulta);
		}

		/*		public void ArmarParametrosCompras(ref SqlCommand Comando, Compras Com)
				{
					SqlParameter SqlParametros = new SqlParameter();
					SqlParametros = Comando.Parameters.Add("@NroCompra", SqlDbType.NVarChar, 50);
					SqlParametros.Value = Com.getFactura();
					SqlParametros = Comando.Parameters.Add("@Total", SqlDbType.Money);
					SqlParametros.Value = Com.getTotal();
					SqlParametros = Comando.Parameters.Add("@Fecha", SqlDbType.SmallDateTime);
					SqlParametros.Value = Com.getFecha();
					SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
					SqlParametros.Value = Com.getEstado();
				}

				public void InsertarComprasEnBD(String NombreTabla, Compras com)
				{

					SqlCommand Comando = new SqlCommand();
					ArmarParametrosCompras(ref Comando, com);
					AccesoDatos ad = new AccesoDatos();
					ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_Compra");
				}

				public void eliminarcomSQL(int codigo)
				{
						SqlConnection conex = new SqlConnection();
						conex = ds.ObtenerConexion();
						SqlCommand Comando = new SqlCommand();

						SqlParameter SqlParametros = new SqlParameter();
						SqlParametros = Comando.Parameters.Add("@NroCom", SqlDbType.Int);
						SqlParametros.Value = codigo;

						Comando.Connection = conex;
						Comando.CommandType = CommandType.StoredProcedure;
						Comando.CommandText = "Baja_Compra";
						Comando.ExecuteNonQuery();

				}

				public int incrementarfact()
				{
					SqlConnection conex = new SqlConnection();
					conex = ds.ObtenerConexion();
					SqlCommand Comando = new SqlCommand();
					Comando.Connection = conex;
					Comando.CommandText = "SELECT COUNT(*) FROM Compras";
					Int32 count = (Int32)Comando.ExecuteScalar();
					return count + 1;
				}*/
	}
}
