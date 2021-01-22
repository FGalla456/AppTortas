namespace WindowsFormsApp1.Pedidos
{
    partial class Agregar_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Pedido));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTotal = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIdCliente = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCosto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuImageButton();
            this.GrillaCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Location = new System.Drawing.Point(358, 215);
            this.dtpFecha.MaxDate = new System.DateTime(2110, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(237, 20);
            this.dtpFecha.TabIndex = 14;
            this.dtpFecha.Value = new System.DateTime(2019, 3, 3, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
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
            this.label1.Size = new System.Drawing.Size(357, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "AGREGAR PEDIDO";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(88, 509);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(200, 29);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Total de la Venta:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(353, 516);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(237, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(88, 215);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(210, 29);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Fecha de Entrega:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(128, 108);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(121, 29);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Id Cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCliente.BackColor = System.Drawing.Color.White;
            this.txtIdCliente.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(353, 106);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(237, 20);
            this.txtIdCliente.TabIndex = 15;
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(128, 358);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(143, 29);
            this.bunifuCustomLabel5.TabIndex = 18;
            this.bunifuCustomLabel5.Text = "Costo Total:";
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(353, 362);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(237, 20);
            this.txtCosto.TabIndex = 17;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
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
            this.btnCancelar.Location = new System.Drawing.Point(682, 593);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(174, 53);
            this.btnCancelar.TabIndex = 34;
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
            this.btnAceptar.Location = new System.Drawing.Point(319, 593);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(174, 53);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "      ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageActive = null;
            this.btnClientes.Location = new System.Drawing.Point(596, 101);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(35, 29);
            this.btnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClientes.TabIndex = 35;
            this.btnClientes.TabStop = false;
            this.btnClientes.Zoom = 10;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // GrillaCliente
            // 
            this.GrillaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrillaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrillaCliente.EnableHeadersVisualStyles = false;
            this.GrillaCliente.Location = new System.Drawing.Point(662, 108);
            this.GrillaCliente.Name = "GrillaCliente";
            this.GrillaCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrillaCliente.Size = new System.Drawing.Size(444, 198);
            this.GrillaCliente.TabIndex = 37;
            this.GrillaCliente.Visible = false;
            this.GrillaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaCliente_CellDoubleClick);
            // 
            // Agregar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1118, 694);
            this.Controls.Add(this.GrillaCliente);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Pedido";
            this.Text = "Agregar_Pedido";
            this.Load += new System.EventHandler(this.Agregar_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCosto;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private Bunifu.Framework.UI.BunifuImageButton btnClientes;
        private System.Windows.Forms.DataGridView GrillaCliente;
    }
}