using Microsoft.AspNetCore.Mvc;
using TSystems.ASPNETCoreMVC.Torneio.Domain;
using TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces;

namespace TSystems.ASPNETCoreMVC.Torneio.Controllers
{
    public class TorneioController : Controller
    {
        private readonly IChampionRepository _championRepository;

        public TorneioController(IChampionRepository championRepository)
        {
            _championRepository = championRepository;
        }

        public IActionResult Champions()
        {
            var champions = _championRepository.Champions;
            return View(champions);
        }

        public IActionResult Vencedor([FromBody] string ids)
        {
            var inicioTorneio = new TorneioService();

            return View("Vencedor", inicioTorneio.ComeçarTorneio(ids));
        }
    }
}
