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

namespace WindowsFormsApp1.Clientes
{
    public partial class Actualizar_Cliente : Form
    {
        Genericas gen = new Genericas();
        N_Clientes nc = new N_Clientes();
        public Actualizar_Cliente()
        {
            InitializeComponent();
        }

        #region KeyPress

        public void PermitirNumeros(object sender, KeyPressEventArgs e) 
        {
            gen.PermitirNumeros(sender,e);
        }

        public void PermitirLetras(object sender, KeyPressEventArgs e)
        {
            gen.PermitirLetras(sender,e);
        }

        public void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            gen.NoPermitirEscribir(sender, e);
        }

        #endregion
        private void Actualizar_Cliente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.DataSource = nc.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            this.Close();
        }

    }
}
