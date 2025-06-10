using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium1.Models;

[Table("SomeModel")]
[PrimaryKey(nameof(id))]
public class Models
{
    // Model sluzy do mapowania rzeczy w bazie danych
    /* [Key], [ForeignKey("SomeId")], [PrimaryKey(nameof(something), nameof(somethingelse)]
     * [MaxLength(length)]
     * public virtual Something something { get; set; } 
     */

    public int id { get; set; }
}

[Table("Map")]
[PrimaryKey(nameof(MapId))]
public class Map
{
    [Key]
    public int MapId { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(100)]
    public string Type { get; set; }
}

[Table("Tournament")]
[PrimaryKey(nameof(TournamentId))]
public class Tournament
{
    [Key]
    public int TournamentId { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

[Table("Match")]
[PrimaryKey(nameof(MatchId))]
public class Match
{
    [Key]
    public int MatchId { get; set; }
    
    [ForeignKey("TournamentId")]
    public int TournamentId { get; set; }
    
    [ForeignKey("MapId")]
    public int MapId { get; set; }
    
    public DateTime MatchDate { get; set; }
    
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }

    public float? BestRating { get; set; } = null!;
    
    public virtual Tournament Tournament { get; set; }
    public virtual Map Map { get; set; }
}

[Table("Player")]
[PrimaryKey(nameof(PlayerId))]
public class Player
{
    [Key]
    public int PlayerId { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [MaxLength(100)]
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; } 
}

[Table("Player_Match")]
[PrimaryKey("MatchId", "PlayerId")]
public class Player_Match
{
    [ForeignKey("MatchId")]
    public int MatchId { get; set; }
    
    [ForeignKey("PlayerId")]
    public int PlayerId { get; set; }
    
    public int MVPs { get; set; }
    public float Rating { get; set; }
    
    public virtual Match Match { get; set; }
    public virtual Player Player { get; set; }
}