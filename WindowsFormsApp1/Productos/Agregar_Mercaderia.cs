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

namespace WindowsFormsApp1.Mercaderia
{
    public partial class Agregar_Mercaderia : Form
    {

        N_Producto NP = new N_Producto();
        Producto Pro = new Producto();
        Genericas gen = new Genericas();
        public Agregar_Mercaderia()
        {
            InitializeComponent();
        }

        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (txtNombre.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Nombre";
                }
                else
                {
                    Mensaje += ", Nombre";
                }
            }
            if (cbUnidad.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Unidad";
                }
                else
                {
                    Mensaje += ", Unidad";
                }
            }
            return Mensaje;
        }

        private void Agregar_Mercaderia_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cbUnidad.Items.Add("Unidad");
            cbUnidad.Items.Add("Kilogramos");
            cbUnidad.Items.Add("Litros");
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

        public void PerimitirDecimales(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirDecimales(sender, e, Texto);
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtNombre.Text != "" && cbUnidad.Text !="")
            {
                Pro.setNombre(txtNombre.Text.ToString());
                Pro.setPrecioT(0);
                Pro.setPrecioU(0);
                Pro.setStock(0);
                Pro.setUnidad(cbUnidad.Text.ToString());
                NP.datosPro(Pro);
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
