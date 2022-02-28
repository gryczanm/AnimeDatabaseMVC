using AnimeDatabase.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDatabase.Domain.Interface
{
    public interface IAnimeTypeRepository
    {
        IQueryable<AnimeType> GetAllAnimeTypes();
    }
}
