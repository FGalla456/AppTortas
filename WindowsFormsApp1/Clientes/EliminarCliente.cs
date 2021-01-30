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
        #region Declaraciones

            DataGridViewRow row = new DataGridViewRow();
            Genericas gen = new Genericas();
            N_Clientes nc = new N_Clientes();

        #endregion 

        #region Inicio

        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.DataSource = nc.getTabla();
            Grilla.Columns[0].Visible = false;
        }

        #endregion

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

        #region Botones

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                row = Grilla.CurrentRow;
                nc.eliminarCliente(Convert.ToInt32(row.Cells[0].Value));
                btnAceptar.Enabled = false;
                this.Close();
            }
        }

        #endregion

        #region Eventos

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = Grilla.CurrentRow;
            txtCliente.Text = Convert.ToString(row.Cells["Nombre"].Value) + " " + Convert.ToString(row.Cells["Apellido"].Value);
        }

        #endregion
    }
}
