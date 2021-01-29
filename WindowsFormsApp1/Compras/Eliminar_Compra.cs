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
    public partial class Eliminar_Compra : Form
    {
        #region Declaraciones

        Genericas gen = new Genericas();
        N_Compras nc = new N_Compras();
        static public string celda;

        #endregion

        #region Inicio

        public Eliminar_Compra()
        {
            InitializeComponent();
        }

        private void Eliminar_Compra_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.DataSource = nc.getTabla();
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

        public void PermitirLetrasEspacio(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirLetrasEspacio(sender, e, Texto);
        }

        #endregion

        #region Botones
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCompra.Text != "")
            {
                nc.eliminarCompra(int.Parse(txtCompra.Text.ToString()));
                btnAceptar.Enabled = false;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                btnAceptar.Enabled = false;
                this.Close();
        }

        #endregion

        #region Eventos

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Grilla.CurrentRow;

            celda = Convert.ToString(row.Cells["Numero de Compra"].Value);
            txtCompra.Text = celda;
        }

        #endregion

    }
}
