using AnimeDatabase.Application.Mapping;
using AutoMapper;
using AnimeDatabase.Domain.Model;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeDetailsViewModel : IMapFrom<Anime>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Anime, AnimeDetailsViewModel>()
                .ForPath(x => x.Synopsis, opt => opt.MapFrom(X => X.AnimeDetails.Synopsis));
        }
    }
}
