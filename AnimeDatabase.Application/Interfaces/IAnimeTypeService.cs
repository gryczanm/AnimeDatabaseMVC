using AnimeDatabase.Application.ViewModels.AnimeType;
using System.Collections.Generic;

namespace AnimeDatabase.Application.Interfaces
{
    public interface IAnimeTypeService
    {
        List<AnimeTypeVm> GetAllAnimeTypes();
    }
}
