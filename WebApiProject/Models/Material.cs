using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Material
{
    public Material()
    {
        PurchaseDetails = new List<PurchaseDetails>();
        RequisitionDetails = new List<RequisitionDetails>();
        Stocks = new List<Stock>();
    }
    [Key]
    public int MaterialId { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public string MaterialName { get; set; } = string.Empty;
    public string Unit { get; set; }= string.Empty;
    public string ImageUrl { get; set; }
    public virtual Category Category { get; set; }
    public virtual List<PurchaseDetails> PurchaseDetails { get; set; }
    public virtual List<RequisitionDetails> RequisitionDetails { get; set; }
    public virtual List<Stock> Stocks { get; set; }
}
