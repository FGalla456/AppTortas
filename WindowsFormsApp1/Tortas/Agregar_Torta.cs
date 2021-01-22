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

namespace WindowsFormsApp1.Tortas
{
    public partial class Agregar_Torta : Form
    {
        public Agregar_Torta()
        {
            InitializeComponent();
        }

        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (txtTorta.Text == "")
            {
                Mensaje = "Id Torta";
            }
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
            if (txtCosto.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Costo";
                }
                else
                {
                    Mensaje += ", Costo";
                }
            }
            return Mensaje;
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
            if (txtTorta.Text !="" && txtNombre.Text != "" && txtCosto.Text != "")
            {
                Entidad.Tortas Tor = new Entidad.Tortas();
                Tor.setCosto(float.Parse(txtCosto.Text.ToString()));
                Tor.setEstado(true);
                Tor.setNombre(txtNombre.Text.ToString());
                Tor.setTorta(int.Parse(txtTorta.Text.ToString()));
                N_Tortas T = new N_Tortas();
                T.datosTor(Tor);
                btnAceptar.Enabled = false;
                this.Close();
            }
            else
            {
                Mensaje = ConstruirMensaje();
                MessageBox.Show("Faltan Cargar: " + Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Agregar_Torta_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Tortas Tor = new N_Tortas();
        }
    }
}
