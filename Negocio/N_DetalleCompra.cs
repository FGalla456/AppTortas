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

        DaoDetalleCompra DC = new DaoDetalleCompra();
        public DataTable getTabla()
        {
            return DC.getTablaDetalleCompra();
        }

        public void eliminarDetalle(int NroCom, int IdMer)
        {
            DC.EliminarDetalleCompra(NroCom, IdMer);
        }
        
        public void datosDC(DataTable lista)
        {
            for (int i = 0; i < lista.Rows.Count; i++)
            {
             //   DC.InsertarDetalleCompra();
            }
        }

    }
}
