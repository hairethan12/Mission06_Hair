using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Hair.Models;

namespace Mission06_Hair.Controllers
{
    public class HomeController : Controller
    {
        private NewMovieContext _context;

        public HomeController(NewMovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovies(NewMovie response)
        {
            _context.NewMovies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }


    }
}
