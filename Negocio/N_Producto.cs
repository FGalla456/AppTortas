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
    public class N_Producto
    {
        DaoProductos Pro = new DaoProductos();
        public DataTable getTabla()
        {
            return Pro.getTablaProductos();
        }

        public DataTable getTablaProCom()
        {

            return Pro.getTablaProductoComp();
        }


        public void datosPro(Producto Mer)
        {
            Pro.InsertarProducto(Mer);
        }


        public void eliminarProducto(int codigo)
        {
            Pro.EliminarProducto(codigo);
        }

        public string Unidad(int IdMer)
        {
            return "";//Mer.validacionMer(IdMer);
        }

    }
}
