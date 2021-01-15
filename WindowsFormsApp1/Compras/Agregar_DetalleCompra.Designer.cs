namespace WindowsFormsApp1.Compras
{
	partial class Agregar_DetalleCompra
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_DetalleCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NroCompra = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIdProd = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtPU = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnMercaderia = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.GrillaProd = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GrillaAgregar = new System.Windows.Forms.DataGridView();
            this.CerrarForm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnMercaderia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "AGREGAR COMPRA";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(147, 349);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(115, 29);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Cantidad:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(133, 224);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(142, 29);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Id Producto:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(81, 99);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(232, 29);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Numero de Compra:";
            // 
            // NroCompra
            // 
            this.NroCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NroCompra.BackColor = System.Drawing.Color.White;
            this.NroCompra.BorderColor = System.Drawing.Color.Chartreuse;
            this.NroCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NroCompra.Cursor = System.Windows.Forms.Cursors.No;
            this.NroCompra.Enabled = false;
            this.NroCompra.Location = new System.Drawing.Point(340, 108);
            this.NroCompra.Name = "NroCompra";
            this.NroCompra.Size = new System.Drawing.Size(237, 20);
            this.NroCompra.TabIndex = 8;
            this.NroCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NroCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(90, 474);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(214, 29);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Precio por Unidad:";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdProd.BackColor = System.Drawing.Color.White;
            this.txtIdProd.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProd.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(340, 230);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(237, 20);
            this.txtIdProd.TabIndex = 15;
            this.txtIdProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // txtPU
            // 
            this.txtPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPU.BackColor = System.Drawing.Color.White;
            this.txtPU.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPU.Location = new System.Drawing.Point(340, 474);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(237, 20);
            this.txtPU.TabIndex = 17;
            this.txtPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPU_KeyPress);
            // 
            // btnMercaderia
            // 
            this.btnMercaderia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMercaderia.BackColor = System.Drawing.Color.Transparent;
            this.btnMercaderia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMercaderia.Image = ((System.Drawing.Image)(resources.GetObject("btnMercaderia.Image")));
            this.btnMercaderia.ImageActive = null;
            this.btnMercaderia.Location = new System.Drawing.Point(598, 224);
            this.btnMercaderia.MaximumSize = new System.Drawing.Size(35, 29);
            this.btnMercaderia.Name = "btnMercaderia";
            this.btnMercaderia.Size = new System.Drawing.Size(35, 29);
            this.btnMercaderia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMercaderia.TabIndex = 18;
            this.btnMercaderia.TabStop = false;
            this.btnMercaderia.Zoom = 10;
            this.btnMercaderia.Click += new System.EventHandler(this.btnMercaderia_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Activecolor = System.Drawing.Color.Transparent;
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.BorderRadius = 0;
            this.btnAceptar.ButtonText = "      ACEPTAR";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Iconimage")));
            this.btnAceptar.Iconimage_right = null;
            this.btnAceptar.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnAceptar.Iconimage_Selected = null;
            this.btnAceptar.IconMarginLeft = 0;
            this.btnAceptar.IconMarginRight = 0;
            this.btnAceptar.IconRightVisible = true;
            this.btnAceptar.IconRightZoom = 0D;
            this.btnAceptar.IconVisible = true;
            this.btnAceptar.IconZoom = 90D;
            this.btnAceptar.IsTab = false;
            this.btnAceptar.Location = new System.Drawing.Point(120, 585);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(174, 53);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "      ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "      CANCELAR";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Iconimage")));
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(774, 585);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(174, 53);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "      CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudCant
            // 
            this.nudCant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nudCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCant.DecimalPlaces = 1;
            this.nudCant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCant.Location = new System.Drawing.Point(340, 352);
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(237, 16);
            this.nudCant.TabIndex = 21;
            this.nudCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudCant_KeyPress);
            // 
            // GrillaProd
            // 
            this.GrillaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrillaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrillaProd.EnableHeadersVisualStyles = false;
            this.GrillaProd.Location = new System.Drawing.Point(662, 99);
            this.GrillaProd.Name = "GrillaProd";
            this.GrillaProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrillaProd.Size = new System.Drawing.Size(444, 198);
            this.GrillaProd.TabIndex = 22;
            this.GrillaProd.Visible = false;
            this.GrillaProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProd_CellDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "      AGREGAR";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Iconimage")));
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = global::WindowsFormsApp1.Properties.Resources.icons8_menor_que_50;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(447, 585);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(174, 53);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "      AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // GrillaAgregar
            // 
            this.GrillaAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAgregar.EnableHeadersVisualStyles = false;
            this.GrillaAgregar.Location = new System.Drawing.Point(662, 305);
            this.GrillaAgregar.Name = "GrillaAgregar";
            this.GrillaAgregar.Size = new System.Drawing.Size(444, 198);
            this.GrillaAgregar.TabIndex = 24;
            this.GrillaAgregar.Visible = false;
            // 
            // CerrarForm
            // 
            this.CerrarForm.Interval = 5;
            this.CerrarForm.Tick += new System.EventHandler(this.CerrarForm_Tick);
            // 
            // Agregar_DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1118, 694);
            this.Controls.Add(this.GrillaAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.GrillaProd);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnMercaderia);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.NroCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_DetalleCompra";
            this.Text = "Agregar_DetalleCompra";
            this.Load += new System.EventHandler(this.Agregar_DetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMercaderia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private WindowsFormsControlLibrary1.BunifuCustomTextbox NroCompra;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
		private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdProd;
		private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPU;
		private Bunifu.Framework.UI.BunifuImageButton btnMercaderia;
		private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
		private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.DataGridView GrillaProd;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private System.Windows.Forms.DataGridView GrillaAgregar;
        private System.Windows.Forms.Timer CerrarForm;
    }
}