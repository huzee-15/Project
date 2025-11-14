using Microsoft.EntityFrameworkCore;
using Project.Models.Entities;
public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }
    public DbSet<Product>  Product { get; set; }

}