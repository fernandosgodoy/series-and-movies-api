using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesCollection.Entities
{
    public class Cast
    {

        [Key, Column(Order = 0)]
        [Required]
        public int ActorId { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Role { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
