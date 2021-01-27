using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Clientes
    {
        private int Id_Cliente;
        private string Nombre;
        private string Apellido;
        private string Telefono;
        private string Domicilio;
        private bool Estado;

        public int getCliente()
        {
            return Id_Cliente;
        }

        public void setCliente(int cli)
        {
            Id_Cliente = cli;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string N)
        {
            Nombre = N;
        }

        public string getApellido()
        {
            return Apellido;
        }

        public void setApellido(string A)
        {
            Apellido = A;
        }

        public string getDomicilio()
        {
            return Domicilio;
        }

        public void setDomicilio(string D)
        {
            Domicilio = D;
        }

        public string getTelefono()
        {
            return Telefono;
        }

        public void setTelefono(string T)
        {
            Telefono = T;
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
