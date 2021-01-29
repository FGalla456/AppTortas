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

namespace WindowsFormsApp1.Pedidos
{
    public partial class Ver_Pedidos : Form
    {
        #region Declaraciones

        N_Pedidos np = new N_Pedidos();
        N_TortasPedido ntp = new N_TortasPedido();
        static public bool SubGrilla = new bool();

        #endregion

        #region Inicio

        public Ver_Pedidos()
        {
            InitializeComponent();
        }

        private void Ver_Pedidos_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.DataSource = np.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubGrilla = false;
        }

        #endregion

        #region Botones

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (SubGrilla == false)
            {
                Grilla.DataSource = np.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                Grilla.DataSource = ntp.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Atras.Visible = false;
            SubGrilla = false;
            label1.Visible = true;
            Entregados.Visible = true;
            Grilla.DataSource = np.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        #region Eventos

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Atras.Visible = true;
            SubGrilla = true;
            label1.Visible = false;
            Entregados.Visible = false;
            Grilla.DataSource = ntp.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Entregados_CheckedChanged(object sender, EventArgs e)
        {
            if (Entregados.Checked == true)
            {
                Grilla.DataSource = np.getTablaEntregados();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {   
                Grilla.DataSource = np.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        #endregion

    }
}
