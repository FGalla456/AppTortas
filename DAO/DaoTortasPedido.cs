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
    public class DaoTortasPedido
    {
        AccesoDatos ds = new AccesoDatos();

        public void ArmarParametrosTortaPedido(ref SqlCommand Comando, Tortas_x_Pedido TP)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Codtor", SqlDbType.Int);
            SqlParametros.Value = TP.getTorta();
            SqlParametros = Comando.Parameters.Add("@IdPed", SqlDbType.Int);
            SqlParametros.Value = TP.getIdPed();
            SqlParametros = Comando.Parameters.Add("@PV", SqlDbType.Money);
            SqlParametros.Value = TP.getPrecioV();
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
            SqlParametros.Value = TP.getEstado();
            SqlParametros = Comando.Parameters.Add("@Cantidad", SqlDbType.Int);
            SqlParametros.Value = TP.getCantidad();
            SqlParametros = Comando.Parameters.Add("@Costo", SqlDbType.Money);
            SqlParametros.Value = TP.getCosto();
            SqlParametros = Comando.Parameters.Add("@Total", SqlDbType.Money);
            SqlParametros.Value = TP.getTotal();
        }

        public void InsertarTortaPedidoEnBD(String NombreTabla, Tortas_x_Pedido TP)
        {

            SqlCommand Comando = new SqlCommand();
            ArmarParametrosTortaPedido(ref Comando, TP);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_TortaPedido");
        }

        public void eliminarTPSQL(int Torta, int IdPed)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@CodTor", SqlDbType.Int);
            SqlParametros.Value = Torta;

            SqlParametros = Comando.Parameters.Add("@IdPed", SqlDbType.Int);
            SqlParametros.Value = IdPed;


            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "Baja_TortasPedido";
            Comando.ExecuteNonQuery();

        }

        public int incrementarPed()
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conex;
            Comando.CommandText = "SELECT COUNT(*) FROM Pedidos";
            Int32 count = (Int32)Comando.ExecuteScalar();
            return count + 1;
        }

        public DataTable getTablaTortaPedido()
        {
            List<Tortas_x_Pedido> lista = new List<Tortas_x_Pedido>();
            DataTable tabla = ds.ObtenerTabla("TortasPedido", "select Tortas_x_Pedido.CodTor as 'Id Torta', Nombre, Tortas_x_Pedido.Precio_Venta as 'Precio de Venta'," +
                " Tortas_x_Pedido.Cantidad from Tortas_x_Pedido inner join Tortas on Tortas.CodTor = Tortas_x_Pedido.CodTor where Tortas_x_Pedido.Estado = 1");
            return tabla;
        }
    }
}
