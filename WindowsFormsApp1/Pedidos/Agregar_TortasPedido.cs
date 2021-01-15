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

namespace WindowsFormsApp1
{
    public partial class Agregar_TortasPedido : Form
    {
        static public DataTable lista = new DataTable();
        static public string CeldaT; /// Guarda el Codigo de Torta
        static public string CeldaC; ///Guarda el Costo de Produccion

        public Agregar_TortasPedido()
        {
            InitializeComponent();
        }

        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (txtPed.Text == "")
            {
                Mensaje = "Numero de Pedido";
            }
            if (txtTorta.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Id Torta";
                }
                else
                {
                    Mensaje += ", Id Torta";
                }
            }
            if (nudCant.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Cantidad";
                }
                else
                {
                    Mensaje += ", Cantidad";
                }
            }
            if (txtVenta.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Precio de Vetna";
                }
                else
                {
                    Mensaje += ", Precio de Venta";
                }

            }
            if (txtCosto.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Costo de Produccion";
                }
                else
                {
                    Mensaje += ", Costo de Produccion";
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

        private void Agregar_TortasPedido_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_TortasPedido TP = new N_TortasPedido();
            txtPed.Text = TP.incremetarPed().ToString();
            lista.Clear();
            GrillaAgregar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // lista.Reset();
            if (lista.Columns.Contains("Nº Pedido") == false)
            {
                lista.Columns.Add("Nº Pedido", typeof(int));
                lista.Columns.Add("Id Torta", typeof(int));
                lista.Columns.Add("Cantidad", typeof(int));
                lista.Columns.Add("Precio", typeof(float));
                lista.Columns.Add("Costo", typeof(float));
            }
            btnAceptar.Enabled = false;
        }

        private void btnTorta_Click(object sender, EventArgs e)
        {
            N_Tortas Tor = new N_Tortas();
            GrillaTorta.DataSource = Tor.getTabla();
            GrillaTorta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrillaTorta.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtPed.Text != "" && txtTorta.Text != "" && txtVenta.Text != "" && nudCant.Text != "" && txtCosto.Text != "")
            {
                foreach (DataRow row in lista.Rows)
                {
                    if (row["Id Torta"].ToString() == txtTorta.Text.ToString())
                    {
                        MessageBox.Show("Ya cargado si quiere ingresar mas cantidad cierre e ingrese de nuevo");
                        return;
                    }
                }
                if (float.Parse(nudCant.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad mayor a 0");
                    return;
                }
                lista.Rows.Add(int.Parse(txtPed.Text.ToString()), int.Parse(txtTorta.Text.ToString()),
                (float.Parse(nudCant.Text)), float.Parse(txtVenta.Text.ToString()), float.Parse(txtCosto.Text.ToString()));
                //MessageBox.Show("Se cargo correctamente");
                GrillaAgregar.DataSource = lista;
                GrillaAgregar.Visible = true;
                GrillaAgregar.DataSource = lista;
                btnAceptar.Visible = true;
                btnAceptar.Enabled = true;
                txtPed.Text = "";
                txtTorta.Text = "";
                nudCant.Text = "0";
                txtVenta.Text = "";
                txtCosto.Text = "";
            }
            else
            {
                Mensaje = ConstruirMensaje();
                MessageBox.Show("Faltan Cargar: " + Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tortas_x_Pedido TP = new Tortas_x_Pedido();
            TP.setCantidad(int.Parse(nudCant.Text.ToString()));
            ///  TP.setCosto(); ///Agregar despues
            TP.setEstado(true);
            TP.setIdPed(int.Parse(txtPed.Text.ToString()));
            TP.setPrecioV(float.Parse(txtVenta.Text.ToString()));
            TP.setTorta(int.Parse(txtTorta.Text.ToString()));
            TP.setTotal(float.Parse(txtCosto.Text.ToString()));
            N_TortasPedido T = new N_TortasPedido();
            T.datosTP(TP);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        private void GrillaTorta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GrillaTorta.CurrentRow;

            CeldaT = Convert.ToString(row.Cells["Id Torta"].Value);
            CeldaC = Convert.ToString(row.Cells["Costo de Produccion"].Value);
            txtTorta.Text = CeldaT;
            txtCosto.Text = CeldaC;
            GrillaTorta.Visible = false;
        }
    }
}
