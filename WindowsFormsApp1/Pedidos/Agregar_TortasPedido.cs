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

        #region Declaraciones

        Genericas gen = new Genericas();
        N_TortasPedido ntp = new N_TortasPedido();
        N_Tortas nt = new N_Tortas();
        Tortas_x_Pedido TP = new Tortas_x_Pedido();
        static public DataTable lista = new DataTable();
        static public string CeldaT; /// Guarda el Codigo de Torta
        static public string CeldaC; ///Guarda el Costo de Produccion

        #endregion

        #region Inicio

        public Agregar_TortasPedido()
        {
            InitializeComponent();
        }

        private void Agregar_TortasPedido_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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

        public void PerimitirDecimales(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirDecimales(sender, e, Texto);
        }

        #endregion

        #region Botones
        private void btnTorta_Click(object sender, EventArgs e)
        {
            GrillaTorta.DataSource = nt.getTabla();
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
            TP.setCantidad(int.Parse(nudCant.Text.ToString()));
            ///  TP.setCosto(); ///Agregar despues
            TP.setEstado(true);
            TP.setIdPed(int.Parse(txtPed.Text.ToString()));
            TP.setPrecioV(float.Parse(txtVenta.Text.ToString()));
            TP.setTorta(int.Parse(txtTorta.Text.ToString()));
            TP.setTotal(float.Parse(txtCosto.Text.ToString()));
            ntp.datosTP(TP);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        #endregion

        #region Eventos

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

        private void GrillaTorta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GrillaTorta.CurrentRow;

            CeldaT = Convert.ToString(row.Cells["Id Torta"].Value);
            CeldaC = Convert.ToString(row.Cells["Costo de Produccion"].Value);
            txtTorta.Text = CeldaT;
            txtCosto.Text = CeldaC;
            GrillaTorta.Visible = false;
        }

        #endregion

    }
}
