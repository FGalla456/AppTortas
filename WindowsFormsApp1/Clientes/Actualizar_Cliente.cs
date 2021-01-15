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
    public partial class Actualizar_Cliente : Form
    {
        public Actualizar_Cliente()
        {
            InitializeComponent();
        }

        private void Actualizar_Cliente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Clientes Cli = new N_Clientes();
            Grilla.DataSource = Cli.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

    }
}
