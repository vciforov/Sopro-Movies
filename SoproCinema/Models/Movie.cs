using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoproCinema.Data.Base;

namespace SoproCinema.Models
{
    public class Movie:IEntityBase
    {
        [Key]
        public int Id { get; set; } 

        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double MovieRatings { get; set; }
        public string ImdbLink { get; set; }
        public int Length { get; set; }
        public string Description { get; set; }

        //Relationships 
        public List<MovieGenre> MovieGenres { get; set; }
        public List<PersonMovieRole> PersonMovieRoles { get; set; }

    }
}
