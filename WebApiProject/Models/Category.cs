using System.ComponentModel.DataAnnotations;

namespace WebApiProject.Models;

public class Category
{
    public Category()
    {
        Materials = new List<Material>();
    }
    [Key]
    public int CategoryId { get; set; }
    [Required, StringLength(50), 
    Display(Name = "Category name")]
    public string CategoryName { get; set; }
    public virtual List<Material> Materials { get; set; }
}
