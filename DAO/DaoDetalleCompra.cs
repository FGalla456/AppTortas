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
    public class DaoDetalleCompra
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaDetalleCompra()
        {
            List<Detalle_x_Compra> lista = new List<Detalle_x_Compra>();
            DataTable tabla = ds.ObtenerTabla("DetalleCompra", "select DetalleCompra.Id_Mercaderia as 'Id Producto',Nombre,Cantidad," +
                "DetalleCompra.Precio_x_Unidad as 'Precio Unitario' from DetalleCompra " +
                "inner join Mercaderia on Mercaderia.IdMercaderia = DetalleCompra.Id_Mercaderia where DetalleCompra.Estado = 1");
            return tabla;
        }
        public DataTable getTablaVentasFiltrada(string Consulta)
        {
            List<Detalle_x_Compra> lista = new List<Detalle_x_Compra>();
            DataTable tabla = ds.ObtenerTabla("DetalleCompra", Consulta);
            return tabla;
        }
        public void InsertarDetalleCompra(Detalle_x_Compra dc)
        {
            string Consulta = "insert into DetalleCompra(idCompra,idProducto,Cantidad,PrecioUnitario,Estado)" +
                "values(" + dc.getCompra() + "," + dc.getPrecio() + "," + dc.getCantidad() + "," + dc.getPrecio() + ",1)";

            ds.RealizarConsulta(Consulta);
        }

        public void EliminarDetalleCompra(int idC, int idP)
        {
            string Consulta = "UPDATE DetalleCompra SET Estado = 0 WHERE idCompra = " + idC + " AND idProducto = " + idP;
            ds.RealizarConsulta(Consulta);
        }

        /*
       public void ArmarParametrosDetalleCompras(ref SqlCommand Comando, DataTable fila, int i)
       {
               SqlParameter SqlParametros = new SqlParameter();
               SqlParametros = Comando.Parameters.Add("@NroFact", SqlDbType.NVarChar, 50);
               SqlParametros.Value = fila.Rows[i]["Nº Compra"];
               SqlParametros = Comando.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 50);
               SqlParametros.Value = fila.Rows[i]["Cantidad"];
               SqlParametros = Comando.Parameters.Add("@PU", SqlDbType.Int);
               SqlParametros.Value = fila.Rows[i]["Precio"];
               SqlParametros = Comando.Parameters.Add("@IdMercaderia", SqlDbType.Money);
               SqlParametros.Value = fila.Rows[i]["Id Producto"];
       }

       public void InsertarDetalleComprasEnBD(DataTable lista, int row)
           {

               SqlCommand Comando = new SqlCommand();
               ArmarParametrosDetalleCompras(ref Comando, lista, row);
               AccesoDatos ad = new AccesoDatos();
               ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_DetalleCompra");
           }


       public int AgregarDetCom(string consulta)
       {
               AccesoDatos cn = new AccesoDatos();
               SqlConnection conex = new SqlConnection();
               conex = cn.ObtenerConexion();
               SqlCommand comando = new SqlCommand(consulta, conex);
               int filasAfectadas = comando.ExecuteNonQuery();
               return filasAfectadas;
       }

       public void eliminarcomSQL(int Factura, int IdMer)
       {
               SqlConnection conex = new SqlConnection();
               conex = ds.ObtenerConexion();
               SqlCommand Comando = new SqlCommand();

               SqlParameter SqlParametros = new SqlParameter();

               SqlParametros = Comando.Parameters.Add("@NroCom", SqlDbType.Int);
               SqlParametros.Value = Factura;

               SqlParametros = Comando.Parameters.Add("@IdMer", SqlDbType.Int);
               SqlParametros.Value = IdMer;


               Comando.Connection = conex;
               Comando.CommandType = CommandType.StoredProcedure;
               Comando.CommandText = "Baja_DetalleCompra";
               Comando.ExecuteNonQuery();

       }

        public int incrementarfact()
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conex;
            Comando.CommandText = "SELECT TOP 1 Nro_Compra FROM Compras ORDER BY Nro_Compra DESC";
            Int32 count = Convert.ToInt32(Comando.ExecuteScalar());
            return count + 1;
        }
  */
    }
}
