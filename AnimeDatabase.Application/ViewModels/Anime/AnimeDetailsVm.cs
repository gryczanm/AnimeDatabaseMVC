using AnimeDatabase.Application.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeDetailsVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<AnimeDatabase.Domain.Model.Anime, AnimeDetailsVm>()
        //        .ForMember(a => a.Type, opt => opt.MapFrom(b => b.Type.Name))
        //        .ForMember(a => a.Description, opt => opt.MapFrom(b => b.AnimeDetails.Description));
        //}
    }
}
