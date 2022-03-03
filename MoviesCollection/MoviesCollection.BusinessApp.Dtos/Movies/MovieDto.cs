using MoviesCollection.BusinessApp.Dtos.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesCollection.BusinessApp.Dtos.Movies
{
    public class MovieDto
        : DtoBase
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string CoverUrl { get; set; }
        [Required]
        public string Storyline { get; set; }
        [Required]
        public MovieLanguage Languages { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Synopsis { get; set; }
    }
}
