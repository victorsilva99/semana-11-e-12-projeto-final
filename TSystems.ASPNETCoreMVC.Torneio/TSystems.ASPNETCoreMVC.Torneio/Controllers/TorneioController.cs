using Microsoft.AspNetCore.Mvc;
using TSystems.ASPNETCoreMVC.Torneio.Domain;
using TSystems.ASPNETCoreMVC.Torneio.Models;
using TSystems.ASPNETCoreMVC.Torneio.Repositories.Interfaces;
using TSystems.ASPNETCoreMVC.Torneio.DAO;
using System.Web.Http.Routing;

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

        [Route("Torneio/Vencedor/{championId}")]
        public IActionResult Vencedor(string championId)
        {
            var repository = new Repository();
            var vencedor = repository.BuscarChampion(championId)[0];
            return View(vencedor);
        }

        public JsonResult MataMata([FromBody] string ids)
        {
            var inicioTorneio = new TorneioService();
            var vencedor = inicioTorneio.ComeçarTorneio(ids)[0].Id;

            return Json(new { url = $"Torneio/Vencedor/{vencedor}" });
        }
    }
}
