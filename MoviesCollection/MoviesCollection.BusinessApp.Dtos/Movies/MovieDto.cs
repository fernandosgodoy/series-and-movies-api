﻿using MoviesCollection.BusinessApp.Dtos.Base;
using System;

namespace MoviesCollection.BusinessApp.Dtos.Movies
{
    public class MovieDto
        : DtoBase
    {
        public string Title { get; set; }
        public string CoverUrl { get; set; }
        public string Storyline { get; set; }
        public int Languages { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
    }
}
