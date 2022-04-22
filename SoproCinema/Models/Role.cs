using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoproCinema.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        //Relationships
        public List<PersonMovieRole> PersonMovieRoles { get; set; }
    }
}
    