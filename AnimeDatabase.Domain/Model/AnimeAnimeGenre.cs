namespace AnimeDatabase.Domain.Model
{
    public class AnimeAnimeGenre
    {
        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
        public int AnimeGenreId { get; set; }
        public AnimeGenre AnimeGenre { get; set; }
    }
}
