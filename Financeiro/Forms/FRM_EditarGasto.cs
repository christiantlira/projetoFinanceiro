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
    public partial class FRM_EditarGasto : Form
    {
        string filtro;
        int fkCategoria;
        string descricao;
        double valor;
        DateTime data;

        public FRM_EditarGasto(string filtro, int fkCategoria, string descricao, double valor, DateTime data)
        {
            this.filtro = filtro;
            this.fkCategoria = fkCategoria;
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            InitializeComponent();
        }

        private void FRM_EditarGasto_Load(object sender, EventArgs e)
        {
            ConfiguraCombo();
            tbDescricao.Text = descricao;
            tbValor.Text = valor.ToString();
            dtpData.Text = data.ToString();
        }

        private void ConfiguraCombo()
        {
            cbCategorias.Items.Clear();

            DataTable categorias = CTR_DadosSql.getCategorias();
            if (categorias.Rows.Count > 0)
            {
                cbCategorias.DataSource = CTR_DadosSql.getCategorias();
                cbCategorias.DisplayMember = "CATEGORIA_NOME";
                cbCategorias.ValueMember = "PK";

                cbCategorias.SelectedIndex = 0;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ErroCadastro() == 0)
            {
                int categoria = int.Parse(cbCategorias.SelectedValue.ToString());
                string descricao = tbDescricao.Text;
                string valor = tbValor.Text.Replace(',', '.');
                DateTime data = DateTime.Parse(dtpData.Text);

                CTR_DadosSql.editarOperacao(filtro, categoria, descricao, valor, data);
                MessageBox.Show("Atualização concluída com sucesso!", "Conclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (ErroCadastro() == 1)
            {
                MessageBox.Show("Você deixou um ou mais campos em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Você digitou um número não válido para o valor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private int ErroCadastro()
        {
            //VERIFICA SE HÁ CAMPOS EM BRANCO
            if (cbCategorias.Text.Length <= 0)
            {
                return 1;
            }
            if (tbDescricao.Text.Length <= 0)
            {
                return 1;
            }
            if (tbValor.Text.Length <= 0)
            {
                return 1;
            }

            //VERIFICA SE O VALOR DIGITADO É UM DOUBLE
            if (double.TryParse(tbValor.Text, out double result))
            {
                return 0;
            }
            else
            {
                return 2;
            }
            return 0;
        }
    }
}
