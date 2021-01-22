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
    public class N_Clientes
    {
        public DataTable getTabla()
        {
            DaoClientes dao = new DaoClientes();
            return dao.getTablaClientes();
        }

        public void datosCli(Clientes Cli)
        {
            DaoClientes clien = new DaoClientes();
            clien.InsertarCliente(Cli);
        }

   /*     public void eliminarCliente(int codigo)
        {
            DaoClientes Cli = new DaoClientes();
            Cli.eliminarcliSQL(codigo);
        }*/

    }
}
