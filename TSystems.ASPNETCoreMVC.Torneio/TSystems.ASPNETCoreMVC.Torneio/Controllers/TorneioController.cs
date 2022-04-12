using Microsoft.AspNetCore.Mvc;
using TSystems.ASPNETCoreMVC.Torneio.Domain;
using TSystems.ASPNETCoreMVC.Torneio.Models;
using TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces;
using TSystems.ASPNETCoreMVC.Torneio.DAO;

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

        [Route("/Vencedor/{championId}")]
        public IActionResult Vencedor(string championId)
        {
            var repository = new Repository();
            var vencedor = repository.BuscarChampion(championId);
            return View(vencedor);
        }

        public JsonResult MataMata([FromBody] string ids)
        {
            var inicioTorneio = new TorneioService();
            var vencedor = inicioTorneio.ComeçarTorneio(ids)[0].Id;

            return Json(new { url = $"/Vencedor/{vencedor}"});
        }
    }
}
