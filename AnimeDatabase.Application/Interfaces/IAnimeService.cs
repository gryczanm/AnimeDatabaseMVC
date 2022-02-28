using AnimeDatabase.Application.ViewModels.Anime;
using AnimeDatabase.Application.ViewModels.AnimeType;
using System.Collections.Generic;
using System.Linq;

namespace AnimeDatabase.Application.Interfaces
{
    public interface IAnimeService
    {
        AnimeDetailsViewModel GetAnimeDetails(int animeId);
        ListAnimeForList GetAllAnimesForList(int pageNumber, int pageSize, string searchString);
        int AddAnime(AnimeAddViewModel anime);

        AnimeAddViewModel SetParametersToVm(AnimeAddViewModel model);
        IQueryable<AnimeTypeVm> GetAnimeTypesToSelectList();
    }
}