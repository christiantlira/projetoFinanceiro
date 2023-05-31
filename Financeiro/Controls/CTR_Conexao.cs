using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Controls
{
    class CTR_Conexao
    {
        public DataTable executarFila(string sql, SqlConnection conexao)
        {
            int i_error = 0;
            eReinicioError:;

            try
            {
                SqlCommand sqlComm = new SqlCommand(sql, conexao);

                SqlDataAdapter da = new SqlDataAdapter(sqlComm);

                da.SelectCommand.CommandTimeout = TimeSpan.FromMinutes(210).Seconds;

                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                conexao.Close();

                return dt;
            }
            catch (Exception e)
            {
                i_error++;

                if (i_error == 3)
                {
                    throw e;
                }

                goto eReinicioError;

            }
        }
    }
}
