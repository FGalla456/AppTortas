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
    public class N_DetalleCompra
    {

        public DataTable getTabla()
        {
            DaoDetalleCompra dao = new DaoDetalleCompra();
            return dao.getTablaDetalleCompra();
        }

        public void eliminarDetalle(int NroCom, int IdMer)
        {
            DaoDetalleCompra DC = new DaoDetalleCompra();
         //   DC.eliminarcomSQL(NroCom, IdMer);
        }
        
        public void datosDC(DataTable lista)
        {
            DaoDetalleCompra DC = new DaoDetalleCompra();
            for (int i = 0; i < lista.Rows.Count; i++)
            {
             //   DC.InsertarDetalleCompra();
            }
        }

    }
}
