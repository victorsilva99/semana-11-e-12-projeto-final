using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSystems.ASPNETCoreMVC.Torneio.DAO
{
    public static class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string conectionString = (@"Data Source = CTS1A519954\SQLEXPRESS; Initial Catalog = db_ProjetoFinal; Integrated Security = True");
            SqlConnection iniciarConexao = new SqlConnection(conectionString);
            iniciarConexao.Open();
            return iniciarConexao;
        }
    }
}
