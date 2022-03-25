using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSystems.ASPNETCoreMVC.Torneio.Context;
using TSystems.ASPNETCoreMVC.Torneio.Models;
using TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces;

namespace TSystems.ASPNETCoreMVC.Torneio.Repositories
{
    public class ChampionsRepository : IChampionsRepository
    {
        private readonly AppDbContext _context;
        public ChampionsRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<ChampionsModel> Champions => _context.Champions;
    }
}
