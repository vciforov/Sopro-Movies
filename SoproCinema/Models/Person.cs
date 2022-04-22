using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoproCinema.Data.Base;

namespace SoproCinema.Models
{
    public class Person:IEntityBase
    {
        [Key]
        public int Id { get; set; }   

        [Display(Name ="Name")]
        public string PersonName { get; set; }

        [Display(Name = "Last Name")]
        public string PersonLastName { get; set; }

        //Relationships
        public List<PersonMovieRole> PersonMovieRoles { get; set; }
        

    }
}
            