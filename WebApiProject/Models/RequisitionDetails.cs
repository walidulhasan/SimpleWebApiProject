using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class RequisitionDetails
{
    [Key]
    public int RequiDetailsId { get; set; }
    [ForeignKey("Requisition")]
    public int RequisitionId { get; set; }
    [ForeignKey("Material")]
    public int MaterialId { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }
    public virtual Requisition Requisition { get; set; }
    public virtual Material Material { get; set; }
}
