using Vidly.Core6.Models;

namespace Vidly.Core6.ViewModels
{
  public class RandomMovieViewModel
  {
    public Movie Movie { get; set; } = new Movie();
    public List<Customer> Customers { get; set; } = new List<Customer>();
  }
}