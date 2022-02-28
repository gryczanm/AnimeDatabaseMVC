using AnimeDatabase.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AnimeDatabase.Web.Controllers
{
    public class AnimeTypeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnimeTypeService _animeTypeService;

        public AnimeTypeController(ILogger<HomeController> logger, IAnimeTypeService animeTypeService)
        {
            _logger = logger;
            _animeTypeService = animeTypeService;
        }

        //[Route("type/all")]
        //public IActionResult Index()
        //{
        //    var animeType = _animeTypeService.GetAllAnimeTypesToList();

        //    return View(animeType);
        //}
    }
}
