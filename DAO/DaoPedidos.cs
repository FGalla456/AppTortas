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
    public class DaoPedidos
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaPedidos()
        {
            List<Pedidos> lista = new List<Pedidos>();
            DataTable tabla = ds.ObtenerTabla("Pedidos", "select CodPed as 'Id Pedido', IdCliente 'Id Cliente', Fecha_Entrega as 'Fecha de Entrega' from Pedido where Estado = 1");
            return tabla;
        }

        public DataTable getTablaPedidosEntregados()
        {
            List<Pedidos> lista = new List<Pedidos>();
            DataTable tabla = ds.ObtenerTabla("Pedidos", "select CodPed as 'Id Pedido', IdCliente 'Id Cliente', Fecha_Entrega as 'Fecha de Entrega' from Pedido");
            return tabla;
        }

        public DataTable getTablaPedVen()
        {
            List<Pedidos> lista = new List<Pedidos>();
            DataTable tabla = ds.ObtenerTabla("Pedidos", "select CodPed as 'Id Pedido', IdCliente 'Id Cliente' from Pedido where Estado = 1");
            return tabla;
        }
        public void InsertarPedidos(Pedidos ped)
        {
            string Consulta = "insert into Pedido(idCliente,Costo,PrecioVenta,FechaEntrega,Estado)" +
                "values(" + ped.getCliente() + "," + ped.getCosto() + "," + ped.getPrecioV() + ",'" + ped.getFecha() + "',1)";

            ds.RealizarConsulta(Consulta);
        }

        public void EliminarPedido(int id)
        {
            string Consulta = "UPDATE Pedido SET Estado = 0 WHERE idPedido = " + id;
            ds.RealizarConsulta(Consulta);
        }

        /*
                public void ArmarParametrosPedido(ref SqlCommand Comando, Pedidos Ped)
                {
                    SqlParameter SqlParametros = new SqlParameter();
                    SqlParametros = Comando.Parameters.Add("@CodPed", SqlDbType.Int);
                    SqlParametros.Value = Ped.getIdPed();
                    SqlParametros = Comando.Parameters.Add("@IdCli", SqlDbType.Int);
                    SqlParametros.Value = Ped.getCliente();
                    SqlParametros = Comando.Parameters.Add("@Costo", SqlDbType.Money);
                    SqlParametros.Value = Ped.getCosto();
                    SqlParametros = Comando.Parameters.Add("@PV", SqlDbType.Money);
                    SqlParametros.Value = Ped.getPrecioV();
                    SqlParametros = Comando.Parameters.Add("@Fecha", SqlDbType.VarChar, 50);
                    SqlParametros.Value = Ped.getFecha();
                    SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
                    SqlParametros.Value = Ped.getEstado();
                }

                public void InsertarPedidoEnBD(String NombreTabla, Pedidos Ped)
                {
                    SqlCommand Comando = new SqlCommand();
                    ArmarParametrosPedido(ref Comando, Ped);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_Pedido");
                }

                public void eliminarPedSQL(int Pedido)
                {
                    SqlConnection conex = new SqlConnection();
                    conex = ds.ObtenerConexion();
                    SqlCommand Comando = new SqlCommand();

                    SqlParameter SqlParametros = new SqlParameter();

                    SqlParametros = Comando.Parameters.Add("@IdPed", SqlDbType.Int);
                    SqlParametros.Value = Pedido;

                    Comando.Connection = conex;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.CommandText = "Eliminar_Pedido";
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
        */

    }
}
