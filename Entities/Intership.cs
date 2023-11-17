namespace HackathonApi.Entities;


public class Intership
{
    public int Id { get; set; }
    public required Company IntershipCreator { get; set; }
    public required List<User> ApprovedUsers { get; set; }
    public required List<User> Applicants { get; set; }
    public required DateTime DateOfStart { get; set; }
    public required DateTime DateOfEnd { get; set; }
    public required DateTime RecrutationStart { get; set; }
    public required DateTime RecrutationEnd { get; set; }
}
