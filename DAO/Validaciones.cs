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
    class Validaciones
    {
        AccesoDatos ds = new AccesoDatos();

   /*     public string existedato(string nombretabla, int datoabuscar, string nombrecolumna)
        {

            string var;
            string consulta = "SELECT * FROM " + nombretabla;
            SqlConnection sql = ds.ObtenerConexion();
            SqlCommand comando = new SqlCommand(consulta, sql);
            SqlDataReader rd = comando.ExecuteReader();
            while (rd.Read())
            {
                if (rd[nombrecolumna].ToString() == datoabuscar.ToString())
                {
                    var = rd["Unidad"].ToString();
                    return var;
                }
            }
            return "Error";
        }*/
    }
}
