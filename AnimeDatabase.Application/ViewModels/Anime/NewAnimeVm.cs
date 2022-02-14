using AnimeDatabase.Application.Mapping;
using AutoMapper;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using AnimeDatabase.Domain.Model;

namespace AnimeDatabase.Application.ViewModels
{
    public class NewAnimeVm : IMapFrom<Domain.Model.Anime>
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewAnimeVm, Domain.Model.Anime>()
                .ForMember(a => a.TypeId, opt => opt.MapFrom(b => 1))
                .ForPath(x => x.AnimeDetails.Description, opt => opt.MapFrom(x => x.Description))
                .ReverseMap();
        }
    }
    
    public class NewAnimeValidation : AbstractValidator<NewAnimeVm>
    {
        public NewAnimeValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Title).NotNull().MaximumLength(255);
        }
    }
}
