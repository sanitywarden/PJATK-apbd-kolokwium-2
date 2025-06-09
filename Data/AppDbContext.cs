using kolokwium1.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium1.Services;

public class AppDbContext : DbContext
{
    // public DbSet<Something> Something { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<SomeModel>().HasData(
            new SomeModel { id = 1 }
        );
    }
}