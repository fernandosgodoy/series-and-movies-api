using MoviesCollection.BusinessApp.Dtos.Base;
using System;

namespace MoviesCollection.BusinessApp.Dtos.Actors
{
    public class ActorDto
        : DtoBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Biography { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
