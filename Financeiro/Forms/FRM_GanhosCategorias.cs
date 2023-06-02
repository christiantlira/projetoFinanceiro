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
    public partial class FRM_GanhosCategorias : Form
    {
        public FRM_GanhosCategorias()
        {
            InitializeComponent();
        }

        private void FRM_CategoriasGanhos_Load(object sender, EventArgs e)
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

            lista.Columns.Add("Categoria", 200);
            lista.Columns.Add("Salário", 195);
            lista.Columns.Add("Cor", 300);

            string filtroCategorias = "WHERE GANHO = 'true'";
            DataTable tabelaCategoria = CTR_DadosSql.getCategorias(filtroCategorias);

            if (tabelaCategoria.Rows.Count > 0)
            {
                foreach (DataRow linhaCategoria in tabelaCategoria.Rows)
                {
                    Categoria categoria = new Categoria();

                    categoria.Id = int.Parse(linhaCategoria["PK"].ToString());
                    categoria.Name = linhaCategoria["CATEGORIA_NOME"].ToString();
                    categoria.Essencial = bool.Parse(linhaCategoria["ESSENCIAL"].ToString());
                    categoria.Cor = linhaCategoria["COR"].ToString();

                    string essencial = "";

                    if (categoria.Essencial)
                    {
                        essencial = "Sim";
                    }
                    else
                    {
                        essencial = "Não";
                    }

                    ListViewItem lvi = new ListViewItem(categoria.Name);
                    lvi.SubItems.Add(essencial);
                    lvi.SubItems.Add(categoria.Cor);
                    lvi.SubItems.Add(categoria.Id.ToString());

                    FRM_GastosCategorias.setBackColor(lvi, categoria.Cor);

                    lista.Items.Add(lvi);
                }
            }
        }

        private void ConfiguraCombo()
        {
            //COMBO CORES
            cbCor.Items.Clear();

            cbCor.Items.Add("Azul");
            cbCor.Items.Add("Cinza");
            cbCor.Items.Add("Vermelho");
            cbCor.Items.Add("Amarelo");
            cbCor.Items.Add("Laranja");
            cbCor.Items.Add("Roxo");
            cbCor.Items.Add("Verde");
            cbCor.Items.Add("Branco");

            cbCor.Sorted = true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CTR_DadosSql.novaCategoria(tbCategoria.Text, cbCor.Text, cbSalario.Checked, true);
            ConfiguraLista();
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
            //PEGAR INDEX DA LINHA SELECIONADA
            int index = lista.SelectedIndices[0];

            string categoria = lista.Items[index].SubItems[0].Text;
            bool salario = cbSalario.Checked;
            string cor = lista.Items[index].SubItems[2].Text;
            string id = lista.Items[index].SubItems[3].Text;

            string filtro = "WHERE PK = '" + id + "';";

            FRM_CategoriaEditar f = new FRM_CategoriaEditar(filtro, categoria, salario, cor);

            f.ShowDialog();
            f.Dispose();
        }
    }
}
