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

namespace WindowsFormsApp1.Tortas
{
    public partial class Eliminar_Ingrediente : Form
    {

        #region Declaraciones

        Genericas gen = new Genericas();
        N_IngredienteTorta nit = new N_IngredienteTorta();

        #endregion

        #region Inicio

        public Eliminar_Ingrediente()
        {
            InitializeComponent();
        }

        private void Eliminar_Ingrediente_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grilla.DataSource = nit.getTabla();
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
            if (txtMerc.Text != "" && txtTorta.Text != "")
            {
                nit.eliminarIngrediente(int.Parse(txtTorta.Text.ToString()),int.Parse(txtMerc.Text.ToString()));
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
    }
}
