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

namespace WindowsFormsApp1.Compras
{

    public partial class Agregar_DetalleCompra : Form
	{

        #region Declaraciones

        public DataTable lista = new DataTable();
        static public bool var = new bool();
        static public bool Coma = new bool();
        static public bool Punto = new bool();
        static public string Celda;
        static public string Unidad;
        N_DetalleCompra dc = new N_DetalleCompra();
        N_Producto NP = new N_Producto();
        Genericas gen = new Genericas();

        #endregion

        #region Inicio

        public Agregar_DetalleCompra()
		{
			InitializeComponent();
		}
        
        private void Agregar_DetalleCompra_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            lista.Clear();
            GrillaAgregar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // lista.Reset();
            if (lista.Columns.Contains("Nº Compra") == false)
            {
                lista.Columns.Add("Nº Compra", typeof(int));
                lista.Columns.Add("Id Producto", typeof(int));
                lista.Columns.Add("Cantidad", typeof(float));
                lista.Columns.Add("Precio", typeof(float));
            }
            btnAceptar.Enabled = false;
            if (var == false)
            {
                //    btnfact.Visible = false;
            }
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

        private void txtPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            PerimitirDecimales(sender, e, txtPU.Text);
        }

        private void nudCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            PerimitirDecimales(sender, e, nudCant.Value.ToString());
        }

        #endregion

        #region Botones

        private void btnMercaderia_Click(object sender, EventArgs e)
        {

            GrillaProd.DefaultCellStyle.ForeColor = Color.White;
            GrillaProd.DefaultCellStyle.BackColor = Color.FromArgb(30,30,46);
            GrillaProd.BackgroundColor = Color.FromArgb(30, 30, 46);
            GrillaProd.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaProd.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(168, 21, 80);
            GrillaProd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrillaProd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(168, 21, 80);
            GrillaProd.DataSource = NP.getTablaProCom();
            GrillaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrillaProd.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            N_DetalleCompra DC = new N_DetalleCompra();
            //  CerrarForm.Start();
            AbrirHijo<Agregar_Compra>();
            /*while (HijoAbierto<Agregar_Compra>() == true)
             {
                 //DC.datosDC(lista);
             }
            */
            /*  AC.MdiParent = this.MdiParent;
              AC.Show();
              MessageBox.Show("xd");
              */
            // btnAceptar.Enabled = false;
            //  this.Close();
          //  this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Mensaje;
            if (NroCompra.Text != "" && txtIdProd.Text != "" && txtPU.Text != "" && nudCant.Text != "")
            {
                foreach (DataRow row in lista.Rows)
                {
                    if (row["Id producto"].ToString() == txtIdProd.Text.ToString())
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
                lista.Rows.Add(int.Parse(NroCompra.Text.ToString()), int.Parse(txtIdProd.Text.ToString()),
                (float.Parse(nudCant.Text)), float.Parse(txtPU.Text.ToString()));
                //MessageBox.Show("Se cargo correctamente");
                GrillaAgregar.DataSource = lista;
                GrillaAgregar.Visible = true;
                GrillaAgregar.DataSource = lista;
                btnAceptar.Visible = true;
                btnAceptar.Enabled = true;
                txtIdProd.Text = "";
                txtPU.Text = "";
                nudCant.Text = "0,0";
            }
            else
            {
                Mensaje = ConstruirMensaje();
                MessageBox.Show("Faltan Cargar: " + Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        #endregion

        #region Eventos

        private string ConstruirMensaje()
        {
            string Mensaje = null;
            if (NroCompra.Text == "")
            {
                Mensaje = "Numero de Compra";
            }
            if (txtIdProd.Text == "")
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
            if (txtPU.Text == "")
            {
                if (Mensaje == null)
                {
                    Mensaje = "Precio Unitario";
                }
                else
                {
                    Mensaje += ", Precio Unitario";
                }

            }
            return Mensaje;
        }

        private void AbrirHijo<Forms>() where Forms : Form, new()
        {
            Agregar_Compra formulario = new Agregar_Compra();
            // formulario = Controls.OfType<Agregar_Compra>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            //   if (formulario == null)
            // {
           // formulario = new Agregar_Compra();
            formulario.TopLevel = false;
            //   formulario.Dock = DockStyle.Fill;
            formulario.Anchor = AnchorStyles.Bottom;
            formulario.Anchor = AnchorStyles.Left;
            formulario.Anchor = AnchorStyles.Right;
            formulario.Anchor = AnchorStyles.Top;
            Controls.Add(formulario);
            Tag = formulario;
            formulario.lista = lista;
            formulario.x(lista);
            formulario.Show();
            formulario.BringToFront();

            // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            /*   }
               else
               {

                   //Si el Formulario/instancia existe, lo traemos a frente
                   formulario.BringToFront();

                   //Si la instancia esta minimizada mostramos
                   if (formulario.WindowState == FormWindowState.Minimized)
                   {
                       formulario.WindowState = FormWindowState.Normal;
                   }

               }*/
        }

        private bool HijoAbierto<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                MessageBox.Show("No Existe");
                return false;
            }
            else
            {
                //Si el Formulario/instancia existe, lo traemos a frente
                return true;
            }
        }

        private void GrillaProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GrillaProd.CurrentRow;

            Celda = Convert.ToString(row.Cells["Id Producto"].Value);
            txtIdProd.Text = Celda;
            GrillaProd.Visible = false;
            //Unidad = NP.Unidad(int.Parse(txtIdProd.Text.ToString()));
         /*   if(Unidad == "Unidad")
            {
                nudCant.DecimalPlaces = 0;
                nudCant.Increment = 1;
            }
            else
            {
                nudCant.DecimalPlaces = 1;
                nudCant.Increment = 0.1m;
            }*/
        }

        private void CerrarForm_Tick(object sender, EventArgs e)
        {
                CerrarForm.Stop();
                btnAceptar.Enabled = false;
                this.Close();
        }

        #endregion
    }
}
