﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WindowsFormsApp1.Mercaderia
{
    public partial class Eliminar_Mercaderia : Form
    {

        #region Declaraciones

        DataGridViewRow row = new DataGridViewRow();
        N_Producto Pro = new N_Producto();
        Genericas gen = new Genericas();

        #endregion

        #region Inicio

        public Eliminar_Mercaderia()
        {
            InitializeComponent();
        }

        private void Eliminar_Mercaderia_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.DataSource = Pro.getTabla();
            Grilla.Columns[0].Visible = false;
        }

        #endregion

        #region KeyPress

        public void PermitirNumeros(object sender, KeyPressEventArgs e)
        {
            gen.PermitirNumeros(sender, e);
        }

        public void PermitirLetras(object sender, KeyPressEventArgs e)
        {
            gen.PermitirLetras(sender, e);
        }

        public void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            gen.NoPermitirEscribir(sender, e);
        }

        public void PermitirLetrasEspacio(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirLetrasEspacio(sender, e, Texto);
        }

        public void PerimitirDecimales(object sender, KeyPressEventArgs e, string Texto)
        {
            gen.PermitirDecimales(sender, e, Texto);
        }

        #endregion

        #region Botones

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMercaderia.Text != "")
            {
                row = Grilla.CurrentRow;
                Pro.eliminarProducto(Convert.ToInt32(row.Cells[0].Value));
                btnAceptar.Enabled = false;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                btnAceptar.Enabled = false;
                this.Close();
        }

        #endregion

        #region Eventos

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = Grilla.CurrentRow;
            txtMercaderia.Text = Convert.ToString(row.Cells[1].Value);
        }

        #endregion

    }
}
