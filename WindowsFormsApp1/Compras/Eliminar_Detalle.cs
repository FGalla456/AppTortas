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
    public partial class Eliminar_Detalle : Form
    {
        #region Declaraciones

        Genericas gen = new Genericas();
        N_Compras com = new N_Compras();
        N_DetalleCompra dc = new N_DetalleCompra();
        static public string celda;
        static public bool Detalle = new bool();

        #endregion

        #region Inicio
        public Eliminar_Detalle()
        {
            InitializeComponent();
        }

        private void Eliminar_Detalle_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.DataSource = com.getTabla();
            Detalle = false;
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
            if (txtCompra.Text != "" && txtMercaderia.Text != "")
            {
                dc.eliminarDetalle(int.Parse(txtCompra.Text.ToString()),int.Parse(txtMercaderia.Text.ToString()));
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
            if (Detalle == false)
            {
                celda = Convert.ToString(row.Cells["Numero de Compra"].Value);
                txtCompra.Text = celda;
                Detalle = true;
                Grilla.DataSource = dc.getTabla();
            }
            else
            {
                if (Detalle == true)
                {
                    celda = Convert.ToString(row.Cells["Id Producto"].Value);
                    txtMercaderia.Text = celda;
                    Detalle = false;
                    Grilla.DataSource = com.getTabla();
                }
            }
        }

        #endregion

    }
}
