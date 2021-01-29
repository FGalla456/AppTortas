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

namespace WindowsFormsApp1.Mercaderia
{
    public partial class Ver_Mercaderia : Form
    {

        #region Declaraciones

        N_Producto Pro = new N_Producto();

        #endregion

        #region Inicio

        public Ver_Mercaderia()
        {
            InitializeComponent();
        }

        private void Ver_Mercaderia_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.DataSource = Pro.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        #region Botones

        private void Refresh_Click(object sender, EventArgs e)
        {
            Grilla.DataSource = Pro.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion
    }
}
