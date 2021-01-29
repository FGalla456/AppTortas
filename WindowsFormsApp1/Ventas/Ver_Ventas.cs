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

namespace WindowsFormsApp1.Ventas
{
    public partial class Ver_Ventas : Form
    {

        #region Declaraciones

        N_Ventas nv = new N_Ventas();

        #endregion

        #region Inicio

        public Ver_Ventas()
        {
            InitializeComponent();
        }

        private void Ver_Ventas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.DataSource = nv.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        #region Botones

        private void Refresh_Click(object sender, EventArgs e)
        {
            Grilla.DataSource = nv.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

    }
}
