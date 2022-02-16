using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesCollection.Entities
{
    public abstract class EntityBase
    {

        [Key]
        [Required]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? Deleted { get; set; } = null;

    }
}
