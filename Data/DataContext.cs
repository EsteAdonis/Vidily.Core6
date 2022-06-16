using Microsoft.EntityFrameworkCore;
using Vidly.Core6.Models;

namespace Vidly.Core6.Data
{
  public class DataContext: DbContext
  {
    public DataContext(DbContextOptions<DataContext> options): base(options)
    {
      
    }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Movie> Movies => Set<Movie>();   
    public DbSet<MembershipType> MembershipTypes => Set<MembershipType>(); 
    public DbSet<Genre> Genres => Set<Genre>();
  }
}