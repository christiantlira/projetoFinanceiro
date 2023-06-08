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

        private void ConfiguraLista(string filtro = "")
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
            lista.Columns.Add("Descrição", 400);
            lista.Columns.Add("Valor", 200);
            lista.Columns.Add("Data", 200);


            HashSet<Categoria> categorias = new HashSet<Categoria>();
            DataTable categoriasDT = CTR_DadosSql.getCategorias();
            foreach (DataRow row in categoriasDT.Rows)
            {
                Categoria categoria = new Categoria();
                categoria.Id = int.Parse(row["PK"].ToString());
                categoria.Name = row["CATEGORIA_NOME"].ToString();
                categoria.Essencial = bool.Parse(row["ESSENCIAL"].ToString());
                categoria.Ganho = bool.Parse(row["GANHO"].ToString());

                categorias.Add(categoria);
            }

            
            CalcularGastos(filtro == "");
            CalcularGanhos(filtro == "");
            double resta = double.Parse(tbGanho.Text.Replace("R$", "")) - double.Parse(tbGasto.Text.Replace("R$", ""));
            tbResta.Text = "R$" + resta.ToString("0.00");
            CalcularEssenciais(filtro == "");
            CalcularNaoEssenciais(filtro == "");


            int distanceGanhos = 0;
            int distanceGastos = 0;
            tpGastos.Controls.Clear();
            tpGanhos.Controls.Clear();
            foreach (Categoria cat in categorias)
            {
                string dataInicio = DateTime.Parse(dtpDe.Text).ToString("yyyy-MM-dd");
                string dataFinal = DateTime.Parse(dtpAte.Text).ToString("yyyy-MM-dd");

                string filtroSum = "";
                if (filtro == "")
                {
                    int mes = int.Parse(DateTime.Now.ToString("MM"));
                    filtroSum = "WHERE GANHO = '" + cat.Ganho +
                        "' AND CATEGORIA_FK = '" + cat.Id +
                        "' AND MONTH(DATA) = '" + mes + "' ";
                }
                else
                {
                    filtroSum = "WHERE GANHO = '" + cat.Ganho +
                        "' AND CATEGORIA_FK = '" + cat.Id +
                        "' AND DATA BETWEEN '" + dataInicio +
                        "' AND '" + dataFinal + "' ";
                }

                DataTable sum = CTR_DadosSql.getSum(filtroSum, "GANHO");

                double total = 0;
                if (sum.Rows.Count > 0)
                {
                    total = double.Parse(sum.Rows[0]["TOTAL"].ToString());
                }

                // Criar instância da Label
                Label label = new Label();

                // Configurar as propriedades da Label
                label.Size = new Size(200, 20);

                label.Name = "lbl" + cat.Name;
                label.Text = cat.Name + ":";
                label.AutoSize = true;

                // Criar instância da TextBox
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();

                // Configurar as propriedades da TextBox
                textBox.Size = new Size(100, 23);

                textBox.Name = "tb" + cat.Name;
                textBox.Multiline = true;
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.Enabled = false;
                textBox.Text = "R$" + total.ToString("0.00");

                // Adicionar a Label e a TextBox à TabPage
                if (!cat.Ganho)
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

            if (filtro == "")
            {
                int mes = int.Parse(DateTime.Now.ToString("MM"));
                filtro = "WHERE MONTH(DATA) = '" + mes + "'";
            }

            DataTable operacoes = CTR_DadosSql.getView(filtro);
            int itens = 0;
            if (operacoes.Rows.Count > 0)
            {
                foreach (DataRow row in operacoes.Rows)
                {
                    itens++;
                    //REGRISTRO DE CATEGORIA
                    Categoria categoria = new Categoria();
                    categoria.Id = int.Parse(row["CATEGORIA_FK"].ToString());
                    categoria.Name = row["CATEGORIA_NOME"].ToString();
                    categoria.Ganho = bool.Parse(row["GANHO"].ToString());
                    categoria.Essencial = bool.Parse(row["ESSENCIAL"].ToString());

                    //REGISTRO DE OPERAÇÃO
                    Operacao operacao = new Operacao();
                    operacao.Categoria = categoria;
                    operacao.Descricao = row["DESCRICAO"].ToString().ToUpper();
                    operacao.Valor = double.Parse(row["VALOR"].ToString());
                    operacao.Data = DateTime.Parse(row["DATA"].ToString());
                    operacao.Ganho = bool.Parse(row["GANHO"].ToString());

                    //CRIAÇÃO DO ITEM DA LISTA
                    ListViewItem item = new ListViewItem(categoria.Name);
                    item.SubItems.Add(operacao.Descricao);
                    item.SubItems.Add("R$" + operacao.Valor.ToString("0.00"));
                    item.SubItems.Add(operacao.Data.ToString("dd/MM/yyyy"));

                    if (operacao.Ganho)
                    {
                        item.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        item.BackColor = Color.Tomato;
                    }

                    //ADICIONANDO ITEM NA LISTA
                    lista.Items.Add(item);
                }
            }
            tbItens.Text = itens.ToString();
        }

        private void CalcularGastos(bool hasFiltro)
        {
            int mes = int.Parse(DateTime.Now.ToString("MM"));
            string dataInicio = DateTime.Parse(dtpDe.Text).ToString("yyyy-MM-dd");
            string dataFinal = DateTime.Parse(dtpAte.Text).ToString("yyyy-MM-dd");

            string filtroSum = "";
            if (hasFiltro)
            {
                filtroSum = "WHERE GANHO = 'false' AND MONTH(DATA) = '" + mes + "' ";
            }
            else
            {
                filtroSum = "WHERE GANHO = 'false' " +
                    "AND DATA BETWEEN '" + dataInicio +
                    "' AND '" + dataFinal + "' ";
            }
            DataTable sum = CTR_DadosSql.getSum(filtroSum, "GANHO");

            double total = 0;
            if (sum.Rows.Count > 0)
            {
                total = double.Parse(sum.Rows[0]["TOTAL"].ToString());
            }
            tbGasto.Text = "R$" + total.ToString("0.00");
        }

        private void CalcularGanhos(bool hasFiltro)
        {
            int mes = int.Parse(DateTime.Now.ToString("MM"));
            string dataInicio = DateTime.Parse(dtpDe.Text).ToString("yyyy-MM-dd");
            string dataFinal = DateTime.Parse(dtpAte.Text).ToString("yyyy-MM-dd");

            string filtroSum = "";
            if (hasFiltro)
            {
                filtroSum = "WHERE GANHO = 'true' AND MONTH(DATA) = '" + mes + "' ";
            }
            else
            {
                filtroSum = "WHERE GANHO = 'true' " +
                    "AND DATA BETWEEN '" + dataInicio +
                    "' AND '" + dataFinal + "' ";
            }
            DataTable sum = CTR_DadosSql.getSum(filtroSum, "GANHO");

            double total = 0;
            if (sum.Rows.Count > 0)
            {
                total = double.Parse(sum.Rows[0]["TOTAL"].ToString());
            }
            tbGanho.Text = "R$" + total.ToString("0.00");
        }

        private void CalcularEssenciais(bool hasFiltro)
        {
            int mes = int.Parse(DateTime.Now.ToString("MM"));
            string dataInicio = DateTime.Parse(dtpDe.Text).ToString("yyyy-MM-dd");
            string dataFinal = DateTime.Parse(dtpAte.Text).ToString("yyyy-MM-dd");

            string filtroSum = "";
            if (hasFiltro)
            {
                filtroSum = "WHERE ESSENCIAL = 'true'  AND GANHO = 'false'" +
                    "AND MONTH(DATA) = '" + mes + "' ";
            }
            else
            {
                filtroSum = "WHERE ESSENCIAL = 'true' AND GANHO = 'false'" +
                    "AND DATA BETWEEN '" + dataInicio +
                    "' AND '" + dataFinal + "' ";
            }
            DataTable sum = CTR_DadosSql.getSum(filtroSum, "ESSENCIAL");

            double total = 0;
            if (sum.Rows.Count > 0)
            {
                total = double.Parse(sum.Rows[0]["TOTAL"].ToString());
            }
            tbEssenciais.Text = "R$" + total.ToString("0.00");
        }
        private void CalcularNaoEssenciais(bool hasFiltro)
        {
            int mes = int.Parse(DateTime.Now.ToString("MM"));
            string dataInicio = DateTime.Parse(dtpDe.Text).ToString("yyyy-MM-dd");
            string dataFinal = DateTime.Parse(dtpAte.Text).ToString("yyyy-MM-dd");

            string filtroSum = "";
            if (hasFiltro)
            {
                filtroSum = "WHERE ESSENCIAL = 'false'  AND GANHO = 'false'" +
                    "AND MONTH(DATA) = '" + mes + "' ";
            }
            else
            {
                filtroSum = "WHERE ESSENCIAL = 'false' AND GANHO = 'false'" +
                    "AND DATA BETWEEN '" + dataInicio +
                    "' AND '" + dataFinal + "' ";
            }
            DataTable sum = CTR_DadosSql.getSum(filtroSum, "ESSENCIAL");

            double total = 0;
            if (sum.Rows.Count > 0)
            {
                total = double.Parse(sum.Rows[0]["TOTAL"].ToString());
            }
            tbNaoEssenciais.Text = "R$" + total.ToString("0.00");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string filtro = "WHERE DATA BETWEEN '" + DateTime.Parse(dtpDe.Text).ToString("yyyy-MM-dd") + "' AND '" + DateTime.Parse(dtpAte.Text).ToString("yyyy-MM-dd") + "' ";
            ConfiguraLista(filtro);
        }
    }
}
