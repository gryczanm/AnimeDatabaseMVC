using System;
using System.Collections.Generic;
using AnimeDatabase.Application.Mapping;
using AutoMapper;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using AnimeDatabase.Domain.Model;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeAddViewModel /*: IMapFrom<Anime>*/
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public List<AnimeType> AnimeTypes { get; set; }


        //public int TypeId { get; set; }
        //public List<AnimeTypeVm> AnimeTypes { get; set; }


        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<AnimeAddViewModel, Domain.Model.Anime>()
        //        .ForPath(x => x.AnimeDetails.Description, opt => opt.MapFrom(x => x.Description))
        //        .ForMember(x => x.TypeId, opt => opt.MapFrom(x => 2))
        //        .ReverseMap();
        //}

        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<AnimeAddViewModel, Anime>()
        //        .ForPath(x => x.AnimeDetails.Synopsis, opt => opt.MapFrom(x => x.Synopsis))
        //        .ReverseMap();
        //}
    }

    public class AnimeAddValidation : AbstractValidator<AnimeAddViewModel>
    {
        public AnimeAddValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Title).NotNull().MaximumLength(255);
        }
    }
}
