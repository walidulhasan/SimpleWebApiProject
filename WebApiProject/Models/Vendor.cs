using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Vendor
{
    [Key]
    public int VendorId { get; set; }
    public string VendorName { get; set; } 
    public string ContactPerson { get; set; }
    [Required, StringLength(50), Display(Name = "Phone No")]
    public string PhoneNo { get; set; }
    public virtual ICollection<PurchaseDetails> PurchaseDetails { get; set; }
}
