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

namespace WindowsFormsApp1.Tortas
{
    public partial class Ver_Tortas : Form
    {

        #region Declaraciones

        N_Tortas nt = new N_Tortas();
        N_IngredienteTorta nit = new N_IngredienteTorta();
        static public bool SubGrilla = new bool();

        #endregion

        #region Inicio

        public Ver_Tortas()
        {
            InitializeComponent();
        }

        private void Ver_Tortas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            Grilla.DataSource = nt.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubGrilla = false;
        }

        #endregion

        #region Botones

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (SubGrilla == false)
            {
                Grilla.DataSource = nt.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {

                Grilla.DataSource = nit.getTabla();
                Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Atras.Visible = false;
            SubGrilla = false;
            Grilla.DataSource = nt.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        #region Eventos

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Atras.Visible = true;
            SubGrilla = true;
            Grilla.DataSource = nit.getTabla();
            Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

    }
}
