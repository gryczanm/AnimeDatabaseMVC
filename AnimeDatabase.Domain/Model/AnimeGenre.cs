using System.Collections.Generic;

namespace AnimeDatabase.Domain.Model;

public class AnimeGenre
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<AnimeAnimeGenre> AnimeAnimeGenres { get; set; }
}