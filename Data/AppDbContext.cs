using kolokwium1.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium1.Services;

public class AppDbContext : DbContext
{
    public DbSet<Player> Players { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Map> Maps { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<Player_Match> Player_Matches { get; set; }
    
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Player>().HasData(
            new Player()
            {
                PlayerId = 1, BirthDate = DateTime.Now, FirstName = "John", LastName = "Doe",
            },
            new Player()
            {
                PlayerId = 2, BirthDate = DateTime.Now, FirstName = "Jane", LastName = "Doe",
            }
        );

        modelBuilder.Entity<Tournament>().HasData(
            new Tournament()
            {
                Name = "Some Tournament", TournamentId = 1, StartDate = DateTime.Now, EndDate = DateTime.Now,
            }
        );

        modelBuilder.Entity<Map>().HasData(
            new Map()
            {
                MapId = 1, Name = "Some Map", Type = "Some Type"
            }
        );

        modelBuilder.Entity<Match>().HasData(
            new Match()
            {
                MapId = 1, TournamentId = 1, BestRating = 5, MatchId = 1, MatchDate = DateTime.Now, Team1Score = 100, Team2Score = 100
            }
        );

        modelBuilder.Entity<Player_Match>().HasData(
            new Player_Match()
            {
                PlayerId = 1, MatchId = 1, Rating = 10, MVPs = 10
            }
        );
    }
}