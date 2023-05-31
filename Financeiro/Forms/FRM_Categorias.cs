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
    public partial class FRM_Categorias : Form
    {
        public FRM_Categorias()
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

            lista.Columns.Add("Categoria", 400);
            lista.Columns.Add("Cor", 300);

            DataTable tabelaCategoria = CTR_DadosSql.getCategorias();
            if (tabelaCategoria.Rows.Count > 0)
            {
                foreach (DataRow linhaCategoria in tabelaCategoria.Rows)
                {
                    Categoria categoria = new Categoria();

                    categoria.Name = linhaCategoria["CATEGORIA_NOME"].ToString();
                    categoria.Cor = linhaCategoria["COR"].ToString();

                    ListViewItem lvi = new ListViewItem(categoria.Name);
                    lvi.SubItems.Add(categoria.Cor);

                    setBackColor(lvi, categoria.Cor);

                    lista.Items.Add(lvi);
                }
            }
        }

        private void ConfiguraCombo()
        {
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
            CTR_DadosSql.novaCategoria(tbCategoria.Text, cbCor.Text);
            ConfiguraLista();
        }

        public static ListViewItem setBackColor(ListViewItem item, string cor)
        {
            Color azul = Color.Azure;
            Color cinza = Color.Gainsboro;
            Color vermelho = Color.Tomato;
            Color amarelo = Color.LightGoldenrodYellow;
            Color laranja = Color.LightSalmon;
            Color roxo = Color.MediumOrchid;
            Color verde = Color.LightGreen;

            switch (cor.ToLower())
            {
                case "azul":
                    item.BackColor = azul;
                    break;
                case "amarelo":
                    item.BackColor = amarelo;
                    break;
                case "cinza":
                    item.BackColor = cinza;
                    break;
                case "vermelho":
                    item.BackColor = vermelho;
                    break;
                case "laranja":
                    item.BackColor = laranja;
                    break;
                case "roxo":
                    item.BackColor = roxo;
                    break;
                case "verde":
                    item.BackColor = verde;
                    break;
                default:
                    item.BackColor = Color.White;
                    break;
            }

            return item;
        }
    }
}
