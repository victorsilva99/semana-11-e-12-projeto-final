using Microsoft.AspNetCore.Mvc;
using TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces;

namespace TSystems.ASPNETCoreMVC.Torneio.Controllers
{
    public class ChampionController : Controller
    {
        private readonly IChampionRepository _championRepository;

        public ChampionController(IChampionRepository championRepository)
        {
            _championRepository = championRepository;
        }

        public IActionResult List()
        {
            var champions = _championRepository.Champions;
            return View(champions);
        }
    }
}
