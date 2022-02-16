using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesCollection.Entities
{
    public class Actor
        : EntityBase
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        public string Biography { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public ICollection<Cast> Casts { get; set; }

    }
}
