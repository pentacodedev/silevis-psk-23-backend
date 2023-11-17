namespace HackathonApi.Entities;


public class Intership
{
    public int Id { get; set; }
    public required Company IntershipCreator { get; set; }
    public required DateTime DateOfStart { get; set; }
    public required DateTime DateOfEnd { get; set; }
    public required DateTime RecrutationStart { get; set; }
    public required DateTime RecrutationEnd { get; set; }
    public string? StudentEmail { get; set; }
    public bool HasStudent => StudentEmail != null;
    public int DaysUntilExpired => (DateTime.Now - DateOfStart).Days;
}
