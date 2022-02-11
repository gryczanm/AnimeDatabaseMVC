﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    //e.g. movie / tv
    //relacja one-to-many
    //jeden typ może posiadać wiele anime, ale anime może być przypisany tylko do jednego typu
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Anime> animes { get; set; }
    }
}
