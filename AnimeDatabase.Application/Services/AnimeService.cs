using AnimeDatabase.Application.Interfaces;
using AnimeDatabase.Application.ViewModels;
using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Domain.Model;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimeDatabase.Application.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _animeRepo;
        private readonly IMapper _mapper;

        public AnimeService(IAnimeRepository animeRepo, IMapper mapper)
        {
            _animeRepo = animeRepo;
            _mapper = mapper;
        }

        public AnimeDetailsViewModel GetAnimeDetails(int animeId)
        {
            var anime = _animeRepo.GetAnime(animeId);
            var animeVm = _mapper.Map<AnimeDetailsViewModel>(anime);

            return animeVm;
        }

        public ListAnimeForList GetAllAnimesForList(int pageSize, int pageNumber, string searchString)
        {
            var animes = _animeRepo.GetAllAnimes()
                .Where(p => p.Title.StartsWith(searchString))
                .ProjectTo<AnimeForListVm>(_mapper.ConfigurationProvider).ToList();
            var animesToShow = animes.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
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

        //public List<AnimeTypeVm> GetAllAnimeTypes()
        //{
        //    List<AnimeTypeVm> allAnimeTypes = _animeRepo.GetAllTypes().ProjectTo<AnimeTypeVm>(_mapper.ConfigurationProvider).ToList();

        //    return allAnimeTypes;
        //}

        //public int AddAnime(AnimeAddViewModel animeVm)
        //{
        //    var anime = _mapper.Map<Anime>(animeVm);

        //    var id = _animeRepo.AddAnime(anime);

        //    return id;
        //}

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

