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
    public class N_Mercaderia
    {
        public DataTable getTabla()
        {
            DaoMercaderia dao = new DaoMercaderia();
            return dao.getTablaMercaderia();
        }

        public DataTable getTablaMerCom()
        {
            DaoMercaderia dao = new DaoMercaderia();
            return dao.getTablaMercaderiaComp();
        }


        public void datosMer(Mercaderia Mer)
        {
            DaoMercaderia Merc = new DaoMercaderia();
            Merc.InsertarMercEnBD("Mercaderia", Mer);
        }

        public int incremetarMer()
        {
            DaoMercaderia det = new DaoMercaderia();
            int pep = det.incrementarMer();
            return pep;
        }

        public void eliminarMercaderia(int codigo)
        {
            DaoMercaderia Mer = new DaoMercaderia();
            Mer.eliminarMerSQL(codigo);
        }

        public string Unidad(int IdMer)
        {
            DaoMercaderia Mer = new DaoMercaderia();
            return Mer.validacionMer(IdMer);
                
        }

    }
}
