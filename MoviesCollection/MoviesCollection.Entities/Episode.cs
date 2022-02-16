using System.ComponentModel.DataAnnotations;

namespace MoviesCollection.Entities
{
    public class Episode
        : EntityBase
    {

        [Required]
        public string Title { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }


    }
}
