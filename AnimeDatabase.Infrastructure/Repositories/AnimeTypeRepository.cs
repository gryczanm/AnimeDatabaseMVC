using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDatabase.Infrastructure.Repositories
{
    public class AnimeTypeRepository : IAnimeTypeRepository
    {
        private readonly Context _context;

        public AnimeTypeRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<AnimeType> GetAllAnimeTypes()
        {
            return _context.AnimeTypes;
        }
    }
}
