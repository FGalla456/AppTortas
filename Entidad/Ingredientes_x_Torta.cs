using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
     public class Ingredientes_x_Torta
     {
        private int Id_Mercaderia;
        private int Id_Torta;
        private float Cantidad;
        private float Costo;
        private bool Estado;

        public int getTorta()
        {
            return Id_Torta;
        }

        public void setTorta(int tor)
        {
            Id_Torta = tor;
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

        public float getCosto()
        {
            return Costo;
        }

        public void setCosto(float pre)
        {
            Costo = pre;
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
