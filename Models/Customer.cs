using System.ComponentModel.DataAnnotations;

namespace Vidly.Core6.Models
{
    public class Customer
    {
      public int Id { get; set; }
      [Required]
      [StringLength(255)]
      public string Name { get; set; } = string.Empty;

      [Display(Name = "Date of Birth")]
      [Required]
      [DisplayFormat(DataFormatString = "{0:dd MM yyyy}")]
      public DateTime? Birthdate { get; set; }
      public bool IsSubscribedToNewsletter { get; set; }

      public MembershipType? MembershipType { get; set; }

      [Display(Name = "Membership Type")]
      [Range(1,5, ErrorMessage = "You should select a Membership Type")]
      public byte MembershipTypeId {get; set;}  // navigation property
    }
}