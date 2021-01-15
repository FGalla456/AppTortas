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

        public DataTable getTabla()
        {
            DaoPedidos dao = new DaoPedidos();
            return dao.getTablaPedidos();
        }

        public DataTable getTablaEntregados()
        {
            DaoPedidos dao = new DaoPedidos();
            return dao.getTablaPedidosEntregados();
        }

        public DataTable getTablaPedVen()
        {
            DaoPedidos dao = new DaoPedidos();
            return dao.getTablaPedVen();
        }

        public void datosPed(Pedidos Ped)
        {
            DaoPedidos Pedi = new DaoPedidos();
            Pedi.InsertarPedidoEnBD("Pedidos", Ped);
        }

        public int incremetarPed()
        {
            DaoPedidos det = new DaoPedidos();
            int pep = det.incrementarPed();
            return pep;
        }

        public void eliminarPedido(int codigo)
        {
            DaoPedidos Ped = new DaoPedidos();
            Ped.eliminarPedSQL(codigo);
        }

    }
}
