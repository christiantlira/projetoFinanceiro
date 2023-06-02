using Financeiro.Controls;
using Financeiro.Models;
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
    public partial class FRM_Ganhos : Form
    {
        public FRM_Ganhos()
        {
            InitializeComponent();
        }
        private void FRM_Ganhos_Load(object sender, EventArgs e)
        {
            ConfiguraLista();
            ConfiguraCombo();
        }

        private void ConfiguraLista()
        {
            lista.Items.Clear();
            lista.Columns.Clear();

            // Set the view to show details.
            lista.View = View.Details;
            // Allow the user to edit item text.
            lista.LabelEdit = true;
            // Allow the user to rearrange columns.
            lista.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            lista.FullRowSelect = true;
            // Display grid lines.
            lista.GridLines = true;

            lista.Columns.Add("Categoria", 110);
            lista.Columns.Add("Descrição", 410);
            lista.Columns.Add("Valor", 100);
            lista.Columns.Add("Data", 185);

            int nItens = 0;
            double valorTotal = 0;

            string filtroOp = "WHERE GANHO = 'true'";
            DataTable ganhos = CTR_DadosSql.getOperacao(filtroOp);
            if (ganhos.Rows.Count > 0)
            {
                foreach (DataRow gasto in ganhos.Rows)
                {
                    string filtroCategoria = "WHERE PK = '" + gasto["CATEGORIA_FK"].ToString() + "'";
                    DataTable cat = CTR_DadosSql.getCategorias(filtroCategoria);

                    Categoria categoria = new Categoria();
                    categoria.Name = cat.Rows[0]["CATEGORIA_NOME"].ToString();
                    categoria.Cor = cat.Rows[0]["COR"].ToString();

                    Operacao ganho = new Operacao();
                    ganho.Id = int.Parse(gasto["PK"].ToString());
                    ganho.Categoria = categoria;
                    ganho.Descricao = gasto["DESCRICAO"].ToString();
                    ganho.Valor = double.Parse(gasto["VALOR"].ToString());
                    ganho.Data = DateTime.Parse(gasto["DATA"].ToString());

                    ListViewItem lvi = new ListViewItem(ganho.Categoria.Name);
                    lvi.SubItems.Add(ganho.Descricao);
                    lvi.SubItems.Add("R$" + ganho.Valor.ToString("0.00"));
                    lvi.SubItems.Add(ganho.Data.ToString("dd 'de' MMMM 'de' yyyy"));
                    lvi.SubItems.Add(ganho.Id.ToString());

                    FRM_GastosCategorias.setBackColor(lvi, ganho.Categoria.Cor);

                    lista.Items.Add(lvi);

                    nItens++;
                    valorTotal += ganho.Valor;
                }
            }
            lblItens.Text = nItens.ToString();
            lblValor.Text = "R$" + valorTotal.ToString("0.00");

        }

        private void ConfiguraCombo()
        {
            string filtroCategorias = "WHERE GANHO = 'true'";
            DataTable categorias = CTR_DadosSql.getCategorias(filtroCategorias);
            if (categorias.Rows.Count > 0)
            {

                cbCategorias.DataSource = categorias;
                cbCategorias.DisplayMember = "CATEGORIA_NOME";
                cbCategorias.ValueMember = "PK";

                cbCategorias.SelectedIndex = 0;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ErroCadastro() == 0)
            {
                string categoria = cbCategorias.SelectedValue.ToString();
                string descricao = txtBoxDescricao.Text;
                string valor = txtBoxValor.Text.Replace(',', '.');
                DateTime data = DateTime.Parse(dtpData.Text);

                CTR_DadosSql.novaOperacao(categoria, descricao, valor, data, "true");
                ConfiguraLista();
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
            if (txtBoxDescricao.Text.Length <= 0)
            {
                return 1;
            }
            if (txtBoxValor.Text.Length <= 0)
            {
                return 1;
            }

            //VERIFICA SE O VALOR DIGITADO É UM DOUBLE
            if (double.TryParse(txtBoxValor.Text, out double result))
            {
                return 0;
            }
            else
            {
                return 2;
            }
            return 0;
        }

        private void lista_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsBotaoDireito.Show(Cursor.Position);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lista.SelectedIndices[0];

            string categoria = lista.Items[index].SubItems[0].Text;
            string descricao = lista.Items[index].SubItems[1].Text;
            double valor = double.Parse(lista.Items[index].SubItems[2].Text.Replace("R$", ""));
            string dt = DateTime.Parse(lista.Items[index].SubItems[3].Text).ToString("dd/MM/yyyy");
            DateTime data = DateTime.Parse(dt);

            string filtroCategoria = "WHERE CATEGORIA_NOME = '" + categoria + "'";
            DataTable categoriaTable = CTR_DadosSql.getCategorias(filtroCategoria);
            int pkCategoria = int.Parse(categoriaTable.Rows[0]["PK"].ToString());

            string filtroGasto = "WHERE PK = " + lista.Items[index].SubItems[4].Text;
            FRM_GastoEditar f = new FRM_GastoEditar(filtroGasto, pkCategoria, descricao, valor, data);

            f.ShowDialog();
            f.Dispose();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ConfiguraLista();
            ConfiguraCombo();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FRM_GanhosCategorias f = new FRM_GanhosCategorias();

            f.ShowDialog();
            f.Dispose();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer excluir esse gasto?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int index = lista.SelectedIndices[0];
                string pk = lista.Items[index].SubItems[4].Text;

                string filtroGanho = "WHERE PK = '" + pk + "'";

                CTR_DadosSql.apagarOperacao(filtroGanho);
                MessageBox.Show("Gasto excluído com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAtualizar_Click(sender, e);
            }
        }
    }
}
