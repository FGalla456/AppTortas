namespace WindowsFormsApp1.Tortas
{
    partial class Ver_Tortas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_Tortas));
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.Atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla
            // 
            this.Grilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(0, 34);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(800, 416);
            this.Grilla.TabIndex = 1;
            this.Grilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellDoubleClick);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.Location = new System.Drawing.Point(748, -2);
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
            this.Atras.Location = new System.Drawing.Point(0, -2);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(52, 30);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Atras.TabIndex = 5;
            this.Atras.TabStop = false;
            this.Atras.Visible = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Ver_Tortas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Grilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_Tortas";
            this.Text = "Ver_Tortas";
            this.Load += new System.EventHandler(this.Ver_Tortas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.PictureBox Atras;
    }
}