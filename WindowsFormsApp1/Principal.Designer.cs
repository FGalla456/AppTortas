namespace WindowsFormsApp1
{
	partial class Principal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.Label();
            this.PicMenu = new System.Windows.Forms.PictureBox();
            this.PanMenu = new System.Windows.Forms.Panel();
            this.PMenu2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPedidos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTortas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelCompras = new System.Windows.Forms.Panel();
            this.btnVerCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarCompra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarCompra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelClientes = new System.Windows.Forms.Panel();
            this.btnActualizarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelPedidos = new System.Windows.Forms.Panel();
            this.btnActulizarPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerPedidos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelVentas = new System.Windows.Forms.Panel();
            this.btnActualizarVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelProd = new System.Windows.Forms.Panel();
            this.btnActualizarProd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarProd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelTortas = new System.Windows.Forms.Panel();
            this.btnActualizarTorta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerTortas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarTorta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarTorta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.CurvaTabla = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionMenu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ColapzarCompras = new System.Windows.Forms.Timer(this.components);
            this.ColapzarProducto = new System.Windows.Forms.Timer(this.components);
            this.ColapzarTortas = new System.Windows.Forms.Timer(this.components);
            this.ColapzarClientes = new System.Windows.Forms.Timer(this.components);
            this.ColapzarPedidos = new System.Windows.Forms.Timer(this.components);
            this.ColapzarVentas = new System.Windows.Forms.Timer(this.components);
            this.ColapzarInformes = new System.Windows.Forms.Timer(this.components);
            this.MoverTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).BeginInit();
            this.PanMenu.SuspendLayout();
            this.PMenu2.SuspendLayout();
            this.PanelCompras.SuspendLayout();
            this.PanelClientes.SuspendLayout();
            this.PanelPedidos.SuspendLayout();
            this.PanelVentas.SuspendLayout();
            this.PanelProd.SuspendLayout();
            this.PanelTortas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTop
            // 
            this.PTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PTop.Controls.Add(this.Restaurar);
            this.PTop.Controls.Add(this.Minimizar);
            this.PTop.Controls.Add(this.Maximizar);
            this.PTop.Controls.Add(this.Salir);
            this.PTop.Controls.Add(this.L1);
            this.PTop.Controls.Add(this.PicMenu);
            this.PTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnimacionMenu.SetDecoration(this.PTop, BunifuAnimatorNS.DecorationType.None);
            this.PTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTop.Location = new System.Drawing.Point(0, 0);
            this.PTop.Name = "PTop";
            this.PTop.Size = new System.Drawing.Size(1400, 80);
            this.PTop.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionMenu.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1322, 29);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionMenu.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1286, 29);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionMenu.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1322, 29);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionMenu.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1358, 29);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.AnimacionMenu.SetDecoration(this.L1, BunifuAnimatorNS.DecorationType.None);
            this.L1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(82, 33);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(57, 23);
            this.L1.TabIndex = 1;
            this.L1.Text = "Menú";
            // 
            // PicMenu
            // 
            this.PicMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.PicMenu, BunifuAnimatorNS.DecorationType.None);
            this.PicMenu.Image = ((System.Drawing.Image)(resources.GetObject("PicMenu.Image")));
            this.PicMenu.Location = new System.Drawing.Point(34, 29);
            this.PicMenu.Name = "PicMenu";
            this.PicMenu.Size = new System.Drawing.Size(30, 30);
            this.PicMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMenu.TabIndex = 0;
            this.PicMenu.TabStop = false;
            this.PicMenu.Click += new System.EventHandler(this.PicMenu_Click);
            // 
            // PanMenu
            // 
            this.PanMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanMenu.Controls.Add(this.PMenu2);
            this.AnimacionMenu.SetDecoration(this.PanMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanMenu.Location = new System.Drawing.Point(0, 80);
            this.PanMenu.Name = "PanMenu";
            this.PanMenu.Size = new System.Drawing.Size(293, 820);
            this.PanMenu.TabIndex = 1;
            // 
            // PMenu2
            // 
            this.PMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PMenu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PMenu2.BackgroundImage")));
            this.PMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PMenu2.Controls.Add(this.btnCompras);
            this.PMenu2.Controls.Add(this.btnProductos);
            this.PMenu2.Controls.Add(this.btnVentas);
            this.PMenu2.Controls.Add(this.btnPedidos);
            this.PMenu2.Controls.Add(this.btnCliente);
            this.PMenu2.Controls.Add(this.btnTortas);
            this.PMenu2.Controls.Add(this.PanelCompras);
            this.PMenu2.Controls.Add(this.PanelClientes);
            this.PMenu2.Controls.Add(this.PanelPedidos);
            this.PMenu2.Controls.Add(this.PanelVentas);
            this.PMenu2.Controls.Add(this.PanelProd);
            this.PMenu2.Controls.Add(this.PanelTortas);
            this.AnimacionMenu.SetDecoration(this.PMenu2, BunifuAnimatorNS.DecorationType.None);
            this.PMenu2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PMenu2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PMenu2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PMenu2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PMenu2.Location = new System.Drawing.Point(13, 25);
            this.PMenu2.Name = "PMenu2";
            this.PMenu2.Quality = 10;
            this.PMenu2.Size = new System.Drawing.Size(270, 783);
            this.PMenu2.TabIndex = 0;
            // 
            // btnCompras
            // 
            this.btnCompras.Activecolor = System.Drawing.Color.Transparent;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.BorderRadius = 0;
            this.btnCompras.ButtonText = "      COMPRAS";
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnCompras, BunifuAnimatorNS.DecorationType.None);
            this.btnCompras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompras.Iconimage")));
            this.btnCompras.Iconimage_right = global::WindowsFormsApp1.Properties.Resources.icons8_más_de_50_2;
            this.btnCompras.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnCompras.Iconimage_Selected = null;
            this.btnCompras.IconMarginLeft = 0;
            this.btnCompras.IconMarginRight = 0;
            this.btnCompras.IconRightVisible = true;
            this.btnCompras.IconRightZoom = 0D;
            this.btnCompras.IconVisible = true;
            this.btnCompras.IconZoom = 90D;
            this.btnCompras.IsTab = false;
            this.btnCompras.Location = new System.Drawing.Point(5, 28);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompras.selected = false;
            this.btnCompras.Size = new System.Drawing.Size(262, 53);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "      COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Textcolor = System.Drawing.Color.White;
            this.btnCompras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Activecolor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.ButtonText = "      PRODUCTOS";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnProductos, BunifuAnimatorNS.DecorationType.None);
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage")));
            this.btnProductos.Iconimage_right = global::WindowsFormsApp1.Properties.Resources.icons8_más_de_50_2;
            this.btnProductos.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnProductos.Iconimage_Selected = null;
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 90D;
            this.btnProductos.IsTab = false;
            this.btnProductos.Location = new System.Drawing.Point(4, 117);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(261, 51);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "      PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Textcolor = System.Drawing.Color.White;
            this.btnProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "      VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = global::WindowsFormsApp1.Properties.Resources.icons8_más_de_50_2;
            this.btnVentas.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 90D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(11, 398);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(252, 54);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "      VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Activecolor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.BorderRadius = 0;
            this.btnPedidos.ButtonText = "      PEDIDOS";
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnPedidos, BunifuAnimatorNS.DecorationType.None);
            this.btnPedidos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPedidos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPedidos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Iconimage")));
            this.btnPedidos.Iconimage_right = global::WindowsFormsApp1.Properties.Resources.icons8_más_de_50_2;
            this.btnPedidos.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnPedidos.Iconimage_Selected = null;
            this.btnPedidos.IconMarginLeft = 0;
            this.btnPedidos.IconMarginRight = 0;
            this.btnPedidos.IconRightVisible = true;
            this.btnPedidos.IconRightZoom = 0D;
            this.btnPedidos.IconVisible = true;
            this.btnPedidos.IconZoom = 90D;
            this.btnPedidos.IsTab = false;
            this.btnPedidos.Location = new System.Drawing.Point(11, 327);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPedidos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPedidos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPedidos.selected = false;
            this.btnPedidos.Size = new System.Drawing.Size(252, 54);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "      PEDIDOS";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Textcolor = System.Drawing.Color.White;
            this.btnPedidos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.Transparent;
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "      CLIENTES";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCliente.Iconimage")));
            this.btnCliente.Iconimage_right = global::WindowsFormsApp1.Properties.Resources.icons8_más_de_50_2;
            this.btnCliente.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 0;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = true;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 90D;
            this.btnCliente.IsTab = false;
            this.btnCliente.Location = new System.Drawing.Point(11, 261);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(252, 55);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "      CLIENTES";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnTortas
            // 
            this.btnTortas.Activecolor = System.Drawing.Color.Transparent;
            this.btnTortas.BackColor = System.Drawing.Color.Transparent;
            this.btnTortas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTortas.BorderRadius = 0;
            this.btnTortas.ButtonText = "      TORTAS";
            this.btnTortas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnTortas, BunifuAnimatorNS.DecorationType.None);
            this.btnTortas.DisabledColor = System.Drawing.Color.Gray;
            this.btnTortas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTortas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTortas.Iconimage")));
            this.btnTortas.Iconimage_right = global::WindowsFormsApp1.Properties.Resources.icons8_más_de_50_2;
            this.btnTortas.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnTortas.Iconimage_Selected = null;
            this.btnTortas.IconMarginLeft = 0;
            this.btnTortas.IconMarginRight = 0;
            this.btnTortas.IconRightVisible = true;
            this.btnTortas.IconRightZoom = 0D;
            this.btnTortas.IconVisible = true;
            this.btnTortas.IconZoom = 90D;
            this.btnTortas.IsTab = false;
            this.btnTortas.Location = new System.Drawing.Point(11, 194);
            this.btnTortas.Name = "btnTortas";
            this.btnTortas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTortas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnTortas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTortas.selected = false;
            this.btnTortas.Size = new System.Drawing.Size(252, 54);
            this.btnTortas.TabIndex = 2;
            this.btnTortas.Text = "      TORTAS";
            this.btnTortas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTortas.Textcolor = System.Drawing.Color.White;
            this.btnTortas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTortas.Click += new System.EventHandler(this.btnTortas_Click);
            // 
            // PanelCompras
            // 
            this.PanelCompras.BackColor = System.Drawing.Color.Transparent;
            this.PanelCompras.Controls.Add(this.btnVerCompras);
            this.PanelCompras.Controls.Add(this.btnEliminarCompra);
            this.PanelCompras.Controls.Add(this.btnAgregarCompra);
            this.AnimacionMenu.SetDecoration(this.PanelCompras, BunifuAnimatorNS.DecorationType.None);
            this.PanelCompras.Location = new System.Drawing.Point(2, 28);
            this.PanelCompras.MaximumSize = new System.Drawing.Size(270, 225);
            this.PanelCompras.MinimumSize = new System.Drawing.Size(270, 65);
            this.PanelCompras.Name = "PanelCompras";
            this.PanelCompras.Size = new System.Drawing.Size(270, 65);
            this.PanelCompras.TabIndex = 0;
            // 
            // btnVerCompras
            // 
            this.btnVerCompras.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnVerCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerCompras.BorderRadius = 0;
            this.btnVerCompras.ButtonText = "      VER COMPRAS";
            this.btnVerCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnVerCompras, BunifuAnimatorNS.DecorationType.None);
            this.btnVerCompras.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerCompras.Iconimage")));
            this.btnVerCompras.Iconimage_right = null;
            this.btnVerCompras.Iconimage_right_Selected = null;
            this.btnVerCompras.Iconimage_Selected = null;
            this.btnVerCompras.IconMarginLeft = 0;
            this.btnVerCompras.IconMarginRight = 0;
            this.btnVerCompras.IconRightVisible = true;
            this.btnVerCompras.IconRightZoom = 0D;
            this.btnVerCompras.IconVisible = true;
            this.btnVerCompras.IconZoom = 90D;
            this.btnVerCompras.IsTab = false;
            this.btnVerCompras.Location = new System.Drawing.Point(21, 166);
            this.btnVerCompras.Name = "btnVerCompras";
            this.btnVerCompras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerCompras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVerCompras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerCompras.selected = false;
            this.btnVerCompras.Size = new System.Drawing.Size(240, 51);
            this.btnVerCompras.TabIndex = 3;
            this.btnVerCompras.Text = "      VER COMPRAS";
            this.btnVerCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCompras.Textcolor = System.Drawing.Color.White;
            this.btnVerCompras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCompras.Click += new System.EventHandler(this.btnVerCompras_Click);
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCompra.BorderRadius = 0;
            this.btnEliminarCompra.ButtonText = "      ELIMINAR COMPRA";
            this.btnEliminarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnEliminarCompra, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminarCompra.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompra.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarCompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCompra.Iconimage")));
            this.btnEliminarCompra.Iconimage_right = null;
            this.btnEliminarCompra.Iconimage_right_Selected = null;
            this.btnEliminarCompra.Iconimage_Selected = null;
            this.btnEliminarCompra.IconMarginLeft = 0;
            this.btnEliminarCompra.IconMarginRight = 0;
            this.btnEliminarCompra.IconRightVisible = true;
            this.btnEliminarCompra.IconRightZoom = 0D;
            this.btnEliminarCompra.IconVisible = true;
            this.btnEliminarCompra.IconZoom = 90D;
            this.btnEliminarCompra.IsTab = false;
            this.btnEliminarCompra.Location = new System.Drawing.Point(23, 114);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarCompra.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEliminarCompra.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarCompra.selected = false;
            this.btnEliminarCompra.Size = new System.Drawing.Size(240, 47);
            this.btnEliminarCompra.TabIndex = 2;
            this.btnEliminarCompra.Text = "      ELIMINAR COMPRA";
            this.btnEliminarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCompra.Textcolor = System.Drawing.Color.White;
            this.btnEliminarCompra.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompra.Click += new System.EventHandler(this.btnEliminarCompra_Click);
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCompra.BorderRadius = 0;
            this.btnAgregarCompra.ButtonText = "      NUEVA COMPRA";
            this.btnAgregarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnAgregarCompra, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregarCompra.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCompra.Iconimage")));
            this.btnAgregarCompra.Iconimage_right = null;
            this.btnAgregarCompra.Iconimage_right_Selected = null;
            this.btnAgregarCompra.Iconimage_Selected = null;
            this.btnAgregarCompra.IconMarginLeft = 0;
            this.btnAgregarCompra.IconMarginRight = 0;
            this.btnAgregarCompra.IconRightVisible = true;
            this.btnAgregarCompra.IconRightZoom = 0D;
            this.btnAgregarCompra.IconVisible = true;
            this.btnAgregarCompra.IconZoom = 90D;
            this.btnAgregarCompra.IsTab = false;
            this.btnAgregarCompra.Location = new System.Drawing.Point(22, 62);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCompra.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregarCompra.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarCompra.selected = false;
            this.btnAgregarCompra.Size = new System.Drawing.Size(239, 51);
            this.btnAgregarCompra.TabIndex = 1;
            this.btnAgregarCompra.Text = "      NUEVA COMPRA";
            this.btnAgregarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCompra.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCompra.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // PanelClientes
            // 
            this.PanelClientes.BackColor = System.Drawing.Color.Transparent;
            this.PanelClientes.Controls.Add(this.btnActualizarCliente);
            this.PanelClientes.Controls.Add(this.btnVerClientes);
            this.PanelClientes.Controls.Add(this.btnAgregarCliente);
            this.PanelClientes.Controls.Add(this.btnEliminarCliente);
            this.AnimacionMenu.SetDecoration(this.PanelClientes, BunifuAnimatorNS.DecorationType.None);
            this.PanelClientes.Location = new System.Drawing.Point(2, 254);
            this.PanelClientes.MaximumSize = new System.Drawing.Size(270, 285);
            this.PanelClientes.MinimumSize = new System.Drawing.Size(270, 65);
            this.PanelClientes.Name = "PanelClientes";
            this.PanelClientes.Size = new System.Drawing.Size(270, 65);
            this.PanelClientes.TabIndex = 6;
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Activecolor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarCliente.BorderRadius = 0;
            this.btnActualizarCliente.ButtonText = "      ACTUALIZAR CLIENTE";
            this.btnActualizarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnActualizarCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnActualizarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizarCliente.Iconimage")));
            this.btnActualizarCliente.Iconimage_right = null;
            this.btnActualizarCliente.Iconimage_right_Selected = null;
            this.btnActualizarCliente.Iconimage_Selected = null;
            this.btnActualizarCliente.IconMarginLeft = 0;
            this.btnActualizarCliente.IconMarginRight = 0;
            this.btnActualizarCliente.IconRightVisible = true;
            this.btnActualizarCliente.IconRightZoom = 0D;
            this.btnActualizarCliente.IconVisible = true;
            this.btnActualizarCliente.IconZoom = 90D;
            this.btnActualizarCliente.IsTab = false;
            this.btnActualizarCliente.Location = new System.Drawing.Point(22, 111);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizarCliente.selected = false;
            this.btnActualizarCliente.Size = new System.Drawing.Size(240, 51);
            this.btnActualizarCliente.TabIndex = 2;
            this.btnActualizarCliente.Text = "      ACTUALIZAR CLIENTE";
            this.btnActualizarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCliente.Textcolor = System.Drawing.Color.White;
            this.btnActualizarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnVerClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerClientes.BorderRadius = 0;
            this.btnVerClientes.ButtonText = "      VER CLIENTES";
            this.btnVerClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnVerClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnVerClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerClientes.Iconimage")));
            this.btnVerClientes.Iconimage_right = null;
            this.btnVerClientes.Iconimage_right_Selected = null;
            this.btnVerClientes.Iconimage_Selected = null;
            this.btnVerClientes.IconMarginLeft = 0;
            this.btnVerClientes.IconMarginRight = 0;
            this.btnVerClientes.IconRightVisible = true;
            this.btnVerClientes.IconRightZoom = 0D;
            this.btnVerClientes.IconVisible = true;
            this.btnVerClientes.IconZoom = 90D;
            this.btnVerClientes.IsTab = false;
            this.btnVerClientes.Location = new System.Drawing.Point(24, 225);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerClientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVerClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerClientes.selected = false;
            this.btnVerClientes.Size = new System.Drawing.Size(240, 51);
            this.btnVerClientes.TabIndex = 4;
            this.btnVerClientes.Text = "      VER CLIENTES";
            this.btnVerClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerClientes.Textcolor = System.Drawing.Color.White;
            this.btnVerClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCliente.BorderRadius = 0;
            this.btnAgregarCliente.ButtonText = "      NUEVO CLIENTE";
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnAgregarCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Iconimage")));
            this.btnAgregarCliente.Iconimage_right = null;
            this.btnAgregarCliente.Iconimage_right_Selected = null;
            this.btnAgregarCliente.Iconimage_Selected = null;
            this.btnAgregarCliente.IconMarginLeft = 0;
            this.btnAgregarCliente.IconMarginRight = 0;
            this.btnAgregarCliente.IconRightVisible = true;
            this.btnAgregarCliente.IconRightZoom = 0D;
            this.btnAgregarCliente.IconVisible = true;
            this.btnAgregarCliente.IconZoom = 90D;
            this.btnAgregarCliente.IsTab = false;
            this.btnAgregarCliente.Location = new System.Drawing.Point(23, 60);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarCliente.selected = false;
            this.btnAgregarCliente.Size = new System.Drawing.Size(239, 51);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "      NUEVO CLIENTE";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCliente.BorderRadius = 0;
            this.btnEliminarCliente.ButtonText = "      ELIMINAR CLIENTE";
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnEliminarCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Iconimage")));
            this.btnEliminarCliente.Iconimage_right = null;
            this.btnEliminarCliente.Iconimage_right_Selected = null;
            this.btnEliminarCliente.Iconimage_Selected = null;
            this.btnEliminarCliente.IconMarginLeft = 0;
            this.btnEliminarCliente.IconMarginRight = 0;
            this.btnEliminarCliente.IconRightVisible = true;
            this.btnEliminarCliente.IconRightZoom = 0D;
            this.btnEliminarCliente.IconVisible = true;
            this.btnEliminarCliente.IconZoom = 90D;
            this.btnEliminarCliente.IsTab = false;
            this.btnEliminarCliente.Location = new System.Drawing.Point(24, 168);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarCliente.selected = false;
            this.btnEliminarCliente.Size = new System.Drawing.Size(240, 51);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "      ELIMINAR CLIENTE";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Textcolor = System.Drawing.Color.White;
            this.btnEliminarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // PanelPedidos
            // 
            this.PanelPedidos.BackColor = System.Drawing.Color.Transparent;
            this.PanelPedidos.Controls.Add(this.btnActulizarPedido);
            this.PanelPedidos.Controls.Add(this.btnVerPedidos);
            this.PanelPedidos.Controls.Add(this.btnAgregarPedido);
            this.PanelPedidos.Controls.Add(this.btnEliminarPedido);
            this.AnimacionMenu.SetDecoration(this.PanelPedidos, BunifuAnimatorNS.DecorationType.None);
            this.PanelPedidos.Location = new System.Drawing.Point(0, 325);
            this.PanelPedidos.MaximumSize = new System.Drawing.Size(270, 285);
            this.PanelPedidos.MinimumSize = new System.Drawing.Size(270, 65);
            this.PanelPedidos.Name = "PanelPedidos";
            this.PanelPedidos.Size = new System.Drawing.Size(270, 65);
            this.PanelPedidos.TabIndex = 6;
            // 
            // btnActulizarPedido
            // 
            this.btnActulizarPedido.Activecolor = System.Drawing.Color.Transparent;
            this.btnActulizarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnActulizarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActulizarPedido.BorderRadius = 0;
            this.btnActulizarPedido.ButtonText = "      ACTUALIZAR PEDIDO";
            this.btnActulizarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnActulizarPedido, BunifuAnimatorNS.DecorationType.None);
            this.btnActulizarPedido.DisabledColor = System.Drawing.Color.Gray;
            this.btnActulizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizarPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActulizarPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActulizarPedido.Iconimage")));
            this.btnActulizarPedido.Iconimage_right = null;
            this.btnActulizarPedido.Iconimage_right_Selected = null;
            this.btnActulizarPedido.Iconimage_Selected = null;
            this.btnActulizarPedido.IconMarginLeft = 0;
            this.btnActulizarPedido.IconMarginRight = 0;
            this.btnActulizarPedido.IconRightVisible = true;
            this.btnActulizarPedido.IconRightZoom = 0D;
            this.btnActulizarPedido.IconVisible = true;
            this.btnActulizarPedido.IconZoom = 90D;
            this.btnActulizarPedido.IsTab = false;
            this.btnActulizarPedido.Location = new System.Drawing.Point(22, 111);
            this.btnActulizarPedido.Name = "btnActulizarPedido";
            this.btnActulizarPedido.Normalcolor = System.Drawing.Color.Transparent;
            this.btnActulizarPedido.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnActulizarPedido.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActulizarPedido.selected = false;
            this.btnActulizarPedido.Size = new System.Drawing.Size(240, 51);
            this.btnActulizarPedido.TabIndex = 2;
            this.btnActulizarPedido.Text = "      ACTUALIZAR PEDIDO";
            this.btnActulizarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActulizarPedido.Textcolor = System.Drawing.Color.White;
            this.btnActulizarPedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizarPedido.Click += new System.EventHandler(this.btnActulizarPedido_Click);
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerPedidos.BorderRadius = 0;
            this.btnVerPedidos.ButtonText = "      VER PEDIDOS";
            this.btnVerPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnVerPedidos, BunifuAnimatorNS.DecorationType.None);
            this.btnVerPedidos.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerPedidos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerPedidos.Iconimage")));
            this.btnVerPedidos.Iconimage_right = null;
            this.btnVerPedidos.Iconimage_right_Selected = null;
            this.btnVerPedidos.Iconimage_Selected = null;
            this.btnVerPedidos.IconMarginLeft = 0;
            this.btnVerPedidos.IconMarginRight = 0;
            this.btnVerPedidos.IconRightVisible = true;
            this.btnVerPedidos.IconRightZoom = 0D;
            this.btnVerPedidos.IconVisible = true;
            this.btnVerPedidos.IconZoom = 90D;
            this.btnVerPedidos.IsTab = false;
            this.btnVerPedidos.Location = new System.Drawing.Point(24, 225);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerPedidos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVerPedidos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerPedidos.selected = false;
            this.btnVerPedidos.Size = new System.Drawing.Size(240, 51);
            this.btnVerPedidos.TabIndex = 4;
            this.btnVerPedidos.Text = "      VER PEDIDOS";
            this.btnVerPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPedidos.Textcolor = System.Drawing.Color.White;
            this.btnVerPedidos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPedido.BorderRadius = 0;
            this.btnAgregarPedido.ButtonText = "      NUEVO PEDIDO";
            this.btnAgregarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnAgregarPedido, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregarPedido.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPedido.Iconimage")));
            this.btnAgregarPedido.Iconimage_right = null;
            this.btnAgregarPedido.Iconimage_right_Selected = null;
            this.btnAgregarPedido.Iconimage_Selected = null;
            this.btnAgregarPedido.IconMarginLeft = 0;
            this.btnAgregarPedido.IconMarginRight = 0;
            this.btnAgregarPedido.IconRightVisible = true;
            this.btnAgregarPedido.IconRightZoom = 0D;
            this.btnAgregarPedido.IconVisible = true;
            this.btnAgregarPedido.IconZoom = 90D;
            this.btnAgregarPedido.IsTab = false;
            this.btnAgregarPedido.Location = new System.Drawing.Point(23, 60);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarPedido.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregarPedido.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarPedido.selected = false;
            this.btnAgregarPedido.Size = new System.Drawing.Size(239, 51);
            this.btnAgregarPedido.TabIndex = 1;
            this.btnAgregarPedido.Text = "      NUEVO PEDIDO";
            this.btnAgregarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPedido.Textcolor = System.Drawing.Color.White;
            this.btnAgregarPedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarPedido.BorderRadius = 0;
            this.btnEliminarPedido.ButtonText = "      CANCELAR PEDIDO";
            this.btnEliminarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnEliminarPedido, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminarPedido.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPedido.Iconimage")));
            this.btnEliminarPedido.Iconimage_right = null;
            this.btnEliminarPedido.Iconimage_right_Selected = null;
            this.btnEliminarPedido.Iconimage_Selected = null;
            this.btnEliminarPedido.IconMarginLeft = 0;
            this.btnEliminarPedido.IconMarginRight = 0;
            this.btnEliminarPedido.IconRightVisible = true;
            this.btnEliminarPedido.IconRightZoom = 0D;
            this.btnEliminarPedido.IconVisible = true;
            this.btnEliminarPedido.IconZoom = 90D;
            this.btnEliminarPedido.IsTab = false;
            this.btnEliminarPedido.Location = new System.Drawing.Point(24, 168);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarPedido.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEliminarPedido.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarPedido.selected = false;
            this.btnEliminarPedido.Size = new System.Drawing.Size(240, 51);
            this.btnEliminarPedido.TabIndex = 3;
            this.btnEliminarPedido.Text = "      CANCELAR PEDIDO";
            this.btnEliminarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPedido.Textcolor = System.Drawing.Color.White;
            this.btnEliminarPedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // PanelVentas
            // 
            this.PanelVentas.BackColor = System.Drawing.Color.Transparent;
            this.PanelVentas.Controls.Add(this.btnActualizarVenta);
            this.PanelVentas.Controls.Add(this.btnVerVentas);
            this.PanelVentas.Controls.Add(this.btnAgregarVenta);
            this.PanelVentas.Controls.Add(this.btnEliminarVenta);
            this.AnimacionMenu.SetDecoration(this.PanelVentas, BunifuAnimatorNS.DecorationType.None);
            this.PanelVentas.Location = new System.Drawing.Point(0, 396);
            this.PanelVentas.MaximumSize = new System.Drawing.Size(270, 285);
            this.PanelVentas.MinimumSize = new System.Drawing.Size(270, 65);
            this.PanelVentas.Name = "PanelVentas";
            this.PanelVentas.Size = new System.Drawing.Size(270, 65);
            this.PanelVentas.TabIndex = 7;
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.Activecolor = System.Drawing.Color.Transparent;
            this.btnActualizarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarVenta.BorderRadius = 0;
            this.btnActualizarVenta.ButtonText = "      ACTUALIZAR VENTA";
            this.btnActualizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnActualizarVenta, BunifuAnimatorNS.DecorationType.None);
            this.btnActualizarVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizarVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizarVenta.Iconimage")));
            this.btnActualizarVenta.Iconimage_right = null;
            this.btnActualizarVenta.Iconimage_right_Selected = null;
            this.btnActualizarVenta.Iconimage_Selected = null;
            this.btnActualizarVenta.IconMarginLeft = 0;
            this.btnActualizarVenta.IconMarginRight = 0;
            this.btnActualizarVenta.IconRightVisible = true;
            this.btnActualizarVenta.IconRightZoom = 0D;
            this.btnActualizarVenta.IconVisible = true;
            this.btnActualizarVenta.IconZoom = 90D;
            this.btnActualizarVenta.IsTab = false;
            this.btnActualizarVenta.Location = new System.Drawing.Point(22, 111);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnActualizarVenta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnActualizarVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizarVenta.selected = false;
            this.btnActualizarVenta.Size = new System.Drawing.Size(240, 51);
            this.btnActualizarVenta.TabIndex = 2;
            this.btnActualizarVenta.Text = "      ACTUALIZAR VENTA";
            this.btnActualizarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarVenta.Textcolor = System.Drawing.Color.White;
            this.btnActualizarVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVenta.Click += new System.EventHandler(this.btnActualizarVenta_Click);
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerVentas.BorderRadius = 0;
            this.btnVerVentas.ButtonText = "      VER VENTAS";
            this.btnVerVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnVerVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVerVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerVentas.Iconimage")));
            this.btnVerVentas.Iconimage_right = null;
            this.btnVerVentas.Iconimage_right_Selected = null;
            this.btnVerVentas.Iconimage_Selected = null;
            this.btnVerVentas.IconMarginLeft = 0;
            this.btnVerVentas.IconMarginRight = 0;
            this.btnVerVentas.IconRightVisible = true;
            this.btnVerVentas.IconRightZoom = 0D;
            this.btnVerVentas.IconVisible = true;
            this.btnVerVentas.IconZoom = 90D;
            this.btnVerVentas.IsTab = false;
            this.btnVerVentas.Location = new System.Drawing.Point(24, 225);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVerVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerVentas.selected = false;
            this.btnVerVentas.Size = new System.Drawing.Size(240, 51);
            this.btnVerVentas.TabIndex = 4;
            this.btnVerVentas.Text = "      VER VENTAS";
            this.btnVerVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerVentas.Textcolor = System.Drawing.Color.White;
            this.btnVerVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarVenta.BorderRadius = 0;
            this.btnAgregarVenta.ButtonText = "      NUEVA VENTA";
            this.btnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnAgregarVenta, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregarVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarVenta.Iconimage")));
            this.btnAgregarVenta.Iconimage_right = null;
            this.btnAgregarVenta.Iconimage_right_Selected = null;
            this.btnAgregarVenta.Iconimage_Selected = null;
            this.btnAgregarVenta.IconMarginLeft = 0;
            this.btnAgregarVenta.IconMarginRight = 0;
            this.btnAgregarVenta.IconRightVisible = true;
            this.btnAgregarVenta.IconRightZoom = 0D;
            this.btnAgregarVenta.IconVisible = true;
            this.btnAgregarVenta.IconZoom = 90D;
            this.btnAgregarVenta.IsTab = false;
            this.btnAgregarVenta.Location = new System.Drawing.Point(23, 60);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarVenta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregarVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarVenta.selected = false;
            this.btnAgregarVenta.Size = new System.Drawing.Size(239, 51);
            this.btnAgregarVenta.TabIndex = 1;
            this.btnAgregarVenta.Text = "      NUEVA VENTA";
            this.btnAgregarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarVenta.Textcolor = System.Drawing.Color.White;
            this.btnAgregarVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarVenta.BorderRadius = 0;
            this.btnEliminarVenta.ButtonText = "      CANCELAR VENTA";
            this.btnEliminarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnEliminarVenta, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminarVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarVenta.Iconimage")));
            this.btnEliminarVenta.Iconimage_right = null;
            this.btnEliminarVenta.Iconimage_right_Selected = null;
            this.btnEliminarVenta.Iconimage_Selected = null;
            this.btnEliminarVenta.IconMarginLeft = 0;
            this.btnEliminarVenta.IconMarginRight = 0;
            this.btnEliminarVenta.IconRightVisible = true;
            this.btnEliminarVenta.IconRightZoom = 0D;
            this.btnEliminarVenta.IconVisible = true;
            this.btnEliminarVenta.IconZoom = 90D;
            this.btnEliminarVenta.IsTab = false;
            this.btnEliminarVenta.Location = new System.Drawing.Point(24, 168);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarVenta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEliminarVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarVenta.selected = false;
            this.btnEliminarVenta.Size = new System.Drawing.Size(240, 51);
            this.btnEliminarVenta.TabIndex = 3;
            this.btnEliminarVenta.Text = "      CANCELAR VENTA";
            this.btnEliminarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarVenta.Textcolor = System.Drawing.Color.White;
            this.btnEliminarVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // PanelProd
            // 
            this.PanelProd.BackColor = System.Drawing.Color.Transparent;
            this.PanelProd.Controls.Add(this.btnActualizarProd);
            this.PanelProd.Controls.Add(this.btnVerProducto);
            this.PanelProd.Controls.Add(this.btnAgregarProd);
            this.PanelProd.Controls.Add(this.btnEliminarProducto);
            this.AnimacionMenu.SetDecoration(this.PanelProd, BunifuAnimatorNS.DecorationType.None);
            this.PanelProd.Location = new System.Drawing.Point(3, 108);
            this.PanelProd.MaximumSize = new System.Drawing.Size(270, 285);
            this.PanelProd.MinimumSize = new System.Drawing.Size(270, 65);
            this.PanelProd.Name = "PanelProd";
            this.PanelProd.Size = new System.Drawing.Size(270, 65);
            this.PanelProd.TabIndex = 4;
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.Activecolor = System.Drawing.Color.Transparent;
            this.btnActualizarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarProd.BorderRadius = 0;
            this.btnActualizarProd.ButtonText = "      ACTUALIZAR PRODUCTO";
            this.btnActualizarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnActualizarProd, BunifuAnimatorNS.DecorationType.None);
            this.btnActualizarProd.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizarProd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizarProd.Iconimage")));
            this.btnActualizarProd.Iconimage_right = null;
            this.btnActualizarProd.Iconimage_right_Selected = null;
            this.btnActualizarProd.Iconimage_Selected = null;
            this.btnActualizarProd.IconMarginLeft = 0;
            this.btnActualizarProd.IconMarginRight = 0;
            this.btnActualizarProd.IconRightVisible = true;
            this.btnActualizarProd.IconRightZoom = 0D;
            this.btnActualizarProd.IconVisible = true;
            this.btnActualizarProd.IconZoom = 90D;
            this.btnActualizarProd.IsTab = false;
            this.btnActualizarProd.Location = new System.Drawing.Point(22, 111);
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.Normalcolor = System.Drawing.Color.Transparent;
            this.btnActualizarProd.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnActualizarProd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizarProd.selected = false;
            this.btnActualizarProd.Size = new System.Drawing.Size(240, 51);
            this.btnActualizarProd.TabIndex = 2;
            this.btnActualizarProd.Text = "      ACTUALIZAR PRODUCTO";
            this.btnActualizarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarProd.Textcolor = System.Drawing.Color.White;
            this.btnActualizarProd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProd.Click += new System.EventHandler(this.btnActualizarProd_Click);
            // 
            // btnVerProducto
            // 
            this.btnVerProducto.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnVerProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerProducto.BorderRadius = 0;
            this.btnVerProducto.ButtonText = "      VER PRODUCTOS";
            this.btnVerProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnVerProducto, BunifuAnimatorNS.DecorationType.None);
            this.btnVerProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerProducto.Iconimage")));
            this.btnVerProducto.Iconimage_right = null;
            this.btnVerProducto.Iconimage_right_Selected = null;
            this.btnVerProducto.Iconimage_Selected = null;
            this.btnVerProducto.IconMarginLeft = 0;
            this.btnVerProducto.IconMarginRight = 0;
            this.btnVerProducto.IconRightVisible = true;
            this.btnVerProducto.IconRightZoom = 0D;
            this.btnVerProducto.IconVisible = true;
            this.btnVerProducto.IconZoom = 90D;
            this.btnVerProducto.IsTab = false;
            this.btnVerProducto.Location = new System.Drawing.Point(24, 225);
            this.btnVerProducto.Name = "btnVerProducto";
            this.btnVerProducto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerProducto.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVerProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerProducto.selected = false;
            this.btnVerProducto.Size = new System.Drawing.Size(240, 51);
            this.btnVerProducto.TabIndex = 4;
            this.btnVerProducto.Text = "      VER PRODUCTOS";
            this.btnVerProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerProducto.Textcolor = System.Drawing.Color.White;
            this.btnVerProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProducto.Click += new System.EventHandler(this.btnVerProducto_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProd.BorderRadius = 0;
            this.btnAgregarProd.ButtonText = "      NUEVO PRODUCTO";
            this.btnAgregarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnAgregarProd, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregarProd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarProd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProd.Iconimage")));
            this.btnAgregarProd.Iconimage_right = null;
            this.btnAgregarProd.Iconimage_right_Selected = null;
            this.btnAgregarProd.Iconimage_Selected = null;
            this.btnAgregarProd.IconMarginLeft = 0;
            this.btnAgregarProd.IconMarginRight = 0;
            this.btnAgregarProd.IconRightVisible = true;
            this.btnAgregarProd.IconRightZoom = 0D;
            this.btnAgregarProd.IconVisible = true;
            this.btnAgregarProd.IconZoom = 90D;
            this.btnAgregarProd.IsTab = false;
            this.btnAgregarProd.Location = new System.Drawing.Point(23, 60);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarProd.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregarProd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarProd.selected = false;
            this.btnAgregarProd.Size = new System.Drawing.Size(239, 51);
            this.btnAgregarProd.TabIndex = 1;
            this.btnAgregarProd.Text = "      NUEVO PRODUCTO";
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.Textcolor = System.Drawing.Color.White;
            this.btnAgregarProd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarProducto.BorderRadius = 0;
            this.btnEliminarProducto.ButtonText = "      ELIMINAR PRODUCTO";
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnEliminarProducto, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Iconimage")));
            this.btnEliminarProducto.Iconimage_right = null;
            this.btnEliminarProducto.Iconimage_right_Selected = null;
            this.btnEliminarProducto.Iconimage_Selected = null;
            this.btnEliminarProducto.IconMarginLeft = 0;
            this.btnEliminarProducto.IconMarginRight = 0;
            this.btnEliminarProducto.IconRightVisible = true;
            this.btnEliminarProducto.IconRightZoom = 0D;
            this.btnEliminarProducto.IconVisible = true;
            this.btnEliminarProducto.IconZoom = 90D;
            this.btnEliminarProducto.IsTab = false;
            this.btnEliminarProducto.Location = new System.Drawing.Point(24, 168);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarProducto.selected = false;
            this.btnEliminarProducto.Size = new System.Drawing.Size(240, 51);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "      ELIMINAR PRODUCTO";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Textcolor = System.Drawing.Color.White;
            this.btnEliminarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // PanelTortas
            // 
            this.PanelTortas.BackColor = System.Drawing.Color.Transparent;
            this.PanelTortas.Controls.Add(this.btnActualizarTorta);
            this.PanelTortas.Controls.Add(this.btnVerTortas);
            this.PanelTortas.Controls.Add(this.btnAgregarTorta);
            this.PanelTortas.Controls.Add(this.btnEliminarTorta);
            this.AnimacionMenu.SetDecoration(this.PanelTortas, BunifuAnimatorNS.DecorationType.None);
            this.PanelTortas.Location = new System.Drawing.Point(0, 190);
            this.PanelTortas.MaximumSize = new System.Drawing.Size(270, 285);
            this.PanelTortas.MinimumSize = new System.Drawing.Size(270, 65);
            this.PanelTortas.Name = "PanelTortas";
            this.PanelTortas.Size = new System.Drawing.Size(270, 65);
            this.PanelTortas.TabIndex = 5;
            // 
            // btnActualizarTorta
            // 
            this.btnActualizarTorta.Activecolor = System.Drawing.Color.Transparent;
            this.btnActualizarTorta.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarTorta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarTorta.BorderRadius = 0;
            this.btnActualizarTorta.ButtonText = "      ACTUALIZAR TORTA";
            this.btnActualizarTorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnActualizarTorta, BunifuAnimatorNS.DecorationType.None);
            this.btnActualizarTorta.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizarTorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTorta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizarTorta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizarTorta.Iconimage")));
            this.btnActualizarTorta.Iconimage_right = null;
            this.btnActualizarTorta.Iconimage_right_Selected = null;
            this.btnActualizarTorta.Iconimage_Selected = null;
            this.btnActualizarTorta.IconMarginLeft = 0;
            this.btnActualizarTorta.IconMarginRight = 0;
            this.btnActualizarTorta.IconRightVisible = true;
            this.btnActualizarTorta.IconRightZoom = 0D;
            this.btnActualizarTorta.IconVisible = true;
            this.btnActualizarTorta.IconZoom = 90D;
            this.btnActualizarTorta.IsTab = false;
            this.btnActualizarTorta.Location = new System.Drawing.Point(22, 107);
            this.btnActualizarTorta.Name = "btnActualizarTorta";
            this.btnActualizarTorta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnActualizarTorta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnActualizarTorta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizarTorta.selected = false;
            this.btnActualizarTorta.Size = new System.Drawing.Size(240, 51);
            this.btnActualizarTorta.TabIndex = 2;
            this.btnActualizarTorta.Text = "      ACTUALIZAR TORTA";
            this.btnActualizarTorta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarTorta.Textcolor = System.Drawing.Color.White;
            this.btnActualizarTorta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTorta.Click += new System.EventHandler(this.btnActualizarTorta_Click);
            // 
            // btnVerTortas
            // 
            this.btnVerTortas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVerTortas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerTortas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerTortas.BorderRadius = 0;
            this.btnVerTortas.ButtonText = "      VER TORTAS";
            this.btnVerTortas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnVerTortas, BunifuAnimatorNS.DecorationType.None);
            this.btnVerTortas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerTortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTortas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerTortas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerTortas.Iconimage")));
            this.btnVerTortas.Iconimage_right = null;
            this.btnVerTortas.Iconimage_right_Selected = null;
            this.btnVerTortas.Iconimage_Selected = null;
            this.btnVerTortas.IconMarginLeft = 0;
            this.btnVerTortas.IconMarginRight = 0;
            this.btnVerTortas.IconRightVisible = true;
            this.btnVerTortas.IconRightZoom = 0D;
            this.btnVerTortas.IconVisible = true;
            this.btnVerTortas.IconZoom = 90D;
            this.btnVerTortas.IsTab = false;
            this.btnVerTortas.Location = new System.Drawing.Point(24, 221);
            this.btnVerTortas.Name = "btnVerTortas";
            this.btnVerTortas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerTortas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVerTortas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerTortas.selected = false;
            this.btnVerTortas.Size = new System.Drawing.Size(240, 51);
            this.btnVerTortas.TabIndex = 4;
            this.btnVerTortas.Text = "      VER TORTAS";
            this.btnVerTortas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTortas.Textcolor = System.Drawing.Color.White;
            this.btnVerTortas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTortas.Click += new System.EventHandler(this.btnVerTortas_Click);
            // 
            // btnAgregarTorta
            // 
            this.btnAgregarTorta.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregarTorta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTorta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarTorta.BorderRadius = 0;
            this.btnAgregarTorta.ButtonText = "      NUEVA TORTA";
            this.btnAgregarTorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnAgregarTorta, BunifuAnimatorNS.DecorationType.None);
            this.btnAgregarTorta.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarTorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTorta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarTorta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarTorta.Iconimage")));
            this.btnAgregarTorta.Iconimage_right = null;
            this.btnAgregarTorta.Iconimage_right_Selected = null;
            this.btnAgregarTorta.Iconimage_Selected = null;
            this.btnAgregarTorta.IconMarginLeft = 0;
            this.btnAgregarTorta.IconMarginRight = 0;
            this.btnAgregarTorta.IconRightVisible = true;
            this.btnAgregarTorta.IconRightZoom = 0D;
            this.btnAgregarTorta.IconVisible = true;
            this.btnAgregarTorta.IconZoom = 90D;
            this.btnAgregarTorta.IsTab = false;
            this.btnAgregarTorta.Location = new System.Drawing.Point(23, 56);
            this.btnAgregarTorta.Name = "btnAgregarTorta";
            this.btnAgregarTorta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarTorta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregarTorta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarTorta.selected = false;
            this.btnAgregarTorta.Size = new System.Drawing.Size(239, 51);
            this.btnAgregarTorta.TabIndex = 1;
            this.btnAgregarTorta.Text = "      NUEVA TORTA";
            this.btnAgregarTorta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTorta.Textcolor = System.Drawing.Color.White;
            this.btnAgregarTorta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTorta.Click += new System.EventHandler(this.btnAgregarTorta_Click);
            // 
            // btnEliminarTorta
            // 
            this.btnEliminarTorta.Activecolor = System.Drawing.Color.Transparent;
            this.btnEliminarTorta.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTorta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTorta.BorderRadius = 0;
            this.btnEliminarTorta.ButtonText = "      ELIMINAR TORTA";
            this.btnEliminarTorta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionMenu.SetDecoration(this.btnEliminarTorta, BunifuAnimatorNS.DecorationType.None);
            this.btnEliminarTorta.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarTorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTorta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarTorta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarTorta.Iconimage")));
            this.btnEliminarTorta.Iconimage_right = null;
            this.btnEliminarTorta.Iconimage_right_Selected = null;
            this.btnEliminarTorta.Iconimage_Selected = null;
            this.btnEliminarTorta.IconMarginLeft = 0;
            this.btnEliminarTorta.IconMarginRight = 0;
            this.btnEliminarTorta.IconRightVisible = true;
            this.btnEliminarTorta.IconRightZoom = 0D;
            this.btnEliminarTorta.IconVisible = true;
            this.btnEliminarTorta.IconZoom = 90D;
            this.btnEliminarTorta.IsTab = false;
            this.btnEliminarTorta.Location = new System.Drawing.Point(24, 164);
            this.btnEliminarTorta.Name = "btnEliminarTorta";
            this.btnEliminarTorta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarTorta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEliminarTorta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarTorta.selected = false;
            this.btnEliminarTorta.Size = new System.Drawing.Size(240, 51);
            this.btnEliminarTorta.TabIndex = 3;
            this.btnEliminarTorta.Text = "      ELIMINAR TORTA";
            this.btnEliminarTorta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTorta.Textcolor = System.Drawing.Color.White;
            this.btnEliminarTorta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTorta.Click += new System.EventHandler(this.btnEliminarTorta_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionMenu.SetDecoration(this.Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.Contenedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Contenedor.Location = new System.Drawing.Point(292, 80);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1108, 820);
            this.Contenedor.TabIndex = 1;
            // 
            // CurvaTabla
            // 
            this.CurvaTabla.ElipseRadius = 7;
            this.CurvaTabla.TargetControl = this.PMenu2;
            // 
            // AnimacionMenu
            // 
            this.AnimacionMenu.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.AnimacionMenu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionMenu.DefaultAnimation = animation1;
            // 
            // ColapzarCompras
            // 
            this.ColapzarCompras.Interval = 5;
            this.ColapzarCompras.Tick += new System.EventHandler(this.ColapzarCompras_Tick_1);
            // 
            // ColapzarProducto
            // 
            this.ColapzarProducto.Interval = 10;
            this.ColapzarProducto.Tick += new System.EventHandler(this.ColpazarProducto_Tick);
            // 
            // ColapzarTortas
            // 
            this.ColapzarTortas.Interval = 10;
            this.ColapzarTortas.Tick += new System.EventHandler(this.ColapzarTortas_Tick);
            // 
            // ColapzarClientes
            // 
            this.ColapzarClientes.Interval = 10;
            this.ColapzarClientes.Tick += new System.EventHandler(this.ColapzarClientes_Tick);
            // 
            // ColapzarPedidos
            // 
            this.ColapzarPedidos.Interval = 10;
            this.ColapzarPedidos.Tick += new System.EventHandler(this.ColapzarPedidos_Tick);
            // 
            // ColapzarVentas
            // 
            this.ColapzarVentas.Interval = 10;
            this.ColapzarVentas.Tick += new System.EventHandler(this.ColapzarVentas_Tick);
            // 
            // ColapzarInformes
            // 
            this.ColapzarInformes.Interval = 10;
            // 
            // MoverTop
            // 
            this.MoverTop.Fixed = true;
            this.MoverTop.Horizontal = true;
            this.MoverTop.TargetControl = this.PTop;
            this.MoverTop.Vertical = true;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.PanMenu);
            this.Controls.Add(this.PTop);
            this.AnimacionMenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PTop.ResumeLayout(false);
            this.PTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).EndInit();
            this.PanMenu.ResumeLayout(false);
            this.PMenu2.ResumeLayout(false);
            this.PanelCompras.ResumeLayout(false);
            this.PanelClientes.ResumeLayout(false);
            this.PanelPedidos.ResumeLayout(false);
            this.PanelVentas.ResumeLayout(false);
            this.PanelProd.ResumeLayout(false);
            this.PanelTortas.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PTop;
		private System.Windows.Forms.Label L1;
		private System.Windows.Forms.PictureBox PicMenu;
		private System.Windows.Forms.Panel PanMenu;
		private System.Windows.Forms.Panel Contenedor;
		private System.Windows.Forms.PictureBox Salir;
		private System.Windows.Forms.PictureBox Minimizar;
		private System.Windows.Forms.PictureBox Maximizar;
		private System.Windows.Forms.PictureBox Restaurar;
		private Bunifu.Framework.UI.BunifuFlatButton btnCompras;
		private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
		private Bunifu.Framework.UI.BunifuFlatButton btnPedidos;
		private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
		private Bunifu.Framework.UI.BunifuFlatButton btnTortas;
		private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
		private Bunifu.Framework.UI.BunifuElipse CurvaTabla;
		private BunifuAnimatorNS.BunifuTransition AnimacionMenu;
		private Bunifu.Framework.UI.BunifuGradientPanel PMenu2;
		private Bunifu.Framework.UI.BunifuFlatButton btnEliminarCompra;
		private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCompra;
		private System.Windows.Forms.Panel PanelCompras;
		private System.Windows.Forms.Timer ColapzarCompras;
		private Bunifu.Framework.UI.BunifuFlatButton btnActualizarProd;
		private Bunifu.Framework.UI.BunifuFlatButton btnAgregarProd;
		private Bunifu.Framework.UI.BunifuFlatButton btnVerProducto;
		private Bunifu.Framework.UI.BunifuFlatButton btnEliminarProducto;
		private Bunifu.Framework.UI.BunifuFlatButton btnVerCompras;
		private System.Windows.Forms.Timer ColapzarProducto;
		private System.Windows.Forms.Panel PanelProd;
		private System.Windows.Forms.Panel PanelClientes;
		private Bunifu.Framework.UI.BunifuFlatButton btnActualizarCliente;
		private Bunifu.Framework.UI.BunifuFlatButton btnVerClientes;
		private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCliente;
		private Bunifu.Framework.UI.BunifuFlatButton btnEliminarCliente;
		private System.Windows.Forms.Panel PanelPedidos;
		private Bunifu.Framework.UI.BunifuFlatButton btnActulizarPedido;
		private Bunifu.Framework.UI.BunifuFlatButton btnVerPedidos;
		private Bunifu.Framework.UI.BunifuFlatButton btnAgregarPedido;
		private Bunifu.Framework.UI.BunifuFlatButton btnEliminarPedido;
		private System.Windows.Forms.Panel PanelTortas;
		private Bunifu.Framework.UI.BunifuFlatButton btnActualizarTorta;
		private Bunifu.Framework.UI.BunifuFlatButton btnVerTortas;
		private Bunifu.Framework.UI.BunifuFlatButton btnAgregarTorta;
		private Bunifu.Framework.UI.BunifuFlatButton btnEliminarTorta;
		private System.Windows.Forms.Panel PanelVentas;
		private Bunifu.Framework.UI.BunifuFlatButton btnActualizarVenta;
		private Bunifu.Framework.UI.BunifuFlatButton btnVerVentas;
		private Bunifu.Framework.UI.BunifuFlatButton btnAgregarVenta;
		private Bunifu.Framework.UI.BunifuFlatButton btnEliminarVenta;
		private System.Windows.Forms.Timer ColapzarTortas;
		private System.Windows.Forms.Timer ColapzarClientes;
		private System.Windows.Forms.Timer ColapzarPedidos;
		private System.Windows.Forms.Timer ColapzarVentas;
		private System.Windows.Forms.Timer ColapzarInformes;
		private Bunifu.Framework.UI.BunifuDragControl MoverTop;
	}
}

