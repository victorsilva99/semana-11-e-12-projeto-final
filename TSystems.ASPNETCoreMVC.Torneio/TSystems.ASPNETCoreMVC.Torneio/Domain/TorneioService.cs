using System.Collections.Generic;
using System.Linq;
using TSystems.ASPNETCoreMVC.Torneio.Models;
using TSystems.ASPNETCoreMVC.Torneio.DAO;

namespace TSystems.ASPNETCoreMVC.Torneio.Domain
{
    public class TorneioService
    {
        List<ChampionModel> _torneio = new List<ChampionModel>();

        void CriarLista(string ids)
        {
            Repository repositorio = new Repository();
            _torneio = repositorio.CriarLista(ids);
        }
        
        double porcentagemVitoria(List<ChampionModel> champion, int indice)
        {
            return ((double)champion[indice].Vitorias / champion[indice].TotalDeLutas) * 100;
        }

        void CriteriosDesempate(List<ChampionModel> champion, int indice)
        {
            if (champion[indice].Habilidades > champion[indice + 1].Habilidades)
            {
                _torneio.Remove(champion[indice + 1]);
            }
            else if (champion[indice].Habilidades == champion[indice + 1].Habilidades)
            {
                if (champion[indice].TotalDeLutas > champion[indice + 1].TotalDeLutas)
                {
                    _torneio.Remove(champion[indice + 1]);
                }
                else
                {
                    _torneio.Remove(champion[indice]);
                }
            }
            else
            {
                _torneio.Remove(champion[indice]);
            }
        }

        void RealizarCombates(List<ChampionModel> champion, int indice)
        {
            if (porcentagemVitoria(champion, indice) == porcentagemVitoria(champion, indice + 1))
            {
                CriteriosDesempate(champion, indice);
            }
            else if (porcentagemVitoria(champion, indice) > porcentagemVitoria(champion, indice + 1))
            {
                _torneio.Remove(champion[indice + 1]);
            }
            else
            {
                _torneio.Remove(champion[indice]);
            }
        }

        List<ChampionModel> OrdenarPorIdade(List<ChampionModel> champions)
        {
            return champions.OrderByDescending(x => x.Idade).ToList();
        }

        public List<ChampionModel> ComeçarTorneio(string ids)
        {
            CriarLista(ids);

            while (_torneio.Count > 1)
            {
                for (int i = 0; i < _torneio.Count; i++)
                {
                    RealizarCombates(_torneio, i);
                }

                if (_torneio.Count > 4)
                {
                    OrdenarPorIdade(_torneio);
                }
            }
            return (_torneio);
        }  
    }
}
