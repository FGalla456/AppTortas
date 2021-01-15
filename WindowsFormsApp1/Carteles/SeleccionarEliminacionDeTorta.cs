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
    public partial class SeleccionarFormulario : Form
    {
        public string Seleccion;

        public SeleccionarFormulario()
        {
            InitializeComponent();
        }

        private void btnTorta_Click(object sender, EventArgs e)
        {
            Seleccion = "Torta";
            this.Close();
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            Seleccion = "Ingrediente";
            this.Close();
        }
    }
}
