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

        public DataTable getTabla()
        {
            DaoIngredientes dao = new DaoIngredientes();
            return dao.getTablaIngredientes();
        }

        public void datosIng(Ingredientes_x_Torta Ing)
        {
            DaoIngredientes Ingr = new DaoIngredientes();
            Ingr.InsertarIngredienteEnBD("Ingredientes_x_Torta", Ing);
        }

        public int incremetarIng()
        {
            DaoIngredientes det = new DaoIngredientes();
            int pep = det.incrementarTor();
            return pep;
        }

        public void eliminarIngrediente(int Torta, int Mer)
        {
            DaoIngredientes IT = new DaoIngredientes();
            IT.eliminarITSQL(Torta,Mer);
        }
    }
}
