using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Detalle_x_Compra
    {
        private int Nro_Compra;
        private int Id_Mercaderia;
        private float Cantidad;
        private float PrecioU;

        public int getCompra()
        {
            return Nro_Compra;
        }

        public void setCompra(int Com)
        {
            Nro_Compra = Com;
        }

        public int getIdMer()
        {
            return Id_Mercaderia;
        }

        public void setIdMer(int M)
        {
            Id_Mercaderia = M;
        }

        public float getCantidad()
        {
            return Cantidad;
        }

        public void setCantidad(float Can)
        {
            Cantidad = Can;
        }

        public float getPrecio()
        {
            return PrecioU;
        }

        public void setPrecio(float pre)
        {
            PrecioU = pre;
        }
    }
}
