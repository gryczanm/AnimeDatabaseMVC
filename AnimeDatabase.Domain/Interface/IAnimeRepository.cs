using AnimeDatabase.Domain.Model;
using System.Linq;

namespace AnimeDatabase.Domain.Interface
{
    public interface IAnimeRepository
    {
        Anime GetAnime(int animeId);
        IQueryable<Anime> GetAllAnimes();
        int AddAnime(Anime anime);
        //void DeleteAnime(int animeId);
        ////IQueryable<AnimeTag> GetAllTags();
        IQueryable<AnimeAnimeGenre> GetAllAnimeGenres();
        IQueryable<AnimeType> GetAllAnimeTypes();
        //void UpdateAnime(Anime anime);
    }
}