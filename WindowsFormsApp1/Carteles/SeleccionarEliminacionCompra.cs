using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Carteles
{
    public partial class SeleccionarEliminacionCompra : Form
    {
        public string Seleccion;

        public SeleccionarEliminacionCompra()
        {
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Seleccion = "Compra";
            this.Close();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Seleccion = "Producto";
            this.Close();
        }

    }
}
