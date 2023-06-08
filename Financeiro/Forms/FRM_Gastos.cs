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
    public partial class FRM_Gastos : Form
    {
        public FRM_Gastos()
        {
            InitializeComponent();
        }

        private void FRM_Gastos_Load(object sender, EventArgs e)
        {
            ConfiguraLista();
            ConfiguraCombo();
        }
        private void ConfiguraLista(string filtroGastos = "")
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

            if (filtroGastos.Length == 0)
            {
                int mes = int.Parse(DateTime.Now.ToString("MM"));
                filtroGastos = "WHERE GANHO = 'false' AND MONTH(DATA) = '" + mes + "'";
            }

            DataTable gastos = CTR_DadosSql.getOperacao(filtroGastos);
            if (gastos.Rows.Count > 0)
            {
                foreach (DataRow gasto in gastos.Rows)
                {
                    string filtroCategoria = "WHERE PK = '" + gasto["CATEGORIA_FK"].ToString() + "'";
                    DataTable cat = CTR_DadosSql.getCategorias(filtroCategoria);

                    Categoria categoria = new Categoria();
                    categoria.Name = cat.Rows[0]["CATEGORIA_NOME"].ToString();
                    categoria.Cor = cat.Rows[0]["COR"].ToString();

                    Operacao cust = new Operacao();
                    cust.Id = int.Parse(gasto["PK"].ToString());
                    cust.Categoria = categoria;
                    cust.Descricao = gasto["DESCRICAO"].ToString();
                    cust.Valor = double.Parse(gasto["VALOR"].ToString());
                    cust.Data = DateTime.Parse(gasto["DATA"].ToString());


                    ListViewItem lvi = new ListViewItem(cust.Categoria.Name);
                    lvi.SubItems.Add(cust.Descricao);
                    lvi.SubItems.Add("R$" + cust.Valor.ToString("0.00"));
                    lvi.SubItems.Add(cust.Data.ToString("dd 'de' MMMM 'de' yyyy"));
                    lvi.SubItems.Add(cust.Id.ToString());

                    FRM_GastosCategorias.setBackColor(lvi, cust.Categoria.Cor);

                    lista.Items.Add(lvi);

                    nItens++;
                    valorTotal += cust.Valor;
                }
            }
            lblItens.Text = nItens.ToString();
            lblValor.Text = "R$" + valorTotal.ToString("0.00");

        }

        private void ConfiguraCombo()
        {
            string filtroCategorias = "WHERE GANHO = 'false'";
            DataTable categorias = CTR_DadosSql.getCategorias(filtroCategorias);
            if (categorias.Rows.Count > 0)
            {

                cbCategorias.DataSource = categorias;
                cbCategorias.DisplayMember = "CATEGORIA_NOME";
                cbCategorias.ValueMember = "PK";

                cbCategorias.SelectedIndex = 0;

                DataTable categoriasFiltragem = categorias.Copy();
                DataRow newRow = categoriasFiltragem.NewRow();
                string coluna = "CATEGORIA_NOME";
                newRow[coluna] = "-TODOS-";
                categoriasFiltragem.Rows.Add(newRow);
                categoriasFiltragem.DefaultView.Sort = coluna;

                cbGCat.DataSource = categoriasFiltragem;
                cbGCat.DisplayMember = "CATEGORIA_NOME";
                cbGCat.ValueMember = "PK";

                cbGCat.SelectedIndex = 0;
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

                CTR_DadosSql.novaOperacao(categoria, descricao, valor, data, "false");
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ConfiguraLista();
            ConfiguraCombo();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FRM_GastosCategorias f = new FRM_GastosCategorias();
            f.ShowDialog();
            f.Dispose();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer excluir esse gasto?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int index = lista.SelectedIndices[0];
                string pk = lista.Items[index].SubItems[4].Text;

                string filtroGasto = "WHERE PK = '" + pk + "'";

                CTR_DadosSql.apagarOperacao(filtroGasto);
                MessageBox.Show("Gasto excluído com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAtualizar_Click(sender, e);
            }
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            btnFiltrar.Enabled = false;
            string filtro = "WHERE GANHO = 'false' ";


            if (cbGCat.Text != "-TODOS-")
            {
                filtro += "AND CATEGORIA_FK = '" + cbGCat.SelectedValue.ToString() + "' ";
            }


            if (tbGDesc.Text.Length > 0)
            {
                filtro += "AND DESCRICAO LIKE '%" + tbGDesc.Text + "%' ";
            }


            if (tbGVal.Text.Length > 0)
            {
                filtro += "AND VALOR = '" + tbGVal.Text.Replace(",", ".") + "' ";
            }

            string dataInicio = DateTime.Parse(dtpGDe.Text).ToString("yyyy-MM-dd");
            string dataFinal = DateTime.Parse(dtpGAte.Text).ToString("yyyy-MM-dd");

            filtro += "AND DATA BETWEEN '" + dataInicio + "' AND '" + dataFinal + "'";

            ConfiguraLista(filtro);
            btnFiltrar.Enabled = true;
        }
    }
}
