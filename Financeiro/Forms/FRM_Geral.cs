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

            if (operacoes.Rows.Count > 0)
            {
                foreach (DataRow operacao in operacoes.Rows)
                {
                    string filtroCategoria = "WHERE PK = '" + operacao["CATEGORIA_FK"].ToString() + "'";

                    DataTable catDT = CTR_DadosSql.getCategorias(filtroCategoria);
                    Categoria categoria = new Categoria();
                    categoria.Name = catDT.Rows[0]["CATEGORIA_NOME"].ToString();
                    categoria.Essencial = catDT.Rows[0]["ESSENCIAL"].ToString() == "1";
                    categoria.Cor = catDT.Rows[0]["COR"].ToString();

                    Operacao opera = new Operacao();
                    opera.Id = int.Parse(operacao["PK"].ToString());
                    opera.Categoria = categoria;
                    opera.Descricao = operacao["DESCRICAO"].ToString();
                    opera.Valor = double.Parse(operacao["VALOR"].ToString());
                    opera.Data = DateTime.Parse(operacao["DATA"].ToString());
                    opera.isGanho = bool.Parse(operacao["GANHO"].ToString());

                    ListViewItem item = new ListViewItem(opera.Categoria.Name);
                    item.SubItems.Add(opera.Descricao);
                    item.SubItems.Add("R$"+ opera.Valor.ToString("0.00"));
                    item.SubItems.Add(opera.Data.ToString("dd 'de' MMMM 'de' yyyy"));

                    if (opera.isGanho)
                    {
                        item.BackColor = Color.LightGreen;
                        ganho += opera.Valor;
                        soma += opera.Valor;
                    } else if (!opera.isGanho)
                    {
                        item.BackColor = Color.Tomato;
                        gasto += opera.Valor;
                        soma -= opera.Valor;
                    }

                    lista.Items.Add(item);
                    itens++;
                }
                tbGanho.Text = ganho.ToString();
                tbGasto.Text = gasto.ToString();
                tbResta.Text = soma.ToString();
                tbItens.Text = itens.ToString();
            }
        }
    }
}
