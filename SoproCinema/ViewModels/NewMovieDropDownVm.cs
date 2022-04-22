using System.Collections.Generic;
using SoproCinema.Models;

namespace SoproCinema.ViewModels
{
    public class NewMovieDropDownVm
    {
        public NewMovieDropDownVm()
        {
            Genres = new List<Genre>();
            Persons = new List<Person>();
           
        }
        public List<Genre> Genres { get; set; }
        public List<Person> Persons { get; set; }
       
    }
}
