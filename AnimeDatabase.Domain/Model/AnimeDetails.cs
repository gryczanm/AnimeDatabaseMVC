using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    public class AnimeDetails
    {
        public string Synopsis { get; set; }
        public int AnimeId { get; set; }

        public virtual Anime Anime { get; set; }
    }
}
