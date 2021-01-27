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
    public class N_Pedidos
    {

        DaoPedidos Ped = new DaoPedidos();
        public DataTable getTabla()
        {
            return Ped.getTablaPedidos();
        }

        public DataTable getTablaEntregados()
        {
            return Ped.getTablaPedidosEntregados();
        }

        public DataTable getTablaPedVen()
        {
            return Ped.getTablaPedVen();
        }

        public void datosPed(Pedidos ped)
        {

            Ped.InsertarPedidos(ped);
        }

        public void eliminarPedido(int codigo)
        {
            Ped.EliminarPedido(codigo);
        }

    }
}
