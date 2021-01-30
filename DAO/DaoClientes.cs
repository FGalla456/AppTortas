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
     public class DaoClientes
     {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaClientes()
        {
            List<Clientes> lista = new List<Clientes>();
            DataTable tabla = ds.ObtenerTabla("Clientes", "select idCliente as 'Id Cliente', Nombre, Apellido, Telefono, Domicilio from Cliente where Estado = 1");
            return tabla;
        }

        public DataTable getTablaClientesFiltrada(string Consulta)
        {
            List<Clientes> lista = new List<Clientes>();
            DataTable tabla = ds.ObtenerTabla("Clientes", Consulta);
            return tabla;
        }

        public void InsertarCliente(Clientes cli) 
        {
            string Consulta = "insert into Cliente(Nombre,Apellido,Telefono,Domicilio,Estado)" +
                "values('" + cli.getNombre() + "','" + cli.getApellido() + "','" + cli.getTelefono() + "','" + cli.getDomicilio() + "',1)";

            ds.RealizarConsulta(Consulta);
        }

        public void EliminarCliente(int id)
        {
            string Consulta = "UPDATE Cliente SET Estado = 0 WHERE idCliente = " + id;
            ds.RealizarConsulta(Consulta);
        }

        /*
        public void ArmarParametrosClientes(ref SqlCommand Comando, Clientes cli)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idCliente", SqlDbType.VarChar, 50);
            SqlParametros.Value = cli.getCliente();
            SqlParametros = Comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
            SqlParametros.Value = cli.getNombre();  
            SqlParametros = Comando.Parameters.Add("@apellido", SqlDbType.VarChar, 50);
            SqlParametros.Value = cli.getApellido();
            SqlParametros = Comando.Parameters.Add("@telefono", SqlDbType.VarChar, 50);
            SqlParametros.Value = cli.getTelefono();
            SqlParametros = Comando.Parameters.Add("@domicilio", SqlDbType.VarChar, 50);
            SqlParametros.Value = cli.getDomicilio();
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
            SqlParametros.Value = cli.getEstado();
        }

        public void InsertarClientesEnBD(String NombreTabla, Clientes cli)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosClientes(ref Comando, cli);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_Cliente");
        }


        public void eliminarcliSQL(int codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdCliente", SqlDbType.Int);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "Baja_Cliente";
            Comando.ExecuteNonQuery();

        }

        public bool validacionClientes(string CUIT)
        {
            validacion val = new validacion();
            return (val.existedato("Clientes", CUIT, "CUIT"));
        }

        public void modificar(Clientes cli)
        {
            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            ArmarParametrosClientes(ref Comando, cli);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "Modificar_Clientes");
        }

        public int incrementarCli()
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conex;
            Comando.CommandText = "SELECT COUNT(*) FROM Cliente";
            Int32 count = (Int32)Comando.ExecuteScalar();
            return count + 1;
        }*/

    }
}
