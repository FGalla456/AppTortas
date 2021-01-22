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
            N_Mercaderia Mer = new N_Mercaderia();
        }

        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PermitirSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtNombre.Text != "" && cbUnidad.Text !="")
            {
                Entidad.Mercaderia Mer = new Entidad.Mercaderia();
                Mer.setNombre(txtNombre.Text.ToString());
                Mer.setPrecioT(0);
                Mer.setPrecioU(0);
                Mer.setStock(0);
                Mer.setUnidad(cbUnidad.Text.ToString());
                N_Mercaderia M = new N_Mercaderia();
                M.datosMer(Mer);
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
