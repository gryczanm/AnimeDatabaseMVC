using System;
using System.Collections.Generic;
using AnimeDatabase.Application.Mapping;
using AutoMapper;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using AnimeDatabase.Domain.Model;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeAddViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public int AnimeTypeId { get; set; }
        public List<AnimeTypeVm> AnimeTypes { get; set; }

        //private Anime MapAnimeAddViewModelToAnime(AnimeAddViewModel animeVm)
        //{
        //    var anime = new Anime
        //    {
        //        Id = animeVm.Id,
        //        Title = animeVm.Title,
        //        AnimeDetails = new AnimeDetails()
        //    };

        //    anime.AnimeDetails.Synopsis = animeVm.Synopsis;
        //    anime.AnimeTypeId = animeVm.AnimeTypeId;

        //    return anime;
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
