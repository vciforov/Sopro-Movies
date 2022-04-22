using SoproCinema.Data;
using SoproCinema.Data.Base;
using SoproCinema.Models;

namespace SoproCinema.Services
{
    public class GenresServices: EntityBaseRepository<Genre>, IGenresService
    {
        public GenresServices(AppDbContext context) : base(context)
        {
        }
    }
}
