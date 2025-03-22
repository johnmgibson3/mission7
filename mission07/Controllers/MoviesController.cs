using Microsoft.AspNetCore.Mvc;
using mission07.Models;

namespace mission07.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index"); // Redirect to movie list
            }
            return View(movie); // Reload form if invalid
        }
        
        
        public IActionResult Collection()
        {
            // Linq
            var collection = _context.Movies
                
                .OrderBy(x => x.MovieId).ToList();
            return View(collection);
        }
        
    }
}