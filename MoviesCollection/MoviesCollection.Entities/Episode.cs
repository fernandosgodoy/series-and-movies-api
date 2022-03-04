using MoviesCollection.BusinessApp.Dtos.Episodes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace MoviesCollection.Entities
{
    public class Episode
        : EntityBase
    {

        public Episode() { }

        public Episode(EpisodeDto episodeDto) 
        { 
            if (episodeDto.Id > 0)
                this.Id = episodeDto.Id;    

            this.Title = episodeDto.Title;
            this.MovieId = episodeDto.MovieId;
            this.Slug = episodeDto.Slug;
        }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public static readonly Expression<Func<Episode, EpisodeDto>> ToFullDto =
            ep => new EpisodeDto()
            {
                Id = ep.Id,
                Title = ep.Title,
                Slug = ep.Slug,
                MovieId = ep.MovieId,
                CreatedAt = ep.CreatedAt
            };

    }
}
