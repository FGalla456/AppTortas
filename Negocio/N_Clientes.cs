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
        DaoClientes Cli = new DaoClientes();
        public DataTable getTabla()
        {
            return Cli.getTablaClientes();
        }

        public void datosCli(Clientes cli)
        {
            Cli.InsertarCliente(cli);
        }

        public void eliminarCliente(int codigo)
        {

            Cli.EliminarCliente(codigo);
        }

    }
}
