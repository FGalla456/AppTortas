namespace WindowsFormsApp1.Compras
{
	partial class Ver_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_Compras));
            this.GrillaCompras = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.Atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaCompras
            // 
            this.GrillaCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaCompras.BackgroundColor = System.Drawing.Color.DarkGray;
            this.GrillaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.GrillaCompras.Location = new System.Drawing.Point(0, 36);
            this.GrillaCompras.Name = "GrillaCompras";
            this.GrillaCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrillaCompras.Size = new System.Drawing.Size(1100, 430);
            this.GrillaCompras.TabIndex = 0;
            this.GrillaCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaCompras_CellDoubleClick);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.Location = new System.Drawing.Point(1048, 0);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(52, 30);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Refresh.TabIndex = 3;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Atras
            // 
            this.Atras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Location = new System.Drawing.Point(0, 0);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(52, 30);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Atras.TabIndex = 6;
            this.Atras.TabStop = false;
            this.Atras.Visible = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Ver_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1100, 467);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.GrillaCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_Compras";
            this.Text = "Ver_Compras";
            this.Load += new System.EventHandler(this.Ver_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GrillaCompras;
        private System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.PictureBox Atras;
    }
}