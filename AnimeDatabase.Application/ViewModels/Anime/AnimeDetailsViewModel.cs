using AnimeDatabase.Application.Mapping;
using AutoMapper;
using AnimeDatabase.Domain.Model;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeDetailsViewModel /*: IMapFrom<Anime>*/
    {
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Type { get; set; }

        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<Anime, AnimeDetailsViewModel>();
        //        //.ForMember(x => x.Synopsis, opt => opt.MapFrom(x => x.AnimeDetails.Synopsis))
        //        //.ForPath(x => x.AnimeType.Name, opt => opt.MapFrom(x => x.Type));
        //}
    }
}
