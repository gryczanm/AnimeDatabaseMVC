﻿using AnimeDatabase.Application.Mapping;
using AutoMapper;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeForListVm : IMapFrom<Domain.Model.Anime>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Model.Anime, AnimeForListVm>();
        }
    }
}
