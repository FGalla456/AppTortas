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
    public class N_Ventas
    {

        DaoVentas Ven = new DaoVentas();
        public DataTable getTabla()
        {
            return Ven.getTablaVentas();
        }

        public void datosVen(Ventas ven)
        {
            Ven.InsertarVenta(ven);
        }

        public void eliminarVenta(int codigo)
        {
            Ven.EliminarVenta(codigo);
        }

    }
}
