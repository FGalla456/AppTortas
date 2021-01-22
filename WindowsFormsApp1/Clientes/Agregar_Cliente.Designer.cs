namespace WindowsFormsApp1.Clientes
{
    partial class Agregar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Cliente));
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtApellido = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDomicilio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTelefono = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(182, 344);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(120, 29);
            this.bunifuCustomLabel5.TabIndex = 46;
            this.bunifuCustomLabel5.Text = "Domicilio:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Location = new System.Drawing.Point(381, 251);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(318, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(189, 140);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(107, 29);
            this.bunifuCustomLabel4.TabIndex = 44;
            this.bunifuCustomLabel4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Location = new System.Drawing.Point(381, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.label1.Size = new System.Drawing.Size(372, 42);
            this.label1.TabIndex = 41;
            this.label1.Text = "AGREGAR CLIENTE";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(184, 446);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(116, 29);
            this.bunifuCustomLabel3.TabIndex = 40;
            this.bunifuCustomLabel3.Text = "Telefono:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.White;
            this.txtDomicilio.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDomicilio.Location = new System.Drawing.Point(381, 354);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(318, 20);
            this.txtDomicilio.TabIndex = 4;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(188, 242);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(108, 29);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Apellido:";
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
            this.btnCancelar.TabIndex = 7;
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
            this.btnAceptar.Location = new System.Drawing.Point(324, 593);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(174, 53);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "      ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColor = System.Drawing.Color.Chartreuse;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Location = new System.Drawing.Point(381, 455);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(318, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            // 
            // Agregar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1118, 694);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Cliente";
            this.Text = "Agregar_Cliente";
            this.Load += new System.EventHandler(this.Agregar_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDomicilio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTelefono;
    }
}