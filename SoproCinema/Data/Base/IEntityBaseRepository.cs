using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoproCinema.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
       
    }
}
