    using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }

        public AnimeDetails AnimeDetails { get; set; }

        public virtual Type Type { get; set; }

        public ICollection<AnimeTag> animeTags { get; set; }
    }
}
