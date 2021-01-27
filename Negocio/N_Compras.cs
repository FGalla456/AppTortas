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
		DaoCompras Com = new DaoCompras();
		public DataTable getTabla()
		{
			return Com.getTablaCompras();
		}

		public void datosCom(Compras com)
		{
			Com.InsertarCompra(com);
		}

        public void eliminarCompra(int codigo)
        {
			Com.EliminarCompra(codigo);
        }

        //public bool ExisteCom(string fac)
        //{
        //    DaoCompras Cate = new DaoCompras();
        //    bool categ = Cate.validacionCompras(fac);
        //    return categ;
        //}


		
        //public DataTable Reportestabla(string ClausulaSQL)
		//{
		//	string Consulta = ClausulaSQL;
		//	DaoEmpleados dao = new DaoEmpleados();
		//	return dao.getTablaEmpleadosFiltrada(Consulta);
		//}
	}
}
