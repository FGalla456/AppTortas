using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Detalle_x_Compra
    {
        private int idCompra;
        private int Id_Mercaderia;
        private float Cantidad;
        private float PrecioU;
        private bool Estado;

        public bool Estado1 { get => Estado; set => Estado = value; }

        public int getCompra()
        {
            return idCompra;
        }

        public void setCompra(int Com)
        {
            idCompra = Com;
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
