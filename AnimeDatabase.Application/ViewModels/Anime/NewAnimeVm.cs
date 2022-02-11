using AnimeDatabase.Application.Mapping;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnimeDatabase.Application.ViewModels
{
    public class NewAnimeVm
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int TypeId { get;  set; }

        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<NewAnimeVm, AnimeDatabase.Domain.Model.Anime>()
        //        .ForMember(a => a.TypeId, opt => opt.MapFrom(b => 1))
        //        .ReverseMap();
        //}
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
