using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystems.ASPNETCoreMVC.Torneio.Models;

namespace TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces
{
    public interface IChampionRepository
    {
        IEnumerable<ChampionModel> Champions { get; }
    }
}
