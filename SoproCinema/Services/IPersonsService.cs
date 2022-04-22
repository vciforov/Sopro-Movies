using System.Collections.Generic;
using System.Threading.Tasks;
using SoproCinema.Data.Base;
using SoproCinema.Models;

namespace SoproCinema.Services
{
    public interface IPersonsService:IEntityBaseRepository<Person>
    {
       
    }
}
