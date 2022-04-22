using System.Threading.Tasks;
using SoproCinema.Data.Base;
using SoproCinema.Models;
using SoproCinema.ViewModels;

namespace SoproCinema.Services
{
    public interface IMoviesServices: IEntityBaseRepository<Movie>
    {
        Task<NewMovieDropDownVm> GetNewMovieDropDown();
        Task AddNewMovieAsync(NewMovieVm values);
        Task UpdateMovieAsync(EditMovieVm values);
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
                