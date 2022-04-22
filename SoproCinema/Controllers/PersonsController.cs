using Microsoft.AspNetCore.Mvc;
using SoproCinema.Data;
using System.Linq;
using System.Threading.Tasks;
using SoproCinema.Services;

namespace SoproCinema.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonsService _service;

        public PersonsController(IPersonsService service)
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
