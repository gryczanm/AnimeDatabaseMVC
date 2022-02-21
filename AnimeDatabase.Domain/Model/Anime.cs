    using System;
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

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





        // public int Id { get; set; }
        // public string Title { get; set; }
        //
        // public virtual AnimeDetails AnimeDetails { get; set; }
        //
        // public int TypeId { get; set; }
        // public virtual AnimeType Type { get; set; }
        //
        // public ICollection<Anime_AnimeTag> Anime_AnimeTags { get; set; }
    }
}
