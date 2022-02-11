using AnimeDatabase.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Type = AnimeDatabase.Domain.Model.Type;

namespace AnimeDatabase.Domain.Interface
{
    public interface IAnimeRepository
    {
        int AddAnime(Anime anime);
        Anime GetAnime(int animeId);
        IQueryable<Anime> GetAllAnimes();
        void DeleteAnime(int animeId);
        IQueryable<Anime> GetAnimesByTypeId(int typeId);
        IQueryable<Tag> GetAllTags();
        IQueryable<Type> GetAllTypes();
        void UpdateAnime(Anime anime);
    }
}
