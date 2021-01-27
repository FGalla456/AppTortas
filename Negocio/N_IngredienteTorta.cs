using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidad;
using System.Data;

namespace Negocio
{
    public class N_IngredienteTorta
    {
        DaoIngredientes IT = new DaoIngredientes();
        public DataTable getTabla()
        {
            return IT.getTablaIngredientes();
        }

        public void datosIng(Ingredientes_x_Torta Ing)
        {
            IT.InsertarIngrediente(Ing);
        }

        public void eliminarIngrediente(int Torta, int Mer)
        {

            IT.EliminarIngrediente(Torta,Mer);
        }
    }
}
