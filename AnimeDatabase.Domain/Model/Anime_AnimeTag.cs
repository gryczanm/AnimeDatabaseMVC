using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    public class Anime_AnimeTag
    {
        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
        public int TagId { get; set; }
        public AnimeTag Tag { get; set; }
    }
}
