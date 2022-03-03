using MoviesCollection.BusinessApp.Dtos.Movies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace MoviesCollection.Entities
{
    public class Movie
        : EntityBase
    {

        public Movie() { }
        public Movie(MovieDto movieDto)
        {
            this.Title = movieDto.Title;
            this.CoverUrl = movieDto.CoverUrl;
            this.Storyline = movieDto.Storyline;
            this.Languages = movieDto.Languages;
            this.Synopsis = movieDto.Synopsis;
            this.ReleaseDate = movieDto.ReleaseDate;    
        }

        [Required]
        public string Title { get; set; }
        [Required]
        public string CoverUrl { get; set; }
        public string Storyline { get; set; }
        [Required]
        public int Languages { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
        public ICollection<Cast> Casts { get; set; }
        public ICollection<Episode> Episodes { get; set; }

        public static readonly Expression<Func<Movie, MovieDto>> ToFullDto =
            mv => new MovieDto()
            {
                Id = mv.Id,
                Title = mv.Title,
                CoverUrl = mv.CoverUrl,
                Storyline = mv.Storyline,
                Languages= mv.Languages,
                ReleaseDate = mv.ReleaseDate,
                CreatedAt = mv.CreatedAt
            };
    }
}
