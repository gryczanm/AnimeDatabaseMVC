using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    //relacja many-to-many z Anime
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AnimeTag> animeTags { get; set; }
    }
}
