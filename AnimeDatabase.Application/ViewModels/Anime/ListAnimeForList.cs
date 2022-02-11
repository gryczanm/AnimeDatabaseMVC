﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeDatabase.Application.ViewModels
{
    public class ListAnimeForList
    {
        public List<AnimeForListVm> Animes { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public int Count { get; set; }
    }
}
