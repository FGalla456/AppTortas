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
    public class DaoVentas
    {
        AccesoDatos ds = new AccesoDatos();


        public DataTable getTablaVentas()
        {
            List<Ventas> lista = new List<Ventas>();
            DataTable tabla = ds.ObtenerTabla("Ventas", "select Nro_Venta as 'Numero de Venta', CodPed as 'Id Pedido', Ganancia from Venta where Estado = 1");
            return tabla;
        }

        public void InsertarVenta(Ventas ven)
        {
            string Consulta = "insert into Venta(idPedido,PrecioVenta,Costo,Ganancia,Estado)" +
                "values(" + ven.getIdPed() + "," + ven.getPrecioV() + "," + ven.getCosto() + "," + ven.getGanancia() + ",1)";

            ds.RealizarConsulta(Consulta);
        }


        /*      public void ArmarParametrosVenta(ref SqlCommand Comando, Ventas Ven)
              {
                  SqlParameter SqlParametros = new SqlParameter();
                  SqlParametros = Comando.Parameters.Add("@IdPed", SqlDbType.Int);
                  SqlParametros.Value = Ven.getIdPed();
                  SqlParametros = Comando.Parameters.Add("@PV", SqlDbType.Money);
                  SqlParametros.Value = Ven.getPrecioV();
                  SqlParametros = Comando.Parameters.Add("@Costo", SqlDbType.Money);
                  SqlParametros.Value = Ven.getCosto();
                  SqlParametros = Comando.Parameters.Add("@Gan", SqlDbType.Money);
                  SqlParametros.Value = Ven.getGanancia();
                  SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
                  SqlParametros.Value = Ven.getEstado();
                  SqlParametros = Comando.Parameters.Add("@NVenta", SqlDbType.Int);
                  SqlParametros.Value = Ven.getVenta();
              }

              public void InsertarVentaEnBD(String NombreTabla, Ventas Ven)
              {
                  SqlCommand Comando = new SqlCommand();
                  ArmarParametrosVenta(ref Comando, Ven);
                  AccesoDatos ad = new AccesoDatos();
                  ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_Venta");
              }

              public void eliminarVenSQL(int Pedido)
              {
                  SqlConnection conex = new SqlConnection();
                  conex = ds.ObtenerConexion();
                  SqlCommand Comando = new SqlCommand();

                  SqlParameter SqlParametros = new SqlParameter();

                  SqlParametros = Comando.Parameters.Add("@IdPed", SqlDbType.Int);
                  SqlParametros.Value = Pedido;

                  Comando.Connection = conex;
                  Comando.CommandType = CommandType.StoredProcedure;
                  Comando.CommandText = "Baja_Venta";
                  Comando.ExecuteNonQuery();

              }

              public int incrementarVen()
              {
                  SqlConnection conex = new SqlConnection();
                  conex = ds.ObtenerConexion();
                  SqlCommand Comando = new SqlCommand();
                  Comando.Connection = conex;
                  Comando.CommandText = "SELECT COUNT(*) FROM Ventas";
                  Int32 count = (Int32)Comando.ExecuteScalar();
                  return count + 1;
              }
        */
    }
}
