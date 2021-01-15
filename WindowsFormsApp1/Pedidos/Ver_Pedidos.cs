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
        static public bool SubGrilla = new bool();

        public Ver_Pedidos()
        {
            InitializeComponent();
        }

        private void Ver_Pedidos_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Pedidos Ped = new N_Pedidos();
            Grilla.DataSource = Ped.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubGrilla = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (SubGrilla == false)
            {
                N_Pedidos Ped = new N_Pedidos();
                Grilla.DataSource = Ped.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                N_TortasPedido TP = new N_TortasPedido();
                Grilla.DataSource = TP.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Atras.Visible = true;
            SubGrilla = true;
            label1.Visible = false;
            Entregados.Visible = false;
            N_TortasPedido TP = new N_TortasPedido();
            Grilla.DataSource = TP.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Atras.Visible = false;
            SubGrilla = false;
            label1.Visible = true;
            Entregados.Visible = true;
            N_Pedidos Ped = new N_Pedidos();
            Grilla.DataSource = Ped.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Entregados_CheckedChanged(object sender, EventArgs e)
        {
            N_Pedidos Ped = new N_Pedidos();
            if (Entregados.Checked == true)
            {
                Grilla.DataSource = Ped.getTablaEntregados();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {   
                Grilla.DataSource = Ped.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
