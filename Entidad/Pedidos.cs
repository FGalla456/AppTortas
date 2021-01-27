using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pedidos
    {
        private int Id_Pedido;
        private int Id_Cliente;
        private float CostoP;
        private float Precio_Venta;
        private string Fecha;
        private bool Estado;

        public int getCliente()
        {
            return Id_Cliente;
        }

        public void setCliente(int cli)
        {
            Id_Cliente = cli;
        }

        public int getIdPed()
        {
            return Id_Pedido;
        }

        public void setIdPed(int M)
        {
            Id_Pedido = M;
        }

        public string getFecha()
        {
            return Fecha;
        }

        public void setFecha(string F)
        {
            Fecha = F;
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
