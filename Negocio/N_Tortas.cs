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

        public DataTable getTabla()
        {
            DaoTortas dao = new DaoTortas();
            return dao.getTablaTortas();
        }

        public void datosTor(Tortas Tor)
        {
            DaoTortas Tort = new DaoTortas();
            Tort.InsertarTortaEnBD("Tortas", Tor);
        }

        public int incremetarTor()
        {
            DaoTortas det = new DaoTortas();
            int pep = det.incrementarTor();
            return pep;
        }

        public void EliminarTorta(int codigo)
        {
            DaoTortas Tor = new DaoTortas();
            Tor.eliminarTortaSQL(codigo);
        }

    }
}
