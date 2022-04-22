using System.Linq;
using SoproCinema.Data;
using SoproCinema.Data.Base;
using SoproCinema.Models;
using SoproCinema.ViewModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoproCinema.Services
{
    public class MoviesServices : EntityBaseRepository<Movie>, IMoviesServices
    {
        private readonly AppDbContext _context;
        public MoviesServices(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewMovieAsync(NewMovieVm values)
        {
            var actorRoleId = _context.Roles.FirstOrDefault(x => x.RoleName == "Actor").RoleId;
            var directorRoleId = _context.Roles.FirstOrDefault(x => x.RoleName == "Director").RoleId;
            var producerRoleId = _context.Roles.FirstOrDefault(x => x.RoleName == "Producer").RoleId;

            var newMovie = new Movie()
            {
                MovieName = values.MovieName,
                ReleaseDate = values.ReleaseDate,
                MovieRatings = values.MovieRatings,
                ImdbLink = values.ImdbLink,
                Length = values.Length,
                Description = values.Description

            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();


            foreach (var genresId in values.GenreIds)
            {
                var newMovieGenre = new MovieGenre()
                {
                    MovieId = newMovie.Id,
                    GenreId = genresId
                };
                await _context.MovieGenres.AddAsync(newMovieGenre);

            }

            foreach (var actorsId in values.ActorsIds)
            {
                var newPersonMovieRole = new PersonMovieRole()
                {
                    MovieId = newMovie.Id,
                    PersonId = actorsId,
                    RoleId = actorRoleId
                };
                await _context.PersonMovieRoles.AddAsync(newPersonMovieRole);

            }

            foreach (var directorId in values.DirectorsIds)
            {
                var newPersonMovieRole = new PersonMovieRole()
                {
                    MovieId = newMovie.Id,
                    PersonId = directorId,
                    RoleId = directorRoleId
                };
                await _context.PersonMovieRoles.AddAsync(newPersonMovieRole);

            }

            foreach (var producerId in values.ProducersIds)
            {
                var newPersonMovieRole = new PersonMovieRole()
                {
                    MovieId = newMovie.Id,
                    PersonId = producerId,
                    RoleId = producerRoleId
                };
                await _context.PersonMovieRoles.AddAsync(newPersonMovieRole);

            }
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(mg => mg.MovieGenres)
                .ThenInclude(g => g.Genre)
                .Include(mp => mp.PersonMovieRoles)
                .ThenInclude(p => p.Person)
                .Include(mp => mp.PersonMovieRoles)
                .ThenInclude(p => p.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            return movieDetails;
        }

        public async Task<NewMovieDropDownVm> GetNewMovieDropDown()
        {
            var result = new NewMovieDropDownVm()
            {
                Genres = await _context.Genres.ToListAsync(),
                Persons = await _context.Persons.ToListAsync()

            };

            return result;
        }

        public async Task UpdateMovieAsync(EditMovieVm values)
        {
            var dbMovie = await _context.Movies.SingleOrDefaultAsync(m => m.Id == values.MovieId);
            var actorRoleId = _context.Roles.FirstOrDefault(x => x.RoleName == "Actor").RoleId;
            var directorRoleId = _context.Roles.FirstOrDefault(x => x.RoleName == "Director").RoleId;
            var producerRoleId = _context.Roles.FirstOrDefault(x => x.RoleName == "Producer").RoleId;


            if (dbMovie != null)
            {

                dbMovie.MovieName = values.MovieName;
                dbMovie.ReleaseDate = values.ReleaseDate;
                dbMovie.MovieRatings = values.MovieRatings;
                dbMovie.ImdbLink = values.ImdbLink;
                dbMovie.Length = values.Length;
                dbMovie.Description = values.Description;

                await _context.SaveChangesAsync();

            }
            var dbGenres = _context.MovieGenres
                .Where(mg => mg.MovieId == values.MovieId)
                .ToList();

            _context.MovieGenres.RemoveRange(dbGenres);

            await _context.SaveChangesAsync();

            foreach (var genresId in values.GenreIds)
            {
                var editMovieGenre = new MovieGenre()
                {
                    MovieId = values.MovieId,
                    GenreId = genresId
                };
                await _context.MovieGenres.AddAsync(editMovieGenre);

            }


            var dbPersonMovieRole = _context.PersonMovieRoles
                .Where(p => p.MovieId == values.MovieId)
                .ToList();
            _context.PersonMovieRoles.RemoveRange(dbPersonMovieRole);
            await _context.SaveChangesAsync();

            foreach (var actorsId in values.ActorsIds)
            {
                var editPersonMovieRole = new PersonMovieRole()
                {
                    MovieId = values.MovieId,
                    PersonId = actorsId,
                    RoleId = actorRoleId
                };
                await _context.PersonMovieRoles.AddAsync(editPersonMovieRole);

            }


            foreach (var directorsId in values.DirectorsIds)
            {
                var editPersonMovieRole = new PersonMovieRole()
                {
                    MovieId = values.MovieId,
                    PersonId = directorsId,
                    RoleId = directorRoleId
                };
                await _context.PersonMovieRoles.AddAsync(editPersonMovieRole);

            }


            foreach (var producersId in values.ProducersIds)
            {
                var editPersonMovieRole = new PersonMovieRole()
                {
                    MovieId = values.MovieId,
                    PersonId = producersId,
                    RoleId = producerRoleId
                };
                await _context.PersonMovieRoles.AddAsync(editPersonMovieRole);

            }


            await _context.SaveChangesAsync();
        }
    }
}
