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

namespace WindowsFormsApp1.Compras
{
    public partial class Eliminar_Compra : Form
    {
        public Eliminar_Compra()
        {
            InitializeComponent();
        }

        static public string celda;

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

        private void Eliminar_Compra_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            N_Compras Com = new N_Compras();
            Grilla.DataSource = Com.getTabla();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCompra.Text != "")
            {
                N_Compras Com = new N_Compras();
                Com.eliminarCompra(int.Parse(txtCompra.Text.ToString()));
                btnAceptar.Enabled = false;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                btnAceptar.Enabled = false;
                this.Close();
        }

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grilla.CurrentRow;

            celda = Convert.ToString(row.Cells["Numero de Compra"].Value);
            txtCompra.Text = celda;
        }
    }
}
