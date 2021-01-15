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
    public partial class Ver_Tortas : Form
    {
        static public bool SubGrilla = new bool();

        public Ver_Tortas()
        {
            InitializeComponent();
        }

        private void Ver_Tortas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Tortas Tor = new N_Tortas();
            Grilla.DataSource = Tor.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubGrilla = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (SubGrilla == false)
            {
                N_Tortas Tor = new N_Tortas();
                Grilla.DataSource = Tor.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                N_IngredienteTorta IT = new N_IngredienteTorta();
                Grilla.DataSource = IT.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Atras.Visible = true;
            SubGrilla = true;
            N_IngredienteTorta IT = new N_IngredienteTorta();
            Grilla.DataSource = IT.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Atras.Visible = false;
            SubGrilla = false;
            N_Tortas Tor = new N_Tortas();
            Grilla.DataSource = Tor.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
