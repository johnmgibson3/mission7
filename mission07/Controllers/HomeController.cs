using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission07.Models;

namespace mission07.Controllers;

public class HomeController : Controller
{
    
    private readonly JoelHiltonMovieCollectionContext _context;
    public HomeController(JoelHiltonMovieCollectionContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Joel()
    {
        return View();
    }
    public IActionResult Movie()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View("Movie", new Movie());
    }

    [HttpPost]
    public IActionResult AddMovie(Movie response)
    {
 
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Movie", response); // Redirect to movie list
   
    }
        
        
    public IActionResult Collection()
    {
        // Linq
        var collection = _context.Movies
                
            .OrderBy(x => x.MovieId).ToList();
        return View(collection);
    }

    
    // If using route to receive info names need to match, since id is in the url of Program.cs
    [HttpGet]
    public IActionResult Edit(int id)
    {

        var recordToEdit = _context.Movies
            .Single(x => x.MovieId == id);
        ViewBag.Category =  _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        return View("Movie", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedInfo)
    {
        _context.Movies.Update(updatedInfo);
        _context.SaveChanges();
        return RedirectToAction("Collection");
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);
        return View("Delete", recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(Movie recordToDelete)
    {
        _context.Movies.Remove(recordToDelete);
        _context.SaveChanges();
        
        return RedirectToAction("Collection");
    }

}