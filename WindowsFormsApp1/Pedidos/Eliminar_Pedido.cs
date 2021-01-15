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
    public partial class Eliminar_Pedido : Form
    {
        public Eliminar_Pedido()
        {
            InitializeComponent();
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

        private void Eliminar_Pedido_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            N_Pedidos Ped = new N_Pedidos();
            Grilla.DataSource = Ped.getTablaEntregados();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPedido.Text != "")
            {
                N_Pedidos Ped = new N_Pedidos();
                Ped.eliminarPedido(int.Parse(txtPedido.Text.ToString()));
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
