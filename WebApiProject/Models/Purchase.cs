using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Purchase
{
    [Key]
    public int PurchaseID { get; set; }
    public DateTime PurchaseDate { get; set; }
    [Required, StringLength(50), Display(Name = "Shipment Way")]
    public string ShipmentWay { get; set; }
    public DateTime PurchaseReceiveDate { get; set; }
    public double TotalAmount { get; set; }
    [Required, StringLength(50), Display(Name = "Payment Type")]
    public string PaymentType { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    [ForeignKey("Employee")]
    public int EmployeeId { get; set; }
    public virtual ICollection<PurchaseDetails> PurchaseDetails { get; set; }

}
