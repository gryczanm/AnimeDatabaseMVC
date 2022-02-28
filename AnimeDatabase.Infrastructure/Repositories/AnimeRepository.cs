using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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

        public Anime GetAnime(int animeId)
        {
            var anime = _context.Animes
                .Include(x => x.AnimeDetails)
                .Include(x => x.AnimeType)
                .FirstOrDefault(x => x.Id == animeId);

            return anime;
        }

        public IQueryable<AnimeType> GetAllAnimeTypes()
        {
            return _context.AnimeTypes;
        }

        public IQueryable<Anime> GetAllAnimes()
        {
            return _context.Animes;
        }

        public IQueryable<AnimeAnimeGenre> GetAllAnimeGenres()
        {
            return _context.AnimeAnimeGenre;
        }
    }
}