using AnimeDatabase.Application.ViewModels;
using System.Collections.Generic;

namespace AnimeDatabase.Application.Interfaces
{
    public interface IAnimeService
    {
        AnimeDetailsViewModel GetAnimeDetails(int animeId);
        ListAnimeForList GetAllAnimesForList(int pageNumber, int pageSize, string searchString);
        int AddAnime(AnimeAddViewModel anime);
        //AnimeAddViewModel GetAnimeForEdit(int id);
        //void UpdateAnime(AnimeAddViewModel model);
        //List<AnimeTypeVm> GetAllAnimeTypes();
        List<AnimeTypeVm> GetAllAnimeTypes();
    }
}