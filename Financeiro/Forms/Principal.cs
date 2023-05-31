using Financeiro.Controls;
using Financeiro.Forms;
using Financeiro.Models;
using System.Data;
using System.Globalization;

namespace Financeiro
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
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

            DataTable gastos = CTR_DadosSql.getGastos();
            if (gastos.Rows.Count > 0)
            {
                foreach (DataRow gasto in gastos.Rows)
                {
                    string filtroCategoria = "WHERE PK = '" + gasto["CATEGORIA_FK"].ToString() + "'";
                    DataTable cat = CTR_DadosSql.getCategorias(filtroCategoria);

                    Categoria categoria = new Categoria();
                    categoria.Name = cat.Rows[0]["CATEGORIA_NOME"].ToString();
                    categoria.Cor = cat.Rows[0]["COR"].ToString();

                    Gasto cust = new Gasto();
                    cust.Categoria = categoria;
                    cust.Descricao = gasto["DESCRICAO"].ToString();
                    cust.Valor = double.Parse(gasto["VALOR"].ToString());
                    cust.Data = DateTime.Parse(gasto["DATA"].ToString());


                    ListViewItem lvi = new ListViewItem(cust.Categoria.Name);
                    lvi.SubItems.Add(cust.Descricao);
                    lvi.SubItems.Add(cust.Valor.ToString("0.00"));
                    lvi.SubItems.Add(cust.Data.ToString("dd 'de' MMMM 'de' yyyy"));

                    FRM_Categorias.setBackColor(lvi, cust.Categoria.Cor);

                    lista.Items.Add(lvi);
                }
            }

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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FRM_Categorias f = new FRM_Categorias();

            f.ShowDialog();
            f.Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ErroCadastro() == 0)
            {
                string categoria = cbCategorias.SelectedValue.ToString();
                string descricao = txtBoxDescricao.Text;
                string valor = txtBoxValor.Text.Replace(',', '.');
                DateTime data = DateTime.Parse(dtpData.Text);

                CTR_DadosSql.novoGasto(categoria, descricao, valor, data);
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
    }
}