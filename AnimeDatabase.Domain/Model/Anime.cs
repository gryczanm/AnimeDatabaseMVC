    using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // przechowuje obiekt AnimeDetails
        public virtual AnimeDetails AnimeDetails { get; set; }

        public int TypeId { get; set; }
        public virtual AnimeType Type { get; set; }

        public ICollection<Anime_AnimeTag> Anime_AnimeTags { get; set; }
    }
}
