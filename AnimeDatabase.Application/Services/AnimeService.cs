using AnimeDatabase.Application.Interfaces;
using AnimeDatabase.Application.ViewModels;
using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace AnimeDatabase.Application.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _animeRepo;

        public AnimeService(IAnimeRepository animeRepo)
        {
            _animeRepo = animeRepo;
        }

        public AnimeDetailsViewModel GetAnimeDetails(int animeId)
        {
            var anime = _animeRepo.GetAnime(animeId);

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
            var animes = _animeRepo.GetAllAnimes()
                .Where(x => x.Title.StartsWith(searchString))
                .ToList();

            var animesToShow = animes.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .Select(x => new AnimeForListVm()
                {
                    Id = x.Id,
                    Title = x.Title
                }).ToList();

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

            var id = _animeRepo.AddAnime(anime);

            return id;
        }

        public List<AnimeTypeVm> GetAllAnimeTypes()
        {
            var animeTypes = _animeRepo.GetAllAnimeTypes()
                .Select(x => new AnimeTypeVm()
                {
                    Id= x.Id,
                    Name = x.Name
                })
                .ToList();

            return animeTypes;
        }



        //public AnimeAddViewModel GetAnimeForEdit(int id)
        //{
        //    var anime = _animeRepo.GetAnime(id);
        //    var animeVm = _mapper.Map<AnimeAddViewModel>(anime);

        //    return animeVm;
        //}

        //public void UpdateAnime(AnimeAddViewModel model)
        //{
        //    var anime = _mapper.Map<Anime>(model);
        //    _animeRepo.UpdateAnime(anime);
        //}
    }
}