using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Requisition
{
    [Key]
    public int RequisitionId { get; set; }
    public int ProjectId { get; set; }
    public DateTime RequisitionDate { get; set; }
    public string RequisitionBy { get; set; }
    public bool IsActive { get; set; }
    public string Status { get; set; }
    public virtual ICollection<RequisitionDetails> RequisitionDetails { get; set; }
    public virtual ICollection<PurchaseDistribution> PurchaseDistributions { get; set; }
}
