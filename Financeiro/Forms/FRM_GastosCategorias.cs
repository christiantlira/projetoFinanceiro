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
    public partial class FRM_GastosCategorias : Form
    {
        public FRM_GastosCategorias()
        {
            InitializeComponent();
        }

        private void FRM_Categorias_Load(object sender, EventArgs e)
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
            lista.Columns.Add("Essencial", 195);
            lista.Columns.Add("Cor", 300);

            string filtroCategorias = "WHERE GANHO = 'false'";
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

                    setBackColor(lvi, categoria.Cor);

                    lista.Items.Add(lvi);
                }
            }
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CTR_DadosSql.novaCategoria(tbCategoria.Text, cbCor.Text, cbEssencial.Text.ToLower() == "essencial", false);
            ConfiguraLista();
        }

        public static ListViewItem setBackColor(ListViewItem item, string cor)
        {
            Color azul = ColorTranslator.FromHtml("#D0CDC9");
            Color cinza = ColorTranslator.FromHtml("#918981");
            Color vermelho = ColorTranslator.FromHtml("#9FA4A3");
            Color amarelo = ColorTranslator.FromHtml("#717B7F");
            Color laranja = ColorTranslator.FromHtml("#667579");
            Color roxo = ColorTranslator.FromHtml("#4C5B6C");
            Color verde = ColorTranslator.FromHtml("#3A4E4F");

            switch (cor.ToLower())
            {
                case "azul":
                    item.BackColor = azul;
                    item.ForeColor = Color.Black;
                    break;
                case "amarelo":
                    item.BackColor = amarelo;
                    item.ForeColor = Color.Black;
                    break;
                case "cinza":
                    item.BackColor = cinza;
                    item.ForeColor = Color.Black;
                    break;
                case "vermelho":
                    item.BackColor = vermelho;
                    item.ForeColor = Color.White;
                    break;
                case "laranja":
                    item.BackColor = laranja;
                    item.ForeColor = Color.White;
                    break;
                case "roxo":
                    item.BackColor = roxo;
                    item.ForeColor = Color.White;
                    break;
                case "verde":
                    item.BackColor = verde;
                    item.ForeColor = Color.White;
                    break;
                default:
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                    break;
            }

            return item;
        }

        private void lista_MouseClick_1(object sender, MouseEventArgs e)
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
            bool essencial = lista.Items[index].SubItems[1].Text.ToLower() == "sim";
            string cor = lista.Items[index].SubItems[2].Text;
            string id = lista.Items[index].SubItems[3].Text;

            string filtro = "WHERE PK = '" + id + "';";

            FRM_CategoriaEditar f = new FRM_CategoriaEditar(filtro, categoria, essencial, cor);

            f.ShowDialog();
            f.Dispose();
        }
    }
}
