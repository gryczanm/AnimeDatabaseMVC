using AnimeDatabase.Application.Mapping;
using AutoMapper;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeDetailsVm : IMapFrom<Domain.Model.Anime>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Model.Anime, AnimeDetailsVm>()
                .ForMember(a => a.Type, opt => opt.MapFrom(b => b.Type.Name))
                .ForMember(a => a.Description, opt => opt.MapFrom(b => b.AnimeDetails.Description));
        }
    }
}
