using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        private int Id_Producto;
        private string Nombre;
        private float PrecioT;
        private float Stock;
        private string Unidad;
        private float PrecioU;
        bool Estado;

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string Nom)
        {
            Nombre = Nom;
        }

        public int getIdPro()
        {
            return Id_Producto;
        }

        public void setIdPro(int P)
        {
            Id_Producto = P;
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
