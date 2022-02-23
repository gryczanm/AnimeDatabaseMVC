using System.Collections.Generic;
using FluentValidation;

namespace AnimeDatabase.Application.ViewModels
{
    public class AnimeAddViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public int AnimeTypeId { get; set; }
        public List<AnimeTypeVm> AnimeTypes { get; set; }
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