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

namespace WindowsFormsApp1.Clientes
{
    public partial class VerClientes : Form
    {
        #region Declaraciones

            N_Clientes nc = new N_Clientes();

        #endregion

        #region Inicio

        public VerClientes()
        {
            InitializeComponent();
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.DataSource = nc.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.Columns[0].Visible = false;
        }

        #endregion

        #region Botones

        private void Refresh_Click(object sender, EventArgs e)
        {

            Grilla.DataSource = nc.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

    }
}
