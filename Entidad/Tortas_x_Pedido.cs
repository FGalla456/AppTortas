using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Tortas_x_Pedido
    {
        private int Id_Torta;
        private int Id_Pedido;
        private float Precio_Venta;
        private int Cantidad;
        private float Costo;
        private float Total;
        private bool Estado;

        public int getTorta()
        {
            return Id_Torta;
        }

        public void setTorta(int tor)
        {
            Id_Torta = tor;
        }

        public int getIdPed()
        {
            return Id_Pedido;
        }

        public void setIdPed(int M)
        {
            Id_Pedido = M;
        }

        public int getCantidad()
        {
            return Cantidad;
        }

        public void setCantidad(int Can)
        {
            Cantidad = Can;
        }

        public float getCosto()
        {
            return Costo;
        }

        public void setCosto(float pre)
        {
            Costo = pre;
        }

        public float getPrecioV()
        {
            return Precio_Venta;
        }

        public void setPrecioV(float PV)
        {
            Precio_Venta = PV;
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

        public void setEstado(bool E)
        {
            Estado = E;
        }

    }
}
