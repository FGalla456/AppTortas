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
    public class N_Tortas
    {

        DaoTortas Tor = new DaoTortas();
        public DataTable getTabla()
        {
            return Tor.getTablaTortas();
        }

        public void datosTor(Tortas tor)
        {

            Tor.InsertarTorta(tor);
        }

        public void EliminarTorta(int codigo)
        {

            Tor.EliminarTorta(codigo);
        }

    }
}
