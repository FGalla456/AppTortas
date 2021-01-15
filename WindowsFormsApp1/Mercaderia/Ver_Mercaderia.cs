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
    public partial class Ver_Mercaderia : Form
    {
        public Ver_Mercaderia()
        {
            InitializeComponent();
        }

        private void Ver_Mercaderia_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            N_Mercaderia Mer = new N_Mercaderia();
            Grilla.DataSource = Mer.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            N_Mercaderia Mer = new N_Mercaderia();
            Grilla.DataSource = Mer.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
