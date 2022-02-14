using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    //relacja many-to-many z Anime
    public class AnimeTag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Anime_AnimeTag> Anime_AnimeTags { get; set; }
    }
}
