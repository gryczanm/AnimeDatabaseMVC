using AnimeDatabase.Application.Mapping;
using AnimeDatabase.Domain.Model;
using AutoMapper;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeTypeVm /*: IMapFrom<AnimeType>*/
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<AnimeType, AnimeTypeVm>();
        //}
    }
}