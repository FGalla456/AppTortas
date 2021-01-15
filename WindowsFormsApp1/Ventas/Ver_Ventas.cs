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
        public Ver_Ventas()
        {
            InitializeComponent();
        }

        private void Ver_Ventas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Ventas Ven = new N_Ventas();
            Grilla.DataSource = Ven.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            N_Ventas Ven = new N_Ventas();
            Grilla.DataSource = Ven.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
