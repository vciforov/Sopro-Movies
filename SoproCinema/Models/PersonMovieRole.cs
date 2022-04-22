namespace SoproCinema.Models
{
    public class PersonMovieRole
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
        