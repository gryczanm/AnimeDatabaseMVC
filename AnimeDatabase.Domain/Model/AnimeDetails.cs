using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    public class AnimeDetails
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string YearOfProduction { get; set; }
        public string Rating { get; set; }
        public string Duration { get; set; }

        public int AnimeRef { get; set; }
        public Anime Anime { get; set; }
    }
}
