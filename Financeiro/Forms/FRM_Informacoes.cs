using Financeiro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro.Forms
{
    public partial class FRM_Informacoes : Form
    {
        public FRM_Informacoes()
        {
            InitializeComponent();
        }

        private void FRM_Informacoes_Load(object sender, EventArgs e)
        {
            ConfiguraTextBoxes();
        }

        private void ConfiguraTextBoxes()
        {
            double valorEssenciais = 0;
            double valorNonEssenciais = 0;

            DataTable operacoes = CTR_DadosSql.getOperacao();

            if (operacoes.Rows.Count > 0)
            {
                foreach (DataRow operacao in operacoes.Rows)
                {
                    string pkCategoria = operacao["CATEGORIA_FK"].ToString();
                    bool isGanho = bool.Parse(operacao["GANHO"].ToString());
                    string filtroCategoria = "WHERE PK = '" + pkCategoria + "'";
                    DataTable categoria = CTR_DadosSql.getCategorias(filtroCategoria);

                    bool isEssencial = bool.Parse(categoria.Rows[0]["ESSENCIAL"].ToString());

                    if (isEssencial && !isGanho)
                    {
                        valorEssenciais += double.Parse(operacao["VALOR"].ToString());
                    }
                    else if (!isEssencial && !isGanho)
                    {
                        valorNonEssenciais += double.Parse(operacao["VALOR"].ToString());
                    }
                }
            }

            tbGastosEssenciais.Text = "R$" + valorEssenciais.ToString("0.00");
            tbGastosNaoEssenciais.Text = "R$" + valorNonEssenciais.ToString("0.00");
            tbReserva.Text = "R$" + CalcularReservaEmergencia().ToString("0.00");

            double valorNonEssencial = 0;
            double valorEssencial = 0;
            int meses = 0;
            for (int i = 0; i < 12; i++)
            {
                string filtro = "WHERE MONTH(DATA) = '" + i + "'";
                DataTable Operacoes = CTR_DadosSql.getOperacao(filtro);
                if (Operacoes.Rows.Count > 0)
                {
                    meses++;
                    foreach (DataRow operacao in Operacoes.Rows)
                    {
                        string pkCategoria = operacao["CATEGORIA_FK"].ToString();
                        bool isGanho = bool.Parse(operacao["GANHO"].ToString());

                        string filtroCategoria = "WHERE PK = '" + pkCategoria + "'";
                        DataTable categoria = CTR_DadosSql.getCategorias(filtroCategoria);

                        bool isEssencial = bool.Parse(categoria.Rows[0]["ESSENCIAL"].ToString());

                        if (isEssencial && !isGanho)
                        {
                            valorEssencial += double.Parse(operacao["VALOR"].ToString());
                        }
                        else if (!isEssencial && !isGanho)
                        {
                            valorNonEssencial += double.Parse(operacao["VALOR"].ToString());
                        }
                    }
                }
            }
            double valorEssePMes = valorEssencial / meses;
            double valorNaoEssePMes = valorNonEssencial / meses;

            tbEssenPMes.Text = "R$" + valorEssePMes.ToString("0.00");
            tbNaoEssenPMes.Text = "R$" + valorNaoEssePMes.ToString("0.00");

        }
        private double CalcularReservaEmergencia()
        {
            double valorNonEssencial = 0;
            double valorEssencial = 0;
            int meses = 0;

            for (int i = 0; i < 12; i++)
            {
                string filtro = "WHERE MONTH(DATA) = '" + i + "'";
                DataTable Operacoes = CTR_DadosSql.getOperacao(filtro);
                if (Operacoes.Rows.Count > 0)
                {
                    meses++;
                    foreach (DataRow operacao in Operacoes.Rows)
                    {
                        string pkCategoria = operacao["CATEGORIA_FK"].ToString();
                        bool isGanho = bool.Parse(operacao["GANHO"].ToString());

                        string filtroCategoria = "WHERE PK = '" + pkCategoria + "'";
                        DataTable categoria = CTR_DadosSql.getCategorias(filtroCategoria);

                        bool isEssencial = bool.Parse(categoria.Rows[0]["ESSENCIAL"].ToString());

                        if (isEssencial && !isGanho)
                        {
                            valorEssencial += double.Parse(operacao["VALOR"].ToString());
                        }
                        else if (!isEssencial && !isGanho)
                        {
                            valorNonEssencial += double.Parse(operacao["VALOR"].ToString());
                        }
                    }
                }
            }
            double mediaEssencial = valorEssencial / meses;
            double mediaNonEssencial = valorNonEssencial / meses;

            double reserva = (mediaEssencial * 6) + ((mediaNonEssencial * 6) * 25 / 100);

            return reserva;
        }
    }
}
