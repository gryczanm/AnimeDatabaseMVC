using AnimeDatabase.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Application.Interfaces
{
    public interface IAnimeService
    {
        AnimeDetailsVm GetAnimeDetails(int animeId);
        ListAnimeForList GetAllAnimesForList(int pageNumber, int pageSize, string searchString);
        int AddAnime(NewAnimeVm anime);
        NewAnimeVm GetAnimeForEdit(int id);
        void UpdateAnime(NewAnimeVm model);
    }
}
