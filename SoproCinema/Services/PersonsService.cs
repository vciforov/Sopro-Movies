using SoproCinema.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoproCinema.Data;
using SoproCinema.Data.Base;

namespace SoproCinema.Services
{
    public class PersonsService : EntityBaseRepository<Person>, IPersonsService
    {

        public PersonsService(AppDbContext context) : base(context) { }




    }
}
