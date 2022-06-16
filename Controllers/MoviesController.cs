using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Core6.Data;
using Vidly.Core6.Models;
using Vidly.Core6.ViewModels;

namespace Vidly.Core6
{
  public class MoviesController: Controller
  {
    private readonly DataContext _context;

    public MoviesController(DataContext db)
    {
      _context = db;
    }

    public IActionResult Index()
    {
      var movies = _context.Movies.Include(g => g.Genre).ToList();

      return View(movies);
    }
    
    public IActionResult Random()
    {
      var movie = new Movie() { Name ="Shrek!" };
      var customers = _context.Customers.ToList();
      
      var viewModel = new RandomMovieViewModel
      {
        Movie = movie,
        Customers = _context.Customers.ToList()
      };

      return View(viewModel);
    }

    [HttpGet]
    public IActionResult Details(byte id)
    {
      var details = _context.Movies.Include(g => g.Genre).SingleOrDefault(m => m.Id == id);
      
      return View(details);
    }
  }
}