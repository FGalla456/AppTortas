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
    public class DaoIngredientes
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaIngredientes()
        {
            List<Ingredientes_x_Torta> lista = new List<Ingredientes_x_Torta>();
            DataTable tabla = ds.ObtenerTabla("Ingrediente", "select Tortas.Nombre as 'Nombre de la Torta', Ingrediente.CodMer as 'Id Producto'," +
                " Mercaderia.Nombre as 'Nombre del Producto', Ingrediente.Cantidad, Unidad, Ingrediente.Costo from Ingrediente" +
                " inner join Mercaderia on Mercaderia.IdMercaderia = Ingrediente.CodMer" +
                " inner join Tortas on Tortas.CodTor = Ingrediente.CodTor" +
                " where Ingrediente.Estado = 1");
            return tabla;
        }
        public void InsertarIngrediente(Ingredientes_x_Torta ing)
        {
            string Consulta = "insert into Cliente(idTorta,idProducto,Cantidad,Costo,Estado)" +
                "values(" + ing.getTorta() + "," + ing.getIdPro() + "," + ing.getCantidad() + "," + ing.getCosto() + ",1)";

            ds.RealizarConsulta(Consulta);
        }

        public void EliminarIngrediente(int idP,int idT)
        {
            string Consulta = "UPDATE Ingrediete SET Estado = 0 WHERE idProducto = " + idP + " AND idTorta = " + idT;
            ds.RealizarConsulta(Consulta);
        }

        /*     public void ArmarParametrosIngrediente(ref SqlCommand Comando, Ingredientes_x_Torta Ing)
             {
                 SqlParameter SqlParametros = new SqlParameter();
                 SqlParametros = Comando.Parameters.Add("@idtor", SqlDbType.Int);
                 SqlParametros.Value = Ing.getTorta();
                 SqlParametros = Comando.Parameters.Add("@idMer", SqlDbType.Int);
                 SqlParametros.Value = Ing.getIdMer();
                 SqlParametros = Comando.Parameters.Add("@Cantidad", SqlDbType.Float);
                 SqlParametros.Value = Ing.getCantidad();
                 SqlParametros = Comando.Parameters.Add("@Costo", SqlDbType.Money);
                 SqlParametros.Value = Ing.getCosto();
                 SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
                 SqlParametros.Value = Ing.getEstado();
             }

             public void InsertarIngredienteEnBD(String NombreTabla, Ingredientes_x_Torta Ing)
             {

                 SqlCommand Comando = new SqlCommand();
                 ArmarParametrosIngrediente(ref Comando, Ing);
                 AccesoDatos ad = new AccesoDatos();
                 ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_Ingrediente");
             }


             public void eliminarITSQL(int CodTor, int IdMer)
             {
                 SqlConnection conex = new SqlConnection();
                 conex = ds.ObtenerConexion();
                 SqlCommand Comando = new SqlCommand();

                 SqlParameter SqlParametros = new SqlParameter();

                 SqlParametros = Comando.Parameters.Add("@CodTor", SqlDbType.Int);
                 SqlParametros.Value = CodTor;

                 SqlParametros = Comando.Parameters.Add("@IdMer", SqlDbType.Int);
                 SqlParametros.Value = IdMer;


                 Comando.Connection = conex;
                 Comando.CommandType = CommandType.StoredProcedure;
                 Comando.CommandText = "Baja_Ingrediente";
                 Comando.ExecuteNonQuery();

             }



             public int incrementarTor()
             {
                 SqlConnection conex = new SqlConnection();
                 conex = ds.ObtenerConexion();
                 SqlCommand Comando = new SqlCommand();
                 Comando.Connection = conex;
                 Comando.CommandText = "SELECT COUNT(*) FROM Tortas";
                 Int32 count = (Int32)Comando.ExecuteScalar();
                 return count + 1;
             }*/



    }
}
