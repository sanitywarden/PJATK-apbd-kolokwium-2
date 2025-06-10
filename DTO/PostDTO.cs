namespace kolokwium1.DTO;

public class PlayerMatchPostDTO {
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthDate { get; set; }
    public List<MatchPostDTO> matches { get; set; }
}

public class MatchPostDTO
{
    public int matchId { get; set; }
    public int MVPs { get; set; }
    public float rating { get; set; }
}