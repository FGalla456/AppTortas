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

        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
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

        private void PermitirSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
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

        private void Agregar_Venta_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            txtPed.Enabled = false;
            txtTotal.Enabled = false;
            txtCosto.Enabled = false;
            N_Ventas Ven = new N_Ventas();
            txtVenta.Text = Ven.incremetarVen().ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtCosto.Text != "" && txtPed.Text != "" && txtTotal.Text != "" && txtVenta.Text != "")
            {
                Entidad.Ventas Ven = new Entidad.Ventas();
                Ven.setCosto(float.Parse(txtCosto.Text.ToString()));
                Ven.setEstado(true);
                Ven.setIdPed(int.Parse(txtPed.Text.ToString()));
                Ven.setPrecioV(float.Parse(txtTotal.Text.ToString()));
                Ven.setVenta(int.Parse(txtVenta.Text.ToString()));
                Ven.setGanancia(Ven.getPrecioV() - Ven.getCosto());
                N_Ventas V = new N_Ventas();
                V.datosVen(Ven);
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
            N_Pedidos Ped = new N_Pedidos();
            GrillaPed.DefaultCellStyle.ForeColor = Color.White;
            GrillaPed.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 46);
            GrillaPed.BackgroundColor = Color.FromArgb(30, 30, 46);
            GrillaPed.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaPed.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 48, 49);
            GrillaPed.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaPed.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 48, 49);
            GrillaPed.DataSource = Ped.getTablaPedVen();
            GrillaPed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrillaPed.Visible = true;
        }
    }
}
