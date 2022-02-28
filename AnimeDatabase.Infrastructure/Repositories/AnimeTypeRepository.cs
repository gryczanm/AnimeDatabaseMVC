using AnimeDatabase.Domain.Interface;
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
    }
}
