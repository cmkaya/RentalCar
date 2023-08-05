using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=localhost; Database=RentalCar; User Id=postgres; Password=pas123";
        optionsBuilder.UseNpgsql(connectionString);
    }
}