using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Tortas
    {
        private int Id_Torta;
        private string Nombre;
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

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string N)
        {
            Nombre = N;
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
