using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Compras
    {
		private int idCompra;
		private float Total;
		private string Fecha;
        private bool Estado;

        public string getFecha()
        {
		    return Fecha;
	    }

		public void setFecha(string fec)
		{
			Fecha = fec;
		}

		public int getCompra()
		{
			return idCompra;
		}

		public void setCompra(int Com)
		{
			idCompra = Com;
		}

		public float getTotal()
		{
			return Total;
		}

		public void setTotal(float tot)
		{
			Total = tot;
		}

        public bool getEstado()
        {
            return Estado;
        }

        public void setEstado(bool A)
        {
            Estado = A;
        }

	}
}
