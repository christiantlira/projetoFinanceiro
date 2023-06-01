using Financeiro.Controls;
using Financeiro.Forms;
using Financeiro.Models;
using System.Data;
using System.Globalization;

namespace Financeiro
{
    //PRIMEIRO COMMIT
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            FRM_Gastos f = new FRM_Gastos();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnGanhos_Click(object sender, EventArgs e)
        {
            FRM_Ganhos f = new FRM_Ganhos();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnGeral_Click(object sender, EventArgs e)
        {
            FRM_Geral f = new FRM_Geral();
            f.ShowDialog();
            f.Dispose();
        }
    }
}