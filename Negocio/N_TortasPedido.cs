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

        DaoTortasPedido TP = new DaoTortasPedido();
        public DataTable getTabla()
        {
            return TP.getTablaTortasPedido();
        }

        public void datosTP(Tortas_x_Pedido tp)
        {
            TP.InsertarTortasPedido(tp);
        }

        public void eliminarTP(int Torta,int Pedido)
        {
            TP.EliminarTortaPedido(Torta,Pedido);
        }

    }
}
