using AnimeDatabase.Application.Interfaces;
using AnimeDatabase.Application.ViewModels.Anime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace AnimeDatabase.Web.Controllers
{
    public class AnimeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnimeService _animeService;

        public AnimeController(ILogger<HomeController> logger, IAnimeService animeService)
        {
            _logger = logger;
            _animeService = animeService;
        }

        [HttpGet]
        [Route("anime/all")]
        public IActionResult Index()
        {
            var model = _animeService.GetAllAnimesForList(2, 1, "");

            return View(model);
        }

        [HttpPost]
        [Route("anime/all")]
        public IActionResult Index(int pageSize, int? pageNumber, string searchString)
        {
            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            if (searchString is null)
            {
                searchString = String.Empty;
            }

            var model = _animeService.GetAllAnimesForList(pageSize, pageNumber.Value, searchString);

            return View(model);
        }

        [HttpGet]
        [Route("anime/details/{id}")]
        public IActionResult DetailsAnime(int id)
        {
            var model = _animeService.GetAnimeDetails(id);

            return View(model);
        }

        [HttpGet]
        [Route("anime/add")]
        public IActionResult AddAnime()
        {
            //var model = new AnimeAddViewModel()
            //{
            //    AnimeTypes = _animeService.GetAllAnimeTypes()
            //};

            var model = new AnimeAddViewModel();
            _animeService.SetParametersToVm(model);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("anime/add")]
        public IActionResult AddAnime(AnimeAddViewModel model)
        {
                var id = _animeService.AddAnime(model);
                return RedirectToAction("Index");

            //return View(model);
        }

        //[HttpGet]
        //public IActionResult AnimeTags()
        //{
        //    var model = new AnimeAddViewModel()
        //    {
        //        AnimeTypes = _animeService.GetAllAnimeTypes()
        //    };

        //    return View(model);
        //}

        //[HttpGet]
        //public IActionResult EditAnime(int id)
        //{
        //    var anime = _animeService.GetAnimeForEdit(id);

        //    return View(anime);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult EditAnime(AnimeAddViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _animeService.UpdateAnime(model);
        //        return RedirectToAction("Index");
        //    }

        //    return View(model);
        //}
    }
}