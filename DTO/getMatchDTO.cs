namespace kolokwium1.DTO;

public class PlayerMatchGetDTO
{
    public int playerId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthDate { get; set; }
    public List<MatchGetDTO> matches { get; set; }
}

public class MatchGetDTO
{
    public string tournament { get; set; }
    public string map { get; set; }
    public DateTime date { get; set; }
    public int MVPs { get; set; }
    public float rating { get; set; }
    public int team1Score { get; set; }
    public int team2Score { get; set; }
}