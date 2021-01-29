using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
	public partial class Principal : Form
	{

        #region Declaraciones

        private bool EsColapzado;

		#endregion

        #region Inicio
        public Principal()
		{
			InitializeComponent();
            //ColapzarClientes.Start();
            //ColapzarCompras.Start();
            //ColapzarInformes.Start();
            //ColapzarPedidos.Start();
            //ColapzarProducto.Start();
            //ColapzarVentas.Start();
            //ColapzarTortas.Start();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			///Visibilidad de los Paneles
			PanelCompras.Visible = false;
			PanelProd.Visible = false;
			PanelPedidos.Visible = false;
			PanelClientes.Visible = false;
			PanelTortas.Visible = false;
			PanelVentas.Visible = false;
			///Posicion de los Botones
			btnCompras.Location = new Point(5, 30);
			btnProductos.Location = new Point(5, 110);
			btnTortas.Location = new Point(5, 170);
			btnCliente.Location = new Point(5, 230);
			btnPedidos.Location = new Point(5, 290);
			btnVentas.Location = new Point(5, 350);
			///Posicion de los Paneles
			PanelCompras.Location = new Point(5,30);
			PanelProd.Location = new Point(5,110);
			PanelTortas.Location = new Point(5,170);
			PanelClientes.Location = new Point(5,230);
			PanelPedidos.Location = new Point(5,290);
			PanelVentas.Location = new Point(5,350);
			///Imagen de la derecha de los botones
			btnCompras.Iconimage_right = Resources.icons8_más_de_50_2;;
			btnProductos.Iconimage_right = Resources.icons8_más_de_50_2;
			btnPedidos.Iconimage_right = Resources.icons8_más_de_50_2;
			btnCliente.Iconimage_right = Resources.icons8_más_de_50_2;
			btnTortas.Iconimage_right = Resources.icons8_más_de_50_2;
			btnVentas.Iconimage_right = Resources.icons8_más_de_50_2;
		}

        #endregion

        private void AbrirHijo<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Contenedor.Controls.OfType<Forms>().FirstOrDefault();

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
                Contenedor.Controls.Add(formulario);
                Contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //Si el Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }
        
		//private void AbrirHijo(object FormHijo)
        //{
        //	if (this.Contenedor.Controls.Count > 0)
        //		this.Contenedor.Controls.RemoveAt(0);
        //	Form fh = FormHijo as Form;
        //	fh.TopLevel = false;
        //	fh.Dock = DockStyle.Fill;
        //	this.Contenedor.Controls.Add(fh);
        //	this.Contenedor.Tag = fh;
        //	fh.Show();
        //}

		#region Clicks del panel TOP

        private void Salir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Restaurar_Click(object sender, EventArgs e)
		{
			Restaurar.Visible = false;
			WindowState = FormWindowState.Normal;
			Maximizar.Visible = true;
		}

		private void Maximizar_Click(object sender, EventArgs e)
		{
			Restaurar.Visible = true;
			WindowState = FormWindowState.Maximized;
			Maximizar.Visible = false;
		}

		private void minimizar_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void PicMenu_Click(object sender, EventArgs e)
		{
			if(PMenu2.Width == 270)
			{
                Form1_Load(sender, e);
                PMenu2.Visible = false;
				PMenu2.Width = 68;
				PanMenu.Width = 90;
                Contenedor.Location = new Point(90, 80);
                Contenedor.Width = 2588; 
                AnimacionMenu.Show(PMenu2);
            }
			else
			{
				PMenu2.Visible = false;
				PMenu2.Width = 270;
				PanMenu.Width = 300;
                Contenedor.Location = new Point(292, 80);
                Contenedor.Width = 2108;
                AnimacionMenu.Show(PMenu2);
			}
		}

        #endregion

        #region Botones del Panel Menu

        private void btnCompras_Click(object sender, EventArgs e)
		{
			ColapzarCompras.Start();
		}

		private void btnTortas_Click(object sender, EventArgs e)
		{
			ColapzarTortas.Start();
		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			ColapzarProducto.Start();
		}

		private void btnCliente_Click(object sender, EventArgs e)
		{
			ColapzarClientes.Start();
		}

		private void btnPedidos_Click(object sender, EventArgs e)
		{
			ColapzarPedidos.Start();
		}

		private void btnVentas_Click(object sender, EventArgs e)
		{
			ColapzarVentas.Start();
		}

        #endregion

        #region Timers del panel Menu

        private void ColapzarCompras_Tick_1(object sender, EventArgs e)
		{
			if (EsColapzado)
			{
				PanelCompras.Height += 10;
				if (PanelCompras.Size == PanelCompras.MaximumSize)
				{
					Form1_Load(sender, e);
					btnCompras.Iconimage_right = Resources.icons8_menor_que_50;
					PanelCompras.Visible = true;
					ColapzarCompras.Stop();
					EsColapzado = false;
					btnProductos.Location = new Point(5,250);
					btnTortas.Location = new Point(5, 310);
					btnCliente.Location = new Point(5, 370);
					btnPedidos.Location = new Point(5, 430);
					btnVentas.Location = new Point(5, 490);
				}
			}
			else
			{
				btnCompras.Iconimage_right = Resources.icons8_más_de_50_2;
				PanelCompras.Height -= 10;
				if (PanelCompras.Size == PanelCompras.MinimumSize)
				{
					Form1_Load(sender, e);
					ColapzarCompras.Stop();
					EsColapzado = true;
					btnProductos.Location = new Point(5, 107);
					btnTortas.Location = new Point(5, 167);
					btnCliente.Location = new Point(5, 227);
					btnPedidos.Location = new Point(5, 287);
					btnVentas.Location = new Point(5, 347);
				}
			}
		}

		private void ColpazarProducto_Tick(object sender, EventArgs e)
		{
			if (EsColapzado)
			{
				PanelProd.Height += 10;
				if (PanelProd.Size == PanelProd.MaximumSize)
				{
					Form1_Load(sender, e);
					btnProductos.Iconimage_right = Resources.icons8_menor_que_50;
					PanelProd.Visible = true;
					ColapzarProducto.Stop();
					EsColapzado = false;
					PanelProd.Visible = true;
					btnTortas.Location = new Point(5, 400);
					btnCliente.Location = new Point(5, 460);
					btnPedidos.Location = new Point(5, 520);
					btnVentas.Location = new Point(5, 580);
				}
			}
			else
			{
				btnProductos.Iconimage_right = Resources.icons8_más_de_50_2;
				PanelProd.Height -= 10;
				if (PanelProd.Size == PanelProd.MinimumSize)
				{
					//PanelCompras.Visible = true;
					ColapzarProducto.Stop();
					Form1_Load(sender, e);
					EsColapzado = true;
					btnTortas.Location = new Point(5, 167);
					btnCliente.Location = new Point(5, 227);
					btnPedidos.Location = new Point(5, 287);
					btnVentas.Location = new Point(5, 347);
				}
			}
		}

		private void ColapzarTortas_Tick(object sender, EventArgs e)
		{
			if (EsColapzado)
			{
				PanelTortas.Height += 10;
				if (PanelTortas.Size == PanelTortas.MaximumSize)
				{
					Form1_Load(sender, e);
					PanelTortas.Visible = true;
					btnTortas.Iconimage_right = Resources.icons8_menor_que_50;
					ColapzarTortas.Stop();
					EsColapzado = false;
					PanelTortas.Visible = true;
					btnCliente.Location = new Point(5, 460);
					btnPedidos.Location = new Point(5, 520);
					btnVentas.Location = new Point(5, 580);
				}
			}
			else
			{
				btnTortas.Iconimage_right = Resources.icons8_más_de_50_2;
				PanelTortas.Height -= 10;
				if (PanelTortas.Size == PanelTortas.MinimumSize)
				{
					Form1_Load(sender, e);
					ColapzarTortas.Stop();
					EsColapzado = true;
					btnCliente.Location = new Point(5, 230);
					btnPedidos.Location = new Point(5, 290);
					btnVentas.Location = new Point(5, 350);
				}
			}
		}

		private void ColapzarClientes_Tick(object sender, EventArgs e)
		{
			if (EsColapzado)
			{
				
				PanelClientes.Height += 10;
				if (PanelClientes.Size == PanelClientes.MaximumSize)
				{
					Form1_Load(sender, e);
					PanelClientes.Visible = true;
					btnCliente.Iconimage_right = Resources.icons8_menor_que_50;
					ColapzarClientes.Stop();
					EsColapzado = false;
					PanelClientes.Visible = true;
					btnPedidos.Location = new Point(5, 520);
					btnVentas.Location = new Point(5, 580);
				}
			}
			else
			{
				btnCliente.Iconimage_right = Resources.icons8_más_de_50_2;
				PanelClientes.Height -= 10;
				if (PanelClientes.Size == PanelClientes.MinimumSize)
				{
                    Form1_Load(sender, e);
                    ColapzarClientes.Stop();
					EsColapzado = true;
					btnPedidos.Location = new Point(5, 290);
					btnVentas.Location = new Point(5, 350);
				}
			}
		}

		private void ColapzarPedidos_Tick(object sender, EventArgs e)
		{
			if (EsColapzado)
			{
				
				PanelPedidos.Height += 10;
				if (PanelPedidos.Size == PanelPedidos.MaximumSize)
				{
					Form1_Load(sender, e);
					PanelPedidos.Visible = true;
					btnPedidos.Iconimage_right = Resources.icons8_menor_que_50;
					ColapzarPedidos.Stop();
					EsColapzado = false;
					PanelPedidos.Visible = true;
					btnVentas.Location = new Point(5, 590);
				}
			}
			else
			{
				btnPedidos.Iconimage_right = Resources.icons8_más_de_50_2;
				PanelPedidos.Height -= 10;
				if (PanelPedidos.Size == PanelPedidos.MinimumSize)
				{
					Form1_Load(sender, e);
					ColapzarPedidos.Stop();
					EsColapzado = true;
					btnVentas.Location = new Point(5, 350);
				}
			}
		}

		private void ColapzarVentas_Tick(object sender, EventArgs e)
		{
			if (EsColapzado)
			{
				
				PanelVentas.Height += 10;
				if (PanelVentas.Size == PanelVentas.MaximumSize)
				{
					Form1_Load(sender, e);
					PanelVentas.Visible = true;
					btnVentas.Iconimage_right = Resources.icons8_menor_que_50;
					ColapzarVentas.Stop();
					EsColapzado = false;
					PanelVentas.Visible = true;
				}
			}
			else
			{
				btnVentas.Iconimage_right = Resources.icons8_más_de_50_2;
				PanelVentas.Height -= 10;
				if (PanelVentas.Size == PanelVentas.MinimumSize)
				{
					Form1_Load(sender, e);
					ColapzarPedidos.Stop();
					EsColapzado = true;
				}
			}
		}

        #endregion

        #region Click del Panel Compras

        private void btnAgregarCompra_Click(object sender, EventArgs e)
		{
			AbrirHijo<Compras.Agregar_DetalleCompra>();
		}

		private void btnVerCompras_Click(object sender, EventArgs e)
		{
			AbrirHijo<Compras.Ver_Compras>();
		}

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            string Seleccion;
            Carteles.SeleccionarEliminacionCompra form = new Carteles.SeleccionarEliminacionCompra();
            form.ShowDialog();
            Seleccion = form.Seleccion;
            form.Close();
            if (Seleccion == "Compra")
            {
                AbrirHijo<Compras.Eliminar_Compra>();
            }
            else
            {
                if (Seleccion == "Producto")
                {
                    AbrirHijo<Compras.Eliminar_Detalle>();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }


        #endregion

		#region Click en el Panel de Clientes

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AbrirHijo<Clientes.Agregar_Cliente>();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            AbrirHijo<Clientes.VerClientes>();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            AbrirHijo<Clientes.EliminarCliente>();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            AbrirHijo<Clientes.Actualizar_Cliente>();
        }

		#endregion

		#region Clicks en el Panel de Pedidos

		private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            //AbrirHijo<Agregar_TortasPedido>();
            AbrirHijo<Pedidos.Agregar_Pedido>();
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            AbrirHijo<Pedidos.Ver_Pedidos>();

        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            string Seleccion;
            Carteles.SeleccionarEliminacionPedido form = new Carteles.SeleccionarEliminacionPedido();
            form.ShowDialog();
            Seleccion = form.Seleccion;
            form.Close();
            if (Seleccion == "Pedido")
            {
                AbrirHijo<Pedidos.Eliminar_Pedido>();

            }
            else
            {
                if (Seleccion == "Torta")
                {
                    AbrirHijo<Pedidos.Eliminar_TortasPedido>();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnActulizarPedido_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Clicks en el Panel de Productos

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            AbrirHijo<Mercaderia.Agregar_Mercaderia>();
        }

        private void btnVerProducto_Click(object sender, EventArgs e)
        {
            AbrirHijo<Mercaderia.Ver_Mercaderia>();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            AbrirHijo<Mercaderia.Eliminar_Mercaderia>();
        }

        private void btnActualizarProd_Click(object sender, EventArgs e)
        {

        }

        #endregion

		#region Clicks en el Panel de Tortas

        private void btnAgregarTorta_Click(object sender, EventArgs e)
        {
            AbrirHijo<Tortas.Agregar_Ingredientes>();
        }

        private void btnVerTortas_Click(object sender, EventArgs e)
        {
            AbrirHijo<Tortas.Ver_Tortas>();

        }

        private void btnEliminarTorta_Click(object sender, EventArgs e)
        {
            string Seleccion;
            Carteles.SeleccionarFormulario form = new Carteles.SeleccionarFormulario();
            form.ShowDialog();
            Seleccion = form.Seleccion;
            form.Close();
            if (Seleccion == "Torta")
            {
                AbrirHijo<Tortas.Eliminar_Torta>();
            }
            else
            {
                if (Seleccion == "Ingrediente")
                {
                    AbrirHijo<Tortas.Eliminar_Ingrediente>();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnActualizarTorta_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Clicks en el Panel de Ventas

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            AbrirHijo<Ventas.Agregar_Venta>();
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            AbrirHijo<Ventas.Ver_Ventas>();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            AbrirHijo<Ventas.Eliminar_Venta>();
        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
