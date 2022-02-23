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
        //IQueryable<Anime> GetAnimesByTypeId(int typeId);
        ////IQueryable<AnimeTag> GetAllTags();
        IQueryable<AnimeType> GetAllAnimeTypes();
        //void UpdateAnime(Anime anime);
    }
}