using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesCollection.Entities
{
    public class Movie
        : EntityBase
    {

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

    }
}
