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

namespace WindowsFormsApp1.Pedidos
{
    public partial class Agregar_Pedido : Form
    {
        public Agregar_Pedido()
        {
            InitializeComponent();
        }

        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (txtPed.Text == "")
            {
                Mensaje = "Id Pedido";
            }
            if (txtIdCliente.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Id Cliente";
                }
                else
                {
                    Mensaje += ", Id Cliente";
                }
            }
            if (dtpFecha.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Fecha";
                }
                else
                {
                    Mensaje += ", Fecha";
                }
            }
            if (txtCosto.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Costo";
                }
                else
                {
                    Mensaje += ", Costo";
                }

            }
            if (txtTotal.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Total";
                }
                else
                {
                    Mensaje += ", Total";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtPed.Text != "" && txtIdCliente.Text != "" && txtCosto.Text != "" && txtTotal.Text != "" && dtpFecha.Text != "")
            { 
            Entidad.Pedidos Ped = new Entidad.Pedidos();
            Ped.setCliente(int.Parse(txtIdCliente.Text.ToString()));
            Ped.setCosto(float.Parse(txtCosto.Text.ToString()));
            Ped.setEstado(true);
            Ped.setFecha(dtpFecha.Text.ToString());
            Ped.setIdPed(int.Parse(txtPed.Text.ToString()));
            Ped.setPrecioV(float.Parse(txtTotal.Text.ToString()));
            N_Pedidos P = new N_Pedidos();
            P.datosPed(Ped);
            }
            else
            {
               Mensaje = ConstruirMensaje();   
               MessageBox.Show("Faltan Cargar: " + Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        private void Agregar_Pedido_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Pedidos Ped = new N_Pedidos();
            txtPed.Text = Ped.incremetarPed().ToString();
            dtpFecha.Text = DateTime.Today.ToString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            N_Clientes Cli = new N_Clientes();
            GrillaCliente.DataSource = Cli.getTabla();
            GrillaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrillaCliente.Visible = true;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaIngre = new DateTime();
            DateTime FechaValida = new DateTime();
            FechaValida = DateTime.Today;
            FechaIngre = dtpFecha.Value;
            if (FechaValida > FechaIngre)
            {
                    MessageBox.Show("La fecha Ingresada debe ser Posterior o Igual al " + FechaValida.ToShortDateString().ToString());
            }

        }
    }

}