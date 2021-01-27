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

namespace WindowsFormsApp1.Pedidos
{
    public partial class Eliminar_TortasPedido : Form
    {

        Genericas gen = new Genericas();
        N_TortasPedido ntp = new N_TortasPedido();
        public Eliminar_TortasPedido()
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

        public void PerimitirDecimales(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirDecimales(sender, e, Texto);
        }

        #endregion

        private void Eliminar_TortasPedido_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.DataSource = ntp.getTabla();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPedido.Text != "" && txtTorta.Text != "")
            {
                ntp.eliminarTP(int.Parse(txtTorta.Text.ToString()),int.Parse(txtPedido.Text.ToString()));
                btnAceptar.Enabled = false;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            this.Close();
        }
    }
}
