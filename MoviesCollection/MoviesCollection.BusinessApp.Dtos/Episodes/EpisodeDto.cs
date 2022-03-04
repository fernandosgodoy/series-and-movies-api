using MoviesCollection.BusinessApp.Dtos.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesCollection.BusinessApp.Dtos.Episodes
{
    public class EpisodeDto
        : DtoBase
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public int MovieId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
