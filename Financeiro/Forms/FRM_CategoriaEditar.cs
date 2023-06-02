using Financeiro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Forms
{
    public partial class FRM_CategoriaEditar : Form
    {
        string filtro;
        string categoria;
        bool essencial;
        string cor;

        public FRM_CategoriaEditar(string filtro, string categoria, bool essencial, string cor)
        {
            this.filtro = filtro;
            this.categoria = categoria;
            this.essencial = essencial;
            this.cor = cor;
            InitializeComponent();
            ConfiguraCombo();
        }

        private void ConfiguraCombo()
        {
            //COMBO CORES
            cbCor.Items.Clear();

            cbCor.Items.Add("Swirl");
            cbCor.Items.Add("Natural Gray");
            cbCor.Items.Add("Star Dust");
            cbCor.Items.Add("Rolling Stone");
            cbCor.Items.Add("Nevada");
            cbCor.Items.Add("Black Coral");
            cbCor.Items.Add("Tuatara");
            cbCor.Items.Add("Gray");

            cbCor.Sorted = true;

            //COMBO ESSENCIAL
            cbEssencial.Items.Clear();

            cbEssencial.Items.Add("Não Essencial");
            cbEssencial.Items.Add("Essencial");
        }

        private void FRM_EditarCategoria_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            tbCategoria.Text = categoria;
            cbCor.Text = cor;
            if (essencial)
            {
                cbEssencial.Text = "Essencial";
            }
            else
            {
                cbEssencial.Text = "Não Essencial";
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string categoria = tbCategoria.Text;
            bool essencial = cbEssencial.Text.ToLower() == "essencial";
            string cor = cbCor.Text;

            try
            {
                CTR_DadosSql.editarCategoria(filtro, categoria, essencial, cor);

                MessageBox.Show("Categoria atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
