using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;


namespace WindowsFormsApp1.Clientes
{
    public partial class Agregar_Cliente : Form
    {

        Genericas gen = new Genericas();
        N_Clientes nc = new N_Clientes();
        Entidad.Clientes Cli = new Entidad.Clientes();
        static public bool espacio = new bool(); /// Cambia a true cuando se presiona el espacio en el textbox de Domicilio
        static public bool N = new bool(); ///Cambia a true cuando se presiona el espacio en el textbox de Nombre
        static public bool A = new bool(); ///Cambia a true cuando se presiona el espacio en el textbox de Apellido
        static public bool E = new bool(); ///Cambia a true cuando se presiona un numero en el textbox de Domicilio
        static public int D = new int(); ///Cuenta la cantidad de veces que se uso el espacio, si se escribo algo antes la variable espacio cambia a false (Se usa solo en domicilio)
        static public int Numeros = new int();

        public Agregar_Cliente()
        {
            InitializeComponent();
        }


        #region KeyPress

        public void PermitirNumeros(object sender, KeyPressEventArgs e)
        {
            gen.PermitirNumeros(sender, e);
        }

        public void PermitirLetras(object sender, KeyPressEventArgs e)
        {
            gen.PermitirLetras(sender, e);
        }

        public void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            gen.NoPermitirEscribir(sender, e);
        }

        public void PermitirLetrasEspacio(object sender, KeyPressEventArgs e, string Texto) 
        {
            gen.PermitirLetrasEspacio(sender, e, Texto);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
             PermitirLetrasEspacio(sender, e, txtNombre.Text);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
             PermitirLetrasEspacio(sender, e, txtApellido.Text);
        }

        #endregion
        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (txtNombre.Text == "")
            {
                Mensaje = "Nombre";
            }
            if (txtApellido.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Apellido";
                }
                else
                {
                    Mensaje += ", Apellido";
                }
            }
            if (txtDomicilio.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Domicilio";
                }
                else
                {
                    Mensaje += ", Domicilio";
                }
            }
            if (txtTelefono.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Telefono";
                }
                else
                {
                    Mensaje += ", Telefono";
                }

            }
            return Mensaje;
        }
        private void Agregar_Cliente_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;
            D = 0;
            Numeros = 0;
        }
        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDomicilio.Text == "")
            {
                if (e.KeyChar == ' ')
                {
                    e.Handled = true;
                }
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (txtDomicilio.Text != "")
            {
                if (e.KeyChar == ' ')
                {
                    if (espacio == false)
                    {
                        e.Handled = false;
                        espacio = true;
                        D++;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (Char.IsDigit(e.KeyChar) && espacio == false)
                    {
                        e.Handled = true;
                    }
                    if(Char.IsDigit(e.KeyChar) && espacio == true)
                    {
                        e.Handled = false;
                        Numeros++;
                        D = 4;
                        E = true;
                    }
                    if(Char.IsLetter(e.KeyChar) && espacio == true && D<=2)
                    {
                        espacio = false;
                        D++;
                    }
                    if(Char.IsLetter(e.KeyChar) && espacio == true && E == true)
                    {
                        e.Handled = true;
                    }
                    if (Char.IsLetter(e.KeyChar) && espacio == true && D >= 1)
                    {
                        e.Handled = true;
                    }
                }

            }
            int longitudTexto = txtDomicilio.Text.Length;
            char[] Caracteres_Escritos = new char[longitudTexto];
            Caracteres_Escritos = txtDomicilio.Text.ToCharArray();
            if (e.KeyChar == Convert.ToChar(Keys.Delete) || e.KeyChar == Convert.ToChar(Keys.Back))
            {

                if (Char.IsSeparator(Caracteres_Escritos[longitudTexto - 1]))
                {
                    if (espacio == true)
                    {
                        espacio = false;
                        D--;
                    }
                }

                if (Char.IsDigit(Caracteres_Escritos[longitudTexto - 1]))
                {
                    Numeros--;
                    if (Numeros == 0)
                    {
                        E = false;
                    }
                }

                if (txtDomicilio.Text == "")
                {
                    e.Handled = true;
                }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtApellido.Text !="" && txtDomicilio.Text != "" && txtNombre.Text != "" &&  txtTelefono.Text != "")
            {
                Cli.setApellido(txtApellido.Text.ToString());
                Cli.setDomicilio(txtDomicilio.Text.ToString());
                Cli.setEstado(true);
                Cli.setNombre(txtNombre.Text.ToString());
                Cli.setTelefono(txtTelefono.Text.ToString());
                nc.datosCli(Cli);
                btnAceptar.Enabled = false;
                this.Close();
            }
            else
            {
                Mensaje = ConstruirMensaje();
                MessageBox.Show("Faltan Cargar: " + Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }
    }
}
