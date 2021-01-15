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
        public VerClientes()
        {
            InitializeComponent();
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Clientes Cli = new N_Clientes();
            Grilla.DataSource = Cli.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            N_Clientes Cli = new N_Clientes();
            Grilla.DataSource = Cli.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
