using MoviesCollection.BusinessApp.Dtos.Actors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace MoviesCollection.Entities
{
    public class Actor
        : EntityBase
    {

        public Actor(ActorDto actorDto)
        {
            if (actorDto == null) 
                throw new ArgumentNullException(nameof(actorDto));
            
            if (actorDto.Id > 0)
                this.Id = actorDto.Id;

            this.Name = actorDto.Name;
            this.CreatedAt = actorDto.CreatedAt;
            this.Birthdate = actorDto.Birthdate;
            this.ImageUrl = actorDto.ImageUrl;
            this.Biography = actorDto.Biography;
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        public string Biography { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public ICollection<Cast> Casts { get; set; }


        public static readonly Expression<Func<Actor, ActorDto>> ToFullDto =
            ad => new ActorDto()
            {
                Id = ad.Id,
                Biography = ad.Biography,
                Birthdate = ad.Birthdate,
                CreatedAt = ad.CreatedAt,
                ImageUrl = ad.ImageUrl,
                Name = ad.Name
            };

    }
}
