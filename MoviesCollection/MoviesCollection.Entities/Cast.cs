using System.ComponentModel.DataAnnotations;

namespace MoviesCollection.Entities
{
    public class Cast
        : EntityBase
    {

        [Required]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Role { get; set; }

    }
}
