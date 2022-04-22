using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoproCinema.Data.Base;

namespace SoproCinema.Models
{
    public class Genre:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Genre")]
        public string GenreName { get; set; }

        //Relationships
        public List<MovieGenre> MovieGenres { get; set; }
    }
}
