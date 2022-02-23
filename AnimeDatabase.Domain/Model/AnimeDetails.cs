namespace AnimeDatabase.Domain.Model
{
    public class AnimeDetails
    {
        public int Id { get; set; }
        public string Synopsis { get; set; }

        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}