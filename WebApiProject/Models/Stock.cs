using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Stock
{
    [Key]
    public int StockId { get; set; }
    public string Quantity { get; set; }
    public DateTime StockDate { get; set; }
    [ForeignKey("Material")]
    public int MaterialId { get; set; }
    public virtual Material Material { get; set; }
}
