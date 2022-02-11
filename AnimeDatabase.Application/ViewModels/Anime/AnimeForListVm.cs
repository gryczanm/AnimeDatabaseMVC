using AnimeDatabase.Application.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeForListVm : IMapFrom<AnimeDatabase.Domain.Model.Anime>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AnimeDatabase.Domain.Model.Anime, AnimeForListVm>();
        }
    }
}
