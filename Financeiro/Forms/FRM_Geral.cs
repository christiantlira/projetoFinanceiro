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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Financeiro.Forms
{
    public partial class FRM_Geral : Form
    {
        public FRM_Geral()
        {
            InitializeComponent();
        }

        private void FRM_Geral_Load(object sender, EventArgs e)
        {
            ConfiguraLista();
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
            lista.Columns.Add("Descrição", 200);
            lista.Columns.Add("Valor", 200);
            lista.Columns.Add("Data", 200);

            DataTable operacoes = CTR_DadosSql.getOperacao();

            double ganho = 0;
            double gasto = 0;
            double soma = 0;
            int itens = 0;

            HashSet<Categoria> categorias = new HashSet<Categoria>();

            if (operacoes.Rows.Count > 0)
            {
                foreach (DataRow operacao in operacoes.Rows)
                {
                    string filtroCategoria = "WHERE PK = '" + operacao["CATEGORIA_FK"].ToString() + "'";

                    DataTable catDT = CTR_DadosSql.getCategorias(filtroCategoria);
                    Categoria categoria = new Categoria();
                    categoria.Id = int.Parse(catDT.Rows[0]["PK"].ToString());
                    categoria.Name = catDT.Rows[0]["CATEGORIA_NOME"].ToString();
                    categoria.Essencial = catDT.Rows[0]["ESSENCIAL"].ToString() == "1";
                    categoria.Cor = catDT.Rows[0]["COR"].ToString();
                    categoria.isGanho = bool.Parse(catDT.Rows[0]["GANHO"].ToString());

                    categorias.Add(categoria);

                    Console.WriteLine(categorias);
                    Console.WriteLine(categoria);

                    Operacao opera = new Operacao();
                    opera.Id = int.Parse(operacao["PK"].ToString());
                    opera.Categoria = categoria;
                    opera.Descricao = operacao["DESCRICAO"].ToString();
                    opera.Valor = double.Parse(operacao["VALOR"].ToString());
                    opera.Data = DateTime.Parse(operacao["DATA"].ToString());
                    opera.isGanho = bool.Parse(operacao["GANHO"].ToString());

                    ListViewItem item = new ListViewItem(opera.Categoria.Name);
                    item.SubItems.Add(opera.Descricao);
                    item.SubItems.Add("R$" + opera.Valor.ToString("0.00"));
                    item.SubItems.Add(opera.Data.ToString("dd 'de' MMMM 'de' yyyy"));

                    if (opera.isGanho)
                    {
                        item.BackColor = ColorTranslator.FromHtml("#D0CDC9");
                        item.ForeColor = Color.Black;
                        ganho += opera.Valor;
                        soma += opera.Valor;
                    }
                    else if (!opera.isGanho)
                    {
                        item.BackColor = ColorTranslator.FromHtml("#4C5B6C");
                        item.ForeColor = Color.White;
                        gasto += opera.Valor;
                        soma -= opera.Valor;
                    }

                    lista.Items.Add(item);
                    itens++;
                }
                tbGanho.Text = "R$" + ganho.ToString("0.00");
                tbGasto.Text = "R$" + gasto.ToString("0.00");
                tbResta.Text = "R$" + soma.ToString("0.00");
                tbItens.Text = itens.ToString();
            }

            if (categorias.Count > 0)
            {
                int distanceGastos = 0;
                int distanceGanhos = 0;
                foreach (Categoria categoria in categorias)
                {
                    string filtroCat = "WHERE CATEGORIA_FK = '" + categoria.Id + "'";
                    DataTable operacaos = CTR_DadosSql.getOperacao(filtroCat);
                    double valorOperacoes = 0;
                    foreach (DataRow operacao in operacaos.Rows)
                    {
                        valorOperacoes += double.Parse(operacao["VALOR"].ToString());
                    }

                    // Criar instância da Label
                    Label label = new Label();

                    // Configurar as propriedades da Label
                    label.Size = new Size(200, 20);

                    label.Name = "lbl" + categoria.Name;
                    label.Text = categoria.Name + ":";
                    label.AutoSize = true;

                    // Criar instância da TextBox
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();

                    // Configurar as propriedades da TextBox
                    textBox.Size = new Size(100, 23);

                    textBox.Name = "tb" + categoria.Name;
                    textBox.Multiline = true;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Enabled = false;
                    textBox.Text = "R$" + valorOperacoes.ToString("0.00");

                    // Adicionar a Label e a TextBox à TabPage
                    if (!categoria.isGanho)
                    {
                        label.Location = new Point(10, 10 + distanceGastos);
                        textBox.Location = new Point(10, 28 + distanceGastos);

                        tpGastos.Controls.Add(label);
                        tpGastos.Controls.Add(textBox);

                        distanceGastos += 56;
                    }
                    else
                    {
                        label.Location = new Point(10, 10 + distanceGanhos);
                        textBox.Location = new Point(10, 28 + distanceGanhos);

                        tpGanhos.Controls.Add(label);
                        tpGanhos.Controls.Add(textBox);

                        distanceGanhos += 56;
                    }
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ConfiguraLista();
        }
    }
}
