using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystems.ASPNETCoreMVC.Torneio.Context;
using TSystems.ASPNETCoreMVC.Torneio.Models;
using TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces;

namespace TSystems.ASPNETCoreMVC.Torneio.Repositories
{
    public class ChampionRepository : IChampionRepository
    {
        private readonly AppDbContext _context;
        public ChampionRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<ChampionModel> Champions => _context.Champion;
    }
}
