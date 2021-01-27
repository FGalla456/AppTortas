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
        Genericas gen = new Genericas();
        Entidad.Pedidos Ped = new Entidad.Pedidos();
        N_Pedidos np = new N_Pedidos();
        N_Clientes nc = new N_Clientes();

        public Agregar_Pedido()
        {
            InitializeComponent();
        }

        private string ConstruirMensaje()
        {
            string Mensaje = null;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if ( txtIdCliente.Text != "" && txtCosto.Text != "" && txtTotal.Text != "" && dtpFecha.Text != "")
            { 
            Ped.setCliente(int.Parse(txtIdCliente.Text.ToString()));
            Ped.setCosto(float.Parse(txtCosto.Text.ToString()));
            Ped.setEstado(true);
            Ped.setFecha(dtpFecha.Text.ToString());
            Ped.setPrecioV(float.Parse(txtTotal.Text.ToString()));
            np.datosPed(Ped);
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
            dtpFecha.Text = DateTime.Today.ToString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            GrillaCliente.DataSource = nc.getTabla();
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

        private void GrillaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GrillaCliente.CurrentRow;
            txtIdCliente.Text = (row.Cells[0].Value + " " + row.Cells[1].Value);
        }
    }

}