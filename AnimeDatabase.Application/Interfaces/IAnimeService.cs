using AnimeDatabase.Application.ViewModels.Anime;
using System.Collections.Generic;

namespace AnimeDatabase.Application.Interfaces
{
    public interface IAnimeService
    {
        AnimeDetailsViewModel GetAnimeDetails(int animeId);
        ListAnimeForList GetAllAnimesForList(int pageNumber, int pageSize, string searchString);
        int AddAnime(AnimeAddViewModel anime);
    }
}