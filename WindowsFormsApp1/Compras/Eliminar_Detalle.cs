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
    public partial class Eliminar_Detalle : Form
    {
        public Eliminar_Detalle()
        {
            InitializeComponent();
        }

        static public string celda;
        static public bool Detalle = new bool();

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

        private void Eliminar_Detalle_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            N_Compras DC = new N_Compras();
            Grilla.DataSource = DC.getTabla();
            Detalle = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCompra.Text != "" && txtMercaderia.Text != "")
            {
                N_DetalleCompra DC = new N_DetalleCompra();
                DC.eliminarDetalle(int.Parse(txtCompra.Text.ToString()),int.Parse(txtMercaderia.Text.ToString()));
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
            if (Detalle == false)
            {
                celda = Convert.ToString(row.Cells["Numero de Compra"].Value);
                txtCompra.Text = celda;
                Detalle = true;
                N_DetalleCompra DC = new N_DetalleCompra();
                Grilla.DataSource = DC.getTabla();
            }
            else
            {
                if (Detalle == true)
                {
                    celda = Convert.ToString(row.Cells["Id Producto"].Value);
                    txtMercaderia.Text = celda;
                    Detalle = false;
                    N_Compras DC = new N_Compras();
                    Grilla.DataSource = DC.getTabla();
                }
            }
        }
    }
}
