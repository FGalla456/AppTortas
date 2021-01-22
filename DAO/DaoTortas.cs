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
    public class DaoTortas
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaTortas()
        {
            List<Tortas> lista = new List<Tortas>();
            DataTable tabla = ds.ObtenerTabla("Tortas", "select CodTor as 'Id Torta', Nombre, Costo as 'Costo de Produccion' from Torta where Estado = 1");
            return tabla;
        }

        public void InsertarTorta(Tortas tor)
        {
            string Consulta = "insert into Torta(Nombre,Costo,Estado)" +
                "values('" + tor.getNombre() + "," + tor.getCosto() + "',1)";

            ds.RealizarConsulta(Consulta);
        }

        /*   public void ArmarParametrosTorta(ref SqlCommand Comando, Tortas Tor)
           {
               SqlParameter SqlParametros = new SqlParameter();
               SqlParametros = Comando.Parameters.Add("@CodTor", SqlDbType.Int);
               SqlParametros.Value = Tor.getTorta();
               SqlParametros = Comando.Parameters.Add("@Nom", SqlDbType.VarChar, 50);
               SqlParametros.Value = Tor.getNombre();
               SqlParametros = Comando.Parameters.Add("@Costo", SqlDbType.Money);
               SqlParametros.Value = Tor.getCosto();
               SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
               SqlParametros.Value = Tor.getEstado();
           }

           public void InsertarTortaEnBD(String NombreTabla, Tortas Tor)
           {
               SqlCommand Comando = new SqlCommand();
               ArmarParametrosTorta(ref Comando, Tor);
               AccesoDatos ad = new AccesoDatos();
               ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_Torta");
           }

           public void eliminarTortaSQL(int Torta)
           {
               SqlConnection conex = new SqlConnection();
               conex = ds.ObtenerConexion();
               SqlCommand Comando = new SqlCommand();

               SqlParameter SqlParametros = new SqlParameter();

               SqlParametros = Comando.Parameters.Add("@CodTor", SqlDbType.Int);
               SqlParametros.Value = Torta;

               Comando.Connection = conex;
               Comando.CommandType = CommandType.StoredProcedure;
               Comando.CommandText = "Baja_Torta";
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
