using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Type = AnimeDatabase.Domain.Model.AnimeType;

namespace AnimeDatabase.Infrastructure.Repositories
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly Context _context;

        public AnimeRepository(Context context)
        {
            _context = context;
        }

        public int AddAnime(Anime anime)
        {
            _context.Animes.Add(anime);
            _context.SaveChanges();

            return anime.Id;
        }

        //public void DeleteAnime(int animeId)
        //{
        //    var anime = _context.Animes.Find(animeId);

        //    if (anime != null)
        //    {
        //        _context.Animes.Remove(anime);
        //        _context.SaveChanges();
        //    }
        //}

        //public Anime GetAnime(int animeId)
        //{
        //    var anime = _context.Animes.Include(a => a.Type)
        //        .Include(a => a.AnimeDetails)
        //        .FirstOrDefault(a => a.Id == animeId);

        //    return anime;
        //}


        public Anime GetAnime(int animeId)
        {
            var anime = _context.Animes
                .Include(x => x.AnimeDetails)
                .Include(x => x.AnimeType)
                .FirstOrDefault(x => x.Id == animeId);

            return anime;
        }


        //public IQueryable<Anime> GetAnimesByTypeId(int typeId)
        //{
        //    var animes = _context.Animes.Where(a => a.TypeId == typeId);

        //    return animes;
        //}

        public IQueryable<AnimeType> GetAllAnimeTypes()
        {
            return _context.AnimeTypes;
        }

        public IQueryable<Anime> GetAllAnimes()
        {
            return _context.Animes;
        }

        //public void UpdateAnime(Anime anime)
        //{
        //    _context.Attach(anime);
        //    _context.Entry(anime).Property("Title").IsModified = true;
        //    _context.SaveChanges();
        //}

        //public IQueryable<AnimeTag> GetAllTags()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
