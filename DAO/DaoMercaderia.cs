﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace DAO
{
    public class DaoMercaderia
    {
        AccesoDatos ds = new AccesoDatos();

        public void ArmarParametrosMercaderia (ref SqlCommand Comando, Mercaderia Mer)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdMer", SqlDbType.Int);
            SqlParametros.Value = Mer.getIdMer();
            SqlParametros = Comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            SqlParametros.Value = Mer.getNombre();
            SqlParametros = Comando.Parameters.Add("@Precio", SqlDbType.Money);
            SqlParametros.Value = Mer.getPrecioT();
            SqlParametros = Comando.Parameters.Add("@Stock", SqlDbType.Float);
            SqlParametros.Value = Mer.getStock();
            SqlParametros = Comando.Parameters.Add("@Unidad", SqlDbType.VarChar, 50);
            SqlParametros.Value = Mer.getUnidad();
            SqlParametros = Comando.Parameters.Add("@PU", SqlDbType.Money);
            SqlParametros.Value = Mer.getPrecioU();
            SqlParametros = Comando.Parameters.Add("@Estado", SqlDbType.Bit);
            SqlParametros.Value = Mer.getEstado();
        }

        public void InsertarMercEnBD(String NombreTabla, Mercaderia Mer)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosMercaderia(ref Comando, Mer);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "Cargar_Mercaderia");
        }


        public void eliminarMerSQL(int IdMer)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@IdMer", SqlDbType.Int);
            SqlParametros.Value = IdMer;


            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "Baja_Mercaderia";
            Comando.ExecuteNonQuery();

        }

        public int incrementarMer()
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conex;
            Comando.CommandText = "SELECT COUNT(*) FROM Mercaderia";
            Int32 count = (Int32)Comando.ExecuteScalar();
            return count + 1;
        }

        public DataTable getTablaMercaderia()
        {
            List<Mercaderia> lista = new List<Mercaderia>();
            DataTable tabla = ds.ObtenerTabla("Mercaderia", "select IdMercaderia as 'Id Producto',Nombre,Precio as 'Valor Total',Stock,Unidad,Precio_Unitario as 'Precio Unitario' from Mercaderia where Estado = 1");
            return tabla;
        }

        public DataTable getTablaMercaderiaComp()
        {
            List<Mercaderia> lista = new List<Mercaderia>();
            DataTable tabla = ds.ObtenerTabla("Mercaderia", "select IdMercaderia as 'Id Producto', Nombre from Mercaderia where Estado = 1");
            return tabla;
        }

        public string validacionMer(int IdMer)
        {
            Validaciones Val = new Validaciones();
            return (Val.existedato("Mercaderia", IdMer, "IdMercaderia"));
        }

    }
}
