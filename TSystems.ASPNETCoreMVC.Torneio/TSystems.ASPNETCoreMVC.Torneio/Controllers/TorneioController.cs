using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces;
using TSystems.ASPNETCoreMVC.Torneio.Context;
using TSystems.ASPNETCoreMVC.Torneio.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using TSystems.ASPNETCoreMVC.Torneio.DAO;

namespace TSystems.ASPNETCoreMVC.Torneio.Controllers
{
    public class TorneioController : Controller
    {
        private readonly IChampionRepository _championRepository;
        private readonly ITorneioRepository _torneioRepository;

        public TorneioController(IChampionRepository championRepository)
        {
            _championRepository = championRepository;
        }

        public IActionResult Champions()
        {
            var champions = _championRepository.Champions;
            return View(champions);
        }

        public IActionResult Vencedor()
        {
            var vencedor = _torneioRepository.Torneio;
            return View(vencedor);
        }

        public IActionResult MataMata([FromBody] string ids)
        {
            Repository repositorio = new Repository();
            
            List<ChampionModel> Torneio = new List<ChampionModel>();
            Torneio = repositorio.CriarLista(ids);
            List<ChampionModel> OrdenarPorIdade(List<ChampionModel> champions)
            {
                return champions.OrderByDescending(x => x.Idade).ToList();
            }

            double porcentagemVitoria(List<ChampionModel> champion, int indice)
            {
                return ((double)champion[indice].Vitorias / champion[indice].TotalDeLutas) * 100;
            }

            void CriteriosDesempate(List<ChampionModel> champion, int indice)
            {
                if (champion[indice].Habilidades > champion[indice + 1].Habilidades)
                {
                    Torneio.Remove(champion[indice + 1]);
                }
                else if (champion[indice].Habilidades == champion[indice + 1].Habilidades)
                {
                    if (champion[indice].TotalDeLutas > champion[indice + 1].TotalDeLutas)
                    {
                        Torneio.Remove(champion[indice + 1]);
                    }
                    else
                    {
                        Torneio.Remove(champion[indice]);
                    }
                }
                else
                {
                    Torneio.Remove(champion[indice]);
                }
            }

            void Combates(List<ChampionModel> champion, int indice)
            {
                if (porcentagemVitoria(champion, indice) == porcentagemVitoria(champion, indice + 1))
                {
                    CriteriosDesempate(champion, indice);
                }
                else if (porcentagemVitoria(champion, indice) > porcentagemVitoria(champion, indice + 1))
                {
                    Torneio.Remove(champion[indice + 1]);
                }
                else
                {
                    Torneio.Remove(champion[indice]);
                }
            }

            while (Torneio.Count > 1)
            {
                for (int i = 0; i < Torneio.Count; i++)
                {
                    Combates(Torneio, i);
                }
                if (Torneio.Count > 4)
                {
                    OrdenarPorIdade(Torneio);
                }
            }
            return View("Vencedor");
        }
    }
}
