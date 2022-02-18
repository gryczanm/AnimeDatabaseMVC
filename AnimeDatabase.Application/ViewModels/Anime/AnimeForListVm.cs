using AnimeDatabase.Application.Mapping;
using AutoMapper;
using AnimeDatabase.Domain.Model;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeForListVm : IMapFrom<Anime>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public void Mapping(Profile profile)
        {
            // <typ źródłowy, typ na jaki będę chciał mapować>
            profile.CreateMap<Anime, AnimeForListVm>();
        }
    }
}
