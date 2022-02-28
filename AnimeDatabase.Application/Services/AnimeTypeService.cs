using AnimeDatabase.Application.Interfaces;
using AnimeDatabase.Application.ViewModels.AnimeType;
using AnimeDatabase.Domain.Interface;
using System;
using System.Collections.Generic;

namespace AnimeDatabase.Application.Services
{
    public class AnimeTypeService : IAnimeTypeService
    {
        private readonly IAnimeTypeRepository _animeTypeRepository;

        public AnimeTypeService(IAnimeTypeRepository animeTypeRepository)
        {
            _animeTypeRepository = animeTypeRepository;
        }

        public List<AnimeTypeVm> GetAllAnimeTypes()
        {
            throw new NotImplementedException();
        }

        //public List<AnimeTypeVm> GetAllAnimeTypes()
        //{
        //    var animeTypes = _animeTypeRepository.GetAllAnimeTypes()
        //        .Select(x => new AnimeTypeVm()
        //        {
        //            Id = x.Id,
        //            Name = x.Name
        //        })
        //        .ToList();

        //    return animeTypes;
        //}
    }
}
