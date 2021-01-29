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

        #region Declaraciones

        Genericas gen = new Genericas();
        Entidad.Tortas Tor = new Entidad.Tortas();
        N_Tortas nt = new N_Tortas();

        #endregion

        #region Inicio

        public Agregar_Torta()
        {
            InitializeComponent();
        }

        private void Agregar_Torta_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

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

        #region Botones

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtTorta.Text !="" && txtNombre.Text != "" && txtCosto.Text != "")
            {
                Tor.setCosto(float.Parse(txtCosto.Text.ToString()));
                Tor.setEstado(true);
                Tor.setNombre(txtNombre.Text.ToString());
                Tor.setTorta(int.Parse(txtTorta.Text.ToString()));

                nt.datosTor(Tor);
                btnAceptar.Enabled = false;
                this.Close();
            }
            else
            {
                Mensaje = ConstruirMensaje();
                MessageBox.Show("Faltan Cargar: " + Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Eventos

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

        #endregion

    }
}
