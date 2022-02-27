using System.Collections.Generic;

namespace AnimeDatabase.Domain.Model
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //one-to-one
        public AnimeDetails AnimeDetails { get; set; }

        //one-to-many
        public int AnimeTypeId { get; set; }
        public AnimeType AnimeType { get; set; }

        //many-to-many
        public ICollection<AnimeAnimeGenre> AnimeAnimeGenres { get; set; }
    }
}