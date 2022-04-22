using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SoproCinema.Data;
using SoproCinema.Services;
using SoproCinema.ViewModels;

namespace SoproCinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesServices _service;

        public MoviesController(IMoviesServices service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        public async Task<IActionResult> Filter(string searchString)
        {

            var allMovies = await _service.GetAllAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allMovies.Where(n => n.MovieName.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }

            return View("Index", allMovies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            return View(movieDetails);
        }

        public async Task<IActionResult> Create()
        {

            var dropDowns = await _service.GetNewMovieDropDown();
            ViewBag.Genres = new SelectList(dropDowns.Genres, "Id", "GenreName");
            ViewBag.Persons = new SelectList(dropDowns.Persons, "Id", "PersonName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVm movie)
        {
            if (!ModelState.IsValid)
            {
                var dropDowns = await _service.GetNewMovieDropDown();
                ViewBag.Genres = new SelectList(dropDowns.Genres, "Id", "GenreName");
                ViewBag.Persons = new SelectList(dropDowns.Persons, "Id", "PersonName");
                return View(movie);
            }

            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {

            var movieDetails = await _service.GetMovieByIdAsync(id);

            var returnDetails = new EditMovieVm()
            {
               // MovieId = movieDetails.Id,
                MovieName = movieDetails.MovieName,
                ReleaseDate = movieDetails.ReleaseDate,
                MovieRatings = movieDetails.MovieRatings,
                ImdbLink = movieDetails.ImdbLink,
                Length = movieDetails.Length,
                Description = movieDetails.Description,
                GenreIds = movieDetails.MovieGenres.Select(g => g.GenreId).ToList(),
                ActorsIds = movieDetails.PersonMovieRoles.Select(a => a.RoleId).ToList(),
                DirectorsIds = movieDetails.PersonMovieRoles.Select(d => d.RoleId).ToList(),
                ProducersIds = movieDetails.PersonMovieRoles.Select(p => p.RoleId).ToList()

            };

            var dropDowns = await _service.GetNewMovieDropDown();
            ViewBag.Genres = new SelectList(dropDowns.Genres, "Id", "GenreName");
            ViewBag.Persons = new SelectList(dropDowns.Persons, "Id", "PersonName");
            return View(returnDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditMovieVm movie)
        {
            if (!ModelState.IsValid)
            {
                var dropDowns = await _service.GetNewMovieDropDown();
                ViewBag.Genres = new SelectList(dropDowns.Genres, "Id", "GenreName");
                ViewBag.Persons = new SelectList(dropDowns.Persons, "Id", "PersonName");
                return View(movie);
            }

            await _service.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }


    }
}
