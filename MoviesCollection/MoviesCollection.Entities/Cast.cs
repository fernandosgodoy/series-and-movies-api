using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesCollection.Entities
{
    public class Cast
    {

        [Required]
        public int ActorId { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public string Role { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
