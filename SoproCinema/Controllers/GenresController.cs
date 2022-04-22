using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoproCinema.Data;
using SoproCinema.Services;

namespace SoproCinema.Controllers
{
    public class GenresController : Controller
    {
        private readonly IGenresService _service;

        public GenresController(IGenresService service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
    }
}

