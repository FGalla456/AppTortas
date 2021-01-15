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
        static public bool SubGrilla = new bool();

		public Ver_Compras()
		{
			InitializeComponent();
		}

		private void Ver_Compras_Load(object sender, EventArgs e)
		{
            this.Dock = DockStyle.Fill;
            N_Compras comp = new N_Compras();
			GrillaCompras.DataSource = comp.getTabla();
			GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubGrilla = false;

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (SubGrilla == false)
            { 
                N_Compras comp = new N_Compras();
                GrillaCompras.DataSource = comp.getTabla();
                GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                N_DetalleCompra DC = new N_DetalleCompra();
                GrillaCompras.DataSource = DC.getTabla();
                GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void GrillaCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Atras.Visible = true;
            SubGrilla = true;
            N_DetalleCompra DC = new N_DetalleCompra();
            GrillaCompras.DataSource = DC.getTabla();
            GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Atras.Visible = false;
            SubGrilla = false;
            N_Compras comp = new N_Compras();
            GrillaCompras.DataSource = comp.getTabla();
            GrillaCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
