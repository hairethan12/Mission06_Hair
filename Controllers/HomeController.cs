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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("NewMovies", new NewMovie());
        }

        [HttpPost]
        public IActionResult NewMovies(NewMovie response)
        {
            if (ModelState.IsValid) 
            {
                _context.NewMovies.Add(response);
                Console.WriteLine("Added new movie: " + response.Title);
                _context.SaveChanges();
                Console.WriteLine("Changes saved to database");

                return View("Confirmation", response);
            }
            else
            {
                return View(response);
            }
        }

        public IActionResult MovieList()
        {
            var NewMovies = _context.NewMovies.ToList();

            return View(NewMovies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.NewMovies
                .Single(x => x.MovieID == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            
            return View("NewMovies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(NewMovie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.NewMovies
                .Single(x => x.MovieID == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(NewMovie movie)
        {
            _context.NewMovies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }


    }
}
