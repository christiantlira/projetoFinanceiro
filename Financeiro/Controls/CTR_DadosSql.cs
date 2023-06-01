using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controls
{
    public class CTR_DadosSql
    {
        private static string stringConexao = "Data Source = localhost; Initial Catalog = DB_CHRIS; User ID = sa; Password=wsx@123";

        public static DataTable getCategorias(string filtro = "")
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            string comando = "SELECT * FROM CATEGORIAS " + filtro + ";";

            CTR_Conexao con = new CTR_Conexao();
            DataTable dt = con.executarFila(comando, conexao);

            return dt;
        }

        public static DataTable getGastos(string filtro = "")
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            string comando = "SELECT * FROM GASTOS " + filtro + ";";

            CTR_Conexao con = new CTR_Conexao();
            DataTable dt = con.executarFila(comando, conexao);

            return dt;
        }

        public static DataTable novaCategoria(string categoria = "", string cor = "", bool essencial = false)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            string comando = "INSERT INTO CATEGORIAS (CATEGORIA_NOME, COR, ESSENCIAL) " +
                "VALUES ('" + categoria + "', '" + cor + "', '" + essencial + "');";

            CTR_Conexao con = new CTR_Conexao();
            DataTable dt = con.executarFila(comando, conexao);

            return dt;
        }

        public static DataTable novoGasto(string categoria, string descricao, string valor, DateTime data)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            string comando = "INSERT INTO GASTOS (CATEGORIA_FK, DESCRICAO, VALOR, DATA) " +
                "VALUES ('" + categoria + "', '" + descricao + "', '" + valor + "', '" + data + "');";

            CTR_Conexao con = new CTR_Conexao();
            DataTable dt = con.executarFila(comando, conexao);

            return dt;
        }

        public static DataTable editarCategoria(string filtro, string categoria = "", bool essencial = false, string cor = "")
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            string comando = "UPDATE CATEGORIAS SET " +
                "CATEGORIA_NOME = '" + categoria + "', COR = '" + cor + "', ESSENCIAL = '" + essencial + "'" +
                filtro;

            CTR_Conexao con = new CTR_Conexao();
            DataTable dt = con.executarFila(comando, conexao);

            return dt;
        }

        public static DataTable editarGasto(string filtro, int categoria_fk, string descricao, string valor, DateTime data)
        {
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            string comando = "UPDATE GASTOS SET " +
                "CATEGORIA_FK = " + categoria_fk + ", DESCRICAO = '" + descricao + "', VALOR = '" + valor + "', DATA = '" + data + "' "
                + filtro;

            CTR_Conexao con = new CTR_Conexao();
            DataTable dt = con.executarFila(comando, conexao);

            return dt;
        }
    }
}