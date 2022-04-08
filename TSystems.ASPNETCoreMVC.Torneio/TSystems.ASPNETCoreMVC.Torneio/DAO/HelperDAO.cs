using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TSystems.ASPNETCoreMVC.Torneio.Models;

namespace TSystems.ASPNETCoreMVC.Torneio.DAO
{
    public class HelperDAO
    {
        public static List<ChampionModel> ExecutaSQL(string sql)
        {
            using (var conexao = ConexaoBD.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    SqlDataReader ler = comando.ExecuteReader();
                    List<ChampionModel> listaChampions = new List<ChampionModel>();

                    while (ler.Read())
                    {
                        ChampionModel champion = new ChampionModel();

                        champion.Nome = ler["Nome"].ToString();
                        champion.Id = int.Parse(ler["Id"].ToString());
                        champion.Habilidades = int.Parse(ler["Habilidades"].ToString());
                        champion.Vitorias = int.Parse(ler["Vitorias"].ToString());
                        champion.Derrotas = int.Parse(ler["Derrotas"].ToString());
                        champion.TotalDeLutas = int.Parse(ler["TotalDeLutas"].ToString());
                        champion.Idade = int.Parse(ler["Idade"].ToString());

                        listaChampions.Add(champion);
                    }
                    return listaChampions;
                }
            }
        }
    }
}
