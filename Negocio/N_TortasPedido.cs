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
    public class N_TortasPedido
    {

        public DataTable getTabla()
        {
            DaoTortasPedido dao = new DaoTortasPedido();
            return dao.getTablaTortaPedido();
        }

        public void datosTP(Tortas_x_Pedido TP)
        {
            DaoTortasPedido TOP = new DaoTortasPedido();
            TOP.InsertarTortaPedidoEnBD("Tortas_x_Pedido", TP);
        }

        public int incremetarPed()
        {
            DaoTortasPedido det = new DaoTortasPedido();
            int pep = det.incrementarPed();
            return pep;
        }

        public void eliminarTP(int Torta,int Pedido)
        {
            DaoTortasPedido TP = new DaoTortasPedido();
            TP.eliminarTPSQL(Torta,Pedido);
        }

    }
}
