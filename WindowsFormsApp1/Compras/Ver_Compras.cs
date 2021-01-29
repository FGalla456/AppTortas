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
	public partial class Ver_Compras : Form
	{
        #region Declaraciones

        N_Compras nc = new N_Compras();
        N_DetalleCompra ndc = new N_DetalleCompra();
        static public bool SubGrilla = new bool();

        #endregion

        #region Inicio

        public Ver_Compras()
		{
			InitializeComponent();
		}

		private void Ver_Compras_Load(object sender, EventArgs e)
		{
            this.Dock = DockStyle.Fill;
			GrillaCompras.DataSource = nc.getTabla();
			GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubGrilla = false;

        }

        #endregion

        #region Botones
        private void Refresh_Click(object sender, EventArgs e)
        {
            if (SubGrilla == false)
            { 
                GrillaCompras.DataSource = nc.getTabla();
                GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                GrillaCompras.DataSource = ndc.getTabla();
                GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Atras.Visible = false;
            SubGrilla = false;
            GrillaCompras.DataSource = nc.getTabla();
            GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        #region Eventos
        private void GrillaCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Atras.Visible = true;
            SubGrilla = true;
            GrillaCompras.DataSource = ndc.getTabla();
            GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

    }
}
