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

namespace WindowsFormsApp1.Pedidos
{
    public partial class Eliminar_TortasPedido : Form
    {
        public Eliminar_TortasPedido()
        {
            InitializeComponent();
        }

        private void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Eliminar_TortasPedido_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            N_TortasPedido TP = new N_TortasPedido();
            Grilla.DataSource = TP.getTabla();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPedido.Text != "" && txtTorta.Text != "")
            {
                N_TortasPedido TP = new N_TortasPedido();
                TP.eliminarTP(int.Parse(txtTorta.Text.ToString()),int.Parse(txtPedido.Text.ToString()));
                btnAceptar.Enabled = false;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                btnAceptar.Enabled = false;
                this.Close();
        }
    }
}
