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
	public partial class Agregar_Compra : Form
	{

        #region Declaraciones

        public DataTable lista = new DataTable();
        Genericas gen = new Genericas();
        static public float Total = new float();

        #endregion

        #region Inicio

        public Agregar_Compra()
		{
			InitializeComponent();
		}

        private void Agregar_Compra_Load(object sender, EventArgs e)
        {
            Total = 0;
            float Cantidad = 0;
            float Precio = 0;
            this.Dock = DockStyle.Fill;
            N_Compras Com = new N_Compras();
            NroCompra.Enabled = false;
            dtpFecha.Text = DateTime.Today.ToString();
            txtTotal.Enabled = false;
            if (lista.Columns.Contains("Nº Compra") == false)
            {
                lista.Columns.Add("Nº Compra", typeof(int));
                lista.Columns.Add("Id Producto", typeof(int));
                lista.Columns.Add("Cantidad", typeof(float));
                lista.Columns.Add("Precio", typeof(float));
            }
            GrillaCompra.DataSource = lista;
            foreach (DataRow row in lista.Rows)
            {
                Cantidad = float.Parse(row["Cantidad"].ToString());
                Precio = float.Parse(row["Precio"].ToString());
                Total += Precio * Cantidad;
            }
            txtTotal.Text = Total.ToString();
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
    //        AbrirHijo<Compras.Agregar_DetalleCompra>();

              string Mensaje;
            /*    if (txtTotal.Text != "" && dtpFecha.Text != "")
                {
                  Entidad.Compras Com = new Entidad.Compras();
                  Com.setEstado(true);
                  Com.setFactura(int.Parse(NroCompra.Text.ToString()));
                  Com.setFecha(dtpFecha.Text.ToString());
                  Com.setTotal(float.Parse(txtTotal.Text.ToString()));
                  N_Compras C = new N_Compras();
                  N_DetalleCompra DC = new N_DetalleCompra();
                  C.datosCom(Com);
                  DC.datosDC(lista);
                  btnAceptar.Enabled = false;
                  this.Close();
                }
                else
                {
                  Mensaje = ConstruirMensaje();
                  MessageBox.Show("Faltan Cargar: " + Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }*/

            btnAceptar.Enabled = false;
            this.Close();
        }
        #endregion

        #region Eventos

        private void AbrirHijo<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //   formulario.Dock = DockStyle.Fill;
                formulario.Anchor = AnchorStyles.Bottom;
                formulario.Anchor = AnchorStyles.Left;
                formulario.Anchor = AnchorStyles.Right;
                formulario.Anchor = AnchorStyles.Top;
                Controls.Add(formulario);
                Tag = formulario;
                formulario.Close();

                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //Si el Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();
                formulario.Close();
                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (NroCompra.Text == "")
            {
                Mensaje = "Compra";
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

        #endregion

    }
}
