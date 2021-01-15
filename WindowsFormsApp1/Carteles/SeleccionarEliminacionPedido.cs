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
    public partial class SeleccionarEliminacionPedido : Form
    {
        public string Seleccion;

        public SeleccionarEliminacionPedido()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Seleccion = "Pedido";
            this.Close();
        }

        private void btnTorta_Click(object sender, EventArgs e)
        {
            Seleccion = "Torta";
            this.Close();
        }
    }
}
