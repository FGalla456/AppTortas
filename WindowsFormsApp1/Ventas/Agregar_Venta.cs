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
using Entidad;

namespace WindowsFormsApp1.Ventas
{
    public partial class Agregar_Venta : Form
    {
        Entidad.Ventas Ven = new Entidad.Ventas();
        N_Pedidos np = new N_Pedidos();
        N_Ventas nv = new N_Ventas();
        Genericas gen = new Genericas();
        public Agregar_Venta()
        {
            InitializeComponent();
        }

        private string ConstruirMensaje()
        {
           string Mensaje = null;
            if (txtVenta.Text == "")
            {
                Mensaje = "Numero de Venta";
            }
            if (txtPed.Text == "")
            {
                if (Mensaje == "")
                {
                    Mensaje = "Numero de Pedido";
                }
                else
                {
                    Mensaje += ", Numero de Pedido";
                }
            }
            if (txtCosto.Text == "")
            {
                if (Mensaje == "")
                {
                    Mensaje = "Costo de Elaboracion";
                }
                else
                {
                    Mensaje += ", Costo de Elaboracion";
                } 
            }
            if (txtTotal.Text == "")
            {
                if (Mensaje == "")
                {
                    Mensaje = "Total de la Venta";
                }
                else
                {
                    Mensaje += ", Total de la Venta";
                }

            }
            return Mensaje;
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

        public void PermitirLetrasEspacio(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirLetrasEspacio(sender, e, Texto);
        }

        public void PerimitirDecimales(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirDecimales(sender, e, Texto);
        }

        #endregion

        private void Agregar_Venta_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            txtPed.Enabled = false;
            txtTotal.Enabled = false;
            txtCosto.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtCosto.Text != "" && txtPed.Text != "" && txtTotal.Text != "" && txtVenta.Text != "")
            {
                Ven.setCosto(float.Parse(txtCosto.Text.ToString()));
                Ven.setEstado(true);
                Ven.setIdPed(int.Parse(txtPed.Text.ToString()));
                Ven.setPrecioV(float.Parse(txtTotal.Text.ToString()));
                Ven.setGanancia(Ven.getPrecioV() - Ven.getCosto());

                nv.datosVen(Ven);
                btnAceptar.Enabled = false;
                this.Close();
            }
            else
            {
               Mensaje = ConstruirMensaje();
                MessageBox.Show("Faltan Cargar: " + Mensaje,"Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            GrillaPed.DefaultCellStyle.ForeColor = Color.White;
            GrillaPed.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 46);
            GrillaPed.BackgroundColor = Color.FromArgb(30, 30, 46);
            GrillaPed.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaPed.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 48, 49);
            GrillaPed.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaPed.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 48, 49);
            GrillaPed.DataSource = np.getTablaPedVen();
            GrillaPed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrillaPed.Visible = true;
        }
    }
}
