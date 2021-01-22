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
        public DataTable getTabla()
        {
            DaoVentas dao = new DaoVentas();
            return dao.getTablaVentas();
        }

        public void datosVen(Ventas Ven)
        {
            DaoVentas Vent = new DaoVentas();
            Vent.InsertarVenta(Ven);
        }

        public void eliminarVenta(int codigo)
        {
            DaoVentas Ven = new DaoVentas();
          //  Ven.eliminarVenSQL(codigo);
        }

    }
}
