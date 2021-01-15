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

namespace WindowsFormsApp1.Tortas
{
    public partial class Eliminar_Ingrediente : Form
    {
        public Eliminar_Ingrediente()
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

        private void Eliminar_Ingrediente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            N_IngredienteTorta IT = new N_IngredienteTorta();
            Grilla.DataSource = IT.getTabla();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMerc.Text != "" && txtTorta.Text != "")
            {
                N_IngredienteTorta IT = new N_IngredienteTorta();
                IT.eliminarIngrediente(int.Parse(txtTorta.Text.ToString()),int.Parse(txtMerc.Text.ToString()));
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
