﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Domain.Model
{
    public class AnimeTag
    {
        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
