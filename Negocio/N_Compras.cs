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
    public class N_Compras
    {
		public DataTable getTabla()
		{
			DaoCompras dao = new DaoCompras();
			return dao.getTablaCompras();
		}

		public void datosCom(Compras com)
		{
			DaoCompras Vent = new DaoCompras();
			Vent.InsertarComprasEnBD("Compras", com);
		}

        public void eliminarCompra(int codigo)
        {
            DaoCompras Com = new DaoCompras();
            Com.eliminarcomSQL(codigo);
        }

        //public bool ExisteCom(string fac)
        //{
        //    DaoCompras Cate = new DaoCompras();
        //    bool categ = Cate.validacionCompras(fac);
        //    return categ;
        //}

        public int incremetarfact()
		{
			DaoDetalleCompra det = new DaoDetalleCompra();
			int pep = det.incrementarfact();
			return pep;
		}
		
        //public DataTable Reportestabla(string ClausulaSQL)
		//{
		//	string Consulta = ClausulaSQL;
		//	DaoEmpleados dao = new DaoEmpleados();
		//	return dao.getTablaEmpleadosFiltrada(Consulta);
		//}
	}
}
