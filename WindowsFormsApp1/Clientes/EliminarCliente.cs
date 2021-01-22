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
    public partial class EliminarCliente : Form
    {
        public string celda;

        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            N_Clientes Cli = new N_Clientes();
            Grilla.DataSource = Cli.getTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                N_Clientes Cli = new N_Clientes();
                btnAceptar.Enabled = false;
                this.Close();
            }
        }

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grilla.CurrentRow;

            celda = Convert.ToString(row.Cells["Id Cliente"].Value);
            txtCliente.Text = celda;
        }
    }
}
