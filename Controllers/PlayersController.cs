using kolokwium1.DTO;
using kolokwium1.Models;
using kolokwium1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kolokwium1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController(AppDbContext db) : Controller
{
    [HttpGet("{id}")]
    [Route("/api/players/{id}/matches")]
    public async Task<IActionResult> Get(int id)
    {
        Console.WriteLine(db.Player_Matches.Count());
        Console.WriteLine(db.Players.Count());
        
        var matches = await db.Player_Matches.Select(match => new MatchGetDTO
        {
            MVPs = match.MVPs,
            date = match.Match.MatchDate,
            rating = match.Rating,
            map = match.Match.Map.Name,
            tournament = match.Match.Tournament.Name,
            team1Score = match.Match.Team1Score,
            team2Score = match.Match.Team2Score
        }).ToListAsync();
        
        var data = db.Players.Select(player => new PlayerMatchGetDTO
        {
            playerId = player.PlayerId,
            firstName = player.FirstName,
            lastName = player.LastName,
            birthDate = player.BirthDate,
            matches = matches,
        }).Where(player => player.playerId == id);

        return Ok(data);    
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PlayerMatchPostDTO data)
    {
        Console.WriteLine("message");
        
        // jezeli nie ma danych
        if(data == null || data.matches == null)
            return BadRequest("data error");

        foreach (var match in data.matches)
        {
            // jezeli mecz nie istnieje
            if (db.Matches.Any(match1 => match1.MatchId == match.matchId) == false)
                return BadRequest();
        }

        var playerId = db.Players.Max(x => x.PlayerId) + 1;
        
        await db.Players.AddAsync(new Player()
        {
           PlayerId = playerId,
           FirstName = data.firstName,
           LastName = data.lastName,
           BirthDate = data.birthDate,
        });

        foreach (var match in data.matches)
        {
            if (db.Matches.Any(match1 => match1.MatchId == match.matchId) == false)
            {
                await db.Player_Matches.AddAsync(new Player_Match()
                {   
                    PlayerId = playerId,
                    MatchId = match.matchId,
                    MVPs = match.MVPs,
                    Rating = match.rating,
                });
            }
        }
        
        db.SaveChanges();
        
        return Created();
    }
}