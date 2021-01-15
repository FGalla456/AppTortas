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

namespace WindowsFormsApp1.Tortas
{
    public partial class Agregar_Ingredientes : Form
    {
        static public DataTable lista = new DataTable();
        static public string Celda;
        static public string Unidad;

        public Agregar_Ingredientes()
        {
            InitializeComponent();
        }

        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (txtTorta.Text == "")
            {
                Mensaje = "Id Torta";
            }
            if (txtProd.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Id Producto";
                }
                else
                {
                    Mensaje += ", Id Producto";
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

        private void Agregar_Ingredientes_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_IngredienteTorta IT = new N_IngredienteTorta();
            txtTorta.Text = IT.incremetarIng().ToString();
            lista.Clear();
            GrillaAgregar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // lista.Reset();
            if (lista.Columns.Contains("Id Torta") == false)
            {
                lista.Columns.Add("Id Torta", typeof(int));
                lista.Columns.Add("Id Producto", typeof(int));
                lista.Columns.Add("Cantidad", typeof(float));
                lista.Columns.Add("Costo", typeof(float));
            }
            btnAceptar.Enabled = false;
        }

        private void btnMercaderia_Click(object sender, EventArgs e)
        {
            N_Mercaderia Mer = new N_Mercaderia();
            GrillaProd.DataSource = Mer.getTablaMerCom();
            GrillaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrillaProd.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (txtProd.Text != "" && txtTorta.Text != "" && nudCant.Text != "" && txtCosto.Text != "")
            {
                foreach (DataRow row in lista.Rows)
                {
                    if (row["Id Producto"].ToString() == txtTorta.Text.ToString())
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
                lista.Rows.Add(int.Parse(txtTorta.Text.ToString()), int.Parse(txtProd.Text.ToString()),
                (float.Parse(nudCant.Text)), float.Parse(txtCosto.Text.ToString()));
                //MessageBox.Show("Se cargo correctamente");
                GrillaAgregar.DataSource = lista;
                GrillaAgregar.Visible = true;
                GrillaAgregar.DataSource = lista;
                btnAceptar.Visible = true;
                btnAceptar.Enabled = true;
                txtTorta.Text = "";
                txtProd.Text = "";
                nudCant.Text = "0";
                txtCosto.Text = "";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ingredientes_x_Torta IT = new Ingredientes_x_Torta();
            IT.setCantidad(float.Parse(nudCant.Text.ToString()));
            IT.setCosto(float.Parse(txtCosto.Text.ToString()));
            IT.setEstado(true);
            IT.setIdMer(int.Parse(txtProd.Text.ToString()));
            IT.setTorta(int.Parse(txtTorta.Text.ToString()));
            N_IngredienteTorta Ing = new N_IngredienteTorta();
            Ing.datosIng(IT);
        }

        private void GrillaProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GrillaProd.CurrentRow;

            Celda = Convert.ToString(row.Cells["Id Producto"].Value);
            txtProd.Text = Celda;
            GrillaProd.Visible = false;
            N_Mercaderia Mer = new N_Mercaderia();
            Unidad = Mer.Unidad(int.Parse(txtProd.Text.ToString()));
            if (Unidad == "Unidad")
            {
                nudCant.DecimalPlaces = 0;
                nudCant.Increment = 1;
            }
            else
            {
                nudCant.DecimalPlaces = 1;
                nudCant.Increment = 0.1m;
            }
        }

    }
}
