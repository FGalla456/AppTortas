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
            return dao.getTablaTortasPedido();
        }

        public void datosTP(Tortas_x_Pedido TP)
        {
            DaoTortasPedido TOP = new DaoTortasPedido();
            TOP.InsertarTortasPedido(TP);
        }

        public void eliminarTP(int Torta,int Pedido)
        {
            DaoTortasPedido TP = new DaoTortasPedido();
           // TP.eliminarTPSQL(Torta,Pedido);
        }

    }
}
