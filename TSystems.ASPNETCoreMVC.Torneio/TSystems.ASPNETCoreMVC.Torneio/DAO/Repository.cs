using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystems.ASPNETCoreMVC.Torneio.Models;

namespace TSystems.ASPNETCoreMVC.Torneio.DAO
{
    public class Repository
    {
        public List<ChampionModel> CriarLista(string ids)
        {
            string sql = $"SELECT * FROM Champion WHERE Id in ({ids}) ORDER BY Idade desc";

            return HelperDAO.ExecutaSQL(sql);
        }
    }
}
