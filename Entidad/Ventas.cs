using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Ventas
    {
        private int Id_Pedido;
        private float Precio_Venta;
        private float CostoP;
        private float Ganancia;
        private bool Estado;

        public float getGanancia()
        {
            return Ganancia;
        }

        public void setGanancia(float gan)
        {
            Ganancia = gan;
        }

        public int getIdPed()
        {
            return Id_Pedido;
        }

        public void setIdPed(int M)
        {
            Id_Pedido = M;
        }

        public float getCosto()
        {
            return CostoP;
        }

        public void setCosto(float pre)
        {
            CostoP = pre;
        }

        public float getPrecioV()
        {
            return Precio_Venta;
        }

        public void setPrecioV(float PV)
        {
            Precio_Venta = PV;
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
