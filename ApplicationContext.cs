using BlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp;

public class ApplicationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite(@"Data Source=Database\database.db");
    
    public DbSet<City> Cities { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Animal> Animals { get; set; }

    
}