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
    public class N_Mercaderia
    {
        public DataTable getTabla()
        {
            DaoProductos dao = new DaoProductos();
            return dao.getTablaProductos();
        }

        public DataTable getTablaMerCom()
        {
            DaoProductos dao = new DaoProductos();
            return dao.getTablaProductoComp();
        }


        public void datosMer(Mercaderia Mer)
        {
            DaoProductos Merc = new DaoProductos();
            Merc.InsertarProducto(Mer);
        }


        public void eliminarMercaderia(int codigo)
        {
            DaoProductos Mer = new DaoProductos();
          //  Mer.eliminarMerSQL(codigo);
        }

        public string Unidad(int IdMer)
        {
            DaoProductos Mer = new DaoProductos();
            return "";//Mer.validacionMer(IdMer);
                
        }

    }
}
