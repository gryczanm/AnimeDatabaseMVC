using AnimeDatabase.Application.ViewModels;
using AnimeDatabase.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Application.Interfaces
{
    public interface IAnimeService
    {
        AnimeDetailsViewModel GetAnimeDetails(int animeId);
        ListAnimeForList GetAllAnimesForList(int pageNumber, int pageSize, string searchString);
        //int AddAnime(AnimeAddViewModel anime);
        //AnimeAddViewModel GetAnimeForEdit(int id);
        //void UpdateAnime(AnimeAddViewModel model);
        //List<AnimeTypeVm> GetAllAnimeTypes();
    }
}
