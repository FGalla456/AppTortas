namespace WindowsFormsApp1.Carteles
{
    partial class SeleccionarFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarFormulario));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTorta = new System.Windows.Forms.Button();
            this.btnIngrediente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que Quiere Eliminar?";
            // 
            // btnTorta
            // 
            this.btnTorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorta.Location = new System.Drawing.Point(34, 84);
            this.btnTorta.Name = "btnTorta";
            this.btnTorta.Size = new System.Drawing.Size(115, 31);
            this.btnTorta.TabIndex = 1;
            this.btnTorta.Text = "Torta";
            this.btnTorta.UseVisualStyleBackColor = true;
            this.btnTorta.Click += new System.EventHandler(this.btnTorta_Click);
            // 
            // btnIngrediente
            // 
            this.btnIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngrediente.Location = new System.Drawing.Point(219, 84);
            this.btnIngrediente.Name = "btnIngrediente";
            this.btnIngrediente.Size = new System.Drawing.Size(115, 31);
            this.btnIngrediente.TabIndex = 2;
            this.btnIngrediente.Text = "Ingrediente";
            this.btnIngrediente.UseVisualStyleBackColor = true;
            this.btnIngrediente.Click += new System.EventHandler(this.btnIngrediente_Click);
            // 
            // SeleccionarFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 144);
            this.Controls.Add(this.btnIngrediente);
            this.Controls.Add(this.btnTorta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionarFormulario";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTorta;
        private System.Windows.Forms.Button btnIngrediente;
    }
}