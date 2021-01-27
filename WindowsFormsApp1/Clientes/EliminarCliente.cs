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
        Genericas gen = new Genericas();
        N_Clientes nc = new N_Clientes();
        public EliminarCliente()
        {
            InitializeComponent();
        }


        #region KeyPress

        public void PermitirNumeros(object sender, KeyPressEventArgs e)
        {
            gen.PermitirNumeros(sender, e);
        }

        public void PermitirLetras(object sender, KeyPressEventArgs e)
        {
            gen.PermitirLetras(sender, e);
        }

        public void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            gen.NoPermitirEscribir(sender, e);
        }

        #endregion

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.DataSource = nc.getTabla();
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
