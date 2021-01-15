using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Compras
    {
		private int Nro_Compra;
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

		public int getFactura()
		{
			return Nro_Compra;
		}

		public void setFactura(int NF)
		{
			Nro_Compra = NF;
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
