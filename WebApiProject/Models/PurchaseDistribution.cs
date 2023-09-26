using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class PurchaseDistribution
{
    [Key]
    public int PurchaseDistributionId { get; set; }
    public DateTime DistributionDate { get; set; }
    [ForeignKey("Requisition")]
    public int RequisitionId { get; set; }
    public int DeliverQuantity { get; set; }
    [ForeignKey("Material")]
    public int MaterialId { get; set; }
    public string Status { get; set; }
    public bool IsCompleted { get; set; }
    public string DistributionBy { get; set; }
    public string ReceivedBy { get; set; }
    public virtual Requisition Requisition { get; set; }
}
