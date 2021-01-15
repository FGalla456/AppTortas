namespace WindowsFormsApp1.Ventas
{
    partial class Agregar_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Venta));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCosto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.labe5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPed = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotal = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtVenta = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.GrillaPed = new System.Windows.Forms.DataGridView();
            this.btnPedidos = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(340, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "AGREGAR VENTA";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(66, 474);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(200, 29);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Total de la Venta:";
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(300, 359);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(318, 20);
            this.txtCosto.TabIndex = 11;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // labe5
            // 
            this.labe5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labe5.AutoSize = true;
            this.labe5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe5.ForeColor = System.Drawing.SystemColors.Control;
            this.labe5.Location = new System.Drawing.Point(54, 224);
            this.labe5.Name = "labe5";
            this.labe5.Size = new System.Drawing.Size(224, 29);
            this.labe5.TabIndex = 9;
            this.labe5.Text = "Numero de Pedido:";
            // 
            // txtPed
            // 
            this.txtPed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPed.BackColor = System.Drawing.Color.White;
            this.txtPed.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtPed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPed.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPed.Enabled = false;
            this.txtPed.Location = new System.Drawing.Point(300, 234);
            this.txtPed.Name = "txtPed";
            this.txtPed.Size = new System.Drawing.Size(318, 20);
            this.txtPed.TabIndex = 8;
            this.txtPed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(41, 349);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(251, 29);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Costo de Elaboracion:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(300, 484);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(318, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
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
            this.btnCancelar.Location = new System.Drawing.Point(625, 589);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(174, 53);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "      CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAceptar.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnAceptar.Location = new System.Drawing.Point(262, 589);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(174, 53);
            this.btnAceptar.TabIndex = 62;
            this.btnAceptar.Text = "      ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(54, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = "Numero de Venta:";
            // 
            // txtVenta
            // 
            this.txtVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenta.BackColor = System.Drawing.Color.White;
            this.txtVenta.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVenta.Enabled = false;
            this.txtVenta.Location = new System.Drawing.Point(300, 109);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(318, 20);
            this.txtVenta.TabIndex = 64;
            this.txtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrillaPed
            // 
            this.GrillaPed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaPed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaPed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrillaPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrillaPed.EnableHeadersVisualStyles = false;
            this.GrillaPed.Location = new System.Drawing.Point(675, 109);
            this.GrillaPed.Name = "GrillaPed";
            this.GrillaPed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrillaPed.Size = new System.Drawing.Size(431, 198);
            this.GrillaPed.TabIndex = 67;
            this.GrillaPed.Visible = false;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageActive = null;
            this.btnPedidos.Location = new System.Drawing.Point(624, 229);
            this.btnPedidos.MaximumSize = new System.Drawing.Size(35, 29);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(35, 29);
            this.btnPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPedidos.TabIndex = 66;
            this.btnPedidos.TabStop = false;
            this.btnPedidos.Zoom = 10;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // Agregar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1118, 694);
            this.Controls.Add(this.GrillaPed);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.labe5);
            this.Controls.Add(this.txtPed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Venta";
            this.Text = "Agregar_Venta";
            this.Load += new System.EventHandler(this.Agregar_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCosto;
        private Bunifu.Framework.UI.BunifuCustomLabel labe5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPed;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private Bunifu.Framework.UI.BunifuCustomLabel label6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtVenta;
        private System.Windows.Forms.DataGridView GrillaPed;
        private Bunifu.Framework.UI.BunifuImageButton btnPedidos;
    }
}