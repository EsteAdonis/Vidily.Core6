using Microsoft.AspNetCore.Mvc.Rendering;
using Vidly.Core6.Models;

namespace Vidly.Core6.ViewModels
{
  public class NewCustomerViewModel
  {
    public IEnumerable<SelectListItem> MemberTypes {get; set;} = new List<SelectListItem>();
    public IEnumerable<MembershipType>? MembershipTypes {get; set;}
    public SelectList? cboMembershipTypes {get; set;}
    public Customer Customer { get; set; } = new Customer();
  }
}