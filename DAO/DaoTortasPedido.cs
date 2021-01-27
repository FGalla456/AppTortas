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

        public DataTable getTablaTortasPedido()
        {
            List<Tortas_x_Pedido> lista = new List<Tortas_x_Pedido>();
            DataTable tabla = ds.ObtenerTabla("TortasPedido", "select TortasPedido.CodTor as 'Id Torta', Nombre, TortasPedido.Precio_Venta as 'Precio de Venta'," +
                " TortasPedido.Cantidad from TortasPedido inner join Tortas on Tortas.CodTor = TortasPedido.CodTor where TortasPedido.Estado = 1");
            return tabla;
        }

        public void InsertarTortasPedido(Tortas_x_Pedido tp)
        {
            string Consulta = "insert into TortasPedido(idTorta,idPedido,PrecioVenta,Cantidad,Costo,Total,Estado)" +
                "values(" + tp.getTorta() + "," + tp.getIdPed() + "," + tp.getPrecioV() + "," + tp.getCantidad() + ","+ tp.getCosto() +"," + tp.getTotal() + ",1)";

            ds.RealizarConsulta(Consulta);
        }
        public void EliminarTortaPedido(int idT, int idP)
        {
            string Consulta = "UPDATE TortasPedido SET Estado = 0 WHERE idTorta = " + idT + " AND idPedido = " + idP;
            ds.RealizarConsulta(Consulta);
        }


        /*    public void ArmarParametrosTortaPedido(ref SqlCommand Comando, Tortas_x_Pedido TP)
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
            }*/


    }
}
