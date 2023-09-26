using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProject.Models;

public class PurchaseDetails
{
    [Key]
    public int PurchaseDetailsId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }
    [ForeignKey("Material")]
    public int MaterialId { get; set; }
    public virtual Material Material { get; set; }
    [ForeignKey("Purchase")]
    public int PurchaseId { get; set; }
    public virtual Purchase Purchase { get; set; }
    [ForeignKey("Vendor")]
    public int VendorId { get; set; }
    public virtual Vendor Vendor { get; set; }
}
