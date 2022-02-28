using AnimeDatabase.Application.Interfaces;
using AnimeDatabase.Application.ViewModels.Anime;
using AnimeDatabase.Application.ViewModels.AnimeType;
using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Domain.Model;
using System.Linq;

namespace AnimeDatabase.Application.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _animeRepository;
        private readonly IAnimeTypeRepository _animeTypeRepository;

        public AnimeService(IAnimeRepository animeRepository, IAnimeTypeRepository animeTypeRepository)
        {
            _animeRepository = animeRepository;
            _animeTypeRepository = animeTypeRepository;
        }

        public AnimeDetailsViewModel GetAnimeDetails(int animeId)
        {
            var anime = _animeRepository.GetAnime(animeId);

            var animeVm = new AnimeDetailsViewModel
            {
                Title = anime.Title,
                Synopsis = anime.AnimeDetails.Synopsis,
                Type = anime.AnimeType.Name
            };

            return animeVm;
        }

        public ListAnimeForList GetAllAnimesForList(int pageSize, int pageNumber, string searchString)
        {
            var animes = _animeRepository.GetAllAnimes()
                .Where(x => x.Title.StartsWith(searchString))
                .Select(x => new AnimeForListVm()
                {
                    Id = x.Id,
                    Title = x.Title,
                    AnimeTypeId = x.AnimeTypeId,
                    TypeName = x.AnimeType.Name
                })
                .ToList();

            var animesToShow = animes.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToList();

            var animeList = new ListAnimeForList()
            {
                Animes = animesToShow,
                CurrentPage = pageNumber,
                PageSize = pageSize,
                SearchString = searchString,
                Count = animes.Count
            };

            return animeList;
        }

        public int AddAnime(AnimeAddViewModel animeVm)
        {
            var anime = new Anime
            {
                Id = animeVm.Id,
                Title = animeVm.Title,
                AnimeDetails = new AnimeDetails()
                {
                    Synopsis = animeVm.Synopsis
                },
                AnimeTypeId = animeVm.AnimeTypeId
            };

            var id = _animeRepository.AddAnime(anime);

            return id;
        }

        public IQueryable<AnimeTypeVm> GetAnimeTypesToSelectList()
        {
            var animeTypes = _animeTypeRepository.GetAllAnimeTypes()
                .Select(x => new AnimeTypeVm
                {
                    Id = x.Id,
                    Name = x.Name
                });

            return animeTypes;
        }

        public AnimeAddViewModel SetParametersToVm(AnimeAddViewModel model)
        {
            model.AnimeTypes = GetAnimeTypesToSelectList().ToList();

            return model;
        }
    }
}