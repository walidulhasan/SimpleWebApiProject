using Microsoft.EntityFrameworkCore;
using WebApiProject.Models;

namespace WebApiProject.Context;

public class DatabaseContext:DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
    {
        
    }
    public DbSet<Category> Category { get; set; }
    public DbSet<Material> Material { get; set; }
}
