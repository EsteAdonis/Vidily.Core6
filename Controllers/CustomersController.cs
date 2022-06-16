using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidly.Core6.Data;
using Vidly.Core6.Models;
using Vidly.Core6.ViewModels;

namespace Vidly.Core6.Controllers
{
  public class CustomersController: Controller
  {
    private readonly DataContext _context;

    public CustomersController(DataContext context)
    {
      _context = context;
    }

    protected override void Dispose(bool disposing)
    {
      _context.Dispose();
    }

    public IActionResult Index()
    {
      var customers = _context.Customers.Include(c=> c.MembershipType).ToList();
      return View(customers);
    }

    [HttpGet]
    public IActionResult New()
    {
      var viewModel = new NewCustomerViewModel
      {
        MembershipTypes = _context.MembershipTypes.ToList(),
        MemberTypes = _context.MembershipTypes
                      .Select( m => new SelectListItem{Value = m.Id.ToString(), Text = m.Name} )
                      .OrderBy( m => m.Value )
                      .ToList(),
      };
      return View("CustomerForm", viewModel);
    }

    public IActionResult Details(int id)
    {
      var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

      if (customer == null)
        return NotFound();

      return View(customer);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Save(Customer customer) 
    {
      if (customer.Id == 0)
          _context.Customers.Add(customer);
      else 
      {
        var customerInDB = _context.Customers.Single(c => c.Id == customer.Id);
        customerInDB.Name = customer.Name;
        customerInDB.Birthdate = customer.Birthdate;
        customerInDB.MembershipType = customer.MembershipType;
        customerInDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
      }          

      _context.SaveChanges();
      return RedirectToAction("Index", "Customers");
    }

    public IActionResult Edit(int id) {
      var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

      if (customer == null)
        return NotFound();
      
      var viewModel = new NewCustomerViewModel
      {
        Customer = customer,
        MembershipTypes = _context.MembershipTypes.ToList(),
        MemberTypes = _context.MembershipTypes
                      .Select( m => new SelectListItem{Value = m.Id.ToString(), Text = m.Name} )
                      .OrderBy( m => m.Value )
                      .ToList(),        
      };

      return View("CustomerForm", viewModel);
    }
  }
}