using AnimeDatabase.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimeDatabase.Domain.Interface
{
    public interface IAnimeRepository
    {
        int AddAnime(Anime anime);
        Anime GetAnime(int animeId);
        IQueryable<Anime> GetAllAnimes();
        void DeleteAnime(int animeId);
        IQueryable<Anime> GetAnimesByTypeId(int typeId);
        IQueryable<AnimeTag> GetAllTags();
        IQueryable<AnimeType> GetAllTypes();
        void UpdateAnime(Anime anime);
    }
}
