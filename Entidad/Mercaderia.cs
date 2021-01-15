using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Mercaderia
    {
        private int Id_Mercaderia;
        private string Nombre;
        private float Stock;
        private float PrecioU;
        private float PrecioT;
        private string Unidad;
        bool Estado;

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string Nom)
        {
            Nombre = Nom;
        }

        public int getIdMer()
        {
            return Id_Mercaderia;
        }

        public void setIdMer(int M)
        {
            Id_Mercaderia = M;
        }

        public float getStock()
        {
            return Stock;
        }

        public void setStock(float Can)
        {
            Stock = Can;
        }

        public float getPrecioU()
        {
            return PrecioU;
        }

        public void setPrecioU(float pre)
        {
            PrecioU = pre;
        }

        public float getPrecioT()
        {
            return PrecioT;
        }

        public void setPrecioT(float pre)
        {
            PrecioT = pre;
        }

        public string getUnidad()
        {
            return Unidad;
        }

        public void setUnidad(string Un)
        {
            Unidad = Un;
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
